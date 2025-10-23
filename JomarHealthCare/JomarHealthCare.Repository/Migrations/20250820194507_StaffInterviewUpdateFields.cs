using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class StaffInterviewUpdateFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_StaffInterview_tbl_Company_CompanyId",
                table: "tbl_StaffInterview");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_StaffInterviewTask_tbl_Company_CompanyId",
                table: "tbl_StaffInterviewTask");

            migrationBuilder.DropIndex(
                name: "IX_tbl_StaffInterviewTask_CompanyId",
                table: "tbl_StaffInterviewTask");

            migrationBuilder.DropIndex(
                name: "IX_tbl_StaffInterview_CompanyId",
                table: "tbl_StaffInterview");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_StaffInterviewTask");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_StaffInterview");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "tbl_StaffInterview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InterviewDate",
                table: "tbl_StaffInterview",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "JobPosition",
                table: "tbl_StaffInterview",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ObtainMarks",
                table: "tbl_StaffInterview",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PassingMarks",
                table: "tbl_StaffInterview",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "tbl_StaffInterview",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "tbl_StaffInterview");

            migrationBuilder.DropColumn(
                name: "InterviewDate",
                table: "tbl_StaffInterview");

            migrationBuilder.DropColumn(
                name: "JobPosition",
                table: "tbl_StaffInterview");

            migrationBuilder.DropColumn(
                name: "ObtainMarks",
                table: "tbl_StaffInterview");

            migrationBuilder.DropColumn(
                name: "PassingMarks",
                table: "tbl_StaffInterview");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "tbl_StaffInterview");

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_StaffInterviewTask",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_StaffInterview",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffInterviewTask_CompanyId",
                table: "tbl_StaffInterviewTask",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffInterview_CompanyId",
                table: "tbl_StaffInterview",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffInterview_tbl_Company_CompanyId",
                table: "tbl_StaffInterview",
                column: "CompanyId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffInterviewTask_tbl_Company_CompanyId",
                table: "tbl_StaffInterviewTask",
                column: "CompanyId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");
        }
    }
}
