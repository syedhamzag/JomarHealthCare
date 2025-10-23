using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AppointmentBooking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_StaffTaskBoardAssignedTo");

            migrationBuilder.DropTable(
                name: "tbl_StaffTaskBoard");

            migrationBuilder.CreateTable(
                name: "tbl_AppointmentBooking",
                columns: table => new
                {
                    AppointmentBookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Location = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    Link = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Class = table.Column<int>(type: "int", nullable: false),
                    AttendeeName = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 38, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_AppointmentBooking", x => x.AppointmentBookingId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CommunicationLog",
                columns: table => new
                {
                    CommunicationLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingTitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MinuteTaker = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ClinicalPresentation = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    Discussion = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    Plan = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    ActionItems = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    CaseNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    AttendeeName = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    ApologiesName = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 38, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CommunicationLog", x => x.CommunicationLogId);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentBookingAttendees",
                columns: table => new
                {
                    AppointmentBookingAttendeesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendeesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppointmentBookingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentBookingAttendees", x => x.AppointmentBookingAttendeesId);
                    table.ForeignKey(
                        name: "FK_AppointmentBookingAttendees_tbl_AppointmentBooking_AppointmentBookingId",
                        column: x => x.AppointmentBookingId,
                        principalTable: "tbl_AppointmentBooking",
                        principalColumn: "AppointmentBookingId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CommunicationLogApologies",
                columns: table => new
                {
                    CommunicationLogApologiesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApologiesId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 38, nullable: false),
                    CommunicationLogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CommunicationLogApologies", x => x.CommunicationLogApologiesId);
                    table.ForeignKey(
                        name: "FK_tbl_CommunicationLogApologies_tbl_CommunicationLog_CommunicationLogId",
                        column: x => x.CommunicationLogId,
                        principalTable: "tbl_CommunicationLog",
                        principalColumn: "CommunicationLogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CommunicationLogAttendees",
                columns: table => new
                {
                    CommunicationLogAttendeesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendeesId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 38, nullable: false),
                    CommunicationLogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CommunicationLogAttendees", x => x.CommunicationLogAttendeesId);
                    table.ForeignKey(
                        name: "FK_tbl_CommunicationLogAttendees_tbl_CommunicationLog_CommunicationLogId",
                        column: x => x.CommunicationLogId,
                        principalTable: "tbl_CommunicationLog",
                        principalColumn: "CommunicationLogId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentBookingAttendees_AppointmentBookingId",
                table: "AppointmentBookingAttendees",
                column: "AppointmentBookingId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CommunicationLogApologies_CommunicationLogId",
                table: "tbl_CommunicationLogApologies",
                column: "CommunicationLogId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CommunicationLogAttendees_CommunicationLogId",
                table: "tbl_CommunicationLogAttendees",
                column: "CommunicationLogId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentBookingAttendees");

            migrationBuilder.DropTable(
                name: "tbl_CommunicationLogApologies");

            migrationBuilder.DropTable(
                name: "tbl_CommunicationLogAttendees");

            migrationBuilder.DropTable(
                name: "tbl_AppointmentBooking");

            migrationBuilder.DropTable(
                name: "tbl_CommunicationLog");

            migrationBuilder.CreateTable(
                name: "tbl_StaffTaskBoard",
                columns: table => new
                {
                    StaffTaskBoardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 38, nullable: false),
                    Attachment = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TaskImage = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    TaskName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
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
        }
    }
}
