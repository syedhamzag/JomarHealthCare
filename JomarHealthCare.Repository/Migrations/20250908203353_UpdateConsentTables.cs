using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateConsentTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ConsentData_tbl_PersonalDetail_PersonalDetailId",
                table: "tbl_ConsentData");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_MentalHealthSupport_tbl_Company_ClientId",
                table: "tbl_MentalHealthSupport");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_OralCare_tbl_Company_ClientId",
                table: "tbl_OralCare");

            migrationBuilder.DropIndex(
                name: "IX_tbl_OralCare_ClientId",
                table: "tbl_OralCare");

            migrationBuilder.DropIndex(
                name: "IX_tbl_MentalHealthSupport_ClientId",
                table: "tbl_MentalHealthSupport");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ConsentLandLine_PersonalDetailId",
                table: "tbl_ConsentLandLine");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ConsentData_PersonalDetailId",
                table: "tbl_ConsentData");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ConsentCare_PersonalDetailId",
                table: "tbl_ConsentCare");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_OralCare");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_OralCare");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_OralCare");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_OralCare");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_OralCare");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_OralCare");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_OralCare");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_OralCare");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_MentalHealthSupport");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_MentalHealthSupport");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_MentalHealthSupport");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_MentalHealthSupport");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_MentalHealthSupport");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_MentalHealthSupport");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_MentalHealthSupport");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_MentalHealthSupport");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "tbl_ConsentData");

            migrationBuilder.DropColumn(
                name: "PersonalDetailId",
                table: "tbl_ConsentData");

            migrationBuilder.AlterColumn<string>(
                name: "UncomfortableDetail",
                table: "tbl_OralCare",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Summary",
                table: "tbl_OralCare",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OtherTypes",
                table: "tbl_OralCare",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OtherMouthCareItems",
                table: "tbl_OralCare",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ManyTimeClean",
                table: "tbl_OralCare",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LookIntoMouth",
                table: "tbl_OralCare",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DenturePotLocated",
                table: "tbl_OralCare",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DentureCleanAny",
                table: "tbl_OralCare",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AnyOralRelatedProblemDetail",
                table: "tbl_OralCare",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AnyBarriersFinding",
                table: "tbl_OralCare",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WiderWorkHealthCare",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TowardTheirGoals",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StrengthBases",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StaffPreference",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SomethingEnjoyed",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OftenNeedSupport",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MethodAndApproach",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Keyworker",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImportantCloseThem",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DoneInTheirLive",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DoesNotWorkAndLike",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Signature",
                table: "tbl_ConsentData",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "tbl_ConsentData",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "AdministratorProcess",
                table: "tbl_ConsentData",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CareDate",
                table: "tbl_ConsentData",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CareName",
                table: "tbl_ConsentData",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CareSignature",
                table: "tbl_ConsentData",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "tbl_ConsentData",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DataName",
                table: "tbl_ConsentData",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FamilyResponsibity",
                table: "tbl_ConsentData",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnMedication",
                table: "tbl_ConsentData",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ConsentLandLine_PersonalDetailId",
                table: "tbl_ConsentLandLine",
                column: "PersonalDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ConsentCare_PersonalDetailId",
                table: "tbl_ConsentCare",
                column: "PersonalDetailId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tbl_ConsentLandLine_PersonalDetailId",
                table: "tbl_ConsentLandLine");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ConsentCare_PersonalDetailId",
                table: "tbl_ConsentCare");

            migrationBuilder.DropColumn(
                name: "AdministratorProcess",
                table: "tbl_ConsentData");

            migrationBuilder.DropColumn(
                name: "CareDate",
                table: "tbl_ConsentData");

            migrationBuilder.DropColumn(
                name: "CareName",
                table: "tbl_ConsentData");

            migrationBuilder.DropColumn(
                name: "CareSignature",
                table: "tbl_ConsentData");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "tbl_ConsentData");

            migrationBuilder.DropColumn(
                name: "DataName",
                table: "tbl_ConsentData");

            migrationBuilder.DropColumn(
                name: "FamilyResponsibity",
                table: "tbl_ConsentData");

            migrationBuilder.DropColumn(
                name: "OwnMedication",
                table: "tbl_ConsentData");

            migrationBuilder.AlterColumn<string>(
                name: "UncomfortableDetail",
                table: "tbl_OralCare",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Summary",
                table: "tbl_OralCare",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OtherTypes",
                table: "tbl_OralCare",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OtherMouthCareItems",
                table: "tbl_OralCare",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ManyTimeClean",
                table: "tbl_OralCare",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LookIntoMouth",
                table: "tbl_OralCare",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DenturePotLocated",
                table: "tbl_OralCare",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DentureCleanAny",
                table: "tbl_OralCare",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AnyOralRelatedProblemDetail",
                table: "tbl_OralCare",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AnyBarriersFinding",
                table: "tbl_OralCare",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_OralCare",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_OralCare",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_OralCare",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_OralCare",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_OralCare",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_OralCare",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_OralCare",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_OralCare",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WiderWorkHealthCare",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TowardTheirGoals",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StrengthBases",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StaffPreference",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SomethingEnjoyed",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OftenNeedSupport",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MethodAndApproach",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Keyworker",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImportantCloseThem",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DoneInTheirLive",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DoesNotWorkAndLike",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_MentalHealthSupport",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_MentalHealthSupport",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_MentalHealthSupport",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_MentalHealthSupport",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_MentalHealthSupport",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_MentalHealthSupport",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Signature",
                table: "tbl_ConsentData",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "tbl_ConsentData",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Name",
                table: "tbl_ConsentData",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonalDetailId",
                table: "tbl_ConsentData",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_OralCare_ClientId",
                table: "tbl_OralCare",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MentalHealthSupport_ClientId",
                table: "tbl_MentalHealthSupport",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ConsentLandLine_PersonalDetailId",
                table: "tbl_ConsentLandLine",
                column: "PersonalDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ConsentData_PersonalDetailId",
                table: "tbl_ConsentData",
                column: "PersonalDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ConsentCare_PersonalDetailId",
                table: "tbl_ConsentCare",
                column: "PersonalDetailId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ConsentData_tbl_PersonalDetail_PersonalDetailId",
                table: "tbl_ConsentData",
                column: "PersonalDetailId",
                principalTable: "tbl_PersonalDetail",
                principalColumn: "PersonalDetailId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_MentalHealthSupport_tbl_Company_ClientId",
                table: "tbl_MentalHealthSupport",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_OralCare_tbl_Company_ClientId",
                table: "tbl_OralCare",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");
        }
    }
}
