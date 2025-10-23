using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class MultipleStaffClientRoleAccess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "tbl_ExternalRoleAccess");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "tbl_ExternalRoleAccess");

            migrationBuilder.CreateTable(
                name: "tbl_ExternalRoleAccessClient",
                columns: table => new
                {
                    ExternalRoleAccessClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExternalAccessId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 38, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ExternalRoleAccessClient", x => x.ExternalRoleAccessClientId);
                    table.ForeignKey(
                        name: "FK_tbl_ExternalRoleAccessClient_tbl_ExternalRoleAccess_ExternalAccessId",
                        column: x => x.ExternalAccessId,
                        principalTable: "tbl_ExternalRoleAccess",
                        principalColumn: "ExternalAccessId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ExternalRoleAccessStaff",
                columns: table => new
                {
                    ExternalRoleAccessStaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExternalAccessId = table.Column<int>(type: "int", nullable: false),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 38, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ExternalRoleAccessStaff", x => x.ExternalRoleAccessStaffId);
                    table.ForeignKey(
                        name: "FK_tbl_ExternalRoleAccessStaff_tbl_ExternalRoleAccess_ExternalAccessId",
                        column: x => x.ExternalAccessId,
                        principalTable: "tbl_ExternalRoleAccess",
                        principalColumn: "ExternalAccessId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ExternalRoleAccessClient_ExternalAccessId",
                table: "tbl_ExternalRoleAccessClient",
                column: "ExternalAccessId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ExternalRoleAccessStaff_ExternalAccessId",
                table: "tbl_ExternalRoleAccessStaff",
                column: "ExternalAccessId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_ExternalRoleAccessClient");

            migrationBuilder.DropTable(
                name: "tbl_ExternalRoleAccessStaff");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "tbl_ExternalRoleAccess",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StaffId",
                table: "tbl_ExternalRoleAccess",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
