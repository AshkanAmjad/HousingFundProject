using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFund.DAL.ViewModels.Security.Login
{
    public class LoginVM
    {
        #region Properties
        public string? UserName {  get; set; }
        public string? Password { get; set; }
        #endregion
    }
}
