using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateJobPositionAndCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_CategoryOfStaff");

            migrationBuilder.RenameColumn(
                name: "JobCategory",
                table: "tbl_StaffPersonalInfo",
                newName: "CategoryId");

            migrationBuilder.AlterColumn<Guid>(
                name: "CompanyId",
                table: "tbl_JobPosition",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "tbl_CategoryOfStaff",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_CategoryOfStaff",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffPersonalInfo_CategoryId",
                table: "tbl_StaffPersonalInfo",
                column: "CategoryId",
                unique: true,
                filter: "[CategoryId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffPersonalInfo_JobPositionId",
                table: "tbl_StaffPersonalInfo",
                column: "JobPositionId",
                unique: true,
                filter: "[JobPositionId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffPersonalInfo_tbl_CategoryOfStaff_CategoryId",
                table: "tbl_StaffPersonalInfo",
                column: "CategoryId",
                principalTable: "tbl_CategoryOfStaff",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffPersonalInfo_tbl_JobPosition_JobPositionId",
                table: "tbl_StaffPersonalInfo",
                column: "JobPositionId",
                principalTable: "tbl_JobPosition",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_StaffPersonalInfo_tbl_CategoryOfStaff_CategoryId",
                table: "tbl_StaffPersonalInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_StaffPersonalInfo_tbl_JobPosition_JobPositionId",
                table: "tbl_StaffPersonalInfo");

            migrationBuilder.DropIndex(
                name: "IX_tbl_StaffPersonalInfo_CategoryId",
                table: "tbl_StaffPersonalInfo");

            migrationBuilder.DropIndex(
                name: "IX_tbl_StaffPersonalInfo_JobPositionId",
                table: "tbl_StaffPersonalInfo");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_CategoryOfStaff");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "tbl_StaffPersonalInfo",
                newName: "JobCategory");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyId",
                table: "tbl_JobPosition",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "tbl_CategoryOfStaff",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_CategoryOfStaff",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
