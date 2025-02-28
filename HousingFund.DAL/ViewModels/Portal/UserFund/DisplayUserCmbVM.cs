﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFund.DAL.ViewModels.Portal.UserFund
{
    public class DisplayUserCmbVM
    {
        #region Properties
        public string? UserId { get; set; }

        public string? NationalCode {  get; set; }

        public string? FirstName {  get; set; }

        public string? LastName { get; set; }
        
        public string? FullName
        {
            get
            {
                return $"{NationalCode} - {FirstName} {LastName}";
            }
        }

        #endregion
    }
}
