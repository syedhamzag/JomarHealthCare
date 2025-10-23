using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateClientAndAreaCodeTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_AuditTrail_tbl_Client_ClientId",
                table: "tbl_AuditTrail");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Balance_tbl_Client_ClientId1",
                table: "tbl_Balance");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_BestInterestAssessment_tbl_Client_ClientId1",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_BodyMap_tbl_Client_ClientId1",
                table: "tbl_BodyMap");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CarePlanNutrition_tbl_Client_ClientId1",
                table: "tbl_CarePlanNutrition");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CareReview_tbl_Client_ClientId1",
                table: "tbl_CareReview");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_tbl_Company_ClientId",
                table: "tbl_Client");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_BloodCoagulationRecord_tbl_Client_ClientId1",
                table: "tbl_Client_BloodCoagulationRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_BloodPressure_tbl_Client_ClientId1",
                table: "tbl_Client_BloodPressure");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_BMIChart_tbl_Client_ClientId1",
                table: "tbl_Client_BMIChart");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_BodyTemp_tbl_Client_ClientId1",
                table: "tbl_Client_BodyTemp");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_BowelMovement_tbl_Client_ClientId1",
                table: "tbl_Client_BowelMovement");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_ComplainRegister_tbl_Client_ClientId1",
                table: "tbl_Client_ComplainRegister");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_EyeHealthMonitoring_tbl_Client_ClientId1",
                table: "tbl_Client_EyeHealthMonitoring");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_FoodIntake_tbl_Client_ClientId1",
                table: "tbl_Client_FoodIntake");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_HeartRate_tbl_Client_ClientId1",
                table: "tbl_Client_HeartRate");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_LogAudit_tbl_Client_ClientId1",
                table: "tbl_Client_LogAudit");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_MedAudit_tbl_Client_ClientId1",
                table: "tbl_Client_MedAudit");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_MgtVisit_tbl_Client_ClientId1",
                table: "tbl_Client_MgtVisit");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Nutrition_tbl_Client_ClientId1",
                table: "tbl_Client_Nutrition");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Oxygenlvl_tbl_Client_ClientId1",
                table: "tbl_Client_Oxygenlvl");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_PainChart_tbl_Client_ClientId1",
                table: "tbl_Client_PainChart");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Program_tbl_Client_ClientId1",
                table: "tbl_Client_Program");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_PulseRate_tbl_Client_ClientId1",
                table: "tbl_Client_PulseRate");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Seizure_tbl_Client_ClientId1",
                table: "tbl_Client_Seizure");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_ServiceWatch_tbl_Client_ClientId1",
                table: "tbl_Client_ServiceWatch");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Voice_tbl_Client_ClientId1",
                table: "tbl_Client_Voice");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_WoundCare_tbl_Client_ClientId1",
                table: "tbl_Client_WoundCare");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientCareDetails_tbl_Client_ClientId1",
                table: "tbl_ClientCareDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientCareObj_tbl_Client_ClientId1",
                table: "tbl_ClientCareObj");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientDailyTask_tbl_Client_ClientId",
                table: "tbl_ClientDailyTask");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientHealthCondition_tbl_Client_ClientId1",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientHobbies_tbl_Client_ClientId1",
                table: "tbl_ClientHobbies");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientInvolvingParty_tbl_Client_ClientId1",
                table: "tbl_ClientInvolvingParty");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientKeyWorkerVoice_tbl_Client_ClientId",
                table: "tbl_ClientKeyWorkerVoice");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientMatrixAudit_tbl_Client_ClientId1",
                table: "tbl_ClientMatrixAudit");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientMedication_tbl_Client_ClientId1",
                table: "tbl_ClientMedication");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientRegulatoryContact_tbl_Client_ClientId1",
                table: "tbl_ClientRegulatoryContact");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientRota_tbl_Client_ClientId1",
                table: "tbl_ClientRota");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ComplainRegistorClients_tbl_Client_ClientId1",
                table: "tbl_ComplainRegistorClients");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_createshiftuserroles_tbl_Client_ClientId",
                table: "tbl_createshiftuserroles");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CuidiBuddy_tbl_Client_ClientId1",
                table: "tbl_CuidiBuddy");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_DutyOnCall_tbl_Client_ClientId1",
                table: "tbl_DutyOnCall");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Enotice__tbl_Client_ClientId",
                table: "tbl_Enotice_");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_EquipmentAssessment_tbl_Client_ClientId1",
                table: "tbl_EquipmentAssessment");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_FilesAndRecord_tbl_Client_ClientId1",
                table: "tbl_FilesAndRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HealthAndLiving_tbl_Client_ClientId1",
                table: "tbl_HealthAndLiving");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HistoryOfFall_tbl_Client_ClientId1",
                table: "tbl_HistoryOfFall");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HomeRiskAssessment_tbl_Client_ClientId1",
                table: "tbl_HomeRiskAssessment");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HospitalEntry_tbl_Client_ClientId1",
                table: "tbl_HospitalEntry");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HospitalExit_tbl_Client_ClientId",
                table: "tbl_HospitalExit");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_IncidentReporting_tbl_Client_ClientId1",
                table: "tbl_IncidentReporting");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Incoming_Meds_tbl_Client_ClientId",
                table: "tbl_Incoming_Meds");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_InfectionControl_tbl_Client_ClientId1",
                table: "tbl_InfectionControl");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_InterestAndObjective_tbl_Client_ClientId1",
                table: "tbl_InterestAndObjective");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ManagingTasks_tbl_Client_ClientId1",
                table: "tbl_ManagingTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PersonalDetail_tbl_Client_ClientId1",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PersonalHygiene_tbl_Client_ClientId1",
                table: "tbl_PersonalHygiene");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Pets_tbl_Client_ClientId1",
                table: "tbl_Pets");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PhysicalAbility_tbl_Client_ClientId1",
                table: "tbl_PhysicalAbility");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Resources__tbl_Client_ClientId",
                table: "tbl_Resources_");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_SpecialHealthAndMedication_tbl_Client_ClientId1",
                table: "tbl_SpecialHealthAndMedication");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_SpecialHealthCondition_tbl_Client_ClientId1",
                table: "tbl_SpecialHealthCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Staff_AdlObs_tbl_Client_ClientId1",
                table: "tbl_Staff_AdlObs");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Staff_KeyWorkerVoice_tbl_Client_ClientId",
                table: "tbl_Staff_KeyWorkerVoice");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Staff_MedCompObs_tbl_Client_ClientId1",
                table: "tbl_Staff_MedCompObs");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Staff_Reference_tbl_Client_ClientId",
                table: "tbl_Staff_Reference");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Staff_SpotCheck_tbl_Client_ClientId1",
                table: "tbl_Staff_SpotCheck");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_StaffBlackList_tbl_Client_ClientId1",
                table: "tbl_StaffBlackList");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_StaffTeamLead_tbl_Client_ClientId",
                table: "tbl_StaffTeamLead");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Client",
                table: "tbl_Client");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Client_ClientId",
                table: "tbl_Client");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_Territory");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_ServiceType");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_AreaCode");

            migrationBuilder.RenameColumn(
                name: "ClientId1",
                table: "tbl_Client",
                newName: "CompanyId");

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_Territory",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tbl_ServiceType",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_ServiceType",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "tbl_Hobbies",
                type: "uniqueidentifier",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UniqueId",
                table: "tbl_Client",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TeritoryId",
                table: "tbl_Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Telephone",
                table: "tbl_Client",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TeamLeaderId",
                table: "tbl_Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "tbl_Client",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "tbl_Client",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "PreferredName",
                table: "tbl_Client",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostCode",
                table: "tbl_Client",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pin",
                table: "tbl_Client",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PassportFilePath",
                table: "tbl_Client",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Middlename",
                table: "tbl_Client",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Longitude",
                table: "tbl_Client",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "LocationDistance",
                table: "tbl_Client",
                type: "float",
                nullable: true,
                defaultValue: 0.01,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.01);

            migrationBuilder.AlterColumn<string>(
                name: "Latitude",
                table: "tbl_Client",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KeyworkerId",
                table: "tbl_Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "IdNumber",
                table: "tbl_Client",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "tbl_Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "tbl_Client",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "tbl_Client",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "Denture",
                table: "tbl_Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "tbl_Client",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientManager",
                table: "tbl_Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "AreaCodeId",
                table: "tbl_Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Aid",
                table: "tbl_Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "tbl_Client",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "tbl_AreaCode",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Client",
                table: "tbl_Client",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_AreaCodeId",
                table: "tbl_Client",
                column: "AreaCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_CompanyId",
                table: "tbl_Client",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_TeritoryId",
                table: "tbl_Client",
                column: "TeritoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_AuditTrail_tbl_Client_ClientId",
                table: "tbl_AuditTrail",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Balance_tbl_Client_ClientId1",
                table: "tbl_Balance",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BestInterestAssessment_tbl_Client_ClientId1",
                table: "tbl_BestInterestAssessment",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BodyMap_tbl_Client_ClientId1",
                table: "tbl_BodyMap",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CarePlanNutrition_tbl_Client_ClientId1",
                table: "tbl_CarePlanNutrition",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CareReview_tbl_Client_ClientId1",
                table: "tbl_CareReview",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_tbl_AreaCode_AreaCodeId",
                table: "tbl_Client",
                column: "AreaCodeId",
                principalTable: "tbl_AreaCode",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_tbl_Company_CompanyId",
                table: "tbl_Client",
                column: "CompanyId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_tbl_Territory_TeritoryId",
                table: "tbl_Client",
                column: "TeritoryId",
                principalTable: "tbl_Territory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_BloodCoagulationRecord_tbl_Client_ClientId1",
                table: "tbl_Client_BloodCoagulationRecord",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_BloodPressure_tbl_Client_ClientId1",
                table: "tbl_Client_BloodPressure",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_BMIChart_tbl_Client_ClientId1",
                table: "tbl_Client_BMIChart",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_BodyTemp_tbl_Client_ClientId1",
                table: "tbl_Client_BodyTemp",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_BowelMovement_tbl_Client_ClientId1",
                table: "tbl_Client_BowelMovement",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_ComplainRegister_tbl_Client_ClientId1",
                table: "tbl_Client_ComplainRegister",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_EyeHealthMonitoring_tbl_Client_ClientId1",
                table: "tbl_Client_EyeHealthMonitoring",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_FoodIntake_tbl_Client_ClientId1",
                table: "tbl_Client_FoodIntake",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_HeartRate_tbl_Client_ClientId1",
                table: "tbl_Client_HeartRate",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_LogAudit_tbl_Client_ClientId1",
                table: "tbl_Client_LogAudit",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_MedAudit_tbl_Client_ClientId1",
                table: "tbl_Client_MedAudit",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_MgtVisit_tbl_Client_ClientId1",
                table: "tbl_Client_MgtVisit",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Nutrition_tbl_Client_ClientId1",
                table: "tbl_Client_Nutrition",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Oxygenlvl_tbl_Client_ClientId1",
                table: "tbl_Client_Oxygenlvl",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_PainChart_tbl_Client_ClientId1",
                table: "tbl_Client_PainChart",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Program_tbl_Client_ClientId1",
                table: "tbl_Client_Program",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_PulseRate_tbl_Client_ClientId1",
                table: "tbl_Client_PulseRate",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Seizure_tbl_Client_ClientId1",
                table: "tbl_Client_Seizure",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_ServiceWatch_tbl_Client_ClientId1",
                table: "tbl_Client_ServiceWatch",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Voice_tbl_Client_ClientId1",
                table: "tbl_Client_Voice",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_WoundCare_tbl_Client_ClientId1",
                table: "tbl_Client_WoundCare",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientCareDetails_tbl_Client_ClientId1",
                table: "tbl_ClientCareDetails",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientCareObj_tbl_Client_ClientId1",
                table: "tbl_ClientCareObj",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

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
                name: "FK_tbl_ClientHobbies_tbl_Client_ClientId1",
                table: "tbl_ClientHobbies",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientInvolvingParty_tbl_Client_ClientId1",
                table: "tbl_ClientInvolvingParty",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientKeyWorkerVoice_tbl_Client_ClientId",
                table: "tbl_ClientKeyWorkerVoice",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientMatrixAudit_tbl_Client_ClientId1",
                table: "tbl_ClientMatrixAudit",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientMedication_tbl_Client_ClientId1",
                table: "tbl_ClientMedication",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientRegulatoryContact_tbl_Client_ClientId1",
                table: "tbl_ClientRegulatoryContact",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientRota_tbl_Client_ClientId1",
                table: "tbl_ClientRota",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ComplainRegistorClients_tbl_Client_ClientId1",
                table: "tbl_ComplainRegistorClients",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_createshiftuserroles_tbl_Client_ClientId",
                table: "tbl_createshiftuserroles",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CuidiBuddy_tbl_Client_ClientId1",
                table: "tbl_CuidiBuddy",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_DutyOnCall_tbl_Client_ClientId1",
                table: "tbl_DutyOnCall",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Enotice__tbl_Client_ClientId",
                table: "tbl_Enotice_",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_EquipmentAssessment_tbl_Client_ClientId1",
                table: "tbl_EquipmentAssessment",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_FilesAndRecord_tbl_Client_ClientId1",
                table: "tbl_FilesAndRecord",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HealthAndLiving_tbl_Client_ClientId1",
                table: "tbl_HealthAndLiving",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HistoryOfFall_tbl_Client_ClientId1",
                table: "tbl_HistoryOfFall",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HomeRiskAssessment_tbl_Client_ClientId1",
                table: "tbl_HomeRiskAssessment",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HospitalEntry_tbl_Client_ClientId1",
                table: "tbl_HospitalEntry",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HospitalExit_tbl_Client_ClientId",
                table: "tbl_HospitalExit",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_IncidentReporting_tbl_Client_ClientId1",
                table: "tbl_IncidentReporting",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Incoming_Meds_tbl_Client_ClientId",
                table: "tbl_Incoming_Meds",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_InfectionControl_tbl_Client_ClientId1",
                table: "tbl_InfectionControl",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_InterestAndObjective_tbl_Client_ClientId1",
                table: "tbl_InterestAndObjective",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ManagingTasks_tbl_Client_ClientId1",
                table: "tbl_ManagingTasks",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PersonalDetail_tbl_Client_ClientId1",
                table: "tbl_PersonalDetail",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PersonalHygiene_tbl_Client_ClientId1",
                table: "tbl_PersonalHygiene",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Pets_tbl_Client_ClientId1",
                table: "tbl_Pets",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PhysicalAbility_tbl_Client_ClientId1",
                table: "tbl_PhysicalAbility",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Resources__tbl_Client_ClientId",
                table: "tbl_Resources_",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_SpecialHealthAndMedication_tbl_Client_ClientId1",
                table: "tbl_SpecialHealthAndMedication",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_SpecialHealthCondition_tbl_Client_ClientId1",
                table: "tbl_SpecialHealthCondition",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Staff_AdlObs_tbl_Client_ClientId1",
                table: "tbl_Staff_AdlObs",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Staff_KeyWorkerVoice_tbl_Client_ClientId",
                table: "tbl_Staff_KeyWorkerVoice",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Staff_MedCompObs_tbl_Client_ClientId1",
                table: "tbl_Staff_MedCompObs",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Staff_Reference_tbl_Client_ClientId",
                table: "tbl_Staff_Reference",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Staff_SpotCheck_tbl_Client_ClientId1",
                table: "tbl_Staff_SpotCheck",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffBlackList_tbl_Client_ClientId1",
                table: "tbl_StaffBlackList",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffTeamLead_tbl_Client_ClientId",
                table: "tbl_StaffTeamLead",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_AuditTrail_tbl_Client_ClientId",
                table: "tbl_AuditTrail");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Balance_tbl_Client_ClientId1",
                table: "tbl_Balance");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_BestInterestAssessment_tbl_Client_ClientId1",
                table: "tbl_BestInterestAssessment");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_BodyMap_tbl_Client_ClientId1",
                table: "tbl_BodyMap");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CarePlanNutrition_tbl_Client_ClientId1",
                table: "tbl_CarePlanNutrition");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CareReview_tbl_Client_ClientId1",
                table: "tbl_CareReview");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_tbl_AreaCode_AreaCodeId",
                table: "tbl_Client");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_tbl_Company_CompanyId",
                table: "tbl_Client");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_tbl_Territory_TeritoryId",
                table: "tbl_Client");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_BloodCoagulationRecord_tbl_Client_ClientId1",
                table: "tbl_Client_BloodCoagulationRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_BloodPressure_tbl_Client_ClientId1",
                table: "tbl_Client_BloodPressure");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_BMIChart_tbl_Client_ClientId1",
                table: "tbl_Client_BMIChart");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_BodyTemp_tbl_Client_ClientId1",
                table: "tbl_Client_BodyTemp");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_BowelMovement_tbl_Client_ClientId1",
                table: "tbl_Client_BowelMovement");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_ComplainRegister_tbl_Client_ClientId1",
                table: "tbl_Client_ComplainRegister");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_EyeHealthMonitoring_tbl_Client_ClientId1",
                table: "tbl_Client_EyeHealthMonitoring");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_FoodIntake_tbl_Client_ClientId1",
                table: "tbl_Client_FoodIntake");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_HeartRate_tbl_Client_ClientId1",
                table: "tbl_Client_HeartRate");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_LogAudit_tbl_Client_ClientId1",
                table: "tbl_Client_LogAudit");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_MedAudit_tbl_Client_ClientId1",
                table: "tbl_Client_MedAudit");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_MgtVisit_tbl_Client_ClientId1",
                table: "tbl_Client_MgtVisit");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Nutrition_tbl_Client_ClientId1",
                table: "tbl_Client_Nutrition");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Oxygenlvl_tbl_Client_ClientId1",
                table: "tbl_Client_Oxygenlvl");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_PainChart_tbl_Client_ClientId1",
                table: "tbl_Client_PainChart");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Program_tbl_Client_ClientId1",
                table: "tbl_Client_Program");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_PulseRate_tbl_Client_ClientId1",
                table: "tbl_Client_PulseRate");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Seizure_tbl_Client_ClientId1",
                table: "tbl_Client_Seizure");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_ServiceWatch_tbl_Client_ClientId1",
                table: "tbl_Client_ServiceWatch");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_Voice_tbl_Client_ClientId1",
                table: "tbl_Client_Voice");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_WoundCare_tbl_Client_ClientId1",
                table: "tbl_Client_WoundCare");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientCareDetails_tbl_Client_ClientId1",
                table: "tbl_ClientCareDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientCareObj_tbl_Client_ClientId1",
                table: "tbl_ClientCareObj");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientDailyTask_tbl_Client_ClientId",
                table: "tbl_ClientDailyTask");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientHealthCondition_tbl_Client_ClientId1",
                table: "tbl_ClientHealthCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientHobbies_tbl_Client_ClientId1",
                table: "tbl_ClientHobbies");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientInvolvingParty_tbl_Client_ClientId1",
                table: "tbl_ClientInvolvingParty");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientKeyWorkerVoice_tbl_Client_ClientId",
                table: "tbl_ClientKeyWorkerVoice");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientMatrixAudit_tbl_Client_ClientId1",
                table: "tbl_ClientMatrixAudit");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientMedication_tbl_Client_ClientId1",
                table: "tbl_ClientMedication");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientRegulatoryContact_tbl_Client_ClientId1",
                table: "tbl_ClientRegulatoryContact");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientRota_tbl_Client_ClientId1",
                table: "tbl_ClientRota");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ComplainRegistorClients_tbl_Client_ClientId1",
                table: "tbl_ComplainRegistorClients");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_createshiftuserroles_tbl_Client_ClientId",
                table: "tbl_createshiftuserroles");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_CuidiBuddy_tbl_Client_ClientId1",
                table: "tbl_CuidiBuddy");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_DutyOnCall_tbl_Client_ClientId1",
                table: "tbl_DutyOnCall");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Enotice__tbl_Client_ClientId",
                table: "tbl_Enotice_");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_EquipmentAssessment_tbl_Client_ClientId1",
                table: "tbl_EquipmentAssessment");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_FilesAndRecord_tbl_Client_ClientId1",
                table: "tbl_FilesAndRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HealthAndLiving_tbl_Client_ClientId1",
                table: "tbl_HealthAndLiving");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HistoryOfFall_tbl_Client_ClientId1",
                table: "tbl_HistoryOfFall");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HomeRiskAssessment_tbl_Client_ClientId1",
                table: "tbl_HomeRiskAssessment");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HospitalEntry_tbl_Client_ClientId1",
                table: "tbl_HospitalEntry");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_HospitalExit_tbl_Client_ClientId",
                table: "tbl_HospitalExit");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_IncidentReporting_tbl_Client_ClientId1",
                table: "tbl_IncidentReporting");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Incoming_Meds_tbl_Client_ClientId",
                table: "tbl_Incoming_Meds");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_InfectionControl_tbl_Client_ClientId1",
                table: "tbl_InfectionControl");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_InterestAndObjective_tbl_Client_ClientId1",
                table: "tbl_InterestAndObjective");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ManagingTasks_tbl_Client_ClientId1",
                table: "tbl_ManagingTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PersonalDetail_tbl_Client_ClientId1",
                table: "tbl_PersonalDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PersonalHygiene_tbl_Client_ClientId1",
                table: "tbl_PersonalHygiene");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Pets_tbl_Client_ClientId1",
                table: "tbl_Pets");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PhysicalAbility_tbl_Client_ClientId1",
                table: "tbl_PhysicalAbility");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Resources__tbl_Client_ClientId",
                table: "tbl_Resources_");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_SpecialHealthAndMedication_tbl_Client_ClientId1",
                table: "tbl_SpecialHealthAndMedication");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_SpecialHealthCondition_tbl_Client_ClientId1",
                table: "tbl_SpecialHealthCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Staff_AdlObs_tbl_Client_ClientId1",
                table: "tbl_Staff_AdlObs");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Staff_KeyWorkerVoice_tbl_Client_ClientId",
                table: "tbl_Staff_KeyWorkerVoice");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Staff_MedCompObs_tbl_Client_ClientId1",
                table: "tbl_Staff_MedCompObs");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Staff_Reference_tbl_Client_ClientId",
                table: "tbl_Staff_Reference");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Staff_SpotCheck_tbl_Client_ClientId1",
                table: "tbl_Staff_SpotCheck");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_StaffBlackList_tbl_Client_ClientId1",
                table: "tbl_StaffBlackList");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_StaffTeamLead_tbl_Client_ClientId",
                table: "tbl_StaffTeamLead");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Client",
                table: "tbl_Client");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Client_AreaCodeId",
                table: "tbl_Client");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Client_CompanyId",
                table: "tbl_Client");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Client_TeritoryId",
                table: "tbl_Client");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_Territory");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_ServiceType");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "tbl_AreaCode");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "tbl_Client",
                newName: "ClientId1");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_Territory",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tbl_ServiceType",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_ServiceType",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "tbl_Hobbies",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UniqueId",
                table: "tbl_Client",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TeritoryId",
                table: "tbl_Client",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telephone",
                table: "tbl_Client",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TeamLeaderId",
                table: "tbl_Client",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "tbl_Client",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "tbl_Client",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PreferredName",
                table: "tbl_Client",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostCode",
                table: "tbl_Client",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pin",
                table: "tbl_Client",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PassportFilePath",
                table: "tbl_Client",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Middlename",
                table: "tbl_Client",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Longitude",
                table: "tbl_Client",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "LocationDistance",
                table: "tbl_Client",
                type: "float",
                nullable: false,
                defaultValue: 0.01,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldDefaultValue: 0.01);

            migrationBuilder.AlterColumn<string>(
                name: "Latitude",
                table: "tbl_Client",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KeyworkerId",
                table: "tbl_Client",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdNumber",
                table: "tbl_Client",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "tbl_Client",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "tbl_Client",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "tbl_Client",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Denture",
                table: "tbl_Client",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "tbl_Client",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientManager",
                table: "tbl_Client",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AreaCodeId",
                table: "tbl_Client",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Aid",
                table: "tbl_Client",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "tbl_Client",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_AreaCode",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Client",
                table: "tbl_Client",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_ClientId",
                table: "tbl_Client",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_AuditTrail_tbl_Client_ClientId",
                table: "tbl_AuditTrail",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Balance_tbl_Client_ClientId1",
                table: "tbl_Balance",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BestInterestAssessment_tbl_Client_ClientId1",
                table: "tbl_BestInterestAssessment",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BodyMap_tbl_Client_ClientId1",
                table: "tbl_BodyMap",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CarePlanNutrition_tbl_Client_ClientId1",
                table: "tbl_CarePlanNutrition",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CareReview_tbl_Client_ClientId1",
                table: "tbl_CareReview",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_tbl_Company_ClientId",
                table: "tbl_Client",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_BloodCoagulationRecord_tbl_Client_ClientId1",
                table: "tbl_Client_BloodCoagulationRecord",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_BloodPressure_tbl_Client_ClientId1",
                table: "tbl_Client_BloodPressure",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_BMIChart_tbl_Client_ClientId1",
                table: "tbl_Client_BMIChart",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_BodyTemp_tbl_Client_ClientId1",
                table: "tbl_Client_BodyTemp",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_BowelMovement_tbl_Client_ClientId1",
                table: "tbl_Client_BowelMovement",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_ComplainRegister_tbl_Client_ClientId1",
                table: "tbl_Client_ComplainRegister",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_EyeHealthMonitoring_tbl_Client_ClientId1",
                table: "tbl_Client_EyeHealthMonitoring",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_FoodIntake_tbl_Client_ClientId1",
                table: "tbl_Client_FoodIntake",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_HeartRate_tbl_Client_ClientId1",
                table: "tbl_Client_HeartRate",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_LogAudit_tbl_Client_ClientId1",
                table: "tbl_Client_LogAudit",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_MedAudit_tbl_Client_ClientId1",
                table: "tbl_Client_MedAudit",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_MgtVisit_tbl_Client_ClientId1",
                table: "tbl_Client_MgtVisit",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Nutrition_tbl_Client_ClientId1",
                table: "tbl_Client_Nutrition",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Oxygenlvl_tbl_Client_ClientId1",
                table: "tbl_Client_Oxygenlvl",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_PainChart_tbl_Client_ClientId1",
                table: "tbl_Client_PainChart",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Program_tbl_Client_ClientId1",
                table: "tbl_Client_Program",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_PulseRate_tbl_Client_ClientId1",
                table: "tbl_Client_PulseRate",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Seizure_tbl_Client_ClientId1",
                table: "tbl_Client_Seizure",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_ServiceWatch_tbl_Client_ClientId1",
                table: "tbl_Client_ServiceWatch",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Voice_tbl_Client_ClientId1",
                table: "tbl_Client_Voice",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_WoundCare_tbl_Client_ClientId1",
                table: "tbl_Client_WoundCare",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientCareDetails_tbl_Client_ClientId1",
                table: "tbl_ClientCareDetails",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientCareObj_tbl_Client_ClientId1",
                table: "tbl_ClientCareObj",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientDailyTask_tbl_Client_ClientId",
                table: "tbl_ClientDailyTask",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientHealthCondition_tbl_Client_ClientId1",
                table: "tbl_ClientHealthCondition",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientHobbies_tbl_Client_ClientId1",
                table: "tbl_ClientHobbies",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientInvolvingParty_tbl_Client_ClientId1",
                table: "tbl_ClientInvolvingParty",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientKeyWorkerVoice_tbl_Client_ClientId",
                table: "tbl_ClientKeyWorkerVoice",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientMatrixAudit_tbl_Client_ClientId1",
                table: "tbl_ClientMatrixAudit",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientMedication_tbl_Client_ClientId1",
                table: "tbl_ClientMedication",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientRegulatoryContact_tbl_Client_ClientId1",
                table: "tbl_ClientRegulatoryContact",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientRota_tbl_Client_ClientId1",
                table: "tbl_ClientRota",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ComplainRegistorClients_tbl_Client_ClientId1",
                table: "tbl_ComplainRegistorClients",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_createshiftuserroles_tbl_Client_ClientId",
                table: "tbl_createshiftuserroles",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CuidiBuddy_tbl_Client_ClientId1",
                table: "tbl_CuidiBuddy",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_DutyOnCall_tbl_Client_ClientId1",
                table: "tbl_DutyOnCall",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Enotice__tbl_Client_ClientId",
                table: "tbl_Enotice_",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_EquipmentAssessment_tbl_Client_ClientId1",
                table: "tbl_EquipmentAssessment",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_FilesAndRecord_tbl_Client_ClientId1",
                table: "tbl_FilesAndRecord",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HealthAndLiving_tbl_Client_ClientId1",
                table: "tbl_HealthAndLiving",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HistoryOfFall_tbl_Client_ClientId1",
                table: "tbl_HistoryOfFall",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HomeRiskAssessment_tbl_Client_ClientId1",
                table: "tbl_HomeRiskAssessment",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HospitalEntry_tbl_Client_ClientId1",
                table: "tbl_HospitalEntry",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HospitalExit_tbl_Client_ClientId",
                table: "tbl_HospitalExit",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_IncidentReporting_tbl_Client_ClientId1",
                table: "tbl_IncidentReporting",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Incoming_Meds_tbl_Client_ClientId",
                table: "tbl_Incoming_Meds",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_InfectionControl_tbl_Client_ClientId1",
                table: "tbl_InfectionControl",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_InterestAndObjective_tbl_Client_ClientId1",
                table: "tbl_InterestAndObjective",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ManagingTasks_tbl_Client_ClientId1",
                table: "tbl_ManagingTasks",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PersonalDetail_tbl_Client_ClientId1",
                table: "tbl_PersonalDetail",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PersonalHygiene_tbl_Client_ClientId1",
                table: "tbl_PersonalHygiene",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Pets_tbl_Client_ClientId1",
                table: "tbl_Pets",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PhysicalAbility_tbl_Client_ClientId1",
                table: "tbl_PhysicalAbility",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Resources__tbl_Client_ClientId",
                table: "tbl_Resources_",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_SpecialHealthAndMedication_tbl_Client_ClientId1",
                table: "tbl_SpecialHealthAndMedication",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_SpecialHealthCondition_tbl_Client_ClientId1",
                table: "tbl_SpecialHealthCondition",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Staff_AdlObs_tbl_Client_ClientId1",
                table: "tbl_Staff_AdlObs",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Staff_KeyWorkerVoice_tbl_Client_ClientId",
                table: "tbl_Staff_KeyWorkerVoice",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Staff_MedCompObs_tbl_Client_ClientId1",
                table: "tbl_Staff_MedCompObs",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Staff_Reference_tbl_Client_ClientId",
                table: "tbl_Staff_Reference",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Staff_SpotCheck_tbl_Client_ClientId1",
                table: "tbl_Staff_SpotCheck",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffBlackList_tbl_Client_ClientId1",
                table: "tbl_StaffBlackList",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffTeamLead_tbl_Client_ClientId",
                table: "tbl_StaffTeamLead",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");
        }
    }
}
