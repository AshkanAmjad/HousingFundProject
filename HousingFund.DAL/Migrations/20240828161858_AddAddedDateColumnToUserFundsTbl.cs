using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HousingFund.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddAddedDateColumnToUserFundsTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFunds_Funds_FundId",
                table: "UserFunds");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFunds_Users_UserId",
                table: "UserFunds");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("85720b74-c573-4990-888e-b2293c204eae"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "UserFunds",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "FundId",
                table: "UserFunds",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "UserFunds",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "FirstName", "IsActive", "IsAdmin", "LastName", "NationalCode", "Password", "PhoneNumber", "RegisterDate", "UserName" },
                values: new object[] { new Guid("27527c4d-8ea6-469d-aff8-ecfa391fb150"), "کرج، فردیس، کانال غربی", "اشکان", true, true, "مطهری", "0021047022", "MTIzZkBAa2ZAaGJoanNoYmtpaHF3JSRrNDU0ISEtWg==", "09351225600", new DateTime(2024, 8, 28, 19, 48, 57, 905, DateTimeKind.Local).AddTicks(3183), "AshkanAmjad" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserFunds_Funds_FundId",
                table: "UserFunds",
                column: "FundId",
                principalTable: "Funds",
                principalColumn: "FundId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFunds_Users_UserId",
                table: "UserFunds",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("27527c4d-8ea6-469d-aff8-ecfa391fb150"));

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "UserFunds");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "UserFunds",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "FundId",
                table: "UserFunds",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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
    }
}
