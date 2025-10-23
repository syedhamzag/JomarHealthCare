using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateComplainRegisterTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ComplainRegistorClients_tbl_Client_ClientId1",
                table: "tbl_ComplainRegistorClients");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ComplainRegistorClients_tbl_Company_ClientId",
                table: "tbl_ComplainRegistorClients");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ComplainRegistorClients_ClientId1",
                table: "tbl_ComplainRegistorClients");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_ComplainRegistorClients");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_ComplainRegistorClients");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_ComplainRegistorClients");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_ComplainRegistorClients");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_ComplainRegistorClients");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_ComplainRegistorClients");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_ComplainRegistorClients");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_ComplainRegistorClients");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_ComplainRegistorClients");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_ComplainRegistor");

            migrationBuilder.RenameColumn(
                name: "DateComplainCloseDate",
                table: "tbl_ComplainRegistor",
                newName: "ComplainCloseDate");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_ComplainRegistorClients",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfComplain",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReasonOfPending",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1052)",
                oldMaxLength: 1052,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RC_Prevented",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RC_CasuesWithIncident",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PersonMakingComplain",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1052)",
                oldMaxLength: 1052,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OfficerName",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(38)",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "M_Other",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ListOfConcern",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IoP_Attachment",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ido_StaffResponse",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ido_Attachment",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ev_Decision",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ev_Attachment",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContentOfOfficer",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ComplainDate",
                table: "tbl_ComplainRegistor",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Cls_Attachment",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cls_AnyInfo",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClosingStatment",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1052)",
                oldMaxLength: 1052,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Clc_Attachment",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Clc_AnyInfo",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ComplainCloseDate",
                table: "tbl_ComplainRegistor",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_ComplainRegistor",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_ComplainRegistor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ComplainRegistorClients_tbl_Client_ClientId",
                table: "tbl_ComplainRegistorClients",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ComplainRegistorClients_tbl_Client_ClientId",
                table: "tbl_ComplainRegistorClients");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_ComplainRegistor");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_ComplainRegistor");

            migrationBuilder.RenameColumn(
                name: "ComplainCloseDate",
                table: "tbl_ComplainRegistor",
                newName: "DateComplainCloseDate");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_ComplainRegistorClients",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_ComplainRegistorClients",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_ComplainRegistorClients",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_ComplainRegistorClients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_ComplainRegistorClients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_ComplainRegistorClients",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_ComplainRegistorClients",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_ComplainRegistorClients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_ComplainRegistorClients",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_ComplainRegistorClients",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfComplain",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReasonOfPending",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(1052)",
                maxLength: 1052,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RC_Prevented",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RC_CasuesWithIncident",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PersonMakingComplain",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(1052)",
                maxLength: 1052,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OfficerName",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(38)",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "M_Other",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ListOfConcern",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IoP_Attachment",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ido_StaffResponse",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ido_Attachment",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ev_Decision",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ev_Attachment",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContentOfOfficer",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ComplainDate",
                table: "tbl_ComplainRegistor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cls_Attachment",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cls_AnyInfo",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClosingStatment",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(1052)",
                maxLength: 1052,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Clc_Attachment",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Clc_AnyInfo",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateComplainCloseDate",
                table: "tbl_ComplainRegistor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_ComplainRegistor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ComplainRegistorClients_ClientId1",
                table: "tbl_ComplainRegistorClients",
                column: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ComplainRegistorClients_tbl_Client_ClientId1",
                table: "tbl_ComplainRegistorClients",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ComplainRegistorClients_tbl_Company_ClientId",
                table: "tbl_ComplainRegistorClients",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");
        }
    }
}
