using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddClientIdRoleAccess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ExternalRoleAccess_tbl_Company_ClientId",
                table: "tbl_ExternalRoleAccess");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ExternalRoleAccess_ClientId",
                table: "tbl_ExternalRoleAccess");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_tbl_ExternalRoleAccess_ClientId",
                table: "tbl_ExternalRoleAccess",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ExternalRoleAccess_tbl_Company_ClientId",
                table: "tbl_ExternalRoleAccess",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId");
        }
    }
}
