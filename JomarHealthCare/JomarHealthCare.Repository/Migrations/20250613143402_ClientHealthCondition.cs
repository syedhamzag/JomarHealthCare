using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class ClientHealthCondition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClassOfStaff_tbl_User_CreatedBy",
                table: "tbl_ClassOfStaff");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientHealthCondition_tbl_HealthCondition_HCId",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ClientHealthCondition_HCId",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ClassOfStaff_CreatedBy",
                table: "tbl_ClassOfStaff");

            migrationBuilder.DropColumn(
                name: "HCId",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_ClassOfStaff");

            migrationBuilder.AddColumn<string>(
                name: "ActionRequiredToStaff",
                table: "tbl_ClientHealthCondition",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CausesAndTrigger",
                table: "tbl_ClientHealthCondition",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientManagingWithCondition",
                table: "tbl_ClientHealthCondition",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Condition",
                table: "tbl_ClientHealthCondition",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "tbl_ClientHealthCondition",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EscalationsApproach",
                table: "tbl_ClientHealthCondition",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "tbl_ClientHealthCondition",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "tbl_ClientHealthCondition",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RiskToClient",
                table: "tbl_ClientHealthCondition",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RiskToStaff",
                table: "tbl_ClientHealthCondition",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Symptoms",
                table: "tbl_ClientHealthCondition",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_ClassOfStaff",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionRequiredToStaff",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropColumn(
                name: "CausesAndTrigger",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropColumn(
                name: "ClientManagingWithCondition",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropColumn(
                name: "Condition",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropColumn(
                name: "EscalationsApproach",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropColumn(
                name: "RiskToClient",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropColumn(
                name: "RiskToStaff",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropColumn(
                name: "Symptoms",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_ClassOfStaff");

            migrationBuilder.AddColumn<int>(
                name: "HCId",
                table: "tbl_ClientHealthCondition",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_ClassOfStaff",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientHealthCondition_HCId",
                table: "tbl_ClientHealthCondition",
                column: "HCId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClassOfStaff_CreatedBy",
                table: "tbl_ClassOfStaff",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClassOfStaff_tbl_User_CreatedBy",
                table: "tbl_ClassOfStaff",
                column: "CreatedBy",
                principalTable: "tbl_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientHealthCondition_tbl_HealthCondition_HCId",
                table: "tbl_ClientHealthCondition",
                column: "HCId",
                principalTable: "tbl_HealthCondition",
                principalColumn: "HCId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
