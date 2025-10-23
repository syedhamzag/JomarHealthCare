using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCareplanTablePhase2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HealthAndLiving_tbl_Client_ClientId1",
                table: "tbl_HealthAndLiving");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HealthAndLiving_tbl_Company_ClientId",
                table: "tbl_HealthAndLiving");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HistoryOfFall_tbl_Client_ClientId1",
                table: "tbl_HistoryOfFall");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HistoryOfFall_tbl_Company_ClientId",
                table: "tbl_HistoryOfFall");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PersonalHygiene_tbl_Client_ClientId1",
                table: "tbl_PersonalHygiene");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PersonalHygiene_tbl_Company_ClientId",
                table: "tbl_PersonalHygiene");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_SpecialHealthAndMedication_tbl_Client_ClientId1",
                table: "tbl_SpecialHealthAndMedication");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_SpecialHealthAndMedication_tbl_Company_ClientId",
                table: "tbl_SpecialHealthAndMedication");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_SpecialHealthCondition_tbl_Client_ClientId1",
                table: "tbl_SpecialHealthCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_SpecialHealthCondition_tbl_Company_ClientId",
                table: "tbl_SpecialHealthCondition");

            migrationBuilder.DropIndex(
                name: "IX_tbl_SpecialHealthCondition_ClientId1",
                table: "tbl_SpecialHealthCondition");

            migrationBuilder.DropIndex(
                name: "IX_tbl_SpecialHealthAndMedication_ClientId1",
                table: "tbl_SpecialHealthAndMedication");

            migrationBuilder.DropIndex(
                name: "IX_tbl_PersonalHygiene_ClientId1",
                table: "tbl_PersonalHygiene");

            migrationBuilder.DropIndex(
                name: "IX_tbl_HistoryOfFall_ClientId1",
                table: "tbl_HistoryOfFall");

            migrationBuilder.DropIndex(
                name: "IX_tbl_HealthAndLiving_ClientId1",
                table: "tbl_HealthAndLiving");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_SpecialHealthCondition");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_SpecialHealthCondition");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_SpecialHealthCondition");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_SpecialHealthCondition");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_SpecialHealthCondition");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_SpecialHealthCondition");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_SpecialHealthCondition");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_SpecialHealthCondition");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_SpecialHealthCondition");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_SpecialHealthAndMedication");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_SpecialHealthAndMedication");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_SpecialHealthAndMedication");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_SpecialHealthAndMedication");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_SpecialHealthAndMedication");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_SpecialHealthAndMedication");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_SpecialHealthAndMedication");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_SpecialHealthAndMedication");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_SpecialHealthAndMedication");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_PersonalHygiene");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_PersonalHygiene");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_PersonalHygiene");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_PersonalHygiene");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_PersonalHygiene");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_PersonalHygiene");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_PersonalHygiene");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_PersonalHygiene");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_PersonalHygiene");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_HistoryOfFall");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_HistoryOfFall");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_HistoryOfFall");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_HistoryOfFall");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_HistoryOfFall");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_HistoryOfFall");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_HistoryOfFall");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_HistoryOfFall");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_HistoryOfFall");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_HealthAndLiving");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_HealthAndLiving");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_HealthAndLiving");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_HealthAndLiving");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_HealthAndLiving");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_HealthAndLiving");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_HealthAndLiving");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_HealthAndLiving");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_HealthAndLiving");

            migrationBuilder.RenameColumn(
                name: "ClinetId",
                table: "tbl_Capacity",
                newName: "ClientId");

            migrationBuilder.AlterColumn<string>(
                name: "Trigger",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SourceInformation",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PlanningHealthCondition",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LivingActivities",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LifestyleSupport",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Frequency",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FeelingBeforeIncident",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FeelingAfterIncident",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ConditionName",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ClinicRecommendation",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_SpecialHealthCondition",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "ClientAction",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "WhoAdminister",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TempMARChart",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SpecialStorage",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PharmaMARChart",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PNRMedsMissing",
                table: "tbl_SpecialHealthAndMedication",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "PNRMedsAdmin",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PNRMedReq",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PNRMedList",
                table: "tbl_SpecialHealthAndMedication",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "PNRDoses",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OverdoseContact",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NoMedAccess",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NameFormMedicaiton",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MedsGPOrder",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "MedicationStorage",
                table: "tbl_SpecialHealthAndMedication",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MedicationAllergy",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "MedKeyCode",
                table: "tbl_SpecialHealthAndMedication",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MedAccessDenial",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LeftoutMedicine",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FamilyReturnMed",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FamilyMeds",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "tbl_SpecialHealthAndMedication",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Consent",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_SpecialHealthAndMedication",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "By",
                table: "tbl_SpecialHealthAndMedication",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "AdminLvl",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AccessMedication",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LaundrySupport",
                table: "tbl_PersonalHygiene",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LaundryGuide",
                table: "tbl_PersonalHygiene",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_PersonalHygiene",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Prevention",
                table: "tbl_HistoryOfFall",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "HowToControl",
                table: "tbl_HistoryOfFall",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Escallation",
                table: "tbl_HistoryOfFall",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "tbl_HistoryOfFall",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DetailofRisk",
                table: "tbl_HistoryOfFall",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "tbl_HistoryOfFall",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_HistoryOfFall",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "CauseAndTriger",
                table: "tbl_HistoryOfFall",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cause",
                table: "tbl_HistoryOfFall",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "WakeUp",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "VideoCallRequired",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TextFontSize",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TeaChocolateCoffee",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TVandMusic",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SupportToBed",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "SpecialCleaning",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialCaution",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Smoking",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ShoppingRequired",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PressureSore",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PostalService",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ObserveHealth",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "NeighbourInvolment",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "MovingAndHandling",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MeansOfComm",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LifeStyle",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LetterOpening",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LaundaryRequired",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FinanceManagement",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FamilyUpdate",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Email",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EatingWithStaff",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DehydrationRisk",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ContinenceSource",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContinenceNeeds",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ContinenceIssue",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ConstraintRequired",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ConstraintDetails",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ConstraintAttachment",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_HealthAndLiving",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "CareSupport",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BriefHealth",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "AllowChats",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AlcoholicDrink",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AbilityToRead",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HealthAndLiving_tbl_Client_ClientId",
                table: "tbl_HealthAndLiving",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HistoryOfFall_tbl_Client_ClientId",
                table: "tbl_HistoryOfFall",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PersonalHygiene_tbl_Client_ClientId",
                table: "tbl_PersonalHygiene",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_SpecialHealthAndMedication_tbl_Client_ClientId",
                table: "tbl_SpecialHealthAndMedication",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_SpecialHealthCondition_tbl_Client_ClientId",
                table: "tbl_SpecialHealthCondition",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HealthAndLiving_tbl_Client_ClientId",
                table: "tbl_HealthAndLiving");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HistoryOfFall_tbl_Client_ClientId",
                table: "tbl_HistoryOfFall");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PersonalHygiene_tbl_Client_ClientId",
                table: "tbl_PersonalHygiene");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_SpecialHealthAndMedication_tbl_Client_ClientId",
                table: "tbl_SpecialHealthAndMedication");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_SpecialHealthCondition_tbl_Client_ClientId",
                table: "tbl_SpecialHealthCondition");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "tbl_Capacity",
                newName: "ClinetId");

            migrationBuilder.AlterColumn<string>(
                name: "Trigger",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SourceInformation",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PlanningHealthCondition",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LivingActivities",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LifestyleSupport",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Frequency",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FeelingBeforeIncident",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FeelingAfterIncident",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ConditionName",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClinicRecommendation",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_SpecialHealthCondition",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientAction",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_SpecialHealthCondition",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_SpecialHealthCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_SpecialHealthCondition",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_SpecialHealthCondition",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_SpecialHealthCondition",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_SpecialHealthCondition",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_SpecialHealthCondition",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WhoAdminister",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TempMARChart",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SpecialStorage",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PharmaMARChart",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PNRMedsMissing",
                table: "tbl_SpecialHealthAndMedication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PNRMedsAdmin",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PNRMedReq",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PNRMedList",
                table: "tbl_SpecialHealthAndMedication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PNRDoses",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OverdoseContact",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NoMedAccess",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NameFormMedicaiton",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MedsGPOrder",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MedicationStorage",
                table: "tbl_SpecialHealthAndMedication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MedicationAllergy",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MedKeyCode",
                table: "tbl_SpecialHealthAndMedication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MedAccessDenial",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LeftoutMedicine",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FamilyReturnMed",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FamilyMeds",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "tbl_SpecialHealthAndMedication",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Consent",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_SpecialHealthAndMedication",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "By",
                table: "tbl_SpecialHealthAndMedication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdminLvl",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AccessMedication",
                table: "tbl_SpecialHealthAndMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_SpecialHealthAndMedication",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_SpecialHealthAndMedication",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_SpecialHealthAndMedication",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_SpecialHealthAndMedication",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_SpecialHealthAndMedication",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_SpecialHealthAndMedication",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_SpecialHealthAndMedication",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_SpecialHealthAndMedication",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_SpecialHealthAndMedication",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LaundrySupport",
                table: "tbl_PersonalHygiene",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LaundryGuide",
                table: "tbl_PersonalHygiene",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_PersonalHygiene",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_PersonalHygiene",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_PersonalHygiene",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_PersonalHygiene",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_PersonalHygiene",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_PersonalHygiene",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_PersonalHygiene",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_PersonalHygiene",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_PersonalHygiene",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_PersonalHygiene",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Prevention",
                table: "tbl_HistoryOfFall",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HowToControl",
                table: "tbl_HistoryOfFall",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Escallation",
                table: "tbl_HistoryOfFall",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "tbl_HistoryOfFall",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DetailofRisk",
                table: "tbl_HistoryOfFall",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "tbl_HistoryOfFall",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_HistoryOfFall",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CauseAndTriger",
                table: "tbl_HistoryOfFall",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cause",
                table: "tbl_HistoryOfFall",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_HistoryOfFall",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_HistoryOfFall",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_HistoryOfFall",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_HistoryOfFall",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_HistoryOfFall",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_HistoryOfFall",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_HistoryOfFall",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_HistoryOfFall",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_HistoryOfFall",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WakeUp",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VideoCallRequired",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TextFontSize",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TeaChocolateCoffee",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TVandMusic",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SupportToBed",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SpecialCleaning",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SpecialCaution",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Smoking",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShoppingRequired",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PressureSore",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PostalService",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ObserveHealth",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NeighbourInvolment",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MovingAndHandling",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MeansOfComm",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LifeStyle",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LetterOpening",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LaundaryRequired",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FinanceManagement",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FamilyUpdate",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Email",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EatingWithStaff",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DehydrationRisk",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContinenceSource",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContinenceNeeds",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContinenceIssue",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ConstraintRequired",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ConstraintDetails",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ConstraintAttachment",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_HealthAndLiving",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CareSupport",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BriefHealth",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AllowChats",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AlcoholicDrink",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AbilityToRead",
                table: "tbl_HealthAndLiving",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_HealthAndLiving",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_HealthAndLiving",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_HealthAndLiving",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_HealthAndLiving",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_HealthAndLiving",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_HealthAndLiving",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_HealthAndLiving",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_SpecialHealthCondition_ClientId1",
                table: "tbl_SpecialHealthCondition",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_SpecialHealthAndMedication_ClientId1",
                table: "tbl_SpecialHealthAndMedication",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PersonalHygiene_ClientId1",
                table: "tbl_PersonalHygiene",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HistoryOfFall_ClientId1",
                table: "tbl_HistoryOfFall",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HealthAndLiving_ClientId1",
                table: "tbl_HealthAndLiving",
                column: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HealthAndLiving_tbl_Client_ClientId1",
                table: "tbl_HealthAndLiving",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HealthAndLiving_tbl_Company_ClientId",
                table: "tbl_HealthAndLiving",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HistoryOfFall_tbl_Client_ClientId1",
                table: "tbl_HistoryOfFall",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HistoryOfFall_tbl_Company_ClientId",
                table: "tbl_HistoryOfFall",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PersonalHygiene_tbl_Client_ClientId1",
                table: "tbl_PersonalHygiene",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PersonalHygiene_tbl_Company_ClientId",
                table: "tbl_PersonalHygiene",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_SpecialHealthAndMedication_tbl_Client_ClientId1",
                table: "tbl_SpecialHealthAndMedication",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_SpecialHealthAndMedication_tbl_Company_ClientId",
                table: "tbl_SpecialHealthAndMedication",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_SpecialHealthCondition_tbl_Client_ClientId1",
                table: "tbl_SpecialHealthCondition",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_SpecialHealthCondition_tbl_Company_ClientId",
                table: "tbl_SpecialHealthCondition",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
