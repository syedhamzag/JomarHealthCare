using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class ClientCarePlanAndProfileTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_BelieveTask_tbl_BestInterestAssessment_BestId",
                table: "tbl_BelieveTask");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_BestInterestAssessment_tbl_Client_ClientId",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CareIssuesTask_tbl_BestInterestAssessment_BestId",
                table: "tbl_CareIssuesTask");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_MgtVisit_tbl_Client_ClientId1",
                table: "tbl_Client_MgtVisit");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_MgtVisit_tbl_Company_ClientId",
                table: "tbl_Client_MgtVisit");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Program_tbl_Client_ClientId1",
                table: "tbl_Client_Program");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Program_tbl_Company_ClientId",
                table: "tbl_Client_Program");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_ServiceWatch_tbl_Client_ClientId1",
                table: "tbl_Client_ServiceWatch");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_ServiceWatch_tbl_Company_ClientId",
                table: "tbl_Client_ServiceWatch");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Voice_tbl_Client_ClientId1",
                table: "tbl_Client_Voice");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Voice_tbl_Company_ClientId",
                table: "tbl_Client_Voice");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientInvoice_tbl_Company_ClientId",
                table: "tbl_ClientInvoice");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HealthTask_tbl_BestInterestAssessment_BestId",
                table: "tbl_HealthTask");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HealthTask2_tbl_BestInterestAssessment_BestId",
                table: "tbl_HealthTask2");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_InfectionControl_tbl_Client_ClientId1",
                table: "tbl_InfectionControl");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_InfectionControl_tbl_Company_ClientId",
                table: "tbl_InfectionControl");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ManagingTasks_tbl_Client_ClientId1",
                table: "tbl_ManagingTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ManagingTasks_tbl_Company_ClientId",
                table: "tbl_ManagingTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Pets_tbl_Client_ClientId1",
                table: "tbl_Pets");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Pets_tbl_Company_ClientId",
                table: "tbl_Pets");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Pets_ClientId1",
                table: "tbl_Pets");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ManagingTasks_ClientId1",
                table: "tbl_ManagingTasks");

            migrationBuilder.DropIndex(
                name: "IX_tbl_InfectionControl_ClientId1",
                table: "tbl_InfectionControl");

            migrationBuilder.DropIndex(
                name: "IX_tbl_HealthTask2_BestId",
                table: "tbl_HealthTask2");

            migrationBuilder.DropIndex(
                name: "IX_tbl_HealthTask_BestId",
                table: "tbl_HealthTask");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ClientInvoice_ClientId",
                table: "tbl_ClientInvoice");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Client_Voice_ClientId1",
                table: "tbl_Client_Voice");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Client_ServiceWatch_ClientId1",
                table: "tbl_Client_ServiceWatch");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Client_Program_ClientId1",
                table: "tbl_Client_Program");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Client_MgtVisit_ClientId1",
                table: "tbl_Client_MgtVisit");

            migrationBuilder.DropIndex(
                name: "IX_tbl_CareIssuesTask_BestId",
                table: "tbl_CareIssuesTask");

            migrationBuilder.DropIndex(
                name: "IX_tbl_BelieveTask_BestId",
                table: "tbl_BelieveTask");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_Pets");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_Pets");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_Pets");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_Pets");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_Pets");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_Pets");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_Pets");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_Pets");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_Pets");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_ManagingTasks");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_ManagingTasks");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_ManagingTasks");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_ManagingTasks");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_ManagingTasks");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_ManagingTasks");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_ManagingTasks");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_ManagingTasks");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_ManagingTasks");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_InfectionControl");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_InfectionControl");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_InfectionControl");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_InfectionControl");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_InfectionControl");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_InfectionControl");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_InfectionControl");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_InfectionControl");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_InfectionControl");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_ClientInvoice");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_ClientInvoice");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_ClientInvoice");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_ClientInvoice");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_ClientInvoice");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tbl_ClientInvoice");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_ClientInvoice");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_ClientInvoice");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_Client_Voice");

            migrationBuilder.DropColumn(
                name: "ClientSignature",
                table: "tbl_Client_Voice");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_Client_Voice");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_Client_Voice");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_Client_Voice");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_Client_Voice");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_Client_Voice");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_Client_Voice");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_Client_Voice");

            migrationBuilder.DropColumn(
                name: "ManagerSignature",
                table: "tbl_Client_Voice");

            migrationBuilder.DropColumn(
                name: "StaffSignature",
                table: "tbl_Client_Voice");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_Client_ServiceWatch");

            migrationBuilder.DropColumn(
                name: "ClientSignature",
                table: "tbl_Client_ServiceWatch");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_Client_ServiceWatch");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_Client_ServiceWatch");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_Client_ServiceWatch");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_Client_ServiceWatch");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_Client_ServiceWatch");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_Client_ServiceWatch");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_Client_ServiceWatch");

            migrationBuilder.DropColumn(
                name: "ManagerSignature",
                table: "tbl_Client_ServiceWatch");

            migrationBuilder.DropColumn(
                name: "StaffSignature",
                table: "tbl_Client_ServiceWatch");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_Client_Program");

            migrationBuilder.DropColumn(
                name: "ClientSignature",
                table: "tbl_Client_Program");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_Client_Program");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_Client_Program");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_Client_Program");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_Client_Program");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_Client_Program");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_Client_Program");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_Client_Program");

            migrationBuilder.DropColumn(
                name: "ManagerSignature",
                table: "tbl_Client_Program");

            migrationBuilder.DropColumn(
                name: "StaffSignature",
                table: "tbl_Client_Program");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_Client_MgtVisit");

            migrationBuilder.DropColumn(
                name: "ClientSignature",
                table: "tbl_Client_MgtVisit");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_Client_MgtVisit");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_Client_MgtVisit");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "tbl_Client_MgtVisit");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_Client_MgtVisit");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_Client_MgtVisit");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_Client_MgtVisit");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_Client_MgtVisit");

            migrationBuilder.DropColumn(
                name: "ManagerSignature",
                table: "tbl_Client_MgtVisit");

            migrationBuilder.DropColumn(
                name: "StaffSignature",
                table: "tbl_Client_MgtVisit");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.RenameColumn(
                name: "ManagingTasksId",
                table: "tbl_ManagingTasks",
                newName: "TaskId");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "tbl_BestInterestAssessment",
                newName: "IsStoma");

            migrationBuilder.RenameColumn(
                name: "Deleted",
                table: "tbl_BestInterestAssessment",
                newName: "IsRequired");

            migrationBuilder.AlterColumn<int>(
                name: "VetVisit",
                table: "tbl_Pets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "tbl_Pets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PetInsurance",
                table: "tbl_Pets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PetCare",
                table: "tbl_Pets",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PetActivities",
                table: "tbl_Pets",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tbl_Pets",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MealStorage",
                table: "tbl_Pets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "MealPattern",
                table: "tbl_Pets",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "tbl_Pets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_Pets",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "tbl_Pets",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Task",
                table: "tbl_ManagingTasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_ManagingTasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Help",
                table: "tbl_ManagingTasks",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_ManagingTasks",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "VaccStatus",
                table: "tbl_InfectionControl",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "tbl_InfectionControl",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TestDate",
                table: "tbl_InfectionControl",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_InfectionControl",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "tbl_InfectionControl",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Guideline",
                table: "tbl_InfectionControl",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_InfectionControl",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<int>(
                name: "BestInterestAssessmentBestId",
                table: "tbl_HealthTask2",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BestInterestAssessmentBestId",
                table: "tbl_HealthTask",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "tbl_Client_Voice",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_Client_Voice",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SomethingSpecial",
                table: "tbl_Client_Voice",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RotCause",
                table: "tbl_Client_Voice",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "tbl_Client_Voice",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Reference",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "RateStaffAttending",
                table: "tbl_Client_Voice",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RateServiceRecieving",
                table: "tbl_Client_Voice",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OfficeStaffSupport",
                table: "tbl_Client_Voice",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LessonLearntAndShared",
                table: "tbl_Client_Voice",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "InterestedInPrograms",
                table: "tbl_Client_Voice",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "HealthGoalShortTerm",
                table: "tbl_Client_Voice",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "HealthGoalLongTerm",
                table: "tbl_Client_Voice",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EvidenceOfActionTaken",
                table: "tbl_Client_Voice",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Deadline",
                table: "tbl_Client_Voice",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "tbl_Client_Voice",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_Client_Voice",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Attachment",
                table: "tbl_Client_Voice",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AreasOfImprovements",
                table: "tbl_Client_Voice",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ActionsTakenByMPCC",
                table: "tbl_Client_Voice",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ActionRequired",
                table: "tbl_Client_Voice",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "tbl_Client_ServiceWatch",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_Client_ServiceWatch",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "tbl_Client_ServiceWatch",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Reference",
                table: "tbl_Client_ServiceWatch",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Observation",
                table: "tbl_Client_ServiceWatch",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NextCheckDate",
                table: "tbl_Client_ServiceWatch",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Incident",
                table: "tbl_Client_ServiceWatch",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Details",
                table: "tbl_Client_ServiceWatch",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Deadline",
                table: "tbl_Client_ServiceWatch",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "tbl_Client_ServiceWatch",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Contact",
                table: "tbl_Client_ServiceWatch",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_Client_ServiceWatch",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Attachment",
                table: "tbl_Client_ServiceWatch",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActionRequired",
                table: "tbl_Client_ServiceWatch",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "tbl_Client_Program",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_Client_Program",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "tbl_Client_Program",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ProgramOfChoice",
                table: "tbl_Client_Program",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PlaceLocationProgram",
                table: "tbl_Client_Program",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Observation",
                table: "tbl_Client_Program",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NextCheckDate",
                table: "tbl_Client_Program",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "DetailsOfProgram",
                table: "tbl_Client_Program",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Deadline",
                table: "tbl_Client_Program",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "DaysOfChoice",
                table: "tbl_Client_Program",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "tbl_Client_Program",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_Client_Program",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Attachment",
                table: "tbl_Client_Program",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActionRequired",
                table: "tbl_Client_Program",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_Client_MgtVisit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ServiceRecommended",
                table: "tbl_Client_MgtVisit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "RotCause",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Reference",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "RateServiceRecieving",
                table: "tbl_Client_MgtVisit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RateManagers",
                table: "tbl_Client_MgtVisit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Observation",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NextCheckDate",
                table: "tbl_Client_MgtVisit",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "LessonLearntAndShared",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImprovementExpect",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "HowToComplain",
                table: "tbl_Client_MgtVisit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "EvidenceOfActionTaken",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Deadline",
                table: "tbl_Client_MgtVisit",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "tbl_Client_MgtVisit",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_Client_MgtVisit",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Attachment",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActionsTakenByMPCC",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ActionRequired",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(2024)",
                maxLength: 2024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "BestInterestAssessmentBestId",
                table: "tbl_CareIssuesTask",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "tbl_BestInterestAssessment",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "BenefitOfTreatment",
                table: "tbl_BestInterestAssessment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BenefitOfTreatmentRemarks",
                table: "tbl_BestInterestAssessment",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmotionalAspect",
                table: "tbl_BestInterestAssessment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmotionalAspectRemarks",
                table: "tbl_BestInterestAssessment",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EthicalAspect",
                table: "tbl_BestInterestAssessment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EthicalAspectRemarks",
                table: "tbl_BestInterestAssessment",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinance",
                table: "tbl_BestInterestAssessment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsHygiene",
                table: "tbl_BestInterestAssessment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsMedication",
                table: "tbl_BestInterestAssessment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsNutrition",
                table: "tbl_BestInterestAssessment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PowerofAttorney",
                table: "tbl_BestInterestAssessment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PowerofAttorneyRemarks",
                table: "tbl_BestInterestAssessment",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RefuseTreatment",
                table: "tbl_BestInterestAssessment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefuseTreatmentRemarks",
                table: "tbl_BestInterestAssessment",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Statutory",
                table: "tbl_BestInterestAssessment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StatutoryRemarks",
                table: "tbl_BestInterestAssessment",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Summary",
                table: "tbl_BestInterestAssessment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SummaryRemarks",
                table: "tbl_BestInterestAssessment",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WelfareAspect",
                table: "tbl_BestInterestAssessment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WelfareAspectRemarks",
                table: "tbl_BestInterestAssessment",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BestInterestAssessmentBestId",
                table: "tbl_BelieveTask",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HealthTask2_BestInterestAssessmentBestId",
                table: "tbl_HealthTask2",
                column: "BestInterestAssessmentBestId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HealthTask_BestInterestAssessmentBestId",
                table: "tbl_HealthTask",
                column: "BestInterestAssessmentBestId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CareIssuesTask_BestInterestAssessmentBestId",
                table: "tbl_CareIssuesTask",
                column: "BestInterestAssessmentBestId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BelieveTask_BestInterestAssessmentBestId",
                table: "tbl_BelieveTask",
                column: "BestInterestAssessmentBestId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BelieveTask_tbl_BestInterestAssessment_BestInterestAssessmentBestId",
                table: "tbl_BelieveTask",
                column: "BestInterestAssessmentBestId",
                principalTable: "tbl_BestInterestAssessment",
                principalColumn: "BestId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BestInterestAssessment_tbl_Client_ClientId",
                table: "tbl_BestInterestAssessment",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CareIssuesTask_tbl_BestInterestAssessment_BestInterestAssessmentBestId",
                table: "tbl_CareIssuesTask",
                column: "BestInterestAssessmentBestId",
                principalTable: "tbl_BestInterestAssessment",
                principalColumn: "BestId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_MgtVisit_tbl_Client_ClientId",
                table: "tbl_Client_MgtVisit",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Program_tbl_Client_ClientId",
                table: "tbl_Client_Program",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_ServiceWatch_tbl_Client_ClientId",
                table: "tbl_Client_ServiceWatch",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Voice_tbl_Client_ClientId",
                table: "tbl_Client_Voice",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HealthTask_tbl_BestInterestAssessment_BestInterestAssessmentBestId",
                table: "tbl_HealthTask",
                column: "BestInterestAssessmentBestId",
                principalTable: "tbl_BestInterestAssessment",
                principalColumn: "BestId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HealthTask2_tbl_BestInterestAssessment_BestInterestAssessmentBestId",
                table: "tbl_HealthTask2",
                column: "BestInterestAssessmentBestId",
                principalTable: "tbl_BestInterestAssessment",
                principalColumn: "BestId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_InfectionControl_tbl_Client_ClientId",
                table: "tbl_InfectionControl",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ManagingTasks_tbl_Client_ClientId",
                table: "tbl_ManagingTasks",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Pets_tbl_Client_ClientId",
                table: "tbl_Pets",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_BelieveTask_tbl_BestInterestAssessment_BestInterestAssessmentBestId",
                table: "tbl_BelieveTask");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_BestInterestAssessment_tbl_Client_ClientId",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CareIssuesTask_tbl_BestInterestAssessment_BestInterestAssessmentBestId",
                table: "tbl_CareIssuesTask");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_MgtVisit_tbl_Client_ClientId",
                table: "tbl_Client_MgtVisit");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Program_tbl_Client_ClientId",
                table: "tbl_Client_Program");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_ServiceWatch_tbl_Client_ClientId",
                table: "tbl_Client_ServiceWatch");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Voice_tbl_Client_ClientId",
                table: "tbl_Client_Voice");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HealthTask_tbl_BestInterestAssessment_BestInterestAssessmentBestId",
                table: "tbl_HealthTask");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HealthTask2_tbl_BestInterestAssessment_BestInterestAssessmentBestId",
                table: "tbl_HealthTask2");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_InfectionControl_tbl_Client_ClientId",
                table: "tbl_InfectionControl");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ManagingTasks_tbl_Client_ClientId",
                table: "tbl_ManagingTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Pets_tbl_Client_ClientId",
                table: "tbl_Pets");

            migrationBuilder.DropIndex(
                name: "IX_tbl_HealthTask2_BestInterestAssessmentBestId",
                table: "tbl_HealthTask2");

            migrationBuilder.DropIndex(
                name: "IX_tbl_HealthTask_BestInterestAssessmentBestId",
                table: "tbl_HealthTask");

            migrationBuilder.DropIndex(
                name: "IX_tbl_CareIssuesTask_BestInterestAssessmentBestId",
                table: "tbl_CareIssuesTask");

            migrationBuilder.DropIndex(
                name: "IX_tbl_BelieveTask_BestInterestAssessmentBestId",
                table: "tbl_BelieveTask");

            migrationBuilder.DropColumn(
                name: "BestInterestAssessmentBestId",
                table: "tbl_HealthTask2");

            migrationBuilder.DropColumn(
                name: "BestInterestAssessmentBestId",
                table: "tbl_HealthTask");

            migrationBuilder.DropColumn(
                name: "BestInterestAssessmentBestId",
                table: "tbl_CareIssuesTask");

            migrationBuilder.DropColumn(
                name: "BenefitOfTreatment",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "BenefitOfTreatmentRemarks",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "EmotionalAspect",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "EmotionalAspectRemarks",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "EthicalAspect",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "EthicalAspectRemarks",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "IsFinance",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "IsHygiene",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "IsMedication",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "IsNutrition",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "PowerofAttorney",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "PowerofAttorneyRemarks",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "RefuseTreatment",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "RefuseTreatmentRemarks",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "Statutory",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "StatutoryRemarks",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "Summary",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "SummaryRemarks",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "WelfareAspect",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "WelfareAspectRemarks",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropColumn(
                name: "BestInterestAssessmentBestId",
                table: "tbl_BelieveTask");

            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "tbl_ManagingTasks",
                newName: "ManagingTasksId");

            migrationBuilder.RenameColumn(
                name: "IsStoma",
                table: "tbl_BestInterestAssessment",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "IsRequired",
                table: "tbl_BestInterestAssessment",
                newName: "Deleted");

            migrationBuilder.AlterColumn<int>(
                name: "VetVisit",
                table: "tbl_Pets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "tbl_Pets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PetInsurance",
                table: "tbl_Pets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PetCare",
                table: "tbl_Pets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PetActivities",
                table: "tbl_Pets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tbl_Pets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MealStorage",
                table: "tbl_Pets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MealPattern",
                table: "tbl_Pets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "tbl_Pets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_Pets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "tbl_Pets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_Pets",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_Pets",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_Pets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_Pets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_Pets",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_Pets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_Pets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_Pets",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_Pets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Task",
                table: "tbl_ManagingTasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_ManagingTasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Help",
                table: "tbl_ManagingTasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_ManagingTasks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_ManagingTasks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_ManagingTasks",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_ManagingTasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_ManagingTasks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_ManagingTasks",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_ManagingTasks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_ManagingTasks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_ManagingTasks",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_ManagingTasks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VaccStatus",
                table: "tbl_InfectionControl",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "tbl_InfectionControl",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "TestDate",
                table: "tbl_InfectionControl",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_InfectionControl",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "tbl_InfectionControl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Guideline",
                table: "tbl_InfectionControl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_InfectionControl",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_InfectionControl",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_InfectionControl",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_InfectionControl",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_InfectionControl",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_InfectionControl",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_InfectionControl",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_InfectionControl",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_InfectionControl",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_InfectionControl",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_ClientInvoice",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_ClientInvoice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_ClientInvoice",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_ClientInvoice",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_ClientInvoice",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tbl_ClientInvoice",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_ClientInvoice",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_ClientInvoice",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_Client_Voice",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SomethingSpecial",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RotCause",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Reference",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RateStaffAttending",
                table: "tbl_Client_Voice",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RateServiceRecieving",
                table: "tbl_Client_Voice",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OfficeStaffSupport",
                table: "tbl_Client_Voice",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LessonLearntAndShared",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InterestedInPrograms",
                table: "tbl_Client_Voice",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HealthGoalShortTerm",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HealthGoalLongTerm",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EvidenceOfActionTaken",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Deadline",
                table: "tbl_Client_Voice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "tbl_Client_Voice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_Client_Voice",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Attachment",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AreasOfImprovements",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActionsTakenByMPCC",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActionRequired",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_Client_Voice",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientSignature",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_Client_Voice",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_Client_Voice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_Client_Voice",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_Client_Voice",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_Client_Voice",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_Client_Voice",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_Client_Voice",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManagerSignature",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaffSignature",
                table: "tbl_Client_Voice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "tbl_Client_ServiceWatch",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_Client_ServiceWatch",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "tbl_Client_ServiceWatch",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Reference",
                table: "tbl_Client_ServiceWatch",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Observation",
                table: "tbl_Client_ServiceWatch",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NextCheckDate",
                table: "tbl_Client_ServiceWatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Incident",
                table: "tbl_Client_ServiceWatch",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Details",
                table: "tbl_Client_ServiceWatch",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Deadline",
                table: "tbl_Client_ServiceWatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "tbl_Client_ServiceWatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Contact",
                table: "tbl_Client_ServiceWatch",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_Client_ServiceWatch",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Attachment",
                table: "tbl_Client_ServiceWatch",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActionRequired",
                table: "tbl_Client_ServiceWatch",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_Client_ServiceWatch",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientSignature",
                table: "tbl_Client_ServiceWatch",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_Client_ServiceWatch",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_Client_ServiceWatch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_Client_ServiceWatch",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_Client_ServiceWatch",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_Client_ServiceWatch",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_Client_ServiceWatch",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_Client_ServiceWatch",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManagerSignature",
                table: "tbl_Client_ServiceWatch",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaffSignature",
                table: "tbl_Client_ServiceWatch",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "tbl_Client_Program",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_Client_Program",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "tbl_Client_Program",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProgramOfChoice",
                table: "tbl_Client_Program",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlaceLocationProgram",
                table: "tbl_Client_Program",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Observation",
                table: "tbl_Client_Program",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NextCheckDate",
                table: "tbl_Client_Program",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DetailsOfProgram",
                table: "tbl_Client_Program",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Deadline",
                table: "tbl_Client_Program",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DaysOfChoice",
                table: "tbl_Client_Program",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "tbl_Client_Program",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_Client_Program",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Attachment",
                table: "tbl_Client_Program",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActionRequired",
                table: "tbl_Client_Program",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_Client_Program",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientSignature",
                table: "tbl_Client_Program",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_Client_Program",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_Client_Program",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_Client_Program",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_Client_Program",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_Client_Program",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_Client_Program",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_Client_Program",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManagerSignature",
                table: "tbl_Client_Program",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaffSignature",
                table: "tbl_Client_Program",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_Client_MgtVisit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ServiceRecommended",
                table: "tbl_Client_MgtVisit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RotCause",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Reference",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RateServiceRecieving",
                table: "tbl_Client_MgtVisit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RateManagers",
                table: "tbl_Client_MgtVisit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Observation",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NextCheckDate",
                table: "tbl_Client_MgtVisit",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LessonLearntAndShared",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImprovementExpect",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HowToComplain",
                table: "tbl_Client_MgtVisit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EvidenceOfActionTaken",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Deadline",
                table: "tbl_Client_MgtVisit",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "tbl_Client_MgtVisit",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "tbl_Client_MgtVisit",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 38,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Attachment",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActionsTakenByMPCC",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActionRequired",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2024)",
                oldMaxLength: 2024,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_Client_MgtVisit",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientSignature",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_Client_MgtVisit",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "tbl_Client_MgtVisit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_Client_MgtVisit",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_Client_MgtVisit",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManagerSignature",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaffSignature",
                table: "tbl_Client_MgtVisit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "tbl_BestInterestAssessment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_BestInterestAssessment",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tbl_BestInterestAssessment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "tbl_BestInterestAssessment",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "tbl_BestInterestAssessment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "tbl_BestInterestAssessment",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "tbl_BestInterestAssessment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Pets_ClientId1",
                table: "tbl_Pets",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ManagingTasks_ClientId1",
                table: "tbl_ManagingTasks",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_InfectionControl_ClientId1",
                table: "tbl_InfectionControl",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HealthTask2_BestId",
                table: "tbl_HealthTask2",
                column: "BestId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HealthTask_BestId",
                table: "tbl_HealthTask",
                column: "BestId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientInvoice_ClientId",
                table: "tbl_ClientInvoice",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_Voice_ClientId1",
                table: "tbl_Client_Voice",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_ServiceWatch_ClientId1",
                table: "tbl_Client_ServiceWatch",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_Program_ClientId1",
                table: "tbl_Client_Program",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_MgtVisit_ClientId1",
                table: "tbl_Client_MgtVisit",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CareIssuesTask_BestId",
                table: "tbl_CareIssuesTask",
                column: "BestId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BelieveTask_BestId",
                table: "tbl_BelieveTask",
                column: "BestId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BelieveTask_tbl_BestInterestAssessment_BestId",
                table: "tbl_BelieveTask",
                column: "BestId",
                principalTable: "tbl_BestInterestAssessment",
                principalColumn: "BestId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BestInterestAssessment_tbl_Client_ClientId",
                table: "tbl_BestInterestAssessment",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CareIssuesTask_tbl_BestInterestAssessment_BestId",
                table: "tbl_CareIssuesTask",
                column: "BestId",
                principalTable: "tbl_BestInterestAssessment",
                principalColumn: "BestId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_MgtVisit_tbl_Client_ClientId1",
                table: "tbl_Client_MgtVisit",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_MgtVisit_tbl_Company_ClientId",
                table: "tbl_Client_MgtVisit",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Program_tbl_Client_ClientId1",
                table: "tbl_Client_Program",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Program_tbl_Company_ClientId",
                table: "tbl_Client_Program",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_ServiceWatch_tbl_Client_ClientId1",
                table: "tbl_Client_ServiceWatch",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_ServiceWatch_tbl_Company_ClientId",
                table: "tbl_Client_ServiceWatch",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Voice_tbl_Client_ClientId1",
                table: "tbl_Client_Voice",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Voice_tbl_Company_ClientId",
                table: "tbl_Client_Voice",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientInvoice_tbl_Company_ClientId",
                table: "tbl_ClientInvoice",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HealthTask_tbl_BestInterestAssessment_BestId",
                table: "tbl_HealthTask",
                column: "BestId",
                principalTable: "tbl_BestInterestAssessment",
                principalColumn: "BestId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HealthTask2_tbl_BestInterestAssessment_BestId",
                table: "tbl_HealthTask2",
                column: "BestId",
                principalTable: "tbl_BestInterestAssessment",
                principalColumn: "BestId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_InfectionControl_tbl_Client_ClientId1",
                table: "tbl_InfectionControl",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_InfectionControl_tbl_Company_ClientId",
                table: "tbl_InfectionControl",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ManagingTasks_tbl_Client_ClientId1",
                table: "tbl_ManagingTasks",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ManagingTasks_tbl_Company_ClientId",
                table: "tbl_ManagingTasks",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Pets_tbl_Client_ClientId1",
                table: "tbl_Pets",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Pets_tbl_Company_ClientId",
                table: "tbl_Pets",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
