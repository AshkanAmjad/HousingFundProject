using AutoMapper;
using HousingFund.DAL.Context;
using HousingFund.DAL.Entities.Portal.Fund.Models;
using HousingFund.DAL.Mapping;
using HousingFund.DAL.Repositories.Interface;
using HousingFund.DAL.Utilities;
using HousingFund.DAL.ViewModels.Portal.UserFund;
using Microsoft.EntityFrameworkCore;

namespace HousingFund.DAL.Repositories.Implementation
{
    public class UserFundRepository : IUserFundRepository
    {
        #region Constructor
        private readonly HousingFundContext _context;
        private readonly IMapper _mapper;

        public UserFundRepository()
        {
            _context = new HousingFundContext();
            var mappingConfig = new MappingConfig();
            _mapper = mappingConfig.CreateMapper();
        }
        #endregion

        public IQueryable<UserFund> GetUserFundsQuery(Guid fundId)
        {
            return _context.UserFunds
                           .Where(uf => uf.FundId == fundId)
                           .Include(uf => uf.User)
                           .Include(uf => uf.Fund)
                           .AsQueryable();
        }
        public List<DisplayUserFundsVM> GetUserFunds(Guid fundId)
        {
            var context = GetUserFundsQuery(fundId);
            var funds = context.OrderByDescending(uf => uf.CreatedDate)
                               .Select(uf => new DisplayUserFundsVM
                               {
                                   UserFundId = uf.UserFundId.ToString(),
                                   FundId = uf.FundId.ToString(),
                                   UserId = uf.UserId.ToString(),
                                   NationalCode = uf.User.NationalCode,
                                   CreatedDate = uf.CreatedDate.ToShamsi(),
                                   FirstName = uf.User.FirstName,
                                   LastName = uf.User.LastName,
                                   PhoneNumber = uf.User.PhoneNumber,
                                   IsActive = (uf.User.IsActive ? "فعال" : "غیر فعال"),
                               }).ToList();
            return funds;
        }

        public List<DisplayUserFundsVM> Search(Guid fundId, string search)
        {
            using (HousingFundContext db = new())
            {
                var context = GetUserFundsQuery(fundId);
                var funds = context.Where(uf => uf.User.NationalCode.Contains(search) ||
                                                uf.User.FirstName.Contains(search) ||
                                                uf.User.LastName.Contains(search)
                                          )
                                   .OrderByDescending(uf => uf.CreatedDate)
                                   .Select(uf => new DisplayUserFundsVM
                                   {
                                       FundId = uf.FundId.ToString(),
                                       UserId = uf.UserId.ToString(),
                                       NationalCode = uf.User.NationalCode,
                                       CreatedDate = uf.CreatedDate.ToShamsi(),
                                       FirstName = uf.User.FirstName,
                                       LastName = uf.User.LastName,
                                       PhoneNumber = uf.User.PhoneNumber,
                                       IsActive = (uf.User.IsActive ? "فعال" : "غیر فعال"),
                                   }).ToList();
                return funds;
            }
        }

        public List<DisplayUserCmbVM> GetIdAndNameUsers()
        {
            var users = _context.Users.Where(u => u.IsActive)
                                      .Select(u => new DisplayUserCmbVM
                                      {
                                          UserId = u.UserId.ToString(),
                                          NationalCode = u.NationalCode,
                                          FirstName = u.FirstName,
                                          LastName = u.LastName,
                                      }).ToList();
            return users;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public bool Add(RegisterUserFundVM model, out string message)
        {
            string checkMessage = "";

            var similarity = Similarity(model.UserId, model.FundId, out checkMessage);

            if (similarity)
            {
                message = checkMessage;
                return false;
            }

            UserFund userFund = _mapper.Map<UserFund>(model);
            userFund.UserFundId = Guid.NewGuid();

            _context.UserFunds.Add(userFund);

            message = "";
            return true;
        }

        public bool Delete(Guid userFundId, out string message)
        {
            string checkMessage = "";
            if (userFundId != Guid.Empty)
            {
                using (HousingFundContext context = new())
                {
                    var userFund = context.UserFunds
                                          .Find(userFundId);

                    if (userFund != null)
                    {
                        context.UserFunds.Remove(userFund);
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

        public bool Similarity(Guid userId, Guid fundId, out string message)
        {
            var context = GetUserFundsQuery(fundId);

            bool checkUserFund = context.Where(u => u.UserId == userId)
                                        .Any();

            if (checkUserFund)
            {
                message = "کاربری با این شناسه در این قرعه قبلا ثبت شده است.";
                return checkUserFund;
            }

            message = "";
            return false;
        }

        public bool Lottery(Guid fundId, out string message)
        {
            string checkMessage = "عملیات قرعه کشی با شکست مواجه شد.";

            if (fundId != Guid.Empty)
            {
                var context = GetUserFunds(fundId);

                var ids = context.Select(u => u.UserId)
                                 .ToList();

                int count = ids.Count;

                if (count == 0)
                {
                    message = "قرعه فاقد شرکت کننده می باشد.";
                    return false;
                }

                Random rand = new();

                int indexOfWinner = rand.Next(0, count-1);

                if (indexOfWinner < 0)
                {
                    message = checkMessage;
                    return false;
                }

                var db_Fund = _context.Funds.Find(fundId);

                if (db_Fund != null)
                {
                    db_Fund.IsActive = false;

                    _context.Update(db_Fund);

                    var id = ids[indexOfWinner];

                    var winnerId = new Guid(id);

                    var db_UserFund = _context.UserFunds.Include(u => u.User)
                                                        .Where(uf => uf.FundId == fundId && uf.UserId == winnerId)
                                                        .SingleOrDefault();

                                                       
                    if (db_UserFund != null)
                    {
                        db_UserFund.IsWinner = true;
                        db_UserFund.CreatedDate = DateTime.Now;

                        _context.UserFunds.Update(db_UserFund);
                    }


                    message = $"کاربر {db_UserFund.User.FirstName} {db_UserFund.User.LastName} برنده این قرعه کشی شد.";
                    return true;
                }
            }

            message = checkMessage;
            return false;
        }

    }
}
