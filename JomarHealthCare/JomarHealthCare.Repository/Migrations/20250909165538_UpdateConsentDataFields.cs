using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateConsentDataFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CareName",
                table: "tbl_ConsentData");

            migrationBuilder.DropColumn(
                name: "DataName",
                table: "tbl_ConsentData");

            migrationBuilder.AddColumn<string>(
                name: "CareInvolvingPerson",
                table: "tbl_ConsentData",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvolvingPerson",
                table: "tbl_ConsentData",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CareInvolvingPerson",
                table: "tbl_ConsentData");

            migrationBuilder.DropColumn(
                name: "InvolvingPerson",
                table: "tbl_ConsentData");

            migrationBuilder.AddColumn<Guid>(
                name: "CareName",
                table: "tbl_ConsentData",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DataName",
                table: "tbl_ConsentData",
                type: "uniqueidentifier",
                maxLength: 38,
                nullable: true);
        }
    }
}
