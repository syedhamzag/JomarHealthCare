using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateApplicationUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_chatNotification_tbl_User_ToUserId",
                table: "tbl_chatNotification");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_chatsupport_tbl_User_FromUserId",
                table: "tbl_chatsupport");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_chatsupportconversation_tbl_User_ApplicationUserId",
                table: "tbl_chatsupportconversation");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Client_tbl_User_CreatedBy",
                table: "tbl_Client");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientRotaName_tbl_User_UserId",
                table: "tbl_ClientRotaName");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_conversation_tbl_User_CreatedBy",
                table: "tbl_conversation");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Inbox_tbl_User_ToUserId",
                table: "tbl_Inbox");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Investigation_tbl_User_CreatedBy",
                table: "tbl_Investigation");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Medication_tbl_User_CreatedBy",
                table: "tbl_Medication");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Staff_AdlObs_tbl_User_CreatedBy",
                table: "tbl_Staff_AdlObs");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_StaffIncidentReporting_tbl_User_CreatedBy",
                table: "tbl_StaffIncidentReporting");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_User_CompanyModel_CompanyModelId",
                table: "tbl_User");

            migrationBuilder.DropIndex(
                name: "IX_tbl_User_CompanyModelId",
                table: "tbl_User");

            migrationBuilder.DropIndex(
                name: "IX_tbl_StaffIncidentReporting_CreatedBy",
                table: "tbl_StaffIncidentReporting");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Staff_AdlObs_CreatedBy",
                table: "tbl_Staff_AdlObs");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Medication_CreatedBy",
                table: "tbl_Medication");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Investigation_CreatedBy",
                table: "tbl_Investigation");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Inbox_ToUserId",
                table: "tbl_Inbox");

            migrationBuilder.DropIndex(
                name: "IX_tbl_conversation_CreatedBy",
                table: "tbl_conversation");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ClientRotaName_UserId",
                table: "tbl_ClientRotaName");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Client_CreatedBy",
                table: "tbl_Client");

            migrationBuilder.DropIndex(
                name: "IX_tbl_chatsupportconversation_ApplicationUserId",
                table: "tbl_chatsupportconversation");

            migrationBuilder.DropIndex(
                name: "IX_tbl_chatsupport_FromUserId",
                table: "tbl_chatsupport");

            migrationBuilder.DropIndex(
                name: "IX_tbl_chatNotification_ToUserId",
                table: "tbl_chatNotification");

            migrationBuilder.DropColumn(
                name: "CompanyModelId",
                table: "tbl_User");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "tbl_ClientRotaName");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "tbl_chatsupportconversation");

            migrationBuilder.AlterColumn<string>(
                name: "ToUserId",
                table: "tbl_Inbox",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "tbl_ClientRotaName",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "tbl_chatsupportconversation",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FromUserId",
                table: "tbl_chatsupport",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ToUserId",
                table: "tbl_chatNotification",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "CompanyModel",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompanyModel_UserId1",
                table: "CompanyModel",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyModel_tbl_User_UserId1",
                table: "CompanyModel",
                column: "UserId1",
                principalTable: "tbl_User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyModel_tbl_User_UserId1",
                table: "CompanyModel");

            migrationBuilder.DropIndex(
                name: "IX_CompanyModel_UserId1",
                table: "CompanyModel");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "CompanyModel");

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyModelId",
                table: "tbl_User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "ToUserId",
                table: "tbl_Inbox",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "tbl_ClientRotaName",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "tbl_ClientRotaName",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "tbl_chatsupportconversation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "tbl_chatsupportconversation",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FromUserId",
                table: "tbl_chatsupport",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ToUserId",
                table: "tbl_chatNotification",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_User_CompanyModelId",
                table: "tbl_User",
                column: "CompanyModelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffIncidentReporting_CreatedBy",
                table: "tbl_StaffIncidentReporting",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Staff_AdlObs_CreatedBy",
                table: "tbl_Staff_AdlObs",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Medication_CreatedBy",
                table: "tbl_Medication",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Investigation_CreatedBy",
                table: "tbl_Investigation",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Inbox_ToUserId",
                table: "tbl_Inbox",
                column: "ToUserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_conversation_CreatedBy",
                table: "tbl_conversation",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientRotaName_UserId",
                table: "tbl_ClientRotaName",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_CreatedBy",
                table: "tbl_Client",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_chatsupportconversation_ApplicationUserId",
                table: "tbl_chatsupportconversation",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_chatsupport_FromUserId",
                table: "tbl_chatsupport",
                column: "FromUserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_chatNotification_ToUserId",
                table: "tbl_chatNotification",
                column: "ToUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_chatNotification_tbl_User_ToUserId",
                table: "tbl_chatNotification",
                column: "ToUserId",
                principalTable: "tbl_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_chatsupport_tbl_User_FromUserId",
                table: "tbl_chatsupport",
                column: "FromUserId",
                principalTable: "tbl_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_chatsupportconversation_tbl_User_ApplicationUserId",
                table: "tbl_chatsupportconversation",
                column: "ApplicationUserId",
                principalTable: "tbl_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_tbl_User_CreatedBy",
                table: "tbl_Client",
                column: "CreatedBy",
                principalTable: "tbl_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientRotaName_tbl_User_UserId",
                table: "tbl_ClientRotaName",
                column: "UserId",
                principalTable: "tbl_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_conversation_tbl_User_CreatedBy",
                table: "tbl_conversation",
                column: "CreatedBy",
                principalTable: "tbl_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Inbox_tbl_User_ToUserId",
                table: "tbl_Inbox",
                column: "ToUserId",
                principalTable: "tbl_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Investigation_tbl_User_CreatedBy",
                table: "tbl_Investigation",
                column: "CreatedBy",
                principalTable: "tbl_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Medication_tbl_User_CreatedBy",
                table: "tbl_Medication",
                column: "CreatedBy",
                principalTable: "tbl_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Staff_AdlObs_tbl_User_CreatedBy",
                table: "tbl_Staff_AdlObs",
                column: "CreatedBy",
                principalTable: "tbl_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffIncidentReporting_tbl_User_CreatedBy",
                table: "tbl_StaffIncidentReporting",
                column: "CreatedBy",
                principalTable: "tbl_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_User_CompanyModel_CompanyModelId",
                table: "tbl_User",
                column: "CompanyModelId",
                principalTable: "CompanyModel",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
