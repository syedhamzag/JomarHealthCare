using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCareObjectiveAndOtherTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HospitalEntry_tbl_Client_ClientId1",
                table: "tbl_HospitalEntry");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HospitalEntry_tbl_Company_ClientId",
                table: "tbl_HospitalEntry");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Interest_tbl_InterestAndObjective_GoalId",
                table: "tbl_Interest");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Interest_GoalId",
                table: "tbl_Interest");

            migrationBuilder.DropIndex(
                name: "IX_tbl_HospitalEntry_ClientId1",
                table: "tbl_HospitalEntry");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_HospitalEntry");

            migrationBuilder.AlterColumn<string>(
                name: "CareGoal",
                table: "tbl_InterestAndObjective",
                type: "nvarchar(2056)",
                maxLength: 2056,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Brief",
                table: "tbl_InterestAndObjective",
                type: "nvarchar(2056)",
                maxLength: 2056,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommunityActivity",
                table: "tbl_InterestAndObjective",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventAwarness",
                table: "tbl_InterestAndObjective",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GoalAndObjective",
                table: "tbl_InterestAndObjective",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InformalActivity",
                table: "tbl_InterestAndObjective",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InterestId",
                table: "tbl_InterestAndObjective",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LeisureActivity",
                table: "tbl_InterestAndObjective",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaintainContact",
                table: "tbl_InterestAndObjective",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_HospitalEntry",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "StaffSignature",
                table: "tbl_HospitalEntry",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "tbl_HospitalEntry",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Reference",
                table: "tbl_HospitalEntry",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PurposeofAdmission",
                table: "tbl_HospitalEntry",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PossibleDateReturn",
                table: "tbl_HospitalEntry",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "MeansOfTransport",
                table: "tbl_HospitalEntry",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastDateofAdmission",
                table: "tbl_HospitalEntry",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "IsHomeCleaned",
                table: "tbl_HospitalEntry",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IsFamilyInformed",
                table: "tbl_HospitalEntry",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAndTime",
                table: "tbl_HospitalEntry",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "ConditionOfAdmission",
                table: "tbl_HospitalEntry",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_HospitalEntry",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Attachment",
                table: "tbl_HospitalEntry",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_InterestAndObjective_InterestId",
                table: "tbl_InterestAndObjective",
                column: "InterestId",
                unique: true,
                filter: "[InterestId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HospitalEntry_tbl_Client_ClientId",
                table: "tbl_HospitalEntry",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_InterestAndObjective_tbl_Interest_InterestId",
                table: "tbl_InterestAndObjective",
                column: "InterestId",
                principalTable: "tbl_Interest",
                principalColumn: "InterestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HospitalEntry_tbl_Client_ClientId",
                table: "tbl_HospitalEntry");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_InterestAndObjective_tbl_Interest_InterestId",
                table: "tbl_InterestAndObjective");

            migrationBuilder.DropIndex(
                name: "IX_tbl_InterestAndObjective_InterestId",
                table: "tbl_InterestAndObjective");

            migrationBuilder.DropColumn(
                name: "CommunityActivity",
                table: "tbl_InterestAndObjective");

            migrationBuilder.DropColumn(
                name: "EventAwarness",
                table: "tbl_InterestAndObjective");

            migrationBuilder.DropColumn(
                name: "GoalAndObjective",
                table: "tbl_InterestAndObjective");

            migrationBuilder.DropColumn(
                name: "InformalActivity",
                table: "tbl_InterestAndObjective");

            migrationBuilder.DropColumn(
                name: "InterestId",
                table: "tbl_InterestAndObjective");

            migrationBuilder.DropColumn(
                name: "LeisureActivity",
                table: "tbl_InterestAndObjective");

            migrationBuilder.DropColumn(
                name: "MaintainContact",
                table: "tbl_InterestAndObjective");

            migrationBuilder.AlterColumn<string>(
                name: "CareGoal",
                table: "tbl_InterestAndObjective",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2056)",
                oldMaxLength: 2056,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Brief",
                table: "tbl_InterestAndObjective",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2056)",
                oldMaxLength: 2056,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_HospitalEntry",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StaffSignature",
                table: "tbl_HospitalEntry",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "tbl_HospitalEntry",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Reference",
                table: "tbl_HospitalEntry",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PurposeofAdmission",
                table: "tbl_HospitalEntry",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PossibleDateReturn",
                table: "tbl_HospitalEntry",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MeansOfTransport",
                table: "tbl_HospitalEntry",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastDateofAdmission",
                table: "tbl_HospitalEntry",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IsHomeCleaned",
                table: "tbl_HospitalEntry",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IsFamilyInformed",
                table: "tbl_HospitalEntry",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAndTime",
                table: "tbl_HospitalEntry",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ConditionOfAdmission",
                table: "tbl_HospitalEntry",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_HospitalEntry",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Attachment",
                table: "tbl_HospitalEntry",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_HospitalEntry",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Interest_GoalId",
                table: "tbl_Interest",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HospitalEntry_ClientId1",
                table: "tbl_HospitalEntry",
                column: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HospitalEntry_tbl_Client_ClientId1",
                table: "tbl_HospitalEntry",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HospitalEntry_tbl_Company_ClientId",
                table: "tbl_HospitalEntry",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Interest_tbl_InterestAndObjective_GoalId",
                table: "tbl_Interest",
                column: "GoalId",
                principalTable: "tbl_InterestAndObjective",
                principalColumn: "GoalId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
