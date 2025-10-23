using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class payrollsummary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Createdby",
                table: "tbl_PayrollSummary");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "tbl_PayrollSummary",
                type: "datetime2",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "tbl_PayrollSummary",
                type: "datetime2",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_PayrollSummary",
                type: "uniqueidentifier",
                maxLength: 450,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_PayrollSummary");

            migrationBuilder.AlterColumn<string>(
                name: "StartDate",
                table: "tbl_PayrollSummary",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EndDate",
                table: "tbl_PayrollSummary",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Createdby",
                table: "tbl_PayrollSummary",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);
        }
    }
}
