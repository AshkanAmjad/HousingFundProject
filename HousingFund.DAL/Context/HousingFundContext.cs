using HousingFund.DAL.Entities.Portal.Fund.Models;
using HousingFund.DAL.Entities.Security.User.Models;
using HousingFund.DAL.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFund.DAL.Context
{
    public class HousingFundContext:DbContext
    {
        #region Tables
        public DbSet<User> Users { get; set; }
        public DbSet<Fund> Funds { get; set; }
        #endregion

        #region Connection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=HousingFund_DB;Trusted_Connection=true;TrustServerCertificate=True;");
        }
        #endregion

        #region Seed Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Disable Auto_Increment

            modelBuilder.Entity<User>()
                        .Property(e => e.UserId)
                        .ValueGeneratedNever();

            modelBuilder.Entity<Fund>()
                        .Property(e => e.FundId)
                        .ValueGeneratedNever();

            modelBuilder.Entity<UserFund>()
                        .Property(e => e.UserFundId)
                        .ValueGeneratedNever();
            #endregion



            modelBuilder.Entity<User>().HasData(new User()
            {
                UserId = Guid.NewGuid(),
                UserName = "AshkanAmjad",
                Password = Encrypting.ConvertToEncrypt("123"),
                NationalCode = "0021047022",
                FirstName = "اشکان",
                LastName = "مطهری",
                PhoneNumber = "09351225600",
                Address = "کرج، فردیس، کانال غربی",
                IsActive = true,
                IsAdmin = true,
                RegisterDate = DateTime.Now
            });
        }
        #endregion
    }
}
