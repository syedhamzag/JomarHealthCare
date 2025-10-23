using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class StaffTrainingByList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "tbl_AppointmentBooking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "tbl_StaffTrainingByList",
                columns: table => new
                {
                    StaffTrainingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 38, nullable: false),
                    Training = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Certificate = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true),
                    Location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Trainer = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true),
                    StartDate = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ExpiredDate = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CertificateAttachment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffTrainingByList", x => x.StaffTrainingId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffTrainingByList_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffTrainingByList_StaffPersonalInfoId",
                table: "tbl_StaffTrainingByList",
                column: "StaffPersonalInfoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_StaffTrainingByList");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "tbl_AppointmentBooking");
        }
    }
}
