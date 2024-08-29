using HousingFund.DAL.Entities.Portal.Fund.Models;
using HousingFund.DAL.ViewModels.Portal.History;
using HousingFund.DAL.ViewModels.Portal.UserFund;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFund.DAL.Repositories.Interface
{
    public interface IHistoryWinnerRepository
    {
        IQueryable<UserFund> GetHistoriesQuery();
        List<DisplayHistoryVM> GetHistories();
        List<DisplayHistoryVM> Search(string search);

    }
}
