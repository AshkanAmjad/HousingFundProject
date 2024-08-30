using AutoMapper;
using HousingFund.DAL.Context;
using HousingFund.DAL.Entities.Portal.Fund.Models;
using HousingFund.DAL.Mapping;
using HousingFund.DAL.Repositories.Interface;
using HousingFund.DAL.Utilities;
using HousingFund.DAL.ViewModels.Portal.History;
using Microsoft.EntityFrameworkCore;

namespace HousingFund.DAL.Repositories.Implementation
{
    public class HistoryWinnerRepository : IHistoryWinnerRepository
    {
        #region Constructor
        private readonly HousingFundContext _context;
        private readonly IMapper _mapper;

        public HistoryWinnerRepository()
        {
            _context = new HousingFundContext();
            var mappingConfig = new MappingConfig();
            _mapper = mappingConfig.CreateMapper();
        }
        #endregion

        public IQueryable<UserFund> GetHistoriesQuery()
        {
            return _context.UserFunds
                           .Include(uf => uf.User)
                           .Include(uf => uf.Fund)
                           .AsQueryable();
        }

        public List<DisplayHistoryVM> GetHistories()
        {
            var context = GetHistoriesQuery();

            var histories = context.Where(f => f.IsWinner && !f.Fund.IsActive)
                                   .OrderByDescending(h => h.CreatedDate)
                                   .Select(h => new DisplayHistoryVM
                                   {
                                       Title = h.Fund.Title,
                                       FirstName = h.User.FirstName,
                                       LastName = h.User.LastName,
                                       Income = h.Fund.Income,
                                       NationalCode = h.User.NationalCode,
                                       PhoneNumber = h.User.PhoneNumber,
                                       CreatedDate = h.CreatedDate.ToShamsi()
                                   }).ToList();
            return histories;
        }

        public List<DisplayHistoryVM> Search(string search)
        {
            using (HousingFundContext db = new())
            {
                var context = GetHistoriesQuery();
                var histories = context.Where(h => (h.Fund.Title.Contains(search) ||
                                                   h.User.FirstName.Contains(search) ||
                                                   h.User.LastName.Contains(search)) &&
                                                   h.IsWinner &&
                                                   !h.Fund.IsActive)
                                       .OrderByDescending(h => h.CreatedDate)
                                       .Select(h => new DisplayHistoryVM
                                       {
                                           Title = h.Fund.Title,
                                           FirstName = h.User.FirstName,
                                           LastName = h.User.LastName,
                                           Income = h.Fund.Income,
                                           NationalCode = h.User.NationalCode,
                                           PhoneNumber = h.User.PhoneNumber,
                                           CreatedDate = h.CreatedDate.ToShamsi()
                                       })
                                       
                                       .ToList();
                return histories;
            }
        }

    }
}
