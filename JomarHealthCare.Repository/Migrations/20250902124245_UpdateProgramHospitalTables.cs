using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProgramHospitalTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "isRotaTeamInformed",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "isLittleCashAvailableForServiceUser",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "WhichSupportIsNeeded",
                table: "tbl_HospitalExit",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "tbl_HospitalExit",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Reference",
                table: "tbl_HospitalExit",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ReablementRequired",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfStaffRequiredOnDischarge",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ModeOfMeansOfTrasportBackHome",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IsServiceUseronRota",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IsHomeCleaned",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IsGrosSriesAvaible",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IsCarePlanUpdated",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAndTime",
                table: "tbl_HospitalExit",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "ConditionOnDischarge",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AreStaffTrainnedOnEquipmentNeeded",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AreLocalSupportOrProgramNeeded",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AreEqipmentNeededAvailable",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AreContinentProductNeedAndAvailable",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_HospitalExit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "OfficerToTakeAction",
                table: "tbl_HospitalExit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonToTakeAction",
                table: "tbl_HospitalEntry",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaffInvolved",
                table: "tbl_HospitalEntry",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CallerName",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GoodStaff",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficerToAct",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PoorStaff",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonToAct",
                table: "tbl_Client_ServiceWatch",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaffToAct",
                table: "tbl_Client_ServiceWatch",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficerToAct",
                table: "tbl_Client_Program",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficerToAct",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaffName",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_HospitalExit");

            migrationBuilder.DropColumn(
                name: "OfficerToTakeAction",
                table: "tbl_HospitalExit");

            migrationBuilder.DropColumn(
                name: "PersonToTakeAction",
                table: "tbl_HospitalEntry");

            migrationBuilder.DropColumn(
                name: "StaffInvolved",
                table: "tbl_HospitalEntry");

            migrationBuilder.DropColumn(
                name: "CallerName",
                table: "tbl_Client_Voice");

            migrationBuilder.DropColumn(
                name: "GoodStaff",
                table: "tbl_Client_Voice");

            migrationBuilder.DropColumn(
                name: "OfficerToAct",
                table: "tbl_Client_Voice");

            migrationBuilder.DropColumn(
                name: "PoorStaff",
                table: "tbl_Client_Voice");

            migrationBuilder.DropColumn(
                name: "PersonToAct",
                table: "tbl_Client_ServiceWatch");

            migrationBuilder.DropColumn(
                name: "StaffToAct",
                table: "tbl_Client_ServiceWatch");

            migrationBuilder.DropColumn(
                name: "OfficerToAct",
                table: "tbl_Client_Program");

            migrationBuilder.DropColumn(
                name: "OfficerToAct",
                table: "tbl_Client_MgtVisit");

            migrationBuilder.DropColumn(
                name: "StaffName",
                table: "tbl_Client_MgtVisit");

            migrationBuilder.AlterColumn<int>(
                name: "isRotaTeamInformed",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "isLittleCashAvailableForServiceUser",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WhichSupportIsNeeded",
                table: "tbl_HospitalExit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "tbl_HospitalExit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Reference",
                table: "tbl_HospitalExit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReablementRequired",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfStaffRequiredOnDischarge",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModeOfMeansOfTrasportBackHome",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IsServiceUseronRota",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IsHomeCleaned",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IsGrosSriesAvaible",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IsCarePlanUpdated",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAndTime",
                table: "tbl_HospitalExit",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ConditionOnDischarge",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AreStaffTrainnedOnEquipmentNeeded",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AreLocalSupportOrProgramNeeded",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AreEqipmentNeededAvailable",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AreContinentProductNeedAndAvailable",
                table: "tbl_HospitalExit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
