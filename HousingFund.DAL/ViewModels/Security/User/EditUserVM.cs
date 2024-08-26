using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFund.DAL.ViewModels.Security.User
{
    public class EditUserVM
    {
        #region Properties
        public Guid UserId { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }

        public string? NationalCode { get; set; }

        public bool IsAdmin { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Address { get; set; }

        public bool IsActive { get; set; }

        public DateTime UpdateDate { get; set; }
        #endregion
    }
}
