using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFund.DAL.ViewModels.Portal.Fund
{
    public class EditFundVM
    {
        #region Properties
        public Guid FundId { get; set; }

        public string? Title { get; set; }

        public string? Income {  get; set; }

        public bool IsActive { get; set; }

        public DateTime UpdateDate { get; set; }
        #endregion
    }
}
