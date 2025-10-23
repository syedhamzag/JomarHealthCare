using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class StaffSuperVisionAppraisalUpdatefields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "tbl_Staff_SupervisionAppraisal",
                type: "nvarchar(38)",
                maxLength: 38,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "StaffSupportAreas",
                table: "tbl_Staff_SupervisionAppraisal",
                type: "nvarchar(38)",
                maxLength: 38,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "StaffRating",
                table: "tbl_Staff_SupervisionAppraisal",
                type: "nvarchar(38)",
                maxLength: 38,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "StaffComplaints",
                table: "tbl_Staff_SupervisionAppraisal",
                type: "nvarchar(38)",
                maxLength: 38,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ProfessionalDevelopment",
                table: "tbl_Staff_SupervisionAppraisal",
                type: "nvarchar(38)",
                maxLength: 38,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "tbl_Staff_OneToOne",
                type: "nvarchar(38)",
                maxLength: 38,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PreviousSupervision",
                table: "tbl_Staff_OneToOne",
                type: "nvarchar(38)",
                maxLength: 38,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "tbl_Staff_SupervisionAppraisal",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(38)",
                oldMaxLength: 38);

            migrationBuilder.AlterColumn<int>(
                name: "StaffSupportAreas",
                table: "tbl_Staff_SupervisionAppraisal",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(38)",
                oldMaxLength: 38);

            migrationBuilder.AlterColumn<int>(
                name: "StaffRating",
                table: "tbl_Staff_SupervisionAppraisal",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(38)",
                oldMaxLength: 38);

            migrationBuilder.AlterColumn<int>(
                name: "StaffComplaints",
                table: "tbl_Staff_SupervisionAppraisal",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(38)",
                oldMaxLength: 38);

            migrationBuilder.AlterColumn<int>(
                name: "ProfessionalDevelopment",
                table: "tbl_Staff_SupervisionAppraisal",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(38)",
                oldMaxLength: 38);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "tbl_Staff_OneToOne",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(38)",
                oldMaxLength: 38);

            migrationBuilder.AlterColumn<string>(
                name: "PreviousSupervision",
                table: "tbl_Staff_OneToOne",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(38)",
                oldMaxLength: 38);
        }
    }
}
