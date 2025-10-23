using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateHealthConditionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HealthCondition_tbl_Company_CompanyId",
                table: "tbl_HealthCondition");

            migrationBuilder.DropIndex(
                name: "IX_tbl_HealthCondition_CompanyId",
                table: "tbl_HealthCondition");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_HealthCondition");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_HealthCondition");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_HealthCondition");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_HealthCondition");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_HealthCondition");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_HealthCondition");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_HealthCondition");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_HealthCondition");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_HealthCondition",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_HealthCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_HealthCondition",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_HealthCondition",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_HealthCondition",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_HealthCondition",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_HealthCondition",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_HealthCondition",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HealthCondition_CompanyId",
                table: "tbl_HealthCondition",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HealthCondition_tbl_Company_CompanyId",
                table: "tbl_HealthCondition",
                column: "CompanyId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");
        }
    }
}
