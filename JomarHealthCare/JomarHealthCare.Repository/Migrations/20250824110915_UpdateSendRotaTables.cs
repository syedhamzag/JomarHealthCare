using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSendRotaTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_StaffMedRota_tbl_ClientRotaName_RotaId",
                table: "tbl_StaffMedRota");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_StaffMedRota_tbl_User_CreatedBy",
                table: "tbl_StaffMedRota");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_StaffRota_tbl_ClientRotaName_RotaId",
                table: "tbl_StaffRota");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_StaffRotaPeriod_tbl_Company_ClientId",
                table: "tbl_StaffRotaPeriod");

            migrationBuilder.DropIndex(
                name: "IX_tbl_StaffRotaPeriod_ClientId",
                table: "tbl_StaffRotaPeriod");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ClientMedication_MedicationRouteId",
                table: "tbl_ClientMedication");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_StaffRotaPeriod");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_StaffRotaPeriod");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_StaffRotaPeriod");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_StaffRotaPeriod");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_StaffRotaPeriod");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_StaffRotaPeriod");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_StaffRotaPeriod");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_StaffRotaPeriod");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_StaffRotaPeriod");

            migrationBuilder.DropColumn(
                name: "Staff",
                table: "tbl_StaffMedRota");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "tbl_StaffMedRota",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_StaffMedRota_CreatedBy",
                table: "tbl_StaffMedRota",
                newName: "IX_tbl_StaffMedRota_ApplicationUserId");

            migrationBuilder.AlterColumn<string>(
                name: "reasonExceeding",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "forcedExit",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "forcedEntry",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpcomingplannedTask",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Signature",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ObjectiveOfCareMeet",
                table: "tbl_StaffRotaPeriod",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MealIntake",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LatenessComments",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HandOver",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Feedback",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClockOutMode",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClockOutAddress",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClockInMode",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClockInAddress",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ClientHappyWithServiceOrStaff",
                table: "tbl_StaffRotaPeriod",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Certify",
                table: "tbl_StaffRotaPeriod",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BodyMap",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AlertComment",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "StaffId",
                table: "tbl_StaffRotaPartner",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "Staff",
                table: "tbl_StaffRota",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RotaId",
                table: "tbl_StaffRota",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RotaDate",
                table: "tbl_StaffRota",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "tbl_StaffRota",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReferenceNumber",
                table: "tbl_StaffRota",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "StaffCommentsOrConcern",
                table: "tbl_StaffMedRota",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(550)",
                oldMaxLength: 550,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RotaId",
                table: "tbl_StaffMedRota",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RotaDate",
                table: "tbl_StaffMedRota",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "tbl_StaffMedRota",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReferenceNumber",
                table: "tbl_StaffMedRota",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Measurement",
                table: "tbl_StaffMedRota",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "tbl_StaffMedRota",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GivenMedicationNotInChart",
                table: "tbl_StaffMedRota",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Feedback",
                table: "tbl_StaffMedRota",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DosePrescribed",
                table: "tbl_StaffMedRota",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(550)",
                oldMaxLength: 550,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClockOutLocation",
                table: "tbl_StaffMedRota",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClockInLocation",
                table: "tbl_StaffMedRota",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Attachment",
                table: "tbl_StaffMedRota",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(226)",
                oldMaxLength: 226,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_StaffMedRota",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientMedication_MedicationRouteId",
                table: "tbl_ClientMedication",
                column: "MedicationRouteId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffMedRota_tbl_ClientRotaName_RotaId",
                table: "tbl_StaffMedRota",
                column: "RotaId",
                principalTable: "tbl_ClientRotaName",
                principalColumn: "RotaId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffMedRota_tbl_User_ApplicationUserId",
                table: "tbl_StaffMedRota",
                column: "ApplicationUserId",
                principalTable: "tbl_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffRota_tbl_ClientRotaName_RotaId",
                table: "tbl_StaffRota",
                column: "RotaId",
                principalTable: "tbl_ClientRotaName",
                principalColumn: "RotaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_StaffMedRota_tbl_ClientRotaName_RotaId",
                table: "tbl_StaffMedRota");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_StaffMedRota_tbl_User_ApplicationUserId",
                table: "tbl_StaffMedRota");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_StaffRota_tbl_ClientRotaName_RotaId",
                table: "tbl_StaffRota");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ClientMedication_MedicationRouteId",
                table: "tbl_ClientMedication");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_StaffMedRota");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "tbl_StaffMedRota",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_StaffMedRota_ApplicationUserId",
                table: "tbl_StaffMedRota",
                newName: "IX_tbl_StaffMedRota_CreatedBy");

            migrationBuilder.AlterColumn<string>(
                name: "reasonExceeding",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "forcedExit",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "forcedEntry",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpcomingplannedTask",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Signature",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ObjectiveOfCareMeet",
                table: "tbl_StaffRotaPeriod",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "MealIntake",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LatenessComments",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HandOver",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Feedback",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClockOutMode",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClockOutAddress",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClockInMode",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClockInAddress",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ClientHappyWithServiceOrStaff",
                table: "tbl_StaffRotaPeriod",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Certify",
                table: "tbl_StaffRotaPeriod",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "BodyMap",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AlertComment",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientId1",
                table: "tbl_StaffRotaPeriod",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_StaffRotaPeriod",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_StaffRotaPeriod",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_StaffRotaPeriod",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_StaffRotaPeriod",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_StaffRotaPeriod",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_StaffRotaPeriod",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "StaffId",
                table: "tbl_StaffRotaPartner",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Staff",
                table: "tbl_StaffRota",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RotaId",
                table: "tbl_StaffRota",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RotaDate",
                table: "tbl_StaffRota",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "tbl_StaffRota",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReferenceNumber",
                table: "tbl_StaffRota",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StaffCommentsOrConcern",
                table: "tbl_StaffMedRota",
                type: "nvarchar(550)",
                maxLength: 550,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RotaId",
                table: "tbl_StaffMedRota",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RotaDate",
                table: "tbl_StaffMedRota",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "tbl_StaffMedRota",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReferenceNumber",
                table: "tbl_StaffMedRota",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Measurement",
                table: "tbl_StaffMedRota",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "tbl_StaffMedRota",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GivenMedicationNotInChart",
                table: "tbl_StaffMedRota",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Feedback",
                table: "tbl_StaffMedRota",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DosePrescribed",
                table: "tbl_StaffMedRota",
                type: "nvarchar(550)",
                maxLength: 550,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClockOutLocation",
                table: "tbl_StaffMedRota",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClockInLocation",
                table: "tbl_StaffMedRota",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Attachment",
                table: "tbl_StaffMedRota",
                type: "nvarchar(226)",
                maxLength: 226,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Staff",
                table: "tbl_StaffMedRota",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffRotaPeriod_ClientId",
                table: "tbl_StaffRotaPeriod",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientMedication_MedicationRouteId",
                table: "tbl_ClientMedication",
                column: "MedicationRouteId",
                unique: true,
                filter: "[MedicationRouteId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffMedRota_tbl_ClientRotaName_RotaId",
                table: "tbl_StaffMedRota",
                column: "RotaId",
                principalTable: "tbl_ClientRotaName",
                principalColumn: "RotaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffMedRota_tbl_User_CreatedBy",
                table: "tbl_StaffMedRota",
                column: "CreatedBy",
                principalTable: "tbl_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffRota_tbl_ClientRotaName_RotaId",
                table: "tbl_StaffRota",
                column: "RotaId",
                principalTable: "tbl_ClientRotaName",
                principalColumn: "RotaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffRotaPeriod_tbl_Company_ClientId",
                table: "tbl_StaffRotaPeriod",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");
        }
    }
}
