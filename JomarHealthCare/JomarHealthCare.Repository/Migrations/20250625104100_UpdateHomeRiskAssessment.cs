using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateHomeRiskAssessment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HomeRiskAssessment_tbl_Client_ClientId1",
                table: "tbl_HomeRiskAssessment");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HomeRiskAssessment_tbl_Company_ClientId",
                table: "tbl_HomeRiskAssessment");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HomeRiskAssessmentTask_tbl_Company_CompanyId",
                table: "tbl_HomeRiskAssessmentTask");

            migrationBuilder.DropIndex(
                name: "IX_tbl_HomeRiskAssessmentTask_CompanyId",
                table: "tbl_HomeRiskAssessmentTask");

            migrationBuilder.DropIndex(
                name: "IX_tbl_HomeRiskAssessment_ClientId1",
                table: "tbl_HomeRiskAssessment");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_HomeRiskAssessmentTask");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_HomeRiskAssessment");

            migrationBuilder.DropColumn(
                name: "Heading",
                table: "tbl_HomeRiskAssessment");

            migrationBuilder.AddColumn<int>(
                name: "HeadingId",
                table: "tbl_HomeRiskAssessment",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HomeRiskAssessment_tbl_Client_ClientId",
                table: "tbl_HomeRiskAssessment",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HomeRiskAssessment_tbl_Client_ClientId",
                table: "tbl_HomeRiskAssessment");

            migrationBuilder.DropColumn(
                name: "HeadingId",
                table: "tbl_HomeRiskAssessment");

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_HomeRiskAssessmentTask",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_HomeRiskAssessment",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Heading",
                table: "tbl_HomeRiskAssessment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HomeRiskAssessmentTask_CompanyId",
                table: "tbl_HomeRiskAssessmentTask",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HomeRiskAssessment_ClientId1",
                table: "tbl_HomeRiskAssessment",
                column: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HomeRiskAssessment_tbl_Client_ClientId1",
                table: "tbl_HomeRiskAssessment",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HomeRiskAssessment_tbl_Company_ClientId",
                table: "tbl_HomeRiskAssessment",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HomeRiskAssessmentTask_tbl_Company_CompanyId",
                table: "tbl_HomeRiskAssessmentTask",
                column: "CompanyId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");
        }
    }
}
