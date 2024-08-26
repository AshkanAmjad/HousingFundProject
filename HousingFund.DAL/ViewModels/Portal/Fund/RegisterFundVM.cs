using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFund.DAL.ViewModels.Portal.Fund
{
    public class RegisterFundVM
    {
        #region Properties
        public string? Title { get; set; }

        public string? Income { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }

        #endregion
    }
}
