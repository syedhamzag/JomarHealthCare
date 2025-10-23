using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStaffRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_BestInterestAssessment_tbl_Client_ClientId1",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_BestInterestAssessment_tbl_Company_ClientId",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientBillTo_tbl_Company_ClientId",
                table: "tbl_ClientBillTo");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientCareDetails_tbl_Client_ClientId1",
                table: "tbl_ClientCareDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientCareDetails_tbl_Company_ClientId",
                table: "tbl_ClientCareDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientDailyTask_tbl_Client_ClientId",
                table: "tbl_ClientDailyTask");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientHealthCondition_tbl_Client_ClientId1",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientHealthCondition_tbl_Company_ClientId",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientHobbies_tbl_Client_ClientId1",
                table: "tbl_ClientHobbies");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientHobbies_tbl_Company_ClientId",
                table: "tbl_ClientHobbies");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientInvoiceRate_tbl_Company_ClientId",
                table: "tbl_ClientInvoiceRate");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientInvolvingParty_tbl_Client_ClientId1",
                table: "tbl_ClientInvolvingParty");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientInvolvingParty_tbl_Company_ClientId",
                table: "tbl_ClientInvolvingParty");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientRegulatoryContact_tbl_Client_ClientId1",
                table: "tbl_ClientRegulatoryContact");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientRegulatoryContact_tbl_Company_ClientId",
                table: "tbl_ClientRegulatoryContact");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientRota_tbl_Client_ClientId1",
                table: "tbl_ClientRota");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientRota_tbl_Company_ClientId",
                table: "tbl_ClientRota");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_DutyOnCall_tbl_Client_ClientId1",
                table: "tbl_DutyOnCall");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_DutyOnCall_tbl_Company_ClientId",
                table: "tbl_DutyOnCall");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_EquipmentAssessment_tbl_Client_ClientId1",
                table: "tbl_EquipmentAssessment");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_EquipmentAssessment_tbl_Company_ClientId",
                table: "tbl_EquipmentAssessment");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_InterestAndObjective_tbl_Client_ClientId1",
                table: "tbl_InterestAndObjective");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_InterestAndObjective_tbl_Company_ClientId",
                table: "tbl_InterestAndObjective");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_StaffBlackList_tbl_Company_ClientId",
                table: "tbl_StaffBlackList");

            migrationBuilder.DropIndex(
                name: "IX_tbl_StaffPersonalInfo_CategoryId",
                table: "tbl_StaffPersonalInfo");

            migrationBuilder.DropIndex(
                name: "IX_tbl_StaffPersonalInfo_JobPositionId",
                table: "tbl_StaffPersonalInfo");

            migrationBuilder.DropIndex(
                name: "IX_tbl_StaffBlackList_ClientId",
                table: "tbl_StaffBlackList");

            migrationBuilder.DropIndex(
                name: "IX_tbl_InterestAndObjective_ClientId1",
                table: "tbl_InterestAndObjective");

            migrationBuilder.DropIndex(
                name: "IX_tbl_EquipmentAssessment_ClientId1",
                table: "tbl_EquipmentAssessment");

            migrationBuilder.DropIndex(
                name: "IX_tbl_DutyOnCall_ClientId1",
                table: "tbl_DutyOnCall");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ClientRota_ClientId1",
                table: "tbl_ClientRota");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ClientRegulatoryContact_ClientId1",
                table: "tbl_ClientRegulatoryContact");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ClientInvolvingParty_ClientId1",
                table: "tbl_ClientInvolvingParty");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ClientHobbies_ClientId1",
                table: "tbl_ClientHobbies");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ClientHealthCondition_ClientId1",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ClientCareDetails_ClientId1",
                table: "tbl_ClientCareDetails");

            migrationBuilder.DropIndex(
                name: "IX_tbl_BestInterestAssessment_ClientId",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropIndex(
                name: "IX_tbl_BestInterestAssessment_ClientId1",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_InterestAndObjective");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_EquipmentAssessment");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_DutyOnCall");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_ClientRota");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_ClientRegulatoryContact");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_ClientInvolvingParty");

            migrationBuilder.DropColumn(
                name: "ClientInvolvingPartyItemId",
                table: "tbl_ClientInvolvingParty");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_ClientHobbies");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_ClientCareDetails");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_InterestAndObjective",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_EquipmentAssessment",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_DutyOnCall",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Telephone",
                table: "tbl_ClientInvolvingParty",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Relationship",
                table: "tbl_ClientInvolvingParty",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tbl_ClientInvolvingParty",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "tbl_ClientInvolvingParty",
                type: "nvarchar(125)",
                maxLength: 125,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(125)",
                oldMaxLength: 125);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_ClientInvolvingParty",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "tbl_ClientInvolvingParty",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225);

            migrationBuilder.AddColumn<string>(
                name: "ClientInvolvingPartyItem",
                table: "tbl_ClientInvolvingParty",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_ClientHobbies",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_ClientHealthCondition",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_ClientDailyTask",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_ClientCareDetails",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Signature",
                table: "tbl_BestInterestAssessment",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "tbl_BestInterestAssessment",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tbl_BestInterestAssessment",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_BestInterestAssessment",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffPersonalInfo_CategoryId",
                table: "tbl_StaffPersonalInfo",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffPersonalInfo_JobPositionId",
                table: "tbl_StaffPersonalInfo",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientHobbies_HId",
                table: "tbl_ClientHobbies",
                column: "HId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientHealthCondition_HCId",
                table: "tbl_ClientHealthCondition",
                column: "HCId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BestInterestAssessment_ClientId",
                table: "tbl_BestInterestAssessment",
                column: "ClientId",
                unique: true,
                filter: "[ClientId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BestInterestAssessment_tbl_Client_ClientId",
                table: "tbl_BestInterestAssessment",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientBillTo_tbl_Client_ClientId",
                table: "tbl_ClientBillTo",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientCareDetails_tbl_Client_ClientId",
                table: "tbl_ClientCareDetails",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientDailyTask_tbl_Client_ClientId",
                table: "tbl_ClientDailyTask",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientHealthCondition_tbl_Client_ClientId",
                table: "tbl_ClientHealthCondition",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientHealthCondition_tbl_HealthCondition_HCId",
                table: "tbl_ClientHealthCondition",
                column: "HCId",
                principalTable: "tbl_HealthCondition",
                principalColumn: "HCId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientHobbies_tbl_Client_ClientId",
                table: "tbl_ClientHobbies",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientHobbies_tbl_Hobbies_HId",
                table: "tbl_ClientHobbies",
                column: "HId",
                principalTable: "tbl_Hobbies",
                principalColumn: "HId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientInvoiceRate_tbl_Client_ClientId",
                table: "tbl_ClientInvoiceRate",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientInvolvingParty_tbl_Client_ClientId",
                table: "tbl_ClientInvolvingParty",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientRegulatoryContact_tbl_Client_ClientId",
                table: "tbl_ClientRegulatoryContact",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientRota_tbl_Client_ClientId",
                table: "tbl_ClientRota",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_DutyOnCall_tbl_Client_ClientId",
                table: "tbl_DutyOnCall",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_EquipmentAssessment_tbl_Client_ClientId",
                table: "tbl_EquipmentAssessment",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_InterestAndObjective_tbl_Client_ClientId",
                table: "tbl_InterestAndObjective",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_BestInterestAssessment_tbl_Client_ClientId",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientBillTo_tbl_Client_ClientId",
                table: "tbl_ClientBillTo");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientCareDetails_tbl_Client_ClientId",
                table: "tbl_ClientCareDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientDailyTask_tbl_Client_ClientId",
                table: "tbl_ClientDailyTask");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientHealthCondition_tbl_Client_ClientId",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientHealthCondition_tbl_HealthCondition_HCId",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientHobbies_tbl_Client_ClientId",
                table: "tbl_ClientHobbies");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientHobbies_tbl_Hobbies_HId",
                table: "tbl_ClientHobbies");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientInvoiceRate_tbl_Client_ClientId",
                table: "tbl_ClientInvoiceRate");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientInvolvingParty_tbl_Client_ClientId",
                table: "tbl_ClientInvolvingParty");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientRegulatoryContact_tbl_Client_ClientId",
                table: "tbl_ClientRegulatoryContact");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientRota_tbl_Client_ClientId",
                table: "tbl_ClientRota");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_DutyOnCall_tbl_Client_ClientId",
                table: "tbl_DutyOnCall");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_EquipmentAssessment_tbl_Client_ClientId",
                table: "tbl_EquipmentAssessment");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_InterestAndObjective_tbl_Client_ClientId",
                table: "tbl_InterestAndObjective");

            migrationBuilder.DropIndex(
                name: "IX_tbl_StaffPersonalInfo_CategoryId",
                table: "tbl_StaffPersonalInfo");

            migrationBuilder.DropIndex(
                name: "IX_tbl_StaffPersonalInfo_JobPositionId",
                table: "tbl_StaffPersonalInfo");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ClientHobbies_HId",
                table: "tbl_ClientHobbies");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ClientHealthCondition_HCId",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropIndex(
                name: "IX_tbl_BestInterestAssessment_ClientId",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "ClientInvolvingPartyItem",
                table: "tbl_ClientInvolvingParty");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_InterestAndObjective",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_InterestAndObjective",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_EquipmentAssessment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_EquipmentAssessment",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_DutyOnCall",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_DutyOnCall",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_ClientRota",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_ClientRegulatoryContact",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telephone",
                table: "tbl_ClientInvolvingParty",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Relationship",
                table: "tbl_ClientInvolvingParty",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tbl_ClientInvolvingParty",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "tbl_ClientInvolvingParty",
                type: "nvarchar(125)",
                maxLength: 125,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(125)",
                oldMaxLength: 125,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_ClientInvolvingParty",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "tbl_ClientInvolvingParty",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_ClientInvolvingParty",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientInvolvingPartyItemId",
                table: "tbl_ClientInvolvingParty",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_ClientHobbies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_ClientHobbies",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_ClientHealthCondition",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_ClientHealthCondition",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_ClientDailyTask",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_ClientCareDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_ClientCareDetails",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Signature",
                table: "tbl_BestInterestAssessment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "tbl_BestInterestAssessment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tbl_BestInterestAssessment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_BestInterestAssessment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_BestInterestAssessment",
                type: "uniqueidentifier",
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

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffBlackList_ClientId",
                table: "tbl_StaffBlackList",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_InterestAndObjective_ClientId1",
                table: "tbl_InterestAndObjective",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_EquipmentAssessment_ClientId1",
                table: "tbl_EquipmentAssessment",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DutyOnCall_ClientId1",
                table: "tbl_DutyOnCall",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientRota_ClientId1",
                table: "tbl_ClientRota",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientRegulatoryContact_ClientId1",
                table: "tbl_ClientRegulatoryContact",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientInvolvingParty_ClientId1",
                table: "tbl_ClientInvolvingParty",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientHobbies_ClientId1",
                table: "tbl_ClientHobbies",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientHealthCondition_ClientId1",
                table: "tbl_ClientHealthCondition",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientCareDetails_ClientId1",
                table: "tbl_ClientCareDetails",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BestInterestAssessment_ClientId",
                table: "tbl_BestInterestAssessment",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BestInterestAssessment_ClientId1",
                table: "tbl_BestInterestAssessment",
                column: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BestInterestAssessment_tbl_Client_ClientId1",
                table: "tbl_BestInterestAssessment",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BestInterestAssessment_tbl_Company_ClientId",
                table: "tbl_BestInterestAssessment",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientBillTo_tbl_Company_ClientId",
                table: "tbl_ClientBillTo",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientCareDetails_tbl_Client_ClientId1",
                table: "tbl_ClientCareDetails",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientCareDetails_tbl_Company_ClientId",
                table: "tbl_ClientCareDetails",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientDailyTask_tbl_Client_ClientId",
                table: "tbl_ClientDailyTask",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientHealthCondition_tbl_Client_ClientId1",
                table: "tbl_ClientHealthCondition",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientHealthCondition_tbl_Company_ClientId",
                table: "tbl_ClientHealthCondition",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientHobbies_tbl_Client_ClientId1",
                table: "tbl_ClientHobbies",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientHobbies_tbl_Company_ClientId",
                table: "tbl_ClientHobbies",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientInvoiceRate_tbl_Company_ClientId",
                table: "tbl_ClientInvoiceRate",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientInvolvingParty_tbl_Client_ClientId1",
                table: "tbl_ClientInvolvingParty",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientInvolvingParty_tbl_Company_ClientId",
                table: "tbl_ClientInvolvingParty",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientRegulatoryContact_tbl_Client_ClientId1",
                table: "tbl_ClientRegulatoryContact",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientRegulatoryContact_tbl_Company_ClientId",
                table: "tbl_ClientRegulatoryContact",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientRota_tbl_Client_ClientId1",
                table: "tbl_ClientRota",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientRota_tbl_Company_ClientId",
                table: "tbl_ClientRota",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_DutyOnCall_tbl_Client_ClientId1",
                table: "tbl_DutyOnCall",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_DutyOnCall_tbl_Company_ClientId",
                table: "tbl_DutyOnCall",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_EquipmentAssessment_tbl_Client_ClientId1",
                table: "tbl_EquipmentAssessment",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_EquipmentAssessment_tbl_Company_ClientId",
                table: "tbl_EquipmentAssessment",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_InterestAndObjective_tbl_Client_ClientId1",
                table: "tbl_InterestAndObjective",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_InterestAndObjective_tbl_Company_ClientId",
                table: "tbl_InterestAndObjective",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffBlackList_tbl_Company_ClientId",
                table: "tbl_StaffBlackList",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
