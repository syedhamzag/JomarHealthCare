using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class RotaTaskTableUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_RotaDayofWeek_tbl_Company_CompanyId",
                table: "tbl_RotaDayofWeek");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_RotaTask_tbl_Company_CompanyId",
                table: "tbl_RotaTask");

            migrationBuilder.DropIndex(
                name: "IX_tbl_RotaTask_CompanyId",
                table: "tbl_RotaTask");

            migrationBuilder.DropIndex(
                name: "IX_tbl_RotaTask_GivenAcronym",
                table: "tbl_RotaTask");

            migrationBuilder.DropIndex(
                name: "IX_tbl_RotaTask_NotGivenAcronym",
                table: "tbl_RotaTask");

            migrationBuilder.DropIndex(
                name: "IX_tbl_RotaTask_TaskName",
                table: "tbl_RotaTask");

            migrationBuilder.DropIndex(
                name: "IX_tbl_RotaDayofWeek_CompanyId",
                table: "tbl_RotaDayofWeek");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ClientRotaType_RotaType",
                table: "tbl_ClientRotaType");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_RotaTask");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_RotaTask");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_RotaTask");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_RotaTask");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_RotaTask");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_RotaTask");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_RotaTask");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_RotaDayofWeek");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_RotaDayofWeek");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_RotaDayofWeek");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_RotaDayofWeek");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_RotaDayofWeek");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_RotaDayofWeek");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_RotaDayofWeek");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_RotaDayofWeek");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_ClientRotaType");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_ClientRotaType");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_ClientRotaType");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_ClientRotaType");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_ClientRotaType");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_ClientRotaType");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_ClientRotaType");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "tbl_ClientRotaType",
                newName: "CompanyId");

            migrationBuilder.AlterColumn<string>(
                name: "TaskName",
                table: "tbl_RotaTask",
                type: "nvarchar(125)",
                maxLength: 125,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(125)",
                oldMaxLength: 125);

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "tbl_RotaTask",
                type: "nvarchar(38)",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(125)",
                oldMaxLength: 125,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NotGivenAcronym",
                table: "tbl_RotaTask",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "GivenAcronym",
                table: "tbl_RotaTask",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "RotaType",
                table: "tbl_ClientRotaType",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "tbl_ClientRotaType",
                newName: "ClientId");

            migrationBuilder.AlterColumn<string>(
                name: "TaskName",
                table: "tbl_RotaTask",
                type: "nvarchar(125)",
                maxLength: 125,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(125)",
                oldMaxLength: 125,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "tbl_RotaTask",
                type: "nvarchar(125)",
                maxLength: 125,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(38)",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NotGivenAcronym",
                table: "tbl_RotaTask",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GivenAcronym",
                table: "tbl_RotaTask",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_RotaTask",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_RotaTask",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_RotaTask",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_RotaTask",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_RotaTask",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_RotaTask",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_RotaTask",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_RotaDayofWeek",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_RotaDayofWeek",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_RotaDayofWeek",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_RotaDayofWeek",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_RotaDayofWeek",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_RotaDayofWeek",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_RotaDayofWeek",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_RotaDayofWeek",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RotaType",
                table: "tbl_ClientRotaType",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_ClientRotaType",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_ClientRotaType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_ClientRotaType",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_ClientRotaType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_ClientRotaType",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_ClientRotaType",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_ClientRotaType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "tbl_RotaDayofWeek",
                keyColumn: "RotaDayofWeekId",
                keyValue: 1,
                columns: new[] { "CompanyId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsDeleted", "LastModifiedBy", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null });

            migrationBuilder.UpdateData(
                table: "tbl_RotaDayofWeek",
                keyColumn: "RotaDayofWeekId",
                keyValue: 2,
                columns: new[] { "CompanyId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsDeleted", "LastModifiedBy", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null });

            migrationBuilder.UpdateData(
                table: "tbl_RotaDayofWeek",
                keyColumn: "RotaDayofWeekId",
                keyValue: 3,
                columns: new[] { "CompanyId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsDeleted", "LastModifiedBy", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null });

            migrationBuilder.UpdateData(
                table: "tbl_RotaDayofWeek",
                keyColumn: "RotaDayofWeekId",
                keyValue: 4,
                columns: new[] { "CompanyId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsDeleted", "LastModifiedBy", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null });

            migrationBuilder.UpdateData(
                table: "tbl_RotaDayofWeek",
                keyColumn: "RotaDayofWeekId",
                keyValue: 5,
                columns: new[] { "CompanyId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsDeleted", "LastModifiedBy", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null });

            migrationBuilder.UpdateData(
                table: "tbl_RotaDayofWeek",
                keyColumn: "RotaDayofWeekId",
                keyValue: 6,
                columns: new[] { "CompanyId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsDeleted", "LastModifiedBy", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null });

            migrationBuilder.UpdateData(
                table: "tbl_RotaDayofWeek",
                keyColumn: "RotaDayofWeekId",
                keyValue: 7,
                columns: new[] { "CompanyId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsDeleted", "LastModifiedBy", "LastModifiedOn" },
                values: new object[] { null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_RotaTask_CompanyId",
                table: "tbl_RotaTask",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_RotaTask_GivenAcronym",
                table: "tbl_RotaTask",
                column: "GivenAcronym",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_RotaTask_NotGivenAcronym",
                table: "tbl_RotaTask",
                column: "NotGivenAcronym",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_RotaTask_TaskName",
                table: "tbl_RotaTask",
                column: "TaskName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_RotaDayofWeek_CompanyId",
                table: "tbl_RotaDayofWeek",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientRotaType_RotaType",
                table: "tbl_ClientRotaType",
                column: "RotaType",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_RotaDayofWeek_tbl_Company_CompanyId",
                table: "tbl_RotaDayofWeek",
                column: "CompanyId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_RotaTask_tbl_Company_CompanyId",
                table: "tbl_RotaTask",
                column: "CompanyId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");
        }
    }
}
