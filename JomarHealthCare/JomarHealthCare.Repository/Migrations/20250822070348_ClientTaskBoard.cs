using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class ClientTaskBoard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_TaskBoardAssignedTo_tbl_ClientTaskBoard_TaskBoardId",
                table: "tbl_TaskBoardAssignedTo");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_TaskBoardAssignedTo_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                table: "tbl_TaskBoardAssignedTo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_TaskBoardAssignedTo",
                table: "tbl_TaskBoardAssignedTo");

            migrationBuilder.RenameTable(
                name: "tbl_TaskBoardAssignedTo",
                newName: "tbl_ClientTaskBoardAssignedTo");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_TaskBoardAssignedTo_TaskBoardId",
                table: "tbl_ClientTaskBoardAssignedTo",
                newName: "IX_tbl_ClientTaskBoardAssignedTo_TaskBoardId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_TaskBoardAssignedTo_StaffPersonalInfoId",
                table: "tbl_ClientTaskBoardAssignedTo",
                newName: "IX_tbl_ClientTaskBoardAssignedTo_StaffPersonalInfoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_ClientTaskBoardAssignedTo",
                table: "tbl_ClientTaskBoardAssignedTo",
                column: "TaskBoardAssignedToId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientTaskBoardAssignedTo_tbl_ClientTaskBoard_TaskBoardId",
                table: "tbl_ClientTaskBoardAssignedTo",
                column: "TaskBoardId",
                principalTable: "tbl_ClientTaskBoard",
                principalColumn: "TaskBoardId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientTaskBoardAssignedTo_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                table: "tbl_ClientTaskBoardAssignedTo",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientTaskBoardAssignedTo_tbl_ClientTaskBoard_TaskBoardId",
                table: "tbl_ClientTaskBoardAssignedTo");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientTaskBoardAssignedTo_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                table: "tbl_ClientTaskBoardAssignedTo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_ClientTaskBoardAssignedTo",
                table: "tbl_ClientTaskBoardAssignedTo");

            migrationBuilder.RenameTable(
                name: "tbl_ClientTaskBoardAssignedTo",
                newName: "tbl_TaskBoardAssignedTo");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_ClientTaskBoardAssignedTo_TaskBoardId",
                table: "tbl_TaskBoardAssignedTo",
                newName: "IX_tbl_TaskBoardAssignedTo_TaskBoardId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_ClientTaskBoardAssignedTo_StaffPersonalInfoId",
                table: "tbl_TaskBoardAssignedTo",
                newName: "IX_tbl_TaskBoardAssignedTo_StaffPersonalInfoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_TaskBoardAssignedTo",
                table: "tbl_TaskBoardAssignedTo",
                column: "TaskBoardAssignedToId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_TaskBoardAssignedTo_tbl_ClientTaskBoard_TaskBoardId",
                table: "tbl_TaskBoardAssignedTo",
                column: "TaskBoardId",
                principalTable: "tbl_ClientTaskBoard",
                principalColumn: "TaskBoardId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_TaskBoardAssignedTo_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                table: "tbl_TaskBoardAssignedTo",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
