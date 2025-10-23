using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class TaskBoardAssignedBy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignedBy",
                table: "tbl_TaskBoard");

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_TaskBoard",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_TaskBoard");

            migrationBuilder.AddColumn<int>(
                name: "AssignedBy",
                table: "tbl_TaskBoard",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
