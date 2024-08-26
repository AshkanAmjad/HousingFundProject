using HousingFund.DAL.Entities.Portal.Fund.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFund.DAL.Entities.Security.User.Models
{
    public class User
    {
        #region Properties
        [Key]
        public Guid UserId { get; set; }

        [MaxLength(15)]
        [MinLength(5)]
        public string UserName { get; set; }

        public string Password { get; set; }

        [StringLength(10)]
        public string NationalCode { get; set; }


        public bool IsAdmin { get; set; }

        [MaxLength(20)]
        [MinLength(2)]
        public string FirstName { get; set; }

        [MinLength(2)]
        [MaxLength(20)]
        public string LastName { get; set; }

        [StringLength(11)]
        public string PhoneNumber { get; set; }

        [MaxLength(60)]
        public string? Address { get; set; }

        public bool IsActive { get; set; }

        public DateTime RegisterDate { get; set; }
        #endregion

        #region Relations        
        public ICollection<UserFund> UserFunds { get; set; }
        #endregion
    }
}
