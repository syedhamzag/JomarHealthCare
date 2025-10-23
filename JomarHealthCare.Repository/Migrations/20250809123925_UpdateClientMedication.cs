using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateClientMedication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientMedication_tbl_Client_ClientId1",
                table: "tbl_ClientMedication");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientMedication_tbl_Company_ClientId",
                table: "tbl_ClientMedication");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientMedication_tbl_MedicationManufacturer_MedicationManufacturerId",
                table: "tbl_ClientMedication");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientMedication_tbl_Medication_MedicationId",
                table: "tbl_ClientMedication");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientMedicationPeriod_tbl_ClientRotaType_ClientRotaTypeId",
                table: "tbl_ClientMedicationPeriod");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Medication_tbl_Company_CompanyId",
                table: "tbl_Medication");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_MedicationManufacturer_tbl_Company_CompanyId",
                table: "tbl_MedicationManufacturer");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_MedicationRoute_tbl_Company_CompanyId",
                table: "tbl_MedicationRoute");

            migrationBuilder.DropIndex(
                name: "IX_tbl_MedicationRoute_CompanyId",
                table: "tbl_MedicationRoute");

            migrationBuilder.DropIndex(
                name: "IX_tbl_MedicationManufacturer_CompanyId",
                table: "tbl_MedicationManufacturer");

            migrationBuilder.DropIndex(
                name: "IX_tbl_MedicationManufacturer_Manufacturer",
                table: "tbl_MedicationManufacturer");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Medication_CompanyId",
                table: "tbl_Medication");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ClientMedication_ClientId1",
                table: "tbl_ClientMedication");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_MedicationRoute");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "tbl_MedicationRoute");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_MedicationRoute");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_MedicationRoute");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_MedicationRoute");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_MedicationRoute");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_MedicationRoute");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_MedicationRoute");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_MedicationManufacturer");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_MedicationManufacturer");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_MedicationManufacturer");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_MedicationManufacturer");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_MedicationManufacturer");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_MedicationManufacturer");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_MedicationManufacturer");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_Medication");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_Medication");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_Medication");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_Medication");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_Medication");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_Medication");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_Medication");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_ClientMedication");

            migrationBuilder.AlterColumn<string>(
                name: "RouteName",
                table: "tbl_MedicationRoute",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Manufacturer",
                table: "tbl_MedicationManufacturer",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "tbl_Medication",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RotaId",
                table: "tbl_ClientMedicationPeriod",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClientRotaTypeId",
                table: "tbl_ClientMedicationPeriod",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClientMedicationDayId",
                table: "tbl_ClientMedicationPeriod",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "tbl_ClientMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TimeCritical",
                table: "tbl_ClientMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StopDate",
                table: "tbl_ClientMedication",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "tbl_ClientMedication",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "tbl_ClientMedication",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Route",
                table: "tbl_ClientMedication",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "tbl_ClientMedication",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "PRNGuideline",
                table: "tbl_ClientMedication",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MedicationManufacturerId",
                table: "tbl_ClientMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MedicationId",
                table: "tbl_ClientMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Means",
                table: "tbl_ClientMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Gap_Hour",
                table: "tbl_ClientMedication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Frequency",
                table: "tbl_ClientMedication",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryDate",
                table: "tbl_ClientMedication",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Dossage",
                table: "tbl_ClientMedication",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ClientMedImage",
                table: "tbl_ClientMedication",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_ClientMedication",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientMedication_tbl_Client_ClientId",
                table: "tbl_ClientMedication",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientMedication_tbl_MedicationManufacturer_MedicationManufacturerId",
                table: "tbl_ClientMedication",
                column: "MedicationManufacturerId",
                principalTable: "tbl_MedicationManufacturer",
                principalColumn: "MedicationManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientMedication_tbl_Medication_MedicationId",
                table: "tbl_ClientMedication",
                column: "MedicationId",
                principalTable: "tbl_Medication",
                principalColumn: "MedicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientMedicationPeriod_tbl_ClientRotaType_ClientRotaTypeId",
                table: "tbl_ClientMedicationPeriod",
                column: "ClientRotaTypeId",
                principalTable: "tbl_ClientRotaType",
                principalColumn: "ClientRotaTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientMedication_tbl_Client_ClientId",
                table: "tbl_ClientMedication");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientMedication_tbl_MedicationManufacturer_MedicationManufacturerId",
                table: "tbl_ClientMedication");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientMedication_tbl_Medication_MedicationId",
                table: "tbl_ClientMedication");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientMedicationPeriod_tbl_ClientRotaType_ClientRotaTypeId",
                table: "tbl_ClientMedicationPeriod");

            migrationBuilder.AlterColumn<string>(
                name: "RouteName",
                table: "tbl_MedicationRoute",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_MedicationRoute",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "tbl_MedicationRoute",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_MedicationRoute",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_MedicationRoute",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_MedicationRoute",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_MedicationRoute",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_MedicationRoute",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_MedicationRoute",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Manufacturer",
                table: "tbl_MedicationManufacturer",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_MedicationManufacturer",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_MedicationManufacturer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_MedicationManufacturer",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_MedicationManufacturer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_MedicationManufacturer",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_MedicationManufacturer",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_MedicationManufacturer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "tbl_Medication",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_Medication",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_Medication",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_Medication",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_Medication",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_Medication",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_Medication",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_Medication",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RotaId",
                table: "tbl_ClientMedicationPeriod",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientRotaTypeId",
                table: "tbl_ClientMedicationPeriod",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientMedicationDayId",
                table: "tbl_ClientMedicationPeriod",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "tbl_ClientMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TimeCritical",
                table: "tbl_ClientMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StopDate",
                table: "tbl_ClientMedication",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "tbl_ClientMedication",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StartDate",
                table: "tbl_ClientMedication",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Route",
                table: "tbl_ClientMedication",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "tbl_ClientMedication",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PRNGuideline",
                table: "tbl_ClientMedication",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MedicationManufacturerId",
                table: "tbl_ClientMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MedicationId",
                table: "tbl_ClientMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Means",
                table: "tbl_ClientMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Gap_Hour",
                table: "tbl_ClientMedication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Frequency",
                table: "tbl_ClientMedication",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExpiryDate",
                table: "tbl_ClientMedication",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Dossage",
                table: "tbl_ClientMedication",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientMedImage",
                table: "tbl_ClientMedication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_ClientMedication",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_ClientMedication",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MedicationRoute_CompanyId",
                table: "tbl_MedicationRoute",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MedicationManufacturer_CompanyId",
                table: "tbl_MedicationManufacturer",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MedicationManufacturer_Manufacturer",
                table: "tbl_MedicationManufacturer",
                column: "Manufacturer",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Medication_CompanyId",
                table: "tbl_Medication",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientMedication_ClientId1",
                table: "tbl_ClientMedication",
                column: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientMedication_tbl_Client_ClientId1",
                table: "tbl_ClientMedication",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientMedication_tbl_Company_ClientId",
                table: "tbl_ClientMedication",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientMedication_tbl_MedicationManufacturer_MedicationManufacturerId",
                table: "tbl_ClientMedication",
                column: "MedicationManufacturerId",
                principalTable: "tbl_MedicationManufacturer",
                principalColumn: "MedicationManufacturerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientMedication_tbl_Medication_MedicationId",
                table: "tbl_ClientMedication",
                column: "MedicationId",
                principalTable: "tbl_Medication",
                principalColumn: "MedicationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientMedicationPeriod_tbl_ClientRotaType_ClientRotaTypeId",
                table: "tbl_ClientMedicationPeriod",
                column: "ClientRotaTypeId",
                principalTable: "tbl_ClientRotaType",
                principalColumn: "ClientRotaTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Medication_tbl_Company_CompanyId",
                table: "tbl_Medication",
                column: "CompanyId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_MedicationManufacturer_tbl_Company_CompanyId",
                table: "tbl_MedicationManufacturer",
                column: "CompanyId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_MedicationRoute_tbl_Company_CompanyId",
                table: "tbl_MedicationRoute",
                column: "CompanyId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");
        }
    }
}
