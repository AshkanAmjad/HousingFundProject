using HousingFund.DAL.Entities.Portal.Fund.Models;
using HousingFund.DAL.ViewModels.Portal.Fund;
using HousingFund.DAL.ViewModels.Security.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFund.DAL.Repositories.Interface
{
    public interface IFundRepository
    {
        IQueryable<Fund> GetFundsQuery();
        List<DisplayFundsVM> GetFunds();
        List<DisplayFundsVM> Search(string search);
        bool Add(RegisterFundVM model, out string message);
        EditFundVM GetFundById(Guid fundId);
        bool Edit(EditFundVM model, out string message);
        bool Delete(Guid fundId, out string message);
        void SaveChanges();


    }
}
