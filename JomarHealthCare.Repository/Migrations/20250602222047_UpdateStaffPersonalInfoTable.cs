using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStaffPersonalInfoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_StaffPersonalInfo_tbl_User_ApplicationUserId",
                table: "tbl_StaffPersonalInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_StaffPersonalInfo_tbl_User_CreatedBy",
                table: "tbl_StaffPersonalInfo");

            migrationBuilder.DropIndex(
                name: "IX_tbl_StaffPersonalInfo_ApplicationUserId",
                table: "tbl_StaffPersonalInfo");

            migrationBuilder.DropIndex(
                name: "IX_tbl_StaffPersonalInfo_CreatedBy",
                table: "tbl_StaffPersonalInfo");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "tbl_StaffPersonalInfo");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_StaffPersonalInfo");

            migrationBuilder.AddColumn<Guid>(
                name: "StaffId",
                table: "tbl_User",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telephone",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "tbl_StaffPersonalInfo",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Self_PYEAttachment",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Self_PYE",
                table: "tbl_StaffPersonalInfo",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "RightToWorkAttachment",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "RightToWork",
                table: "tbl_StaffPersonalInfo",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<bool>(
                name: "RightToPractice",
                table: "tbl_StaffPersonalInfo",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePix",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PostCode",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "NIAttachment",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "NI",
                table: "tbl_StaffPersonalInfo",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<bool>(
                name: "IsTeamLeader",
                table: "tbl_StaffPersonalInfo",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsKeyWorker",
                table: "tbl_StaffPersonalInfo",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "HasUniform",
                table: "tbl_StaffPersonalInfo",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "HasIdCard",
                table: "tbl_StaffPersonalInfo",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225);

            migrationBuilder.AlterColumn<string>(
                name: "DrivingLicense",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "tbl_StaffPersonalInfo",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "DBSAttachment",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DBS",
                table: "tbl_StaffPersonalInfo",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<bool>(
                name: "CanDrive",
                table: "tbl_StaffPersonalInfo",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "AboutMe",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_StaffPersonalInfo",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyCode",
                table: "tbl_Company",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_User_StaffId",
                table: "tbl_User",
                column: "StaffId",
                unique: true,
                filter: "[StaffId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_User_tbl_StaffPersonalInfo_StaffId",
                table: "tbl_User",
                column: "StaffId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_User_tbl_StaffPersonalInfo_StaffId",
                table: "tbl_User");

            migrationBuilder.DropIndex(
                name: "IX_tbl_User_StaffId",
                table: "tbl_User");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "tbl_User");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_StaffPersonalInfo");

            migrationBuilder.DropColumn(
                name: "CompanyCode",
                table: "tbl_Company");

            migrationBuilder.AlterColumn<string>(
                name: "Telephone",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "tbl_StaffPersonalInfo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Self_PYEAttachment",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Self_PYE",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "RightToWorkAttachment",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RightToWork",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "RightToPractice",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePix",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostCode",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NIAttachment",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NI",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsTeamLeader",
                table: "tbl_StaffPersonalInfo",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsKeyWorker",
                table: "tbl_StaffPersonalInfo",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "HasUniform",
                table: "tbl_StaffPersonalInfo",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "HasIdCard",
                table: "tbl_StaffPersonalInfo",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DrivingLicense",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DBSAttachment",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DBS",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "CanDrive",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "AboutMe",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_StaffPersonalInfo",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffPersonalInfo_ApplicationUserId",
                table: "tbl_StaffPersonalInfo",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffPersonalInfo_CreatedBy",
                table: "tbl_StaffPersonalInfo",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffPersonalInfo_tbl_User_ApplicationUserId",
                table: "tbl_StaffPersonalInfo",
                column: "ApplicationUserId",
                principalTable: "tbl_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffPersonalInfo_tbl_User_CreatedBy",
                table: "tbl_StaffPersonalInfo",
                column: "CreatedBy",
                principalTable: "tbl_User",
                principalColumn: "Id");
        }
    }
}
