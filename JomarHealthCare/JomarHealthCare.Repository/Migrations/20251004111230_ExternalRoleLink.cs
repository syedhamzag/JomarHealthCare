using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class ExternalRoleLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "tbl_ExternalRole",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "tbl_IncidentDetail",
                columns: table => new
                {
                    IncidentDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PoliceNotify = table.Column<bool>(type: "bit", nullable: false),
                    PoliceNotifyReference = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IncidentDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IncidentCauses = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recommendations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FollowupAction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_IncidentDetail", x => x.IncidentDetailId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_IncidentDetailAssignedTo",
                columns: table => new
                {
                    IncidentDetailAssignedToId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 38, nullable: false),
                    IncidentDetailId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_IncidentDetailAssignedTo", x => x.IncidentDetailAssignedToId);
                    table.ForeignKey(
                        name: "FK_tbl_IncidentDetailAssignedTo_tbl_IncidentDetail_IncidentDetailId",
                        column: x => x.IncidentDetailId,
                        principalTable: "tbl_IncidentDetail",
                        principalColumn: "IncidentDetailId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_IncidentDetailAssignedTo_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ExternalRole_UserId",
                table: "tbl_ExternalRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_IncidentDetailAssignedTo_IncidentDetailId",
                table: "tbl_IncidentDetailAssignedTo",
                column: "IncidentDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_IncidentDetailAssignedTo_StaffPersonalInfoId",
                table: "tbl_IncidentDetailAssignedTo",
                column: "StaffPersonalInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ExternalRole_tbl_User_UserId",
                table: "tbl_ExternalRole",
                column: "UserId",
                principalTable: "tbl_User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ExternalRole_tbl_User_UserId",
                table: "tbl_ExternalRole");

            migrationBuilder.DropTable(
                name: "tbl_IncidentDetailAssignedTo");

            migrationBuilder.DropTable(
                name: "tbl_IncidentDetail");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ExternalRole_UserId",
                table: "tbl_ExternalRole");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "tbl_ExternalRole",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
