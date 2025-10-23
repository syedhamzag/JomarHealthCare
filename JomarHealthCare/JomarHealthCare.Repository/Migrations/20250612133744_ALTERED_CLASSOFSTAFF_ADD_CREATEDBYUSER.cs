using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class ALTERED_CLASSOFSTAFF_ADD_CREATEDBYUSER : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "tbl_ClassOfStaff",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClassOfStaff_CreatedBy",
                table: "tbl_ClassOfStaff",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClassOfStaff_tbl_User_CreatedBy",
                table: "tbl_ClassOfStaff",
                column: "CreatedBy",
                principalTable: "tbl_User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClassOfStaff_tbl_User_CreatedBy",
                table: "tbl_ClassOfStaff");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ClassOfStaff_CreatedBy",
                table: "tbl_ClassOfStaff");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "tbl_ClassOfStaff",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
