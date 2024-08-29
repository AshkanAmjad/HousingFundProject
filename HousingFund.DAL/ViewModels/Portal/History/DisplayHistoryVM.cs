using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFund.DAL.ViewModels.Portal.History
{
    public class DisplayHistoryVM
    {
        #region properties
        public string? Title { get; set; }

        public string? Income { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? NationalCode {  get; set; }

        public string? PhoneNumber { get; set; }

        public string? CreatedDate { get; set; }
        #endregion
    }
}
