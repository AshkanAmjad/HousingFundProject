using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFund.DAL.ViewModels.Portal.UserFund
{
    public class RegisterUserFundVM
    {
        #region Properties
        public Guid UserId { get; set; }

        public Guid FundId { get; set; }

        public bool IsWinner {  get; set; }

        public DateTime CreatedDate { get; set; }
        #endregion
    }
}
