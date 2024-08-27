using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFund.DAL.ViewModels.Portal.Fund
{
    public class DisplayFundsVM
    {
        #region Properties
        public string? FundId { get; set; }

        public string? Title { get; set; }

        public string? Income { get; set; }

        public string? IsActive { get; set; }

        public string? CreatedDate { get; set; }
        #endregion
    }
}
