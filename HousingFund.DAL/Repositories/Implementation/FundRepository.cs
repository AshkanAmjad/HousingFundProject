﻿using AutoMapper;
using HousingFund.DAL.Context;
using HousingFund.DAL.Entities.Portal.Fund.Models;
using HousingFund.DAL.Mapping;
using HousingFund.DAL.Repositories.Interface;
using HousingFund.DAL.Utilities;
using HousingFund.DAL.ViewModels.Portal.Fund;

namespace HousingFund.DAL.Repositories.Implementation
{
    public class FundRepository : IFundRepository
    {
        #region Constructor
        private readonly HousingFundContext _context;
        private readonly IMapper _mapper;

        public FundRepository()
        {
            _context = new HousingFundContext();
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

            var similarity = Similarity(model.Title, out checkMessage);

            if (similarity)
            {
                message = checkMessage;
                return false;
            }

            Fund fund = _mapper.Map<Fund>(model);
            fund.FundId = Guid.NewGuid();

            _context.Funds.Add(fund);

            message = checkMessage;
            return true;
        }

        public EditFundVM GetFundById(Guid fundId)
        {

            var fund = _context.Funds.Where(f => f.FundId == fundId)
                                     .Select(f => new EditFundVM
                                     {
                                         FundId = f.FundId,
                                         Income = f.Income,
                                         Title = f.Title,
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

            var similarity = Similarity(model.FundId ,model.Title , out checkMessage);

            if (similarity)
            {
                message = checkMessage;
                return false;
            }

            Fund fund = _mapper.Map<Fund>(model);

            Fund db = _context.Funds
                              .Find(model.FundId);

            if (db != null)
            {
                db.Title = fund.Title;
                db.CreatedDate = fund.CreatedDate;
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
            using (HousingFundContext db = new())
            {
                var context = GetFundsQuery();
                var funds = context.Where(f => f.Title.Contains(search) ||
                                               f.Income.Contains(search)
                                          )
                                   .OrderByDescending(f => f.CreatedDate)
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

        public bool Similarity(string title, out string message)
        {
            var context = GetFundsQuery();

            bool checkTitle = context.Where(f => f.Title == title && f.IsActive )
                                    .Any();

            if (checkTitle)
            {
                message = "قرعه ای با این عنوان قبلا ثبت شده است.";
                return checkTitle;
            }

            message = "";
            return false;
        }

        public bool Similarity(Guid fundId, string title, out string message)
        {
            var context = GetFundsQuery();

            bool checkTitle = context.Where(f =>f.FundId != fundId && f.Title == title && f.IsActive)
                                    .Any();

            if (checkTitle)
            {
                message = "قرعه ای با این عنوان قبلا ثبت شده است.";
                return checkTitle;
            }

            message = "";
            return false;
        }


        public bool IsActive(Guid fundId)
           => _context.Funds.Where(f => f.FundId == fundId && f.IsActive)
                            .Any();
    }
}
