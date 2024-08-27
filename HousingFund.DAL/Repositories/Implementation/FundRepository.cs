using AutoMapper;
using HousingFund.DAL.Context;
using HousingFund.DAL.Entities.Portal.Fund.Models;
using HousingFund.DAL.Mapping;
using HousingFund.DAL.Repositories.Interface;
using HousingFund.DAL.Utilities;
using HousingFund.DAL.ViewModels.Portal.Fund;
using HousingFund.DAL.ViewModels.Security.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFund.DAL.Repositories.Implementation
{
    public class FundRepository : IFundRepository
    {
        #region Constructor
        private HousingFundContext _context;
        private IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public FundRepository()
        {
            _context = new HousingFundContext();
            _userRepository = new UserRepository();
            var mappingConfig = new MappingConfig();
            _mapper = mappingConfig.CreateMapper();
        }
        #endregion

        public IQueryable<Fund> GetFundsQuery()
        {
            return _context.Funds
                           .AsQueryable();
        }

        public bool Add(RegisterFundVM model, out string message)
        {
            string checkMessage = "";

            Fund fund = _mapper.Map<Fund>(model);
            fund.FundId = Guid.NewGuid();

            _context.Funds.Add(fund);

            message = "";
            return true;
        }

        public EditFundVM GetFundById(Guid fundId)
        {
            var context = GetFundsQuery();

            var fund = context.Where(f => f.FundId == fundId)
                              .Select(f => new EditFundVM
                              {
                                  FundId = f.FundId,
                                  Income = f.Income,
                                  IsActive = f.IsActive

                              })
                             .FirstOrDefault();
            return fund;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public bool Edit(EditFundVM model, out string message)
        {
            string checkMessage = "";

            Fund fund = _mapper.Map<Fund>(model);

            Fund db = _context.Funds
                              .Find(model.FundId);

            if (db != null)
            {
                db.Title = fund.Title;
                db.CreatedDate = fund.CreatedDate;
                db.IsActive = fund.IsActive;
                db.Income = fund.Income;

                _context.Funds.Update(db);

                message = "";
                return true;
            }

            checkMessage = "عملیات ویرایش با شکست مواجه شد.";
            message = checkMessage;
            return false;
        }

        public bool Delete(Guid fundId, out string message)
        {
            string checkMessage = "";
            if (fundId != Guid.Empty)
            {
                using (HousingFundContext context = new())
                {
                    var fund = context.Funds
                                      .Find(fundId);

                    if (fund != null)
                    {
                        context.Funds.Remove(fund);
                        context.SaveChanges();
                    }

                    message = "";

                    return true;
                }
            }
            checkMessage = "عملیات حذف با شکست مواجه شد.";
            message = checkMessage;
            return false;
        }

        public List<DisplayFundsVM> GetFunds()
        {
            var context = GetFundsQuery();
            var funds = context.OrderByDescending(f => f.CreatedDate)
                               .Select(f => new DisplayFundsVM
                               {
                                   FundId = f.FundId.ToString(),
                                   Title = f.Title,
                                   Income = f.Income,
                                   IsActive = (f.IsActive ? "فعال" : "غیر فعال"),
                                   CreatedDate = f.CreatedDate.ToShamsi()
                               }).ToList();

            return funds;
        }

        public List<DisplayFundsVM> Search(string search)
        {
            using(HousingFundContext db = new())
            {
                var context = GetFundsQuery();
                var funds = context.Where(u => u.Title.Contains(search) ||
                                               u.Income.Contains(search) 
                                          )
                                   .Select(f => new DisplayFundsVM
                                   {
                                       FundId = f.FundId.ToString(),
                                       Title = f.Title,
                                       Income = f.Income,
                                       IsActive = (f.IsActive ? "فعال" : "غیر فعال"),
                                       CreatedDate = f.CreatedDate.ToShamsi()
                                   }).ToList();
                return funds;
            }
        }
    }
}
