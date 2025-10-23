using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class updateRegistermodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_RegisterIncome");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_RegisterDeduction");

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_RegisterIncome",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_RegisterDeduction",
                type: "uniqueidentifier",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_RegisterIncome");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_RegisterDeduction");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_RegisterIncome",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_RegisterDeduction",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
