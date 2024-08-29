using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HousingFund.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddUserFundsTblModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFund_Funds_FundId",
                table: "UserFund");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFund_Users_UserId",
                table: "UserFund");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserFund",
                table: "UserFund");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("430e6f7b-a551-41f4-ac6e-11cfbf705bec"));

            migrationBuilder.RenameTable(
                name: "UserFund",
                newName: "UserFunds");

            migrationBuilder.RenameIndex(
                name: "IX_UserFund_UserId",
                table: "UserFunds",
                newName: "IX_UserFunds_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserFund_FundId",
                table: "UserFunds",
                newName: "IX_UserFunds_FundId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserFunds",
                table: "UserFunds",
                column: "UserFundId");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "FirstName", "IsActive", "IsAdmin", "LastName", "NationalCode", "Password", "PhoneNumber", "RegisterDate", "UserName" },
                values: new object[] { new Guid("85720b74-c573-4990-888e-b2293c204eae"), "کرج، فردیس، کانال غربی", "اشکان", true, true, "مطهری", "0021047022", "MTIzZkBAa2ZAaGJoanNoYmtpaHF3JSRrNDU0ISEtWg==", "09351225600", new DateTime(2024, 8, 28, 16, 47, 52, 810, DateTimeKind.Local).AddTicks(7456), "AshkanAmjad" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserFunds_Funds_FundId",
                table: "UserFunds",
                column: "FundId",
                principalTable: "Funds",
                principalColumn: "FundId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFunds_Users_UserId",
                table: "UserFunds",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFunds_Funds_FundId",
                table: "UserFunds");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFunds_Users_UserId",
                table: "UserFunds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserFunds",
                table: "UserFunds");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("85720b74-c573-4990-888e-b2293c204eae"));

            migrationBuilder.RenameTable(
                name: "UserFunds",
                newName: "UserFund");

            migrationBuilder.RenameIndex(
                name: "IX_UserFunds_UserId",
                table: "UserFund",
                newName: "IX_UserFund_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserFunds_FundId",
                table: "UserFund",
                newName: "IX_UserFund_FundId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserFund",
                table: "UserFund",
                column: "UserFundId");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "FirstName", "IsActive", "IsAdmin", "LastName", "NationalCode", "Password", "PhoneNumber", "RegisterDate", "UserName" },
                values: new object[] { new Guid("430e6f7b-a551-41f4-ac6e-11cfbf705bec"), "کرج، فردیس، کانال غربی", "اشکان", true, true, "مطهری", "0021047022", "MTIzZkBAa2ZAaGJoanNoYmtpaHF3JSRrNDU0ISEtWg==", "09351225600", new DateTime(2024, 8, 27, 23, 53, 40, 176, DateTimeKind.Local).AddTicks(3570), "AshkanAmjad" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserFund_Funds_FundId",
                table: "UserFund",
                column: "FundId",
                principalTable: "Funds",
                principalColumn: "FundId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFund_Users_UserId",
                table: "UserFund",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
