using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFund.DAL.ViewModels.Portal.UserFund
{
    public class DisplayUserFundsVM
    {
        #region Properties
        public string? UserFundId {  get; set; }
        public string? FundId { get; set; }

        public string? UserId { get; set; }

        public string? NationalCode {  get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? PhoneNumber {  get; set; }

        public string? IsActive { get; set; }

        public string? CreatedDate { get; set; }
        #endregion
    }
}
