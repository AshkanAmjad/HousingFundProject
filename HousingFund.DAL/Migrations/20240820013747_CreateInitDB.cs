using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HousingFund.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CreateInitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funds",
                columns: table => new
                {
                    FundId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Income = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Winner = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funds", x => x.FundId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "UserFund",
                columns: table => new
                {
                    UserFundId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FundId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFund", x => x.UserFundId);
                    table.ForeignKey(
                        name: "FK_UserFund_Funds_FundId",
                        column: x => x.FundId,
                        principalTable: "Funds",
                        principalColumn: "FundId");
                    table.ForeignKey(
                        name: "FK_UserFund_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "userId");
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "Address", "FirstName", "IsActive", "IsAdmin", "LastName", "NationalCode", "Password", "PhoneNumber", "RegisterDate", "UserName" },
                values: new object[] { new Guid("3cc633ba-05dd-47f7-85fc-480ae495e8c5"), "کرج، فردیس، کانال غربی", "اشکان", true, true, "مطهری", "0021047022", "MTIzYWRlZkBAa2Z4Y2J2QA==", "09351225600", new DateTime(2024, 8, 20, 5, 7, 47, 619, DateTimeKind.Local).AddTicks(98), "AshkanAmjad" });

            migrationBuilder.CreateIndex(
                name: "IX_UserFund_FundId",
                table: "UserFund",
                column: "FundId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFund_UserId",
                table: "UserFund",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFund");

            migrationBuilder.DropTable(
                name: "Funds");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
