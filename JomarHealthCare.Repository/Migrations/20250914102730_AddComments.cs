using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentBookingAttendees_tbl_AppointmentBooking_AppointmentBookingId",
                table: "AppointmentBookingAttendees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppointmentBookingAttendees",
                table: "AppointmentBookingAttendees");

            migrationBuilder.RenameTable(
                name: "AppointmentBookingAttendees",
                newName: "tbl_AppointmentBookingAttendees");

            migrationBuilder.RenameIndex(
                name: "IX_AppointmentBookingAttendees_AppointmentBookingId",
                table: "tbl_AppointmentBookingAttendees",
                newName: "IX_tbl_AppointmentBookingAttendees_AppointmentBookingId");

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "tbl_AppointmentBooking",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_AppointmentBookingAttendees",
                table: "tbl_AppointmentBookingAttendees",
                column: "AppointmentBookingAttendeesId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_AppointmentBookingAttendees_tbl_AppointmentBooking_AppointmentBookingId",
                table: "tbl_AppointmentBookingAttendees",
                column: "AppointmentBookingId",
                principalTable: "tbl_AppointmentBooking",
                principalColumn: "AppointmentBookingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_AppointmentBookingAttendees_tbl_AppointmentBooking_AppointmentBookingId",
                table: "tbl_AppointmentBookingAttendees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_AppointmentBookingAttendees",
                table: "tbl_AppointmentBookingAttendees");

            migrationBuilder.DropColumn(
                name: "Comments",
                table: "tbl_AppointmentBooking");

            migrationBuilder.RenameTable(
                name: "tbl_AppointmentBookingAttendees",
                newName: "AppointmentBookingAttendees");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_AppointmentBookingAttendees_AppointmentBookingId",
                table: "AppointmentBookingAttendees",
                newName: "IX_AppointmentBookingAttendees_AppointmentBookingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppointmentBookingAttendees",
                table: "AppointmentBookingAttendees",
                column: "AppointmentBookingAttendeesId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentBookingAttendees_tbl_AppointmentBooking_AppointmentBookingId",
                table: "AppointmentBookingAttendees",
                column: "AppointmentBookingId",
                principalTable: "tbl_AppointmentBooking",
                principalColumn: "AppointmentBookingId");
        }
    }
}
