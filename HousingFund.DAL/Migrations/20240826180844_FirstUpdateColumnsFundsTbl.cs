using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HousingFund.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FirstUpdateColumnsFundsTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "userId",
                keyValue: new Guid("3cc633ba-05dd-47f7-85fc-480ae495e8c5"));

            migrationBuilder.AlterColumn<string>(
                name: "Income",
                table: "Funds",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Funds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "Address", "FirstName", "IsActive", "IsAdmin", "LastName", "NationalCode", "Password", "PhoneNumber", "RegisterDate", "UserName" },
                values: new object[] { new Guid("756c6c9d-63ec-4ea8-ad6a-d4320d8978f6"), "کرج، فردیس، کانال غربی", "اشکان", true, true, "مطهری", "0021047022", "MTIzYWRlZkBAa2Z4Y2J2QA==", "09351225600", new DateTime(2024, 8, 26, 21, 38, 43, 852, DateTimeKind.Local).AddTicks(6114), "AshkanAmjad" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "userId",
                keyValue: new Guid("756c6c9d-63ec-4ea8-ad6a-d4320d8978f6"));

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Funds");

            migrationBuilder.AlterColumn<decimal>(
                name: "Income",
                table: "Funds",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "Address", "FirstName", "IsActive", "IsAdmin", "LastName", "NationalCode", "Password", "PhoneNumber", "RegisterDate", "UserName" },
                values: new object[] { new Guid("3cc633ba-05dd-47f7-85fc-480ae495e8c5"), "کرج، فردیس، کانال غربی", "اشکان", true, true, "مطهری", "0021047022", "MTIzYWRlZkBAa2Z4Y2J2QA==", "09351225600", new DateTime(2024, 8, 20, 5, 7, 47, 619, DateTimeKind.Local).AddTicks(98), "AshkanAmjad" });
        }
    }
}
