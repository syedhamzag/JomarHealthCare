using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class StaffTaskBoard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_TaskBoardAssignedTo_tbl_TaskBoard_TaskBoardId",
                table: "tbl_TaskBoardAssignedTo");

            migrationBuilder.DropTable(
                name: "tbl_TaskBoard");

            migrationBuilder.CreateTable(
                name: "tbl_ClientTaskBoard",
                columns: table => new
                {
                    TaskBoardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 38, nullable: false),
                    TaskImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attachment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientTaskBoard", x => x.TaskBoardId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientTaskBoard_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffTaskBoard",
                columns: table => new
                {
                    StaffTaskBoardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 38, nullable: false),
                    TaskImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attachment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffTaskBoard", x => x.StaffTaskBoardId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffTaskBoard_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffTaskBoardAssignedTo",
                columns: table => new
                {
                    TaskBoardAssignedToId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffTaskBoardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffTaskBoardAssignedTo", x => x.TaskBoardAssignedToId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffTaskBoardAssignedTo_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_StaffTaskBoardAssignedTo_tbl_StaffTaskBoard_StaffTaskBoardId",
                        column: x => x.StaffTaskBoardId,
                        principalTable: "tbl_StaffTaskBoard",
                        principalColumn: "StaffTaskBoardId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientTaskBoard_ClientId",
                table: "tbl_ClientTaskBoard",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffTaskBoard_StaffPersonalInfoId",
                table: "tbl_StaffTaskBoard",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffTaskBoardAssignedTo_StaffPersonalInfoId",
                table: "tbl_StaffTaskBoardAssignedTo",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffTaskBoardAssignedTo_StaffTaskBoardId",
                table: "tbl_StaffTaskBoardAssignedTo",
                column: "StaffTaskBoardId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_TaskBoardAssignedTo_tbl_ClientTaskBoard_TaskBoardId",
                table: "tbl_TaskBoardAssignedTo",
                column: "TaskBoardId",
                principalTable: "tbl_ClientTaskBoard",
                principalColumn: "TaskBoardId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_TaskBoardAssignedTo_tbl_ClientTaskBoard_TaskBoardId",
                table: "tbl_TaskBoardAssignedTo");

            migrationBuilder.DropTable(
                name: "tbl_ClientTaskBoard");

            migrationBuilder.DropTable(
                name: "tbl_StaffTaskBoardAssignedTo");

            migrationBuilder.DropTable(
                name: "tbl_StaffTaskBoard");

            migrationBuilder.CreateTable(
                name: "tbl_TaskBoard",
                columns: table => new
                {
                    TaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attachment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 38, nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TaskImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_TaskBoard", x => x.TaskId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_TaskBoardAssignedTo_tbl_TaskBoard_TaskBoardId",
                table: "tbl_TaskBoardAssignedTo",
                column: "TaskBoardId",
                principalTable: "tbl_TaskBoard",
                principalColumn: "TaskId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
