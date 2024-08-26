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
    [Migration("20240820013747_CreateInitDB")]
    partial class CreateInitDB
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

                    b.Property<decimal>("Income")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("Winner")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FundId");

                    b.ToTable("Funds");
                });

            modelBuilder.Entity("HousingFund.DAL.Entities.Portal.Fund.Models.UserFund", b =>
                {
                    b.Property<Guid>("UserFundId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FundId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserFundId");

                    b.HasIndex("FundId");

                    b.HasIndex("UserId");

                    b.ToTable("UserFund");
                });

            modelBuilder.Entity("HousingFund.DAL.Entities.Security.User.Models.User", b =>
                {
                    b.Property<Guid>("userId")
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

                    b.HasKey("userId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            userId = new Guid("3cc633ba-05dd-47f7-85fc-480ae495e8c5"),
                            Address = "کرج، فردیس، کانال غربی",
                            FirstName = "اشکان",
                            IsActive = true,
                            IsAdmin = true,
                            LastName = "مطهری",
                            NationalCode = "0021047022",
                            Password = "MTIzYWRlZkBAa2Z4Y2J2QA==",
                            PhoneNumber = "09351225600",
                            RegisterDate = new DateTime(2024, 8, 20, 5, 7, 47, 619, DateTimeKind.Local).AddTicks(98),
                            UserName = "AshkanAmjad"
                        });
                });

            modelBuilder.Entity("HousingFund.DAL.Entities.Portal.Fund.Models.UserFund", b =>
                {
                    b.HasOne("HousingFund.DAL.Entities.Portal.Fund.Models.Fund", "Fund")
                        .WithMany("UserFunds")
                        .HasForeignKey("FundId");

                    b.HasOne("HousingFund.DAL.Entities.Security.User.Models.User", "User")
                        .WithMany("UserFunds")
                        .HasForeignKey("UserId");

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
