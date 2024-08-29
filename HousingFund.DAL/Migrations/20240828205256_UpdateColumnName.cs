using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HousingFund.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("27527c4d-8ea6-469d-aff8-ecfa391fb150"));

            migrationBuilder.RenameColumn(
                name: "AddedDate",
                table: "UserFunds",
                newName: "CreatedDate");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "FirstName", "IsActive", "IsAdmin", "LastName", "NationalCode", "Password", "PhoneNumber", "RegisterDate", "UserName" },
                values: new object[] { new Guid("0558af98-b8d5-4d8e-bc49-b3c3ce6226b8"), "کرج، فردیس، کانال غربی", "اشکان", true, true, "مطهری", "0021047022", "MTIzZkBAa2ZAaGJoanNoYmtpaHF3JSRrNDU0ISEtWg==", "09351225600", new DateTime(2024, 8, 29, 0, 22, 56, 474, DateTimeKind.Local).AddTicks(192), "AshkanAmjad" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("0558af98-b8d5-4d8e-bc49-b3c3ce6226b8"));

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "UserFunds",
                newName: "AddedDate");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "FirstName", "IsActive", "IsAdmin", "LastName", "NationalCode", "Password", "PhoneNumber", "RegisterDate", "UserName" },
                values: new object[] { new Guid("27527c4d-8ea6-469d-aff8-ecfa391fb150"), "کرج، فردیس، کانال غربی", "اشکان", true, true, "مطهری", "0021047022", "MTIzZkBAa2ZAaGJoanNoYmtpaHF3JSRrNDU0ISEtWg==", "09351225600", new DateTime(2024, 8, 28, 19, 48, 57, 905, DateTimeKind.Local).AddTicks(3183), "AshkanAmjad" });
        }
    }
}
