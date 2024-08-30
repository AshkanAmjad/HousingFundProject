using HousingFund.DAL.Entities.Portal.Fund.Models;
using HousingFund.DAL.ViewModels.Portal.UserFund;

namespace HousingFund.DAL.Repositories.Interface
{
    public interface IUserFundRepository
    {
        IQueryable<UserFund> GetUserFundsQuery(Guid fundId);
        List<DisplayUserFundsVM> GetUserFunds(Guid fundId);
        List<DisplayUserFundsVM> Search(Guid fundId,string search);
        List<DisplayUserCmbVM> GetIdAndNameUsers();
        bool Add(RegisterUserFundVM model, out string message);
        bool Delete(Guid userFundId, out string message);
        bool Similarity(Guid userId, Guid fundId, out string message);
        bool Lottery(Guid fundId, out string message);
        void SaveChanges();
      
    }
}
