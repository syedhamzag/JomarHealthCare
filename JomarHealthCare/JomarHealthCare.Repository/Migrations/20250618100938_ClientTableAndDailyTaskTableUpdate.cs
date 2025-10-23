using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class ClientTableAndDailyTaskTableUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_tbl_Company_CompanyId",
                table: "tbl_Client");

            migrationBuilder.DropColumn(
                name: "CapacityId",
                table: "tbl_Client");

            migrationBuilder.DropColumn(
                name: "ChoiceOfStaffId",
                table: "tbl_Client");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "tbl_Client");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "tbl_Client");

            migrationBuilder.DropColumn(
                name: "PassportFilePath",
                table: "tbl_Client");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "tbl_Client");

            migrationBuilder.DropColumn(
                name: "TeamLeaderId",
                table: "tbl_Client");

            migrationBuilder.RenameColumn(
                name: "Keyworker",
                table: "tbl_Client",
                newName: "ServiceType");

            migrationBuilder.AlterColumn<string>(
                name: "DailyTaskName",
                table: "tbl_ClientDailyTask",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HowToPerformTask",
                table: "tbl_ClientDailyTask",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "tbl_ClientDailyTask",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Video",
                table: "tbl_ClientDailyTask",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TeamLeader",
                table: "tbl_Client",
                type: "nvarchar(38)",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "tbl_Client",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                table: "tbl_Client",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "ProvisionVenue",
                table: "tbl_Client",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderReference",
                table: "tbl_Client",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PracticalSupport",
                table: "tbl_Client",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KeyworkerId",
                table: "tbl_Client",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Hobbies",
                table: "tbl_Client",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Denture",
                table: "tbl_Client",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CompanyId",
                table: "tbl_Client",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "ClientManager",
                table: "tbl_Client",
                type: "nvarchar(38)",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aid",
                table: "tbl_Client",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Capacity",
                table: "tbl_Client",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChoiceOfStaff",
                table: "tbl_Client",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "tbl_Client",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "tbl_Client",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileImage",
                table: "tbl_Client",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_tbl_Company_CompanyId",
                table: "tbl_Client",
                column: "CompanyId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_tbl_Company_CompanyId",
                table: "tbl_Client");

            migrationBuilder.DropColumn(
                name: "HowToPerformTask",
                table: "tbl_ClientDailyTask");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "tbl_ClientDailyTask");

            migrationBuilder.DropColumn(
                name: "Video",
                table: "tbl_ClientDailyTask");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "tbl_Client");

            migrationBuilder.DropColumn(
                name: "ChoiceOfStaff",
                table: "tbl_Client");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "tbl_Client");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "tbl_Client");

            migrationBuilder.DropColumn(
                name: "ProfileImage",
                table: "tbl_Client");

            migrationBuilder.RenameColumn(
                name: "ServiceType",
                table: "tbl_Client",
                newName: "Keyworker");

            migrationBuilder.AlterColumn<string>(
                name: "DailyTaskName",
                table: "tbl_ClientDailyTask",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TeamLeader",
                table: "tbl_Client",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(38)",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "tbl_Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                table: "tbl_Client",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProvisionVenue",
                table: "tbl_Client",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderReference",
                table: "tbl_Client",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PracticalSupport",
                table: "tbl_Client",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KeyworkerId",
                table: "tbl_Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Hobbies",
                table: "tbl_Client",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Denture",
                table: "tbl_Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CompanyId",
                table: "tbl_Client",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientManager",
                table: "tbl_Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(38)",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Aid",
                table: "tbl_Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CapacityId",
                table: "tbl_Client",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChoiceOfStaffId",
                table: "tbl_Client",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "tbl_Client",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "tbl_Client",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassportFilePath",
                table: "tbl_Client",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "tbl_Client",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamLeaderId",
                table: "tbl_Client",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_tbl_Company_CompanyId",
                table: "tbl_Client",
                column: "CompanyId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
