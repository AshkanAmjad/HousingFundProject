using HousingFund.DAL.Entities.Portal.Fund.Models;
using HousingFund.DAL.ViewModels.Portal.History;

namespace HousingFund.DAL.Repositories.Interface
{
    public interface IHistoryWinnerRepository
    {
        IQueryable<UserFund> GetHistoriesQuery();
        List<DisplayHistoryVM> GetHistories();
        List<DisplayHistoryVM> Search(string search);

    }
}
