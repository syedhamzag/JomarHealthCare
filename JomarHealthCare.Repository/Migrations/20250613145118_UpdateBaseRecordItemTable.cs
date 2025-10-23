using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBaseRecordItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_BaseRecordItem_Model_tbl_Company_CompanyId",
                table: "tbl_BaseRecordItem_Model");

            migrationBuilder.DropIndex(
                name: "IX_tbl_BaseRecordItem_Model_CompanyId",
                table: "tbl_BaseRecordItem_Model");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_BaseRecordItem_Model");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_BaseRecordItem_Model");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_BaseRecordItem_Model");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_BaseRecordItem_Model");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_BaseRecordItem_Model");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_BaseRecordItem_Model");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_BaseRecordItem_Model");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_BaseRecordItem_Model",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_BaseRecordItem_Model",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_BaseRecordItem_Model",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_BaseRecordItem_Model",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_BaseRecordItem_Model",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_BaseRecordItem_Model",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_BaseRecordItem_Model",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BaseRecordItem_Model_CompanyId",
                table: "tbl_BaseRecordItem_Model",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BaseRecordItem_Model_tbl_Company_CompanyId",
                table: "tbl_BaseRecordItem_Model",
                column: "CompanyId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");
        }
    }
}
