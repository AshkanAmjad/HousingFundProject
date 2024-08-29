﻿// <auto-generated />
using System;
using HousingFund.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HousingFund.DAL.Migrations
{
    [DbContext(typeof(HousingFundContext))]
    [Migration("20240828161858_AddAddedDateColumnToUserFundsTbl")]
    partial class AddAddedDateColumnToUserFundsTbl
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HousingFund.DAL.Entities.Portal.Fund.Models.Fund", b =>
                {
                    b.Property<Guid>("FundId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Income")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FundId");

                    b.ToTable("Funds");
                });

            modelBuilder.Entity("HousingFund.DAL.Entities.Portal.Fund.Models.UserFund", b =>
                {
                    b.Property<Guid>("UserFundId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FundId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsWinner")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserFundId");

                    b.HasIndex("FundId");

                    b.HasIndex("UserId");

                    b.ToTable("UserFunds");
                });

            modelBuilder.Entity("HousingFund.DAL.Entities.Security.User.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NationalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("27527c4d-8ea6-469d-aff8-ecfa391fb150"),
                            Address = "کرج، فردیس، کانال غربی",
                            FirstName = "اشکان",
                            IsActive = true,
                            IsAdmin = true,
                            LastName = "مطهری",
                            NationalCode = "0021047022",
                            Password = "MTIzZkBAa2ZAaGJoanNoYmtpaHF3JSRrNDU0ISEtWg==",
                            PhoneNumber = "09351225600",
                            RegisterDate = new DateTime(2024, 8, 28, 19, 48, 57, 905, DateTimeKind.Local).AddTicks(3183),
                            UserName = "AshkanAmjad"
                        });
                });

            modelBuilder.Entity("HousingFund.DAL.Entities.Portal.Fund.Models.UserFund", b =>
                {
                    b.HasOne("HousingFund.DAL.Entities.Portal.Fund.Models.Fund", "Fund")
                        .WithMany("UserFunds")
                        .HasForeignKey("FundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HousingFund.DAL.Entities.Security.User.Models.User", "User")
                        .WithMany("UserFunds")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fund");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HousingFund.DAL.Entities.Portal.Fund.Models.Fund", b =>
                {
                    b.Navigation("UserFunds");
                });

            modelBuilder.Entity("HousingFund.DAL.Entities.Security.User.Models.User", b =>
                {
                    b.Navigation("UserFunds");
                });
#pragma warning restore 612, 618
        }
    }
}
