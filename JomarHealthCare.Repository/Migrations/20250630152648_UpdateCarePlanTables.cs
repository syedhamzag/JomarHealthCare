using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCarePlanTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Balance_tbl_Client_ClientId1",
                table: "tbl_Balance");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Balance_tbl_Company_ClientId",
                table: "tbl_Balance");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_BodyMap_tbl_Client_ClientId1",
                table: "tbl_BodyMap");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_BodyMap_tbl_Company_ClientId",
                table: "tbl_BodyMap");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Capacity_tbl_PersonalDetail_PersonalDetailId",
                table: "tbl_Capacity");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CarePlanNutrition_tbl_Client_ClientId1",
                table: "tbl_CarePlanNutrition");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CarePlanNutrition_tbl_Company_ClientId",
                table: "tbl_CarePlanNutrition");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientKeyworkerNotes_tbl_Company_ClientId",
                table: "tbl_ClientKeyworkerNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_KeyIndicatorLog_tbl_KeyIndicators_KeyId",
                table: "tbl_KeyIndicatorLog");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_KeyIndicators_tbl_PersonalDetail_PersonalDetailId",
                table: "tbl_KeyIndicators");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Personal_tbl_PersonalDetail_PersonalDetailId",
                table: "tbl_Personal");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PersonCentred_tbl_PersonalDetail_PersonalDetailId",
                table: "tbl_PersonCentred");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PhysicalAbility_tbl_Client_ClientId1",
                table: "tbl_PhysicalAbility");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PhysicalAbility_tbl_Company_ClientId",
                table: "tbl_PhysicalAbility");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Review_tbl_PersonalDetail_PersonalDetailId",
                table: "tbl_Review");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Review_PersonalDetailId",
                table: "tbl_Review");

            migrationBuilder.DropIndex(
                name: "IX_tbl_PhysicalAbility_ClientId1",
                table: "tbl_PhysicalAbility");

            migrationBuilder.DropIndex(
                name: "IX_tbl_PersonCentred_PersonalDetailId",
                table: "tbl_PersonCentred");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Personal_PersonalDetailId",
                table: "tbl_Personal");

            migrationBuilder.DropIndex(
                name: "IX_tbl_KeyIndicators_PersonalDetailId",
                table: "tbl_KeyIndicators");

            migrationBuilder.DropIndex(
                name: "IX_tbl_KeyIndicatorLog_KeyId",
                table: "tbl_KeyIndicatorLog");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ClientKeyworkerNotes_ClientId",
                table: "tbl_ClientKeyworkerNotes");

            migrationBuilder.DropIndex(
                name: "IX_tbl_CarePlanNutrition_ClientId1",
                table: "tbl_CarePlanNutrition");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Capacity_PersonalDetailId",
                table: "tbl_Capacity");

            migrationBuilder.DropIndex(
                name: "IX_tbl_BodyMap_ClientId1",
                table: "tbl_BodyMap");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Balance_ClientId1",
                table: "tbl_Balance");

            migrationBuilder.DropColumn(
                name: "PersonalDetailId",
                table: "tbl_Review");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_PhysicalAbility");

            migrationBuilder.DropColumn(
                name: "PersonalDetailId",
                table: "tbl_PersonCentred");

            migrationBuilder.DropColumn(
                name: "PersonalDetailId",
                table: "tbl_Personal");

            migrationBuilder.DropColumn(
                name: "PersonalDetailId",
                table: "tbl_KeyIndicators");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_ClientKeyworkerNotes");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_ClientKeyworkerNotes");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_ClientKeyworkerNotes");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_ClientKeyworkerNotes");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_ClientKeyworkerNotes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_ClientKeyworkerNotes");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_ClientKeyworkerNotes");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_ClientKeyworkerNotes");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_CarePlanNutrition");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_CarePlanNutrition");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_CarePlanNutrition");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_CarePlanNutrition");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_CarePlanNutrition");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_CarePlanNutrition");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_CarePlanNutrition");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_CarePlanNutrition");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_CarePlanNutrition");

            migrationBuilder.DropColumn(
                name: "Implications",
                table: "tbl_Capacity");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_BodyMap");

            migrationBuilder.DropColumn(
                name: "ClientId2",
                table: "tbl_BodyMap");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_Balance");

            migrationBuilder.RenameColumn(
                name: "PersonalDetailId",
                table: "tbl_Capacity",
                newName: "Implication");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RA_ReviewDate",
                table: "tbl_Review",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RA_PreDate",
                table: "tbl_Review",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CP_ReviewDate",
                table: "tbl_Review",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CP_PreDate",
                table: "tbl_Review",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "tbl_Review",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_PhysicalAbility",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tbl_PhysicalAbility",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Mobility",
                table: "tbl_PhysicalAbility",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "tbl_PhysicalAbility",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_PhysicalAbility",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "ExpSupport",
                table: "tbl_PersonCentred",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "tbl_PersonCentred",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Focus",
                table: "tbl_PersonCentred",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonalId",
                table: "tbl_PersonalDetail",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Religion",
                table: "tbl_Personal",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nationality",
                table: "tbl_Personal",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "tbl_Personal",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "ThingsILike",
                table: "tbl_KeyIndicators",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FamilyRole",
                table: "tbl_KeyIndicators",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AboutMe",
                table: "tbl_KeyIndicators",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "tbl_KeyIndicators",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "LogMethod",
                table: "tbl_KeyIndicators",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KeyIndicatorsKeyId",
                table: "tbl_KeyIndicatorLog",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KeyworkerId",
                table: "tbl_ClientKeyworkerNotes",
                type: "nvarchar(38)",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_ClientKeyworkerNotes",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "OtherStaffId",
                table: "tbl_ClientKeyworkerNotes",
                type: "nvarchar(38)",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WhoRestock",
                table: "tbl_CarePlanNutrition",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "WhenRestock",
                table: "tbl_CarePlanNutrition",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ThingsILike",
                table: "tbl_CarePlanNutrition",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialDiet",
                table: "tbl_CarePlanNutrition",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ServingMeal",
                table: "tbl_CarePlanNutrition",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RiskMitigations",
                table: "tbl_CarePlanNutrition",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MealPreparation",
                table: "tbl_CarePlanNutrition",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FoodStorage",
                table: "tbl_CarePlanNutrition",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FoodIntake",
                table: "tbl_CarePlanNutrition",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EatingDifficulty",
                table: "tbl_CarePlanNutrition",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DrinkType",
                table: "tbl_CarePlanNutrition",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_CarePlanNutrition",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "AvoidFood",
                table: "tbl_CarePlanNutrition",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "ClinetId",
                table: "tbl_Capacity",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Indicators",
                table: "tbl_Capacity",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_Balance",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tbl_Balance",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Mobility",
                table: "tbl_Balance",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "tbl_Balance",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_Balance",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PersonCentred_ClientId",
                table: "tbl_PersonCentred",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PersonalDetail_PersonalId",
                table: "tbl_PersonalDetail",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_KeyIndicatorLog_KeyIndicatorsKeyId",
                table: "tbl_KeyIndicatorLog",
                column: "KeyIndicatorsKeyId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Balance_tbl_Client_ClientId",
                table: "tbl_Balance",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BodyMap_tbl_Client_ClientId",
                table: "tbl_BodyMap",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CarePlanNutrition_tbl_Client_ClientId",
                table: "tbl_CarePlanNutrition",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_KeyIndicatorLog_tbl_KeyIndicators_KeyIndicatorsKeyId",
                table: "tbl_KeyIndicatorLog",
                column: "KeyIndicatorsKeyId",
                principalTable: "tbl_KeyIndicators",
                principalColumn: "KeyId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PersonalDetail_tbl_Personal_PersonalId",
                table: "tbl_PersonalDetail",
                column: "PersonalId",
                principalTable: "tbl_Personal",
                principalColumn: "PersonalId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PersonCentred_tbl_Client_ClientId",
                table: "tbl_PersonCentred",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PhysicalAbility_tbl_Client_ClientId",
                table: "tbl_PhysicalAbility",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Balance_tbl_Client_ClientId",
                table: "tbl_Balance");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_BodyMap_tbl_Client_ClientId",
                table: "tbl_BodyMap");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CarePlanNutrition_tbl_Client_ClientId",
                table: "tbl_CarePlanNutrition");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_KeyIndicatorLog_tbl_KeyIndicators_KeyIndicatorsKeyId",
                table: "tbl_KeyIndicatorLog");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PersonalDetail_tbl_Personal_PersonalId",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PersonCentred_tbl_Client_ClientId",
                table: "tbl_PersonCentred");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PhysicalAbility_tbl_Client_ClientId",
                table: "tbl_PhysicalAbility");

            migrationBuilder.DropIndex(
                name: "IX_tbl_PersonCentred_ClientId",
                table: "tbl_PersonCentred");

            migrationBuilder.DropIndex(
                name: "IX_tbl_PersonalDetail_PersonalId",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropIndex(
                name: "IX_tbl_KeyIndicatorLog_KeyIndicatorsKeyId",
                table: "tbl_KeyIndicatorLog");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "tbl_Review");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "tbl_PersonCentred");

            migrationBuilder.DropColumn(
                name: "Focus",
                table: "tbl_PersonCentred");

            migrationBuilder.DropColumn(
                name: "PersonalId",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "tbl_Personal");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "tbl_KeyIndicators");

            migrationBuilder.DropColumn(
                name: "LogMethod",
                table: "tbl_KeyIndicators");

            migrationBuilder.DropColumn(
                name: "KeyIndicatorsKeyId",
                table: "tbl_KeyIndicatorLog");

            migrationBuilder.DropColumn(
                name: "OtherStaffId",
                table: "tbl_ClientKeyworkerNotes");

            migrationBuilder.DropColumn(
                name: "ClinetId",
                table: "tbl_Capacity");

            migrationBuilder.DropColumn(
                name: "Indicators",
                table: "tbl_Capacity");

            migrationBuilder.RenameColumn(
                name: "Implication",
                table: "tbl_Capacity",
                newName: "PersonalDetailId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RA_ReviewDate",
                table: "tbl_Review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RA_PreDate",
                table: "tbl_Review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CP_ReviewDate",
                table: "tbl_Review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CP_PreDate",
                table: "tbl_Review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonalDetailId",
                table: "tbl_Review",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_PhysicalAbility",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tbl_PhysicalAbility",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Mobility",
                table: "tbl_PhysicalAbility",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "tbl_PhysicalAbility",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_PhysicalAbility",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_PhysicalAbility",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExpSupport",
                table: "tbl_PersonCentred",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonalDetailId",
                table: "tbl_PersonCentred",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Religion",
                table: "tbl_Personal",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nationality",
                table: "tbl_Personal",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonalDetailId",
                table: "tbl_Personal",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ThingsILike",
                table: "tbl_KeyIndicators",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FamilyRole",
                table: "tbl_KeyIndicators",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AboutMe",
                table: "tbl_KeyIndicators",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonalDetailId",
                table: "tbl_KeyIndicators",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "KeyworkerId",
                table: "tbl_ClientKeyworkerNotes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(38)",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_ClientKeyworkerNotes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_ClientKeyworkerNotes",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_ClientKeyworkerNotes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_ClientKeyworkerNotes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_ClientKeyworkerNotes",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_ClientKeyworkerNotes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_ClientKeyworkerNotes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_ClientKeyworkerNotes",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_ClientKeyworkerNotes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WhoRestock",
                table: "tbl_CarePlanNutrition",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WhenRestock",
                table: "tbl_CarePlanNutrition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ThingsILike",
                table: "tbl_CarePlanNutrition",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SpecialDiet",
                table: "tbl_CarePlanNutrition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ServingMeal",
                table: "tbl_CarePlanNutrition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RiskMitigations",
                table: "tbl_CarePlanNutrition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MealPreparation",
                table: "tbl_CarePlanNutrition",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FoodStorage",
                table: "tbl_CarePlanNutrition",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FoodIntake",
                table: "tbl_CarePlanNutrition",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EatingDifficulty",
                table: "tbl_CarePlanNutrition",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DrinkType",
                table: "tbl_CarePlanNutrition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_CarePlanNutrition",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AvoidFood",
                table: "tbl_CarePlanNutrition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_CarePlanNutrition",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_CarePlanNutrition",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_CarePlanNutrition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_CarePlanNutrition",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_CarePlanNutrition",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_CarePlanNutrition",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_CarePlanNutrition",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_CarePlanNutrition",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_CarePlanNutrition",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Implications",
                table: "tbl_Capacity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_BodyMap",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientId2",
                table: "tbl_BodyMap",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_Balance",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tbl_Balance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Mobility",
                table: "tbl_Balance",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "tbl_Balance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_Balance",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_Balance",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Review_PersonalDetailId",
                table: "tbl_Review",
                column: "PersonalDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PhysicalAbility_ClientId1",
                table: "tbl_PhysicalAbility",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PersonCentred_PersonalDetailId",
                table: "tbl_PersonCentred",
                column: "PersonalDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Personal_PersonalDetailId",
                table: "tbl_Personal",
                column: "PersonalDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_KeyIndicators_PersonalDetailId",
                table: "tbl_KeyIndicators",
                column: "PersonalDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_KeyIndicatorLog_KeyId",
                table: "tbl_KeyIndicatorLog",
                column: "KeyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientKeyworkerNotes_ClientId",
                table: "tbl_ClientKeyworkerNotes",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CarePlanNutrition_ClientId1",
                table: "tbl_CarePlanNutrition",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Capacity_PersonalDetailId",
                table: "tbl_Capacity",
                column: "PersonalDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BodyMap_ClientId1",
                table: "tbl_BodyMap",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Balance_ClientId1",
                table: "tbl_Balance",
                column: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Balance_tbl_Client_ClientId1",
                table: "tbl_Balance",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Balance_tbl_Company_ClientId",
                table: "tbl_Balance",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BodyMap_tbl_Client_ClientId1",
                table: "tbl_BodyMap",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BodyMap_tbl_Company_ClientId",
                table: "tbl_BodyMap",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Capacity_tbl_PersonalDetail_PersonalDetailId",
                table: "tbl_Capacity",
                column: "PersonalDetailId",
                principalTable: "tbl_PersonalDetail",
                principalColumn: "PersonalDetailId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CarePlanNutrition_tbl_Client_ClientId1",
                table: "tbl_CarePlanNutrition",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CarePlanNutrition_tbl_Company_ClientId",
                table: "tbl_CarePlanNutrition",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientKeyworkerNotes_tbl_Company_ClientId",
                table: "tbl_ClientKeyworkerNotes",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_KeyIndicatorLog_tbl_KeyIndicators_KeyId",
                table: "tbl_KeyIndicatorLog",
                column: "KeyId",
                principalTable: "tbl_KeyIndicators",
                principalColumn: "KeyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_KeyIndicators_tbl_PersonalDetail_PersonalDetailId",
                table: "tbl_KeyIndicators",
                column: "PersonalDetailId",
                principalTable: "tbl_PersonalDetail",
                principalColumn: "PersonalDetailId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Personal_tbl_PersonalDetail_PersonalDetailId",
                table: "tbl_Personal",
                column: "PersonalDetailId",
                principalTable: "tbl_PersonalDetail",
                principalColumn: "PersonalDetailId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PersonCentred_tbl_PersonalDetail_PersonalDetailId",
                table: "tbl_PersonCentred",
                column: "PersonalDetailId",
                principalTable: "tbl_PersonalDetail",
                principalColumn: "PersonalDetailId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PhysicalAbility_tbl_Client_ClientId1",
                table: "tbl_PhysicalAbility",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PhysicalAbility_tbl_Company_ClientId",
                table: "tbl_PhysicalAbility",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Review_tbl_PersonalDetail_PersonalDetailId",
                table: "tbl_Review",
                column: "PersonalDetailId",
                principalTable: "tbl_PersonalDetail",
                principalColumn: "PersonalDetailId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
