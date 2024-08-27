using HousingFund.DAL.Entities.Security.User.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFund.DAL.Entities.Portal.Fund.Models
{
    public class UserFund
    {
        #region Properties
        [Key]
        public Guid UserFundId { get; set; }

        public Guid? UserId { get; set; }

        public Guid? FundId { get; set; }

        public bool IsWinner {  get; set; }
        #endregion

        #region Realations
        public Fund Fund { get; set; }
        public User User { get; set; }
        #endregion
    }
}
