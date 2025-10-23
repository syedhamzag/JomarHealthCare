using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateHealthConditionAndDailyTaskTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientDailyTask_tbl_Client_ClientId1",
                table: "tbl_ClientDailyTask");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientDailyTask_tbl_Company_ClientId",
                table: "tbl_ClientDailyTask");

            migrationBuilder.DropIndex(
                name: "IX_tbl_ClientDailyTask_ClientId1",
                table: "tbl_ClientDailyTask");

            migrationBuilder.DropColumn(
                name: "Attachment",
                table: "tbl_ClientDailyTask");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "tbl_ClientDailyTask");

            migrationBuilder.AlterColumn<string>(
                name: "DailyTaskName",
                table: "tbl_ClientDailyTask",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientDailyTask_tbl_Client_ClientId",
                table: "tbl_ClientDailyTask",
                column: "ClientId",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_ClientDailyTask_tbl_Client_ClientId",
                table: "tbl_ClientDailyTask");

            migrationBuilder.AlterColumn<string>(
                name: "DailyTaskName",
                table: "tbl_ClientDailyTask",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Attachment",
                table: "tbl_ClientDailyTask",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "tbl_ClientDailyTask",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientDailyTask_ClientId1",
                table: "tbl_ClientDailyTask",
                column: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientDailyTask_tbl_Client_ClientId1",
                table: "tbl_ClientDailyTask",
                column: "ClientId1",
                principalTable: "tbl_Client",
                principalColumn: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientDailyTask_tbl_Company_ClientId",
                table: "tbl_ClientDailyTask",
                column: "ClientId",
                principalTable: "tbl_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
