using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateClientInvoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceTypeId",
                table: "tbl_ClientInvoiceRate");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                table: "tbl_ClientInvoiceRate",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "ServiceType",
                table: "tbl_ClientInvoiceRate",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceType",
                table: "tbl_ClientInvoiceRate");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                table: "tbl_ClientInvoiceRate",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServiceTypeId",
                table: "tbl_ClientInvoiceRate",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
