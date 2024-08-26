using HousingFund.DAL.Entities.Security.User.Models;
using HousingFund.DAL.ViewModels.Security.Login;
using HousingFund.DAL.ViewModels.Security.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFund.DAL.Repositories.Interface
{
    public interface IUserRepository
    {
        bool Login(LoginVM model, out string message);
        IQueryable<User> GetUsersQuery();
        List<DisplayUsersVM> GetUsers();
        EditUserVM GetUserById(Guid userId);
        List<DisplayUsersVM> Search(string search);
        bool Add(RegisterUserVM model, out string message);
        bool Edit(EditUserVM model, out string message);
        bool Delete(Guid userId, out string message);
        bool Similarity(string nationalCode, string userName, out string message);
        void SaveChanges();
    }
}
