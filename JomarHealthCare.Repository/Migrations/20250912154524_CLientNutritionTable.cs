using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class CLientNutritionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Cleaning_tbl_StaffPersonalInfo_STAFFId",
                table: "tbl_Client_Cleaning");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_MealDay_tbl_Client_MealType_ClientMealTypeId",
                table: "tbl_Client_MealDay");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_MealDay_tbl_RotaDayofWeek_MealDayofWeekId",
                table: "tbl_Client_MealDay");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Nutrition_tbl_Client_ClientId1",
                table: "tbl_Client_Nutrition");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Nutrition_tbl_Company_ClientId",
                table: "tbl_Client_Nutrition");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Nutrition_tbl_StaffPersonalInfo_StaffId",
                table: "tbl_Client_Nutrition");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Shopping_tbl_StaffPersonalInfo_STAFFId",
                table: "tbl_Client_Shopping");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PersonalDetail_tbl_Client_ClientId1",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PersonalDetail_tbl_Company_ClientId",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PersonalDetail_tbl_Personal_PersonalId",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropIndex(
                name: "IX_tbl_PersonalDetail_ClientId1",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropIndex(
                name: "IX_tbl_PersonalDetail_PersonalId",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ConsentMedication_PersonalDetailId",
                table: "tbl_ConsentMedication");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Client_Shopping_STAFFId",
                table: "tbl_Client_Shopping");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Client_Nutrition_ClientId1",
                table: "tbl_Client_Nutrition");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Client_Nutrition_StaffId",
                table: "tbl_Client_Nutrition");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Client_MealDay_ClientMealTypeId",
                table: "tbl_Client_MealDay");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Client_MealDay_MealDayofWeekId",
                table: "tbl_Client_MealDay");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Client_Cleaning_STAFFId",
                table: "tbl_Client_Cleaning");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropColumn(
                name: "PersonalId",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_Client_Nutrition");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_Client_Nutrition");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_Client_Nutrition");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_Client_Nutrition");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_Client_Nutrition");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_Client_Nutrition");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_Client_Nutrition");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_Client_Nutrition");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_Client_Nutrition");

            migrationBuilder.DropColumn(
                name: "MEALDETAILS",
                table: "tbl_Client_MealDay");

            migrationBuilder.RenameColumn(
                name: "STAFFId",
                table: "tbl_Client_Shopping",
                newName: "StaffId");

            migrationBuilder.RenameColumn(
                name: "DAYOFSHOPPING",
                table: "tbl_Client_Shopping",
                newName: "DayOfShopping");

            migrationBuilder.RenameColumn(
                name: "DATETO",
                table: "tbl_Client_Shopping",
                newName: "DateTo");

            migrationBuilder.RenameColumn(
                name: "DATEFROM",
                table: "tbl_Client_Shopping",
                newName: "DateFrom");

            migrationBuilder.RenameColumn(
                name: "DATETO",
                table: "tbl_Client_Nutrition",
                newName: "DateTo");

            migrationBuilder.RenameColumn(
                name: "DATEFROM",
                table: "tbl_Client_Nutrition",
                newName: "DateFrom");

            migrationBuilder.RenameColumn(
                name: "SEEVIDEO",
                table: "tbl_Client_MealDay",
                newName: "SeeVideo");

            migrationBuilder.RenameColumn(
                name: "PICTURE",
                table: "tbl_Client_MealDay",
                newName: "Picture");

            migrationBuilder.RenameColumn(
                name: "HOWTOPREPARE",
                table: "tbl_Client_MealDay",
                newName: "HowToPrepare");

            migrationBuilder.RenameColumn(
                name: "STAFFId",
                table: "tbl_Client_Cleaning",
                newName: "StaffId");

            migrationBuilder.RenameColumn(
                name: "SEEVIDEO",
                table: "tbl_Client_Cleaning",
                newName: "SeeVideo");

            migrationBuilder.RenameColumn(
                name: "DAYOFCLEANING",
                table: "tbl_Client_Cleaning",
                newName: "DayOfCleaning");

            migrationBuilder.RenameColumn(
                name: "DATETO",
                table: "tbl_Client_Cleaning",
                newName: "DateTo");

            migrationBuilder.RenameColumn(
                name: "DATEFROM",
                table: "tbl_Client_Cleaning",
                newName: "DateFrom");

            migrationBuilder.AlterColumn<string>(
                name: "StaffSignature",
                table: "tbl_PersonalDetail",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ManagerSignature",
                table: "tbl_PersonalDetail",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientSignature",
                table: "tbl_PersonalDetail",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_PersonalDetail",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "tbl_InfectionControl",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LandDate",
                table: "tbl_ConsentData",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LandInvolvingPerson",
                table: "tbl_ConsentData",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LandMethodOfLogs",
                table: "tbl_ConsentData",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LandSignature",
                table: "tbl_ConsentData",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "StaffId",
                table: "tbl_Client_Shopping",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "tbl_Client_Shopping",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "MeansOfPurchase",
                table: "tbl_Client_Shopping",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LocationOfPurchase",
                table: "tbl_Client_Shopping",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Item",
                table: "tbl_Client_Shopping",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "tbl_Client_Shopping",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "tbl_Client_Shopping",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "DayOfShopping",
                table: "tbl_Client_Shopping",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTo",
                table: "tbl_Client_Shopping",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateFrom",
                table: "tbl_Client_Shopping",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "tbl_Client_Shopping",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<Guid>(
                name: "StaffId",
                table: "tbl_Client_Nutrition",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "ShoppingSpecialNote",
                table: "tbl_Client_Nutrition",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MealSpecialNote",
                table: "tbl_Client_Nutrition",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTo",
                table: "tbl_Client_Nutrition",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateFrom",
                table: "tbl_Client_Nutrition",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_Client_Nutrition",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "CleaningSpecialNote",
                table: "tbl_Client_Nutrition",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "tbl_Client_MealDay",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SeeVideo",
                table: "tbl_Client_MealDay",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "tbl_Client_MealDay",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MealDayofWeekId",
                table: "tbl_Client_MealDay",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "HowToPrepare",
                table: "tbl_Client_MealDay",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ClientMealTypeId",
                table: "tbl_Client_MealDay",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "MealDetail",
                table: "tbl_Client_MealDay",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WhereToKeep",
                table: "tbl_Client_Cleaning",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "WhereToGet",
                table: "tbl_Client_Cleaning",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SafetyHazard",
                table: "tbl_Client_Cleaning",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<Guid>(
                name: "StaffId",
                table: "tbl_Client_Cleaning",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "SeeVideo",
                table: "tbl_Client_Cleaning",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MinuteAlloted",
                table: "tbl_Client_Cleaning",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "LocationOfItem",
                table: "tbl_Client_Cleaning",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "tbl_Client_Cleaning",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "tbl_Client_Cleaning",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "DescOfItem",
                table: "tbl_Client_Cleaning",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "DayOfCleaning",
                table: "tbl_Client_Cleaning",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTo",
                table: "tbl_Client_Cleaning",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateFrom",
                table: "tbl_Client_Cleaning",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "AreasAndItems",
                table: "tbl_Client_Cleaning",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "EatingDifficultyDetail",
                table: "tbl_CarePlanNutrition",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FoodIntakeDetail",
                table: "tbl_CarePlanNutrition",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ConsentMedication_PersonalDetailId",
                table: "tbl_ConsentMedication",
                column: "PersonalDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Nutrition_tbl_Client_ClientId",
                table: "tbl_Client_Nutrition",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PersonalDetail_tbl_Client_ClientId",
                table: "tbl_PersonalDetail",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Nutrition_tbl_Client_ClientId",
                table: "tbl_Client_Nutrition");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PersonalDetail_tbl_Client_ClientId",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ConsentMedication_PersonalDetailId",
                table: "tbl_ConsentMedication");

            migrationBuilder.DropColumn(
                name: "Detail",
                table: "tbl_InfectionControl");

            migrationBuilder.DropColumn(
                name: "LandDate",
                table: "tbl_ConsentData");

            migrationBuilder.DropColumn(
                name: "LandInvolvingPerson",
                table: "tbl_ConsentData");

            migrationBuilder.DropColumn(
                name: "LandMethodOfLogs",
                table: "tbl_ConsentData");

            migrationBuilder.DropColumn(
                name: "LandSignature",
                table: "tbl_ConsentData");

            migrationBuilder.DropColumn(
                name: "MealDetail",
                table: "tbl_Client_MealDay");

            migrationBuilder.DropColumn(
                name: "EatingDifficultyDetail",
                table: "tbl_CarePlanNutrition");

            migrationBuilder.DropColumn(
                name: "FoodIntakeDetail",
                table: "tbl_CarePlanNutrition");

            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "tbl_Client_Shopping",
                newName: "STAFFId");

            migrationBuilder.RenameColumn(
                name: "DayOfShopping",
                table: "tbl_Client_Shopping",
                newName: "DAYOFSHOPPING");

            migrationBuilder.RenameColumn(
                name: "DateTo",
                table: "tbl_Client_Shopping",
                newName: "DATETO");

            migrationBuilder.RenameColumn(
                name: "DateFrom",
                table: "tbl_Client_Shopping",
                newName: "DATEFROM");

            migrationBuilder.RenameColumn(
                name: "DateTo",
                table: "tbl_Client_Nutrition",
                newName: "DATETO");

            migrationBuilder.RenameColumn(
                name: "DateFrom",
                table: "tbl_Client_Nutrition",
                newName: "DATEFROM");

            migrationBuilder.RenameColumn(
                name: "SeeVideo",
                table: "tbl_Client_MealDay",
                newName: "SEEVIDEO");

            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "tbl_Client_MealDay",
                newName: "PICTURE");

            migrationBuilder.RenameColumn(
                name: "HowToPrepare",
                table: "tbl_Client_MealDay",
                newName: "HOWTOPREPARE");

            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "tbl_Client_Cleaning",
                newName: "STAFFId");

            migrationBuilder.RenameColumn(
                name: "SeeVideo",
                table: "tbl_Client_Cleaning",
                newName: "SEEVIDEO");

            migrationBuilder.RenameColumn(
                name: "DayOfCleaning",
                table: "tbl_Client_Cleaning",
                newName: "DAYOFCLEANING");

            migrationBuilder.RenameColumn(
                name: "DateTo",
                table: "tbl_Client_Cleaning",
                newName: "DATETO");

            migrationBuilder.RenameColumn(
                name: "DateFrom",
                table: "tbl_Client_Cleaning",
                newName: "DATEFROM");

            migrationBuilder.AlterColumn<string>(
                name: "StaffSignature",
                table: "tbl_PersonalDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ManagerSignature",
                table: "tbl_PersonalDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientSignature",
                table: "tbl_PersonalDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_PersonalDetail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_PersonalDetail",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_PersonalDetail",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_PersonalDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_PersonalDetail",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_PersonalDetail",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_PersonalDetail",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_PersonalDetail",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_PersonalDetail",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_PersonalDetail",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonalId",
                table: "tbl_PersonalDetail",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "STAFFId",
                table: "tbl_Client_Shopping",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "tbl_Client_Shopping",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MeansOfPurchase",
                table: "tbl_Client_Shopping",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LocationOfPurchase",
                table: "tbl_Client_Shopping",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Item",
                table: "tbl_Client_Shopping",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "tbl_Client_Shopping",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "tbl_Client_Shopping",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DAYOFSHOPPING",
                table: "tbl_Client_Shopping",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATETO",
                table: "tbl_Client_Shopping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATEFROM",
                table: "tbl_Client_Shopping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "tbl_Client_Shopping",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "StaffId",
                table: "tbl_Client_Nutrition",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShoppingSpecialNote",
                table: "tbl_Client_Nutrition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MealSpecialNote",
                table: "tbl_Client_Nutrition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATETO",
                table: "tbl_Client_Nutrition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATEFROM",
                table: "tbl_Client_Nutrition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_Client_Nutrition",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CleaningSpecialNote",
                table: "tbl_Client_Nutrition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_Client_Nutrition",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_Client_Nutrition",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_Client_Nutrition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_Client_Nutrition",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_Client_Nutrition",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_Client_Nutrition",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_Client_Nutrition",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_Client_Nutrition",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_Client_Nutrition",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "tbl_Client_MealDay",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SEEVIDEO",
                table: "tbl_Client_MealDay",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PICTURE",
                table: "tbl_Client_MealDay",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MealDayofWeekId",
                table: "tbl_Client_MealDay",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HOWTOPREPARE",
                table: "tbl_Client_MealDay",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientMealTypeId",
                table: "tbl_Client_MealDay",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MEALDETAILS",
                table: "tbl_Client_MealDay",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "WhereToKeep",
                table: "tbl_Client_Cleaning",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WhereToGet",
                table: "tbl_Client_Cleaning",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "STAFFId",
                table: "tbl_Client_Cleaning",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SEEVIDEO",
                table: "tbl_Client_Cleaning",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SafetyHazard",
                table: "tbl_Client_Cleaning",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MinuteAlloted",
                table: "tbl_Client_Cleaning",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LocationOfItem",
                table: "tbl_Client_Cleaning",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "tbl_Client_Cleaning",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "tbl_Client_Cleaning",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescOfItem",
                table: "tbl_Client_Cleaning",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DAYOFCLEANING",
                table: "tbl_Client_Cleaning",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATETO",
                table: "tbl_Client_Cleaning",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATEFROM",
                table: "tbl_Client_Cleaning",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AreasAndItems",
                table: "tbl_Client_Cleaning",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PersonalDetail_ClientId1",
                table: "tbl_PersonalDetail",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PersonalDetail_PersonalId",
                table: "tbl_PersonalDetail",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ConsentMedication_PersonalDetailId",
                table: "tbl_ConsentMedication",
                column: "PersonalDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_Shopping_STAFFId",
                table: "tbl_Client_Shopping",
                column: "STAFFId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_Nutrition_ClientId1",
                table: "tbl_Client_Nutrition",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_Nutrition_StaffId",
                table: "tbl_Client_Nutrition",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_MealDay_ClientMealTypeId",
                table: "tbl_Client_MealDay",
                column: "ClientMealTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_MealDay_MealDayofWeekId",
                table: "tbl_Client_MealDay",
                column: "MealDayofWeekId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_Cleaning_STAFFId",
                table: "tbl_Client_Cleaning",
                column: "STAFFId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Cleaning_tbl_StaffPersonalInfo_STAFFId",
                table: "tbl_Client_Cleaning",
                column: "STAFFId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_MealDay_tbl_Client_MealType_ClientMealTypeId",
                table: "tbl_Client_MealDay",
                column: "ClientMealTypeId",
                principalTable: "tbl_Client_MealType",
                principalColumn: "ClientMealTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_MealDay_tbl_RotaDayofWeek_MealDayofWeekId",
                table: "tbl_Client_MealDay",
                column: "MealDayofWeekId",
                principalTable: "tbl_RotaDayofWeek",
                principalColumn: "RotaDayofWeekId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Nutrition_tbl_Client_ClientId1",
                table: "tbl_Client_Nutrition",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Nutrition_tbl_Company_ClientId",
                table: "tbl_Client_Nutrition",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Nutrition_tbl_StaffPersonalInfo_StaffId",
                table: "tbl_Client_Nutrition",
                column: "StaffId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Shopping_tbl_StaffPersonalInfo_STAFFId",
                table: "tbl_Client_Shopping",
                column: "STAFFId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PersonalDetail_tbl_Client_ClientId1",
                table: "tbl_PersonalDetail",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PersonalDetail_tbl_Company_ClientId",
                table: "tbl_PersonalDetail",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PersonalDetail_tbl_Personal_PersonalId",
                table: "tbl_PersonalDetail",
                column: "PersonalId",
                principalTable: "tbl_Personal",
                principalColumn: "PersonalId");
        }
    }
}
