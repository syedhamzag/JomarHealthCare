using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class updatethismodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Expenselog_tbl_Company_ClientId",
                table: "tbl_Expenselog");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Expenselog_ClientId",
                table: "tbl_Expenselog");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_PettyCashHeading");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_Expenselog");

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_PettyCashHeading",
                type: "uniqueidentifier",
                maxLength: 450,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_Expenselog",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_Expenselog",
                type: "uniqueidentifier",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_CompanyBank",
                type: "uniqueidentifier",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_CompanyBank",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_CompanyBank",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_CompanyBank",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_CompanyBank",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_CompanyBank",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_CompanyBank",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_CompanyBank",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Expenselog_CompanyId",
                table: "tbl_Expenselog",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CompanyBank_CompanyId",
                table: "tbl_CompanyBank",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CompanyBank_tbl_Company_CompanyId",
                table: "tbl_CompanyBank",
                column: "CompanyId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Expenselog_tbl_Company_CompanyId",
                table: "tbl_Expenselog",
                column: "CompanyId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CompanyBank_tbl_Company_CompanyId",
                table: "tbl_CompanyBank");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Expenselog_tbl_Company_CompanyId",
                table: "tbl_Expenselog");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Expenselog_CompanyId",
                table: "tbl_Expenselog");

            migrationBuilder.DropIndex(
                name: "IX_tbl_CompanyBank_CompanyId",
                table: "tbl_CompanyBank");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_PettyCashHeading");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_Expenselog");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_CompanyBank");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_CompanyBank");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_CompanyBank");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_CompanyBank");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_CompanyBank");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_CompanyBank");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_CompanyBank");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_CompanyBank");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_PettyCashHeading",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_Expenselog",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<int>(
                name: "ClientId1",
                table: "tbl_Expenselog",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Expenselog_ClientId",
                table: "tbl_Expenselog",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Expenselog_tbl_Company_ClientId",
                table: "tbl_Expenselog",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");
        }
    }
}
