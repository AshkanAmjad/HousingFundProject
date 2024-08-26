using HousingFund.DAL.Entities.Security.User.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFund.DAL.Entities.Portal.Fund.Models
{
    public class Fund
    {
        #region Properties
        [Key]
        public Guid FundId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Income { get; set; }

        [Required]
        public Guid Winner { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
        #endregion

        #region Relations
        public ICollection<UserFund> UserFunds { get; set; }
        #endregion
    }
}
