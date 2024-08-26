using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFund.DAL.ViewModels.Security.User
{
    public class DisplayUsersVM
    {
        #region Properties
        public string? userId { get; set; }
        public string? UserName { get; set; }
        public string? NationalCode { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? IsAdmin { get; set; }
        public string? IsActive { get; set; }
        public string? RegisterDate { get; set; }
        #endregion
    }
}
