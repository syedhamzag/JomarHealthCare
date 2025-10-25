using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JomarHealthCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialPostgresMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_AddressHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Address = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    PostCode = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    FromDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ToDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    NoOfLandlord = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    LandLordContactNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Remarks = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_AddressHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_AdminAdvertisement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Image = table.Column<string>(type: "character varying(1025)", maxLength: 1025, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsForAll = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_AdminAdvertisement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_AdminMessage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AdminsMessage = table.Column<string>(type: "character varying(1025)", maxLength: 1025, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsForAll = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_AdminMessage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_AmountRateType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_AmountRateType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_AppMessage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Subject = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Message = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    ToWhom = table.Column<int>(type: "integer", nullable: false),
                    FromDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ToDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PauseOrStart = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_AppMessage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_AppointmentBooking",
                columns: table => new
                {
                    AppointmentBookingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Subject = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Location = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Link = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Class = table.Column<int>(type: "integer", nullable: false),
                    AttendeeName = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Comments = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_AppointmentBooking", x => x.AppointmentBookingId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_AreaCode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_AreaCode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BaseRecord",
                columns: table => new
                {
                    BaseRecordId = table.Column<Guid>(type: "uuid", nullable: false),
                    KeyName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BaseRecord", x => x.BaseRecordId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BaseRecord_Model",
                columns: table => new
                {
                    BaseRecordId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KeyName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BaseRecord_Model", x => x.BaseRecordId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BundleTrainingResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BundleId = table.Column<int>(type: "integer", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    TrainingId = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BundleTrainingResult", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CallDetail",
                columns: table => new
                {
                    CallDetailId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ServiceWeekId = table.Column<int>(type: "integer", nullable: false),
                    NameOfCaller = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    DateOfCall = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TimeOfCall = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FeedBack = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Brief = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CallDetail", x => x.CallDetailId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CandidateInterviewResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    QuestionId = table.Column<int>(type: "integer", nullable: false),
                    Answer = table.Column<string>(type: "text", nullable: false),
                    Point = table.Column<int>(type: "integer", nullable: false),
                    CandidateInterviewId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CandidateInterviewResult", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Capacity",
                columns: table => new
                {
                    CapacityId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false),
                    Pointer = table.Column<int>(type: "integer", nullable: false),
                    Implication = table.Column<int>(type: "integer", nullable: false),
                    Indicators = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Capacity", x => x.CapacityId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CategoryOfStaff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CategoryOfStaff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClassOfStaff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClassName = table.Column<string>(type: "text", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClassOfStaff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientCongnitive",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AbilityStatus = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    UserGetMissing = table.Column<bool>(type: "boolean", nullable: false),
                    RiskLevel = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    LocationOfMissingPersonFound = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    RequireOrCondition = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    PossibleTriggerToLeadClient = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    DuesServices = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    StaffPrepare = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    StaffWhenUserIsMissing = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    StaffWhenUserIsFound = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    DuringTransfer = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    WhenEating = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    WhenWalking = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    WhenSleeping = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    WhenMedicating = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    WhenBathing = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    WhenCleaning = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    WhenShopping = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    WhenBookAppointment = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    WhenCommunication = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    SkinBreakDown = table.Column<bool>(type: "boolean", nullable: false),
                    GeneralSkinCondition = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    SkinInspection = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    SUBeChecked = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    PossibleBreakDown = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    ProtectionOrBreakdown = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    PresureRelievingDevices = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    TypeOfDeviceAvailable = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    StaffUseTheDevice = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    SUawareSkinCare = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    BeforeSkinIntegrity = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    AfterSkinIntegrity = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    WoundCommunicating = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    WoundStage = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    WoundType = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    RisktoSU = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    RisktoStaff = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    Esclation = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    DifficultyInBreathing = table.Column<bool>(type: "boolean", nullable: false),
                    BreathingManage = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    CathataCareRequired = table.Column<bool>(type: "boolean", nullable: false),
                    UseCathata = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    ControlOfCathata = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    ChangeCathata = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    SupplyOFCathata = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    CathataConnected = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    CathataRecylced = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    DurationOfUse = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    CathataPosition = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    UTI = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    CathataEscalation = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Vision = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    Speech = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    Hearing = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    AboutAppetit = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    AboutSwallow = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    CCTV = table.Column<bool>(type: "boolean", nullable: false),
                    Rubbishstorage = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    RiskRubbishstorage = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    Bedrails = table.Column<bool>(type: "boolean", nullable: false),
                    PositionBedrail = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    AssociatedWithBedrail = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    BedrailRisk = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    BedrailEscalation = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Recliner = table.Column<bool>(type: "boolean", nullable: false),
                    PositionRecliner = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    AssociatedWithRecliner = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    ReclinerRisk = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    ReclinerEscalation = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientCongnitive", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientInvoiceSummary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FromDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ToDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Period = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ServiceTypeId = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientInvoiceSummary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientKeyworkerNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KeyworkerId = table.Column<string>(type: "character varying(38)", maxLength: 38, nullable: false),
                    OtherStaffId = table.Column<string>(type: "character varying(38)", maxLength: 38, nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: false),
                    AccessInfo = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientKeyworkerNotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientMedicationAdditional",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientMedicationPeriodId = table.Column<int>(type: "integer", nullable: false),
                    DoseTobeGiven = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DoseGiven = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Instruction = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    FeedBack = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    RotaDate = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Time = table.Column<TimeSpan>(type: "interval", nullable: true),
                    StopTime = table.Column<TimeSpan>(type: "interval", nullable: true),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientMedicationAdditional", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientRotaName",
                columns: table => new
                {
                    RotaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NumberOfStaff = table.Column<int>(type: "integer", nullable: false),
                    RotaName = table.Column<string>(type: "character varying(225)", maxLength: 225, nullable: false),
                    Gender = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Area = table.Column<string>(type: "character varying(225)", maxLength: 225, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientRotaName", x => x.RotaId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientRotaType",
                columns: table => new
                {
                    ClientRotaTypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RotaType = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientRotaType", x => x.ClientRotaTypeId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Communication",
                columns: table => new
                {
                    CommunicationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FromUserId = table.Column<string>(type: "text", nullable: false),
                    ToUserId = table.Column<string>(type: "text", nullable: false),
                    Subject = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: true),
                    Message = table.Column<string>(type: "text", nullable: false),
                    CommuncationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsRead = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Communication", x => x.CommunicationId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CommunicationLog",
                columns: table => new
                {
                    CommunicationLogId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MeetingTitle = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MinuteTaker = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ClinicalPresentation = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Discussion = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Plan = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    ActionItems = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    CaseNo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    AttendeeName = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    ApologiesName = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CommunicationLog", x => x.CommunicationLogId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Company",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Website = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    LogoUrl = table.Column<string>(type: "text", nullable: true),
                    Language = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    PostCode = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Telephone = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Country = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Currency = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    DateFrom = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DateTo = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CurrentCqcRating = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CityOfOperation = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    AdminmessageId = table.Column<int>(type: "integer", nullable: true),
                    AdminAdvertisementId = table.Column<int>(type: "integer", nullable: true),
                    IsTrainingModule = table.Column<bool>(type: "boolean", nullable: false),
                    OurPhilosophy = table.Column<string>(type: "text", nullable: false),
                    Purpose = table.Column<string>(type: "text", nullable: false),
                    Complaint = table.Column<string>(type: "text", nullable: false),
                    ContactUs = table.Column<string>(type: "text", nullable: false),
                    PPE = table.Column<string>(type: "text", nullable: false),
                    CompanyCode = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CompanyMessage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanysMessage = table.Column<string>(type: "character varying(1025)", maxLength: 1025, nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CompanyMessage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CompanyOnlineTraining",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    OnlineTrainingId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CompanyOnlineTraining", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CompanyPincode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Pincode = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CompanyPincode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CompanyReception",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Name = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    logoUrl = table.Column<string>(type: "character varying(1052)", maxLength: 1052, nullable: false),
                    Notes = table.Column<string>(type: "character varying(1052)", maxLength: 1052, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CompanyReception", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CompanyTrainingImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    BannerImg = table.Column<string>(type: "text", nullable: false),
                    InductionImg = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    AllCoursesImg = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    MyCoursesImg = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    CertificationImg = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    LibarayImg = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    SupportImg = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CompanyTrainingImage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ComplainRegistor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    ComplainDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ComplainCloseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    TypeOfComplain = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    PersonMakingComplain = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Ac_Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Ac_DateOfIncident = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    OfficerName = table.Column<string>(type: "character varying(38)", maxLength: 38, nullable: false),
                    ListOfConcern = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    ContentOfOfficer = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Pi_Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Pi_Status = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Pi_AnyOther = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Pi_Notify = table.Column<bool>(type: "boolean", nullable: false),
                    M_SpokenToStaff = table.Column<bool>(type: "boolean", nullable: false),
                    M_ChecktheRecord = table.Column<bool>(type: "boolean", nullable: false),
                    M_VisitedYou = table.Column<bool>(type: "boolean", nullable: false),
                    M_OnetoOne = table.Column<bool>(type: "boolean", nullable: false),
                    M_Whistle = table.Column<bool>(type: "boolean", nullable: false),
                    M_Independent = table.Column<bool>(type: "boolean", nullable: false),
                    M_Other = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Ido_Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Ido_Status = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Ido_ListOfConcern = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Ido_AnyOtherInfo = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Ido_Attachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Ido_Notify = table.Column<bool>(type: "boolean", nullable: false),
                    Ido_StaffResponse = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    IoP_Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IoP_Status = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    IoP_ListOfConcern = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    IoP_AnyOtherInfo = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    IoP_Attachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    IoP_Notify = table.Column<bool>(type: "boolean", nullable: false),
                    Ev_Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Ev_Decision = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Ev_Attachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Ev_Status = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Ev_Reference = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    RC_CasuesWithIncident = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    RC_Prevented = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    RC_Shared = table.Column<bool>(type: "boolean", nullable: false),
                    Clc_Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Clc_AnyInfo = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Clc_Attachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Clc_Status = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Cls_Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Cls_AnyInfo = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Cls_Attachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Cls_Status = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    GeneralStatus = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    ReasonOfPending = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    ClosingStatment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ComplainRegistor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Complements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Subject = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Summary = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Attachment = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    URL = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Remarks = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Complements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ConsentData",
                columns: table => new
                {
                    DataId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    Signature = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    InvolvingPerson = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CareSignature = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    CareDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CareInvolvingPerson = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    LandSignature = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    LandDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LandInvolvingPerson = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    LandMethodOfLogs = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    OwnMedication = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    FamilyResponsibity = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    AdministratorProcess = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ConsentData", x => x.DataId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ContractTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TemplateName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Template = table.Column<string>(type: "text", nullable: false),
                    JobPositionId = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ContractTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CreditCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CardType = table.Column<int>(type: "integer", nullable: false),
                    OtherTypeName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    CardHolderName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CardNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ExpirationDate = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    PostalCode = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    CustomerName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CustomerSignature = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    SignatureDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CreditCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_DeductionForAllStaff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffId = table.Column<int>(type: "integer", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DeductionForAllStaff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_DefaultStaffSupport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    SupportType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DefaultStaffSupport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Directors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    MiddleName = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    lastName = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Address = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Telephone = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    PostCode = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    UserId = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    Password = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_EmailMessage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Subject = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Category = table.Column<int>(type: "integer", nullable: true),
                    Message = table.Column<string>(type: "text", nullable: false),
                    SendDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CompanyId = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_EmailMessage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_EquipmentAssessmentData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EquipmentAssessmentId = table.Column<int>(type: "integer", nullable: false),
                    URL = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    HowToUse = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: false),
                    ClientRisk = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: false),
                    StaffRisk = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: false),
                    Image = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_EquipmentAssessmentData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ExternalRoleAccess",
                columns: table => new
                {
                    ExternalAccessId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExternalId = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ExternalRoleAccess", x => x.ExternalAccessId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_FeedBackMatchingWords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_FeedBackMatchingWords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_FluidIntake",
                columns: table => new
                {
                    FluidIntakeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffRotaPeriodId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Dose = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_FluidIntake", x => x.FluidIntakeId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_FocusedFeedback",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Topic = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    FileURl = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Reason = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Remark = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    ConductedBy = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_FocusedFeedback", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_HealthCondition",
                columns: table => new
                {
                    HCId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Condition = table.Column<string>(type: "text", nullable: false),
                    CausesAndTrigger = table.Column<string>(type: "text", nullable: false),
                    Symptoms = table.Column<string>(type: "text", nullable: false),
                    ClientManagingWithCondition = table.Column<string>(type: "text", nullable: false),
                    RiskToClient = table.Column<string>(type: "text", nullable: false),
                    RiskToStaff = table.Column<string>(type: "text", nullable: false),
                    ActionRequiredToStaff = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Image1 = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_HealthCondition", x => x.HCId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Hobbies",
                columns: table => new
                {
                    HId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Hobbies", x => x.HId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_HolidayCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    NoOfDays = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_HolidayCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_IncidentDetail",
                columns: table => new
                {
                    IncidentDetailId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PoliceNotify = table.Column<bool>(type: "boolean", nullable: false),
                    PoliceNotifyReference = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    IncidentDetails = table.Column<string>(type: "text", nullable: false),
                    IncidentCauses = table.Column<string>(type: "text", nullable: false),
                    Recommendations = table.Column<string>(type: "text", nullable: false),
                    FollowupAction = table.Column<string>(type: "text", nullable: false),
                    IncidentType = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Status = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_IncidentDetail", x => x.IncidentDetailId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_IncidentType",
                columns: table => new
                {
                    IncidentTypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IncidentTypes = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_IncidentType", x => x.IncidentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_IncomeForAllStaff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffId = table.Column<int>(type: "integer", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_IncomeForAllStaff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Inspection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FileName = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    FileURl = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Remark = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Attachment = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Inspection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Interest",
                columns: table => new
                {
                    InterestId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GoalId = table.Column<int>(type: "integer", nullable: false),
                    LeisureActivity = table.Column<int>(type: "integer", nullable: false),
                    InformalActivity = table.Column<int>(type: "integer", nullable: false),
                    MaintainContact = table.Column<int>(type: "integer", nullable: false),
                    CommunityActivity = table.Column<int>(type: "integer", nullable: false),
                    EventAwarness = table.Column<int>(type: "integer", nullable: false),
                    GoalAndObjective = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Interest", x => x.InterestId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_JobPosition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_JobPosition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_JobPositionAccess",
                columns: table => new
                {
                    AccessId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobPositionId = table.Column<int>(type: "integer", nullable: false),
                    PageId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_JobPositionAccess", x => x.AccessId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_KeyIndicators",
                columns: table => new
                {
                    KeyId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false),
                    AboutMe = table.Column<string>(type: "text", nullable: false),
                    FamilyRole = table.Column<string>(type: "text", nullable: false),
                    LivingStatus = table.Column<int>(type: "integer", nullable: false),
                    Debture = table.Column<int>(type: "integer", nullable: false),
                    ThingsILike = table.Column<string>(type: "text", nullable: false),
                    LogMethod = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_KeyIndicators", x => x.KeyId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_LogAuditSummary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateOfAudit = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    NameOfAuditor = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    AuditPeriodStart = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    AuditPeriodEnd = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    TotalClient = table.Column<int>(type: "integer", nullable: true),
                    TotalNoOfHappyClient = table.Column<int>(type: "integer", nullable: true),
                    TotalObjectMet = table.Column<int>(type: "integer", nullable: true),
                    TotalObjectNotMet = table.Column<int>(type: "integer", nullable: true),
                    TotalStaff = table.Column<int>(type: "integer", nullable: true),
                    StaffWithConcern = table.Column<int>(type: "integer", nullable: true),
                    ClientWithConcern = table.Column<int>(type: "integer", nullable: true),
                    NoOfClose = table.Column<int>(type: "integer", nullable: true),
                    NoOfOpen = table.Column<int>(type: "integer", nullable: true),
                    NoOfPending = table.Column<int>(type: "integer", nullable: true),
                    NoOfNoticIssueToStaff = table.Column<int>(type: "integer", nullable: true),
                    NoOfNoticIssueToClient = table.Column<int>(type: "integer", nullable: true),
                    selectedClient = table.Column<string>(type: "text", nullable: false),
                    selectedStaff = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    AuditClosingStatements = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    AuditDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NextAuditDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDelete = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_LogAuditSummary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_LogAuditTracke",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AuditRemarks = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    ActionRecommendation = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    EvidenceOfActionTaken = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    NameOfAuditor = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EmailAuditToClient = table.Column<bool>(type: "boolean", nullable: false),
                    EmailAuditToStaff = table.Column<bool>(type: "boolean", nullable: false),
                    ConcernWithStaff = table.Column<bool>(type: "boolean", maxLength: 50, nullable: false),
                    ConcertWithClient = table.Column<bool>(type: "boolean", nullable: false),
                    StaffRotaPeriodId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_LogAuditTracke", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MealIntake",
                columns: table => new
                {
                    MealIntakeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffRotaPeriodId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Dose = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MealIntake", x => x.MealIntakeId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Medication",
                columns: table => new
                {
                    MedicationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MedicationName = table.Column<string>(type: "character varying(225)", maxLength: 225, nullable: false),
                    Strength = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Indication = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Medication", x => x.MedicationId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MedicationAuditSummary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateOfAudit = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    NameOfAuditor = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    AuditPeriodStart = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    AuditPeriodEnd = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    TotalClient = table.Column<int>(type: "integer", nullable: true),
                    TotalStaff = table.Column<int>(type: "integer", nullable: true),
                    StaffWithConcern = table.Column<int>(type: "integer", nullable: true),
                    ClientWithConcern = table.Column<int>(type: "integer", nullable: true),
                    NoOfClose = table.Column<int>(type: "integer", nullable: true),
                    NoOfOpen = table.Column<int>(type: "integer", nullable: true),
                    NoOfPending = table.Column<int>(type: "integer", nullable: true),
                    NoOfGPContacted = table.Column<int>(type: "integer", nullable: true),
                    NoOfNoticIssueToStaff = table.Column<int>(type: "integer", nullable: true),
                    NoOfNoticIssueToClient = table.Column<int>(type: "integer", nullable: true),
                    selectedClient = table.Column<string>(type: "text", nullable: false),
                    selectedStaff = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    AuditClosingStatements = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    AuditDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NextAuditDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MedicationAuditSummary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MedicationAuditTracker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AuditRemarks = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    ActionRecommendation = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    ContactEstablishedWithGP = table.Column<bool>(type: "boolean", nullable: false),
                    StateDisuccGP = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    EvidenceOfActionTaken = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    NameOfAuditor = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EmailAuditToClient = table.Column<bool>(type: "boolean", nullable: false),
                    EmailAuditToStaff = table.Column<bool>(type: "boolean", nullable: false),
                    ConcernWithStaff = table.Column<bool>(type: "boolean", maxLength: 50, nullable: false),
                    ConcertWithClient = table.Column<bool>(type: "boolean", nullable: false),
                    StaffRotaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MedicationAuditTracker", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MedicationManufacturer",
                columns: table => new
                {
                    MedicationManufacturerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Manufacturer = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MedicationManufacturer", x => x.MedicationManufacturerId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MedicationRoute",
                columns: table => new
                {
                    MedicationRoutId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RouteName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MedicationRoute", x => x.MedicationRoutId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MedicationTrackerDelete",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    clientMedicationPeriodId = table.Column<int>(type: "integer", nullable: false),
                    StaffRotaId = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MedicationTrackerDelete", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MeetingLog",
                columns: table => new
                {
                    MeetingLogId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TimeOFMeeting = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TypeOfMeeting = table.Column<int>(type: "integer", nullable: false),
                    LocationOfMeeting = table.Column<string>(type: "text", nullable: false),
                    TimeAllocated = table.Column<string>(type: "text", nullable: false),
                    DeadLineForFeedback = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NextMeetingDueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ClosingRemark = table.Column<string>(type: "text", nullable: false),
                    NoteTakerContact = table.Column<string>(type: "text", nullable: false),
                    NoteTakerId = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MeetingLog", x => x.MeetingLogId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MeetingType",
                columns: table => new
                {
                    MeetingTypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MeetingName = table.Column<string>(type: "character varying(225)", maxLength: 225, nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MeetingType", x => x.MeetingTypeId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MentalHealthSupport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OftenNeedSupport = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    StaffPreference = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    DayAndTimeSuit = table.Column<bool>(type: "boolean", nullable: false),
                    MethodAndApproach = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    DoesNotWorkAndLike = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    WiderWorkHealthCare = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    SupportPlan = table.Column<bool>(type: "boolean", nullable: false),
                    EligibleSocialCare = table.Column<bool>(type: "boolean", nullable: false),
                    ImportantCloseThem = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    DoneInTheirLive = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    SomethingEnjoyed = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    DoThisAgain = table.Column<bool>(type: "boolean", nullable: false),
                    TowardTheirGoals = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Keyworker = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    PersonNameOrPhoto = table.Column<bool>(type: "boolean", nullable: false),
                    StrengthBases = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MentalHealthSupport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_OnlineClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_OnlineClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_OnlineLogQuestionResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OnlineTrainingId = table.Column<int>(type: "integer", nullable: false),
                    LogQuestionId = table.Column<int>(type: "integer", nullable: false),
                    BeforeAnswer = table.Column<string>(type: "text", nullable: false),
                    DuringAnswer = table.Column<string>(type: "text", nullable: false),
                    AfterAnswer = table.Column<string>(type: "text", nullable: false),
                    ObtainMark = table.Column<decimal>(type: "numeric", nullable: true),
                    staffId = table.Column<int>(type: "integer", nullable: true),
                    BundleId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_OnlineLogQuestionResults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_OnlineMaterialType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_OnlineMaterialType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_OnlineQuestionResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OnlineTrainingId = table.Column<int>(type: "integer", nullable: false),
                    QuestionId = table.Column<int>(type: "integer", nullable: false),
                    OptionId = table.Column<int>(type: "integer", nullable: false),
                    staffId = table.Column<int>(type: "integer", nullable: true),
                    BundleResultId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_OnlineQuestionResults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_OnlineTrainingAssignStaff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OnlineTrainingId = table.Column<int>(type: "integer", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ObtainMarks = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    EligibleForTest = table.Column<bool>(type: "boolean", nullable: false),
                    PaymentEvidence = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Comments = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_OnlineTrainingAssignStaff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_OnlineTrainingBundle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    Fee = table.Column<decimal>(type: "numeric", nullable: true),
                    IsPaid = table.Column<bool>(type: "boolean", nullable: false),
                    StripePaymentLinkId = table.Column<string>(type: "text", nullable: true),
                    StripeProductId = table.Column<string>(type: "text", nullable: true),
                    TrainingType = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_OnlineTrainingBundle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_OnlineTrainingBundleAssignStaff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OnlineTrainingBundleId = table.Column<int>(type: "integer", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    NoOfCompleteCourse = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    EligibleForTest = table.Column<bool>(type: "boolean", nullable: false),
                    PaymentEvidence = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Comments = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_OnlineTrainingBundleAssignStaff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_OralCare",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BurushTeeth = table.Column<bool>(type: "boolean", nullable: false),
                    RequireOralSupport = table.Column<bool>(type: "boolean", nullable: false),
                    ManyTimeClean = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    AssistedDentalAppointment = table.Column<bool>(type: "boolean", nullable: false),
                    AssistedWithOralCare = table.Column<bool>(type: "boolean", nullable: false),
                    AssistedWithDailyActivities = table.Column<bool>(type: "boolean", nullable: false),
                    AssistedWithCleaning = table.Column<bool>(type: "boolean", nullable: false),
                    AnyOralRelatedProblem = table.Column<bool>(type: "boolean", nullable: false),
                    AnyOralRelatedProblemDetail = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    ConfirmDentist = table.Column<bool>(type: "boolean", nullable: false),
                    ConfirmInvolingParties = table.Column<bool>(type: "boolean", nullable: false),
                    TrainingInAssessing = table.Column<bool>(type: "boolean", nullable: false),
                    LookIntoMouth = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    AnyBarriers = table.Column<bool>(type: "boolean", nullable: false),
                    AnyBarriersFinding = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Uncomfortable = table.Column<bool>(type: "boolean", nullable: false),
                    UncomfortableDetail = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    RecordOfMouthProduct = table.Column<bool>(type: "boolean", nullable: false),
                    SmallHeadedToothBrush = table.Column<bool>(type: "boolean", nullable: false),
                    ToothPaste = table.Column<bool>(type: "boolean", nullable: false),
                    Nonfoaming = table.Column<bool>(type: "boolean", nullable: false),
                    DryMouth = table.Column<bool>(type: "boolean", nullable: false),
                    DenturePot = table.Column<bool>(type: "boolean", nullable: false),
                    FoamEnded = table.Column<bool>(type: "boolean", nullable: false),
                    StoreProduct = table.Column<bool>(type: "boolean", nullable: false),
                    OtherMouthCareItems = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    WearDentures = table.Column<bool>(type: "boolean", nullable: false),
                    UpperDenture = table.Column<bool>(type: "boolean", nullable: false),
                    LowerDenture = table.Column<bool>(type: "boolean", nullable: false),
                    TypeDenturePot = table.Column<bool>(type: "boolean", nullable: false),
                    NoTeeth = table.Column<bool>(type: "boolean", nullable: false),
                    OtherTypes = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    DentureCleanAny = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    DenturePotLocated = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Summary = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_OralCare", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_PayrollSummary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", maxLength: 20, nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", maxLength: 20, nullable: true),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 450, nullable: false),
                    CategoryofStaff = table.Column<int>(type: "integer", nullable: true),
                    TypeofStaffService = table.Column<int>(type: "integer", nullable: true),
                    StaffClass = table.Column<int>(type: "integer", nullable: true),
                    Staff = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PayrollSummary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Personal",
                columns: table => new
                {
                    PersonalId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false),
                    Religion = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Nationality = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Smoking = table.Column<int>(type: "integer", nullable: false),
                    DNR = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Personal", x => x.PersonalId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_PettyCash",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Detail = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    MethodId = table.Column<int>(type: "integer", nullable: true),
                    Ammount = table.Column<decimal>(type: "numeric", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PettyCash", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_PettyCashHeading",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    IsMethod = table.Column<bool>(type: "boolean", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PettyCashHeading", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_PlannedDeduction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    DeductionId = table.Column<int>(type: "integer", nullable: false),
                    GrossAmount = table.Column<float>(type: "real", nullable: false),
                    AmountToDeduct = table.Column<int>(type: "integer", nullable: true),
                    PercentageOfGross = table.Column<string>(type: "text", nullable: true),
                    FromDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ToDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PlannedDeduction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_PlannedIncome",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    IncomeId = table.Column<int>(type: "integer", nullable: false),
                    GrossAmount = table.Column<float>(type: "real", nullable: false),
                    AmountToAdd = table.Column<int>(type: "integer", nullable: true),
                    PercentageOfGross = table.Column<string>(type: "text", nullable: true),
                    FromDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ToDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PlannedIncome", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Policies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Ref = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    PolicyOwner = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastReview = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Link = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    PolicyType = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Policies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Policy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PolicyName = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    PolicyURl = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Remark = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Attachment = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Policy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_RecentProject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    Progress = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_RecentProject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_RegisterDeduction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DeductionName = table.Column<string>(type: "text", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_RegisterDeduction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_RegisterIncome",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IncomeName = table.Column<string>(type: "text", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_RegisterIncome", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ReportedConcern",
                columns: table => new
                {
                    ReportedConcernId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReportedConcernType = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ReportedConcern", x => x.ReportedConcernId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Review",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CP_PreDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CP_ReviewDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CarePlanStatus = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    RA_PreDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RA_ReviewDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RisAssistmentStatus = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Review", x => x.ReviewId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Role",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_RotaDayofWeek",
                columns: table => new
                {
                    RotaDayofWeekId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DayofWeek = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_RotaDayofWeek", x => x.RotaDayofWeekId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_RotaPin",
                columns: table => new
                {
                    PinId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Pin = table.Column<int>(type: "integer", nullable: false),
                    Key = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_RotaPin", x => x.PinId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_RotaTask",
                columns: table => new
                {
                    RotaTaskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TaskName = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: false),
                    GivenAcronym = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    NotGivenAcronym = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Remark = table.Column<string>(type: "character varying(38)", maxLength: 38, nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_RotaTask", x => x.RotaTaskId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ServiceType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ServiceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ServiceWeek",
                columns: table => new
                {
                    ServiceWeekId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WeekName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ServiceWeek", x => x.ServiceWeekId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_SideMenu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    ControllerName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    ActionName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Icon = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    parentsId = table.Column<int>(type: "integer", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_SideMenu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffBundleCourseResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BundleId = table.Column<int>(type: "integer", nullable: false),
                    TrainingCourseId = table.Column<int>(type: "integer", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    ObtainMarks = table.Column<decimal>(type: "numeric", nullable: true),
                    IsEligibleForTest = table.Column<bool>(type: "boolean", nullable: false),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffBundleCourseResult", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffCommunication",
                columns: table => new
                {
                    StaffCommunicationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ValueDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Concern = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    CommunicationClass = table.Column<int>(type: "integer", nullable: false),
                    PersonInvolved = table.Column<int>(type: "integer", nullable: false),
                    ExpectedAction = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    ActionTaken = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Telephone = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    PersonResponsibleForAction = table.Column<int>(type: "integer", nullable: false),
                    Attachment = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffCommunication", x => x.StaffCommunicationId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffContract",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ContactId = table.Column<int>(type: "integer", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    Template = table.Column<string>(type: "text", nullable: false),
                    StaffSignature = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    StaffSignatureDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    HRSignature = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    HRSignatureDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffContract", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffMedRotaAudit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AuditRemarks = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    ActionRecommendation = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    ContactEstablishedWithGP = table.Column<bool>(type: "boolean", nullable: false),
                    StateDisuccGP = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    EvidenceOfActionTaken = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    NameOfAuditor = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EmailAuditToClient = table.Column<bool>(type: "boolean", nullable: false),
                    EmailAuditToStaff = table.Column<bool>(type: "boolean", nullable: false),
                    ConcernWithStaff = table.Column<bool>(type: "boolean", maxLength: 50, nullable: false),
                    ConcertWithClient = table.Column<bool>(type: "boolean", nullable: false),
                    StaffRotaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffMedRotaAudit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffMedTracker",
                columns: table => new
                {
                    StaffMedTrackerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MedTrackDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    RotaId = table.Column<int>(type: "integer", nullable: false),
                    ClientMedId = table.Column<int>(type: "integer", nullable: false),
                    DoseGiven = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffMedTracker", x => x.StaffMedTrackerId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffPayRollSetting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FixedAmount = table.Column<decimal>(type: "numeric", nullable: false),
                    FixedAmountTypeId = table.Column<int>(type: "integer", nullable: false),
                    StaffRateTypeId = table.Column<int>(type: "integer", nullable: false),
                    CategoryOfStaffId = table.Column<int>(type: "integer", nullable: false),
                    TypeOfStaffServiceId = table.Column<int>(type: "integer", nullable: false),
                    ClassOfStaffId = table.Column<int>(type: "integer", nullable: false),
                    TeamOfStaffId = table.Column<int>(type: "integer", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    MinHr = table.Column<decimal>(type: "numeric", nullable: true),
                    MaxHr = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffPayRollSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffPerformanceSummary",
                columns: table => new
                {
                    SummaryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartDate = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    StopDate = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    WithoutJob = table.Column<int>(type: "integer", nullable: true),
                    NoOfPerformance = table.Column<string>(type: "text", nullable: false),
                    Feedback = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    IsClientSummary = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffPerformanceSummary", x => x.SummaryId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffRotaForceRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffRotaPeriodId = table.Column<int>(type: "integer", nullable: true),
                    forcedEntry = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    reasonExceeding = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Signature = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    UpcomingplannedTask = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffRotaForceRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffRotaMedAuditSummary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateOfAudit = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    NameOfAuditor = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    AuditPeriodStart = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    AuditPeriodEnd = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    TotalClient = table.Column<int>(type: "integer", nullable: true),
                    TotalStaff = table.Column<int>(type: "integer", nullable: true),
                    StaffWithConcern = table.Column<int>(type: "integer", nullable: true),
                    ClientWithConcern = table.Column<int>(type: "integer", nullable: true),
                    NoOfClose = table.Column<int>(type: "integer", nullable: true),
                    NoOfOpen = table.Column<int>(type: "integer", nullable: true),
                    NoOfPending = table.Column<int>(type: "integer", nullable: true),
                    NoOfGPContacted = table.Column<int>(type: "integer", nullable: true),
                    NoOfNoticIssueToStaff = table.Column<int>(type: "integer", nullable: true),
                    NoOfNoticIssueToClient = table.Column<int>(type: "integer", nullable: true),
                    AuditClosingStatements = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffRotaMedAuditSummary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Territory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Territory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_TrackingConcernNote",
                columns: table => new
                {
                    Ref = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ConcernNote = table.Column<string>(type: "text", nullable: false),
                    ActionRequired = table.Column<string>(type: "text", nullable: false),
                    DateOfIncident = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ExpectedDeadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    StaffNotify = table.Column<int>(type: "integer", nullable: false),
                    ManagerCopied = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    Attachment = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_TrackingConcernNote", x => x.Ref);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Training",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Topic = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    TrainingURl = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Trainer = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Remark = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Attachment = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Training", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_TrainingRequirement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Notes = table.Column<string>(type: "character varying(1052)", maxLength: 1052, nullable: false),
                    KeyName = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_TrainingRequirement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_TypeOfStaffService",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ServiceName = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_TypeOfStaffService", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Untowards",
                columns: table => new
                {
                    UntowardsId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TicketNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Subject = table.Column<string>(type: "character varying(225)", maxLength: 225, nullable: false),
                    TimeOfCall = table.Column<TimeSpan>(type: "interval", nullable: true),
                    PersonReporting = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    PersonReportingTelephone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    PersonReportingEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Details = table.Column<string>(type: "text", nullable: false),
                    ActionRequired = table.Column<string>(type: "text", nullable: false),
                    ActionTaken = table.Column<string>(type: "text", nullable: false),
                    ActionStatus = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Priority = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false),
                    ExpectedDateAndTimeOfFeedback = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IncidentType = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Untowards", x => x.UntowardsId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_UpcomingMeeting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MeetingDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CalledBy = table.Column<int>(type: "integer", nullable: false),
                    Location = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<TimeSpan>(type: "interval", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_UpcomingMeeting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Whisttle_Blower",
                columns: table => new
                {
                    WhisttleBlowerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    PersonReportingName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    IncidentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Happening = table.Column<string>(type: "text", nullable: false),
                    IsThereWitness = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    WitnessDetail = table.Column<string>(type: "text", nullable: false),
                    LikeCalling = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    PhoneNo = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Status = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Image = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    ActionTaken = table.Column<string>(type: "text", nullable: false),
                    CandourAction = table.Column<string>(type: "text", nullable: false),
                    ReferenceNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    NameOfHandlingPerson = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    NameOfHandlingPersonTel = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    IncidentType = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Whisttle_Blower", x => x.WhisttleBlowerId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_AppointmentBookingAttendees",
                columns: table => new
                {
                    AppointmentBookingAttendeesId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AttendeesId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false),
                    AppointmentBookingId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_AppointmentBookingAttendees", x => x.AppointmentBookingAttendeesId);
                    table.ForeignKey(
                        name: "FK_tbl_AppointmentBookingAttendees_tbl_AppointmentBooking_Appo~",
                        column: x => x.AppointmentBookingId,
                        principalTable: "tbl_AppointmentBooking",
                        principalColumn: "AppointmentBookingId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_BaseRecordItem",
                columns: table => new
                {
                    BaseRecordItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    BaseRecordId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false),
                    ValueName = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BaseRecordItem", x => x.BaseRecordItemId);
                    table.ForeignKey(
                        name: "FK_tbl_BaseRecordItem_tbl_BaseRecord_BaseRecordId",
                        column: x => x.BaseRecordId,
                        principalTable: "tbl_BaseRecord",
                        principalColumn: "BaseRecordId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BaseRecordItem_Model",
                columns: table => new
                {
                    BaseRecordItemId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BaseRecordId = table.Column<int>(type: "integer", nullable: false),
                    ValueName = table.Column<string>(type: "text", nullable: false),
                    HasGoogleForm = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    AddLink = table.Column<string>(type: "text", nullable: true),
                    ViewLink = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    ExpiryInMonths = table.Column<int>(type: "integer", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BaseRecordItem_Model", x => x.BaseRecordItemId);
                    table.ForeignKey(
                        name: "FK_tbl_BaseRecordItem_Model_tbl_BaseRecord_Model_BaseRecordId",
                        column: x => x.BaseRecordId,
                        principalTable: "tbl_BaseRecord_Model",
                        principalColumn: "BaseRecordId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CapacityIndicator",
                columns: table => new
                {
                    CapacityIndicatorId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CapacityId = table.Column<int>(type: "integer", nullable: false),
                    BaseRecordId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CapacityIndicator", x => x.CapacityIndicatorId);
                    table.ForeignKey(
                        name: "FK_tbl_CapacityIndicator_tbl_Capacity_CapacityId",
                        column: x => x.CapacityId,
                        principalTable: "tbl_Capacity",
                        principalColumn: "CapacityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientInvoice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InvoiceDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    InvoiceNo = table.Column<long>(type: "bigint", nullable: false),
                    InvoiceNoWithMonth = table.Column<string>(type: "text", nullable: false),
                    BillTo = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    TypeOfService = table.Column<int>(type: "integer", nullable: true),
                    PeriodType = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Credit = table.Column<decimal>(type: "numeric", nullable: true),
                    Charges = table.Column<decimal>(type: "numeric", nullable: true),
                    Total = table.Column<decimal>(type: "numeric", nullable: true),
                    ClientInvoiceSummaryId = table.Column<int>(type: "integer", nullable: false),
                    ClienBillToId = table.Column<int>(type: "integer", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientInvoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_ClientInvoice_tbl_ClientInvoiceSummary_ClientInvoiceSum~",
                        column: x => x.ClientInvoiceSummaryId,
                        principalTable: "tbl_ClientInvoiceSummary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffRota",
                columns: table => new
                {
                    StaffRotaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RotaDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RotaDayofWeekId = table.Column<int>(type: "integer", nullable: true),
                    Staff = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    RotaId = table.Column<int>(type: "integer", nullable: true),
                    Remark = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    ReferenceNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffRota", x => x.StaffRotaId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffRota_tbl_ClientRotaName_RotaId",
                        column: x => x.RotaId,
                        principalTable: "tbl_ClientRotaName",
                        principalColumn: "RotaId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CommunicationLogApologies",
                columns: table => new
                {
                    CommunicationLogApologiesId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApologiesId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false),
                    CommunicationLogId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CommunicationLogApologies", x => x.CommunicationLogApologiesId);
                    table.ForeignKey(
                        name: "FK_tbl_CommunicationLogApologies_tbl_CommunicationLog_Communic~",
                        column: x => x.CommunicationLogId,
                        principalTable: "tbl_CommunicationLog",
                        principalColumn: "CommunicationLogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CommunicationLogAttendees",
                columns: table => new
                {
                    CommunicationLogAttendeesId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AttendeesId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false),
                    CommunicationLogId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CommunicationLogAttendees", x => x.CommunicationLogAttendeesId);
                    table.ForeignKey(
                        name: "FK_tbl_CommunicationLogAttendees_tbl_CommunicationLog_Communic~",
                        column: x => x.CommunicationLogId,
                        principalTable: "tbl_CommunicationLog",
                        principalColumn: "CommunicationLogId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CandidateInterview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    JobPositionId = table.Column<int>(type: "integer", nullable: false),
                    PassingPercentage = table.Column<decimal>(type: "numeric", nullable: true),
                    ObtainPercentage = table.Column<decimal>(type: "numeric", nullable: true),
                    Status = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Comment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    InterviewDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    InterviwerStaff = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CandidateSignature = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    InterviewType = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CandidateInterview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CandidateInterview_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CareobjectMonitor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Month = table.Column<int>(type: "integer", nullable: true),
                    Year = table.Column<int>(type: "integer", nullable: true),
                    Day = table.Column<int>(type: "integer", nullable: true),
                    DateOfCare = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CareobjectMonitor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CareobjectMonitor_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_chatNotification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FromUserId = table.Column<string>(type: "text", nullable: false),
                    ToUserId = table.Column<string>(type: "text", nullable: false),
                    Notification = table.Column<string>(type: "text", nullable: false),
                    NotifyTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_chatNotification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_chatNotification_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_chatsupport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FromUserId = table.Column<string>(type: "text", nullable: false),
                    ChatType = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_chatsupport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_chatsupport_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ChatSupportAssignedStaff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ToUserId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ChatSupportId = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ChatSupportAssignedStaff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_ChatSupportAssignedStaff_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_MealType",
                columns: table => new
                {
                    ClientMealTypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MealType = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_MealType", x => x.ClientMealTypeId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_MealType_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientCareDetailsHeading",
                columns: table => new
                {
                    ClientCareDetailsHeadingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Heading = table.Column<string>(type: "character varying(225)", maxLength: 225, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientCareDetailsHeading", x => x.ClientCareDetailsHeadingId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientCareDetailsHeading_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientChat",
                columns: table => new
                {
                    ChatId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReceiverId = table.Column<int>(type: "integer", nullable: false),
                    SenderId = table.Column<int>(type: "integer", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: false),
                    Dated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientChat", x => x.ChatId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientChat_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientFacility",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    RegistrationType = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    Address = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    PhoneNumber = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    Email = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    Website = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    BusinessType = table.Column<int>(type: "integer", nullable: false),
                    FacilityManagerName = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    FacilityManagerEmail = table.Column<string>(type: "text", nullable: false),
                    FacilityManagerPhoneNumber = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    NumberOfRooms = table.Column<int>(type: "integer", nullable: false),
                    FacilityType = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    Description = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    Profile = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    ServiceObjective = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    AccessCodeNumber = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    GenderId = table.Column<int>(type: "integer", nullable: false),
                    Latitude = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Longitude = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IdNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    AboutClient = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    HourRate = table.Column<decimal>(type: "numeric", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientFacility", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_ClientFacility_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientPerformanceIndicator",
                columns: table => new
                {
                    PerformanceIndicatorId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Heading = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    StaffSignature = table.Column<string>(type: "text", nullable: false),
                    ManagerSignature = table.Column<string>(type: "text", nullable: false),
                    ClientSignature = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientPerformanceIndicator", x => x.PerformanceIndicatorId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientPerformanceIndicator_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientServiceDetail",
                columns: table => new
                {
                    ClientServiceDetailId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    AmountGiven = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    AmountReturned = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    ServiceDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientServiceDetail", x => x.ClientServiceDetailId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientServiceDetail_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientSupportPlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MentalHealth = table.Column<string>(type: "text", nullable: false),
                    SocialCareNeeds = table.Column<string>(type: "text", nullable: false),
                    AccessCommunity = table.Column<string>(type: "text", nullable: false),
                    Reltaionship = table.Column<string>(type: "text", nullable: false),
                    HabitateHomeEnvironment = table.Column<string>(type: "text", nullable: false),
                    PersonalHygiene = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientSupportPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_ClientSupportPlan_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CompanyBank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BankName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Title = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    AccountNo = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    TransitNo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    InstitudionNo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    SortCode = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    IsUKBank = table.Column<bool>(type: "boolean", nullable: false),
                    IsOperating = table.Column<bool>(type: "boolean", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 450, nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CompanyBank", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CompanyBank_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_createshift",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleAndNumber = table.Column<string>(type: "text", nullable: false),
                    IsFreeAccomodation = table.Column<bool>(type: "boolean", nullable: false),
                    RatePerHour = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_createshift", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_createshift_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Expenselog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EexpenseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ReferenceNo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    ItemOfPurchase = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    AmountGivenAdvance = table.Column<decimal>(type: "numeric", nullable: true),
                    ReturnBalance = table.Column<decimal>(type: "numeric", nullable: true),
                    ProofOfPurchase = table.Column<string>(type: "text", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LocationOfPurchase = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    ReceiptNo = table.Column<string>(type: "character varying(124)", maxLength: 124, nullable: false),
                    WhoApproved = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    Remarks = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 450, nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Expenselog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Expenselog_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Inbox",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FromUserId = table.Column<string>(type: "text", nullable: false),
                    ToUserId = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Inbox", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Inbox_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_InterviewQuestion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Question = table.Column<string>(type: "text", nullable: false),
                    IsMandatory = table.Column<bool>(type: "boolean", nullable: false),
                    JobPosition = table.Column<int>(type: "integer", nullable: false),
                    Marks = table.Column<decimal>(type: "numeric", nullable: true),
                    PassingMarks = table.Column<decimal>(type: "numeric", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    InterviewType = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_InterviewQuestion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_InterviewQuestion_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Investigation",
                columns: table => new
                {
                    InvestigationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    IncidentClass = table.Column<int>(type: "integer", nullable: false),
                    Remark = table.Column<string>(type: "text", nullable: false),
                    IncidentDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ConclusionDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Investigation", x => x.InvestigationId);
                    table.ForeignKey(
                        name: "FK_tbl_Investigation_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_PerformanceIndicator",
                columns: table => new
                {
                    PerformanceIndicatorId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Heading = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PerformanceIndicator", x => x.PerformanceIndicatorId);
                    table.ForeignKey(
                        name: "FK_tbl_PerformanceIndicator_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_staffalert",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Heading = table.Column<string>(type: "text", nullable: false),
                    IsSet = table.Column<bool>(type: "boolean", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    TimeDuration = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_staffalert", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_staffalert_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffIncidentReporting",
                columns: table => new
                {
                    StaffIncidentReportingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReportingStaffId = table.Column<int>(type: "integer", nullable: true),
                    StaffInvolvedId = table.Column<int>(type: "integer", nullable: false),
                    IncidentDetails = table.Column<string>(type: "text", nullable: false),
                    ActionTaken = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    Witness = table.Column<string>(type: "text", nullable: true),
                    Attachment = table.Column<string>(type: "text", nullable: true),
                    LoggedById = table.Column<string>(type: "character varying(225)", maxLength: 225, nullable: false),
                    IncidentType = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Status = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    LoggedDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffIncidentReporting", x => x.StaffIncidentReportingId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffIncidentReporting_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffRotaDynamicAddition",
                columns: table => new
                {
                    StaffRotaDynamicAdditionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffRotaDynamicAddition", x => x.StaffRotaDynamicAdditionId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffRotaDynamicAddition_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_DeductionValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DeductionForAllStaffId = table.Column<int>(type: "integer", nullable: false),
                    DeductionType = table.Column<int>(type: "integer", nullable: false),
                    DeductionAmount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DeductionValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_DeductionValue_tbl_DeductionForAllStaff_DeductionForAll~",
                        column: x => x.DeductionForAllStaffId,
                        principalTable: "tbl_DeductionForAllStaff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_EmailMessageUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmailMessageId = table.Column<int>(type: "integer", nullable: false),
                    StaffId = table.Column<int>(type: "integer", nullable: true),
                    IncludeCC = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_EmailMessageUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_EmailMessageUser_tbl_EmailMessage_EmailMessageId",
                        column: x => x.EmailMessageId,
                        principalTable: "tbl_EmailMessage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ExternalRoleAccessClient",
                columns: table => new
                {
                    ExternalRoleAccessClientId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExternalAccessId = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ExternalRoleAccessClient", x => x.ExternalRoleAccessClientId);
                    table.ForeignKey(
                        name: "FK_tbl_ExternalRoleAccessClient_tbl_ExternalRoleAccess_Externa~",
                        column: x => x.ExternalAccessId,
                        principalTable: "tbl_ExternalRoleAccess",
                        principalColumn: "ExternalAccessId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ExternalRoleAccessStaff",
                columns: table => new
                {
                    ExternalRoleAccessStaffId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExternalAccessId = table.Column<int>(type: "integer", nullable: false),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ExternalRoleAccessStaff", x => x.ExternalRoleAccessStaffId);
                    table.ForeignKey(
                        name: "FK_tbl_ExternalRoleAccessStaff_tbl_ExternalRoleAccess_External~",
                        column: x => x.ExternalAccessId,
                        principalTable: "tbl_ExternalRoleAccess",
                        principalColumn: "ExternalAccessId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_IncomeValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IncomeForAllStaffId = table.Column<int>(type: "integer", nullable: false),
                    IncomeType = table.Column<int>(type: "integer", nullable: false),
                    IncomeAmount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_IncomeValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_IncomeValue_tbl_IncomeForAllStaff_IncomeForAllStaffId",
                        column: x => x.IncomeForAllStaffId,
                        principalTable: "tbl_IncomeForAllStaff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffPerformanceHeading",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    JobPositionId = table.Column<int>(type: "integer", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    IsClientHeading = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffPerformanceHeading", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_StaffPerformanceHeading_tbl_JobPosition_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "tbl_JobPosition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_KeyIndicatorLog",
                columns: table => new
                {
                    KeyIndicatorLogId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KeyId = table.Column<int>(type: "integer", nullable: false),
                    BaseRecordId = table.Column<int>(type: "integer", nullable: false),
                    KeyIndicatorsKeyId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_KeyIndicatorLog", x => x.KeyIndicatorLogId);
                    table.ForeignKey(
                        name: "FK_tbl_KeyIndicatorLog_tbl_KeyIndicators_KeyIndicatorsKeyId",
                        column: x => x.KeyIndicatorsKeyId,
                        principalTable: "tbl_KeyIndicators",
                        principalColumn: "KeyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MeetingActionableItem",
                columns: table => new
                {
                    MeetingActionableItemId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MeetingLogId = table.Column<int>(type: "integer", nullable: false),
                    ActionableItem = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MeetingActionableItem", x => x.MeetingActionableItemId);
                    table.ForeignKey(
                        name: "FK_tbl_MeetingActionableItem_tbl_MeetingLog_MeetingLogId",
                        column: x => x.MeetingLogId,
                        principalTable: "tbl_MeetingLog",
                        principalColumn: "MeetingLogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MeetingAgenda",
                columns: table => new
                {
                    MeetingAgendaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MeetingLogId = table.Column<int>(type: "integer", nullable: false),
                    Agenda = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MeetingAgenda", x => x.MeetingAgendaId);
                    table.ForeignKey(
                        name: "FK_tbl_MeetingAgenda_tbl_MeetingLog_MeetingLogId",
                        column: x => x.MeetingLogId,
                        principalTable: "tbl_MeetingLog",
                        principalColumn: "MeetingLogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MeetingDiscussions",
                columns: table => new
                {
                    MeetingDiscussionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MeetingLogId = table.Column<int>(type: "integer", nullable: false),
                    Discussion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MeetingDiscussions", x => x.MeetingDiscussionId);
                    table.ForeignKey(
                        name: "FK_tbl_MeetingDiscussions_tbl_MeetingLog_MeetingLogId",
                        column: x => x.MeetingLogId,
                        principalTable: "tbl_MeetingLog",
                        principalColumn: "MeetingLogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_OnlineTraning",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClassId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    Duration = table.Column<TimeSpan>(type: "interval", nullable: true),
                    Author = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    MaterialId = table.Column<int>(type: "integer", nullable: true),
                    Video = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    Attachment = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    PassingMarks = table.Column<int>(type: "integer", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    IsPaid = table.Column<bool>(type: "boolean", nullable: false),
                    Fee = table.Column<decimal>(type: "numeric", nullable: true),
                    RenewalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsHasLogQuestion = table.Column<bool>(type: "boolean", nullable: false),
                    PaymentURL = table.Column<string>(type: "text", nullable: false),
                    StripePaymentLinkId = table.Column<string>(type: "text", nullable: true),
                    StripeProductId = table.Column<string>(type: "text", nullable: true),
                    AuthorSignature = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    TrainingType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_OnlineTraning", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_OnlineTraning_tbl_OnlineClass_ClassId",
                        column: x => x.ClassId,
                        principalTable: "tbl_OnlineClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_OnlineTraning_tbl_OnlineMaterialType_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "tbl_OnlineMaterialType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_PettyCashUsage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Detail = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ReceiptNo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Data = table.Column<string>(type: "text", nullable: false),
                    Total = table.Column<decimal>(type: "numeric", nullable: true),
                    PettyCashId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PettyCashUsage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_PettyCashUsage_tbl_PettyCash_PettyCashId",
                        column: x => x.PettyCashId,
                        principalTable: "tbl_PettyCash",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_RoleClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_RoleClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_RoleClaim_tbl_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "tbl_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffPerformance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffId = table.Column<int>(type: "integer", nullable: true),
                    Data = table.Column<string>(type: "text", nullable: false),
                    TotalObtain = table.Column<int>(type: "integer", nullable: true),
                    Expectation = table.Column<int>(type: "integer", nullable: true),
                    Rating = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    Remarks = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    PositionId = table.Column<int>(type: "integer", nullable: true),
                    PerformanceSummaryId = table.Column<int>(type: "integer", nullable: false),
                    ClientId1 = table.Column<int>(type: "integer", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffPerformance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_StaffPerformance_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_tbl_StaffPerformance_tbl_StaffPerformanceSummary_Performanc~",
                        column: x => x.PerformanceSummaryId,
                        principalTable: "tbl_StaffPerformanceSummary",
                        principalColumn: "SummaryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientInvoiceRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    FromDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ToDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Number = table.Column<decimal>(type: "numeric", nullable: true),
                    Notes = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    ClientInvoiceId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientInvoiceRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_ClientInvoiceRecords_tbl_ClientInvoice_ClientInvoiceId",
                        column: x => x.ClientInvoiceId,
                        principalTable: "tbl_ClientInvoice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffRotaItem",
                columns: table => new
                {
                    StaffRotaItemId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffRotaId = table.Column<int>(type: "integer", nullable: false),
                    StaffRotaDynamicAdditionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffRotaItem", x => x.StaffRotaItemId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffRotaItem_tbl_StaffRota_StaffRotaId",
                        column: x => x.StaffRotaId,
                        principalTable: "tbl_StaffRota",
                        principalColumn: "StaffRotaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffRotaPartner",
                columns: table => new
                {
                    StaffRotaPartnerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffRotaId = table.Column<int>(type: "integer", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffRotaPartner", x => x.StaffRotaPartnerId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffRotaPartner_tbl_StaffRota_StaffRotaId",
                        column: x => x.StaffRotaId,
                        principalTable: "tbl_StaffRota",
                        principalColumn: "StaffRotaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffRotaPeriod",
                columns: table => new
                {
                    StaffRotaPeriodId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffRotaId = table.Column<int>(type: "integer", nullable: false),
                    ClientRotaTypeId = table.Column<int>(type: "integer", nullable: false),
                    ClockInTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    ClockOutTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    ClockInAddress = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    ClockOutAddress = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    ClockInDistance = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ClockOutDistance = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ClockInCount = table.Column<int>(type: "integer", nullable: true),
                    ClockOutCount = table.Column<int>(type: "integer", nullable: true),
                    ClockInGeolocation = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    ClockOutGeolocation = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Feedback = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    Comment = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    HandOver = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    ClockInMode = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    ClockOutMode = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    ClockInClientTelephone = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ClockOutClientTelephone = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    StartTime = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    StopTime = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    BowelMovement = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    OralCare = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    FluidIntake = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    MealIntake = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    BodyMap = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    OtherTask = table.Column<bool>(type: "boolean", nullable: false),
                    ObjectiveOfCareMeet = table.Column<bool>(type: "boolean", nullable: false),
                    ClientHappyWithServiceOrStaff = table.Column<bool>(type: "boolean", nullable: false),
                    LatenessComments = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Certify = table.Column<bool>(type: "boolean", nullable: false),
                    NotifyManager = table.Column<bool>(type: "boolean", nullable: false),
                    RaseConcern = table.Column<bool>(type: "boolean", nullable: false),
                    forcedEntry = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    forcedExit = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    reasonExceeding = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Signature = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    UpcomingplannedTask = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    IsDelete = table.Column<bool>(type: "boolean", nullable: false),
                    AlertComment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Response = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffRotaPeriod", x => x.StaffRotaPeriodId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffRotaPeriod_tbl_ClientRotaType_ClientRotaTypeId",
                        column: x => x.ClientRotaTypeId,
                        principalTable: "tbl_ClientRotaType",
                        principalColumn: "ClientRotaTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_StaffRotaPeriod_tbl_StaffRota_StaffRotaId",
                        column: x => x.StaffRotaId,
                        principalTable: "tbl_StaffRota",
                        principalColumn: "StaffRotaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_chatsupportconversation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FromUserId = table.Column<string>(type: "text", nullable: true),
                    ToUserId = table.Column<string>(type: "text", nullable: true),
                    ChatSupportId = table.Column<int>(type: "integer", nullable: false),
                    Message = table.Column<string>(type: "character varying(1025)", maxLength: 1025, nullable: false),
                    FilePath = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: true),
                    SessionId = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    OpenTokToken = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsByStaff = table.Column<bool>(type: "boolean", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_chatsupportconversation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_chatsupportconversation_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_tbl_chatsupportconversation_tbl_chatsupport_ChatSupportId",
                        column: x => x.ChatSupportId,
                        principalTable: "tbl_chatsupport",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientCareDetailsTask",
                columns: table => new
                {
                    ClientCareDetailsTaskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientCareDetailsHeadingId = table.Column<int>(type: "integer", nullable: false),
                    Task = table.Column<string>(type: "character varying(225)", maxLength: 225, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientCareDetailsTask", x => x.ClientCareDetailsTaskId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientCareDetailsTask_tbl_ClientCareDetailsHeading_Clie~",
                        column: x => x.ClientCareDetailsHeadingId,
                        principalTable: "tbl_ClientCareDetailsHeading",
                        principalColumn: "ClientCareDetailsHeadingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_ClientCareDetailsTask_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client",
                columns: table => new
                {
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    Pin = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Firstname = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Middlename = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Surname = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    PreferredName = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Email = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    About = table.Column<string>(type: "text", nullable: false),
                    Hobbies = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    KeyworkerId = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    IdNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    NumberOfCalls = table.Column<int>(type: "integer", nullable: true),
                    AreaCodeId = table.Column<int>(type: "integer", nullable: true),
                    TeritoryId = table.Column<int>(type: "integer", nullable: true),
                    ServiceType = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ProvisionVenue = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    PostCode = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Rate = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    TeamLeader = table.Column<string>(type: "character varying(38)", maxLength: 38, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Telephone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Language = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    KeySafe = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ChoiceOfStaff = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    Capacity = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ProviderReference = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    NumberOfStaff = table.Column<int>(type: "integer", nullable: true),
                    UniqueId = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProfileImage = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Address = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Latitude = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Longitude = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ClientManager = table.Column<string>(type: "character varying(38)", maxLength: 38, nullable: false),
                    Denture = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Aid = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    LocationDistance = table.Column<double>(type: "double precision", nullable: true, defaultValue: 0.01),
                    TimeMonitorLower = table.Column<int>(type: "integer", nullable: true),
                    TimeMonitorHigher = table.Column<int>(type: "integer", nullable: true),
                    PracticalSupport = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    CallGap = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    IsDelete = table.Column<bool>(type: "boolean", nullable: false),
                    IsFacilityClient = table.Column<bool>(type: "boolean", nullable: false),
                    ClientFacilityId = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client", x => x.ClientId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_tbl_AreaCode_AreaCodeId",
                        column: x => x.AreaCodeId,
                        principalTable: "tbl_AreaCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_Client_tbl_ClientFacility_ClientFacilityId",
                        column: x => x.ClientFacilityId,
                        principalTable: "tbl_ClientFacility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Client_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_tbl_Client_tbl_Territory_TeritoryId",
                        column: x => x.TeritoryId,
                        principalTable: "tbl_Territory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientFacilityRisk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Question = table.Column<string>(type: "text", nullable: false),
                    Answer = table.Column<string>(type: "text", nullable: false),
                    Attachment = table.Column<string>(type: "text", nullable: false),
                    FacilityClientId = table.Column<int>(type: "integer", nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientFacilityRisk", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_ClientFacilityRisk_tbl_ClientFacility_FacilityClientId",
                        column: x => x.FacilityClientId,
                        principalTable: "tbl_ClientFacility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_ClientFacilityRisk_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientFacilityTask",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Location = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    BeforePerformingTask = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    HowToTaskPerform = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    RiskAssociated = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    HowToMigitate = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    WhatToDoAfterTaskCompleting = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    Picture = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Video = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    FacilityClientId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientFacilityTask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_ClientFacilityTask_tbl_ClientFacility_FacilityClientId",
                        column: x => x.FacilityClientId,
                        principalTable: "tbl_ClientFacility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientPerformanceIndicatorTask",
                columns: table => new
                {
                    PerformanceIndicatorTaskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffCompetenceTestId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<int>(type: "integer", nullable: false),
                    Score = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientPerformanceIndicatorTask", x => x.PerformanceIndicatorTaskId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientPerformanceIndicatorTask_tbl_ClientPerformanceInd~",
                        column: x => x.StaffCompetenceTestId,
                        principalTable: "tbl_ClientPerformanceIndicator",
                        principalColumn: "PerformanceIndicatorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientServiceDetailItem",
                columns: table => new
                {
                    ClientServiceDetailItemId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientServiceDetailId = table.Column<int>(type: "integer", nullable: false),
                    ItemName = table.Column<string>(type: "character varying(225)", maxLength: 225, nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Rate = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientServiceDetailItem", x => x.ClientServiceDetailItemId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientServiceDetailItem_tbl_ClientServiceDetail_ClientS~",
                        column: x => x.ClientServiceDetailId,
                        principalTable: "tbl_ClientServiceDetail",
                        principalColumn: "ClientServiceDetailId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_ClientServiceDetailItem_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientServiceDetailReceipt",
                columns: table => new
                {
                    ClientServiceDetailReceiptId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientServiceDetailId = table.Column<int>(type: "integer", nullable: false),
                    Attachment = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientServiceDetailReceipt", x => x.ClientServiceDetailReceiptId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientServiceDetailReceipt_tbl_ClientServiceDetail_Clie~",
                        column: x => x.ClientServiceDetailId,
                        principalTable: "tbl_ClientServiceDetail",
                        principalColumn: "ClientServiceDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientSupportPlanGoal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientSupportPlanId = table.Column<int>(type: "integer", nullable: false),
                    Goal = table.Column<string>(type: "text", nullable: false),
                    Important = table.Column<string>(type: "text", nullable: false),
                    Help = table.Column<string>(type: "text", nullable: false),
                    Success = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientSupportPlanGoal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_ClientSupportPlanGoal_tbl_ClientSupportPlan_ClientSuppo~",
                        column: x => x.ClientSupportPlanId,
                        principalTable: "tbl_ClientSupportPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_conversation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FromUserId = table.Column<string>(type: "text", nullable: false),
                    ToUserId = table.Column<string>(type: "text", nullable: false),
                    InboxId = table.Column<int>(type: "integer", nullable: false),
                    Message = table.Column<string>(type: "character varying(1025)", maxLength: 1025, nullable: false),
                    FilePath = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: true),
                    SessionId = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    OpenTokToken = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_conversation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_conversation_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_tbl_conversation_tbl_Inbox_InboxId",
                        column: x => x.InboxId,
                        principalTable: "tbl_Inbox",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_InvestigationAttachment",
                columns: table => new
                {
                    InvestigationAttachmentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InvestigationId = table.Column<int>(type: "integer", nullable: false),
                    Attachment = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_InvestigationAttachment", x => x.InvestigationAttachmentId);
                    table.ForeignKey(
                        name: "FK_tbl_InvestigationAttachment_tbl_Investigation_Investigation~",
                        column: x => x.InvestigationId,
                        principalTable: "tbl_Investigation",
                        principalColumn: "InvestigationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_PerformanceIndicatorTask",
                columns: table => new
                {
                    PerformanceIndicatorTaskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffCompetenceTestId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<int>(type: "integer", nullable: false),
                    Score = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PerformanceIndicatorTask", x => x.PerformanceIndicatorTaskId);
                    table.ForeignKey(
                        name: "FK_tbl_PerformanceIndicatorTask_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_tbl_PerformanceIndicatorTask_tbl_PerformanceIndicator_Staff~",
                        column: x => x.StaffCompetenceTestId,
                        principalTable: "tbl_PerformanceIndicator",
                        principalColumn: "PerformanceIndicatorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_staffalertcountmatrix",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffAlertId = table.Column<int>(type: "integer", nullable: false),
                    Missed = table.Column<int>(type: "integer", nullable: false),
                    Expired = table.Column<int>(type: "integer", nullable: false),
                    AboutToExpired = table.Column<int>(type: "integer", nullable: false),
                    TotalCouts = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_staffalertcountmatrix", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_staffalertcountmatrix_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_tbl_staffalertcountmatrix_tbl_staffalert_StaffAlertId",
                        column: x => x.StaffAlertId,
                        principalTable: "tbl_staffalert",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_OnlineTrainingBundleCourse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OnlineTrainingBundleId = table.Column<int>(type: "integer", nullable: false),
                    OnlineTraningId = table.Column<int>(type: "integer", nullable: false),
                    OnlineTraningId1 = table.Column<int>(type: "integer", nullable: false),
                    StaffBundleCourseResultId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_OnlineTrainingBundleCourse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_OnlineTrainingBundleCourse_tbl_OnlineTrainingBundle_Onl~",
                        column: x => x.OnlineTrainingBundleId,
                        principalTable: "tbl_OnlineTrainingBundle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_OnlineTrainingBundleCourse_tbl_OnlineTraning_OnlineTran~",
                        column: x => x.OnlineTraningId1,
                        principalTable: "tbl_OnlineTraning",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_OnlineTrainingBundleCourse_tbl_StaffBundleCourseResult_~",
                        column: x => x.StaffBundleCourseResultId,
                        principalTable: "tbl_StaffBundleCourseResult",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_OnlineTraininglogQuestion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BeforeQuestion = table.Column<string>(type: "text", nullable: false),
                    DuringQuestion = table.Column<string>(type: "text", nullable: false),
                    AfterQuestion = table.Column<string>(type: "text", nullable: false),
                    OnlineTraningId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_OnlineTraininglogQuestion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_OnlineTraininglogQuestion_tbl_OnlineTraning_OnlineTrani~",
                        column: x => x.OnlineTraningId,
                        principalTable: "tbl_OnlineTraning",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_OnlineTraningQuestion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Question = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    QuestionMarks = table.Column<int>(type: "integer", nullable: false),
                    OnlineTraningId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_OnlineTraningQuestion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_OnlineTraningQuestion_tbl_OnlineTraning_OnlineTraningId",
                        column: x => x.OnlineTraningId,
                        principalTable: "tbl_OnlineTraning",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffRotaTask",
                columns: table => new
                {
                    StaffRotaTaskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffRotaPeriodId = table.Column<int>(type: "integer", nullable: false),
                    RotaTaskId = table.Column<int>(type: "integer", nullable: false),
                    IsGiven = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffRotaTask", x => x.StaffRotaTaskId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffRotaTask_tbl_StaffRotaPeriod_StaffRotaPeriodId",
                        column: x => x.StaffRotaPeriodId,
                        principalTable: "tbl_StaffRotaPeriod",
                        principalColumn: "StaffRotaPeriodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_AuditTrail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Duration = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_AuditTrail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_AuditTrail_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_AuditTrail_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Balance",
                columns: table => new
                {
                    BalanceId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Description = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Mobility = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Balance", x => x.BalanceId);
                    table.ForeignKey(
                        name: "FK_tbl_Balance_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_BestInterestAssessment",
                columns: table => new
                {
                    BestId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Position = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Signature = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Date = table.Column<string>(type: "text", nullable: false),
                    RefuseTreatment = table.Column<int>(type: "integer", nullable: true),
                    RefuseTreatmentRemarks = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    PowerofAttorney = table.Column<int>(type: "integer", nullable: true),
                    PowerofAttorneyRemarks = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    BenefitOfTreatment = table.Column<int>(type: "integer", nullable: true),
                    BenefitOfTreatmentRemarks = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    Statutory = table.Column<int>(type: "integer", nullable: false),
                    StatutoryRemarks = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    WelfareAspect = table.Column<int>(type: "integer", nullable: true),
                    WelfareAspectRemarks = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    EthicalAspect = table.Column<int>(type: "integer", nullable: true),
                    EthicalAspectRemarks = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    EmotionalAspect = table.Column<int>(type: "integer", nullable: true),
                    EmotionalAspectRemarks = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    Summary = table.Column<int>(type: "integer", nullable: true),
                    SummaryRemarks = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    IsNutrition = table.Column<bool>(type: "boolean", nullable: false),
                    IsMedication = table.Column<bool>(type: "boolean", nullable: false),
                    IsHygiene = table.Column<bool>(type: "boolean", nullable: false),
                    IsStoma = table.Column<bool>(type: "boolean", nullable: false),
                    IsFinance = table.Column<bool>(type: "boolean", nullable: false),
                    IsRequired = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BestInterestAssessment", x => x.BestId);
                    table.ForeignKey(
                        name: "FK_tbl_BestInterestAssessment_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_BodyMap",
                columns: table => new
                {
                    BodyMapId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffRotaPeriodId = table.Column<int>(type: "integer", nullable: true),
                    CreamName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    PurposeOfCream = table.Column<string>(type: "text", nullable: true),
                    HowToApply = table.Column<string>(type: "text", nullable: true),
                    Instruction = table.Column<string>(type: "text", nullable: true),
                    AreaApplied = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Escalation = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 37, nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BodyMap", x => x.BodyMapId);
                    table.ForeignKey(
                        name: "FK_tbl_BodyMap_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CarePlanNutrition",
                columns: table => new
                {
                    NutritionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FoodStorage = table.Column<int>(type: "integer", nullable: true),
                    ServingMeal = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    WhenRestock = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    WhoRestock = table.Column<int>(type: "integer", nullable: true),
                    SpecialDiet = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    DrinkType = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    AvoidFood = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    ThingsILike = table.Column<int>(type: "integer", nullable: true),
                    FoodIntake = table.Column<int>(type: "integer", nullable: true),
                    FoodIntakeDetail = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    MealPreparation = table.Column<int>(type: "integer", nullable: true),
                    EatingDifficulty = table.Column<int>(type: "integer", nullable: true),
                    EatingDifficultyDetail = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    RiskMitigations = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CarePlanNutrition", x => x.NutritionId);
                    table.ForeignKey(
                        name: "FK_tbl_CarePlanNutrition_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_CareReview",
                columns: table => new
                {
                    CareReviewId = table.Column<Guid>(type: "uuid", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Action = table.Column<int>(type: "integer", nullable: false),
                    StaffSignature = table.Column<string>(type: "text", nullable: false),
                    ManagerSignature = table.Column<string>(type: "text", nullable: false),
                    ClientSignature = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CareReview", x => x.CareReviewId);
                    table.ForeignKey(
                        name: "FK_tbl_CareReview_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_CareReview_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_BloodCoagulationRecord",
                columns: table => new
                {
                    BloodRecordId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Indication = table.Column<int>(type: "integer", nullable: false),
                    TargetINR = table.Column<int>(type: "integer", nullable: false),
                    TargetINRAttach = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CurrentDose = table.Column<int>(type: "integer", nullable: false),
                    INR = table.Column<int>(type: "integer", nullable: false),
                    NewDose = table.Column<int>(type: "integer", nullable: false),
                    NewINR = table.Column<int>(type: "integer", nullable: false),
                    BloodStatus = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    PhysicianResponce = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Remark = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_BloodCoagulationRecord", x => x.BloodRecordId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_BloodCoagulationRecord_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_Client_BloodCoagulationRecord_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_BloodPressure",
                columns: table => new
                {
                    BloodPressureId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GoalSystolic = table.Column<int>(type: "integer", nullable: false),
                    GoalDiastolic = table.Column<int>(type: "integer", nullable: false),
                    ReadingSystolic = table.Column<int>(type: "integer", nullable: false),
                    ReadingDiastolic = table.Column<int>(type: "integer", nullable: false),
                    StatusImage = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    StatusAttach = table.Column<string>(type: "text", nullable: false),
                    PhysicianResponse = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_BloodPressure", x => x.BloodPressureId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_BloodPressure_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_Client_BloodPressure_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_BMIChart",
                columns: table => new
                {
                    BMIChartId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Height = table.Column<int>(type: "integer", nullable: false),
                    Weight = table.Column<string>(type: "text", nullable: false),
                    NumberRange = table.Column<int>(type: "integer", nullable: false),
                    SeeChart = table.Column<int>(type: "integer", nullable: false),
                    SeeChartAttach = table.Column<string>(type: "text", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    PhysicianResponse = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_BMIChart", x => x.BMIChartId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_BMIChart_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_Client_BMIChart_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_BodyTemp",
                columns: table => new
                {
                    BodyTempId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TargetTemp = table.Column<int>(type: "integer", nullable: false),
                    TargetTempAttach = table.Column<string>(type: "text", nullable: false),
                    CurrentReading = table.Column<string>(type: "text", nullable: false),
                    SeeChart = table.Column<int>(type: "integer", nullable: false),
                    SeeChartAttach = table.Column<string>(type: "text", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    PhysicianResponse = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_BodyTemp", x => x.BodyTempId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_BodyTemp_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_Client_BodyTemp_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_BowelMovement",
                columns: table => new
                {
                    BowelMovementId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    TypeAttach = table.Column<string>(type: "text", nullable: false),
                    Size = table.Column<int>(type: "integer", nullable: false),
                    Color = table.Column<int>(type: "integer", nullable: false),
                    ColorAttach = table.Column<string>(type: "text", nullable: false),
                    StatusImage = table.Column<int>(type: "integer", nullable: false),
                    StatusAttach = table.Column<string>(type: "text", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    PhysicianResponse = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_BowelMovement", x => x.BowelMovementId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_BowelMovement_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_Client_BowelMovement_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_ComplainRegister",
                columns: table => new
                {
                    ComplainId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    LINK = table.Column<string>(type: "text", nullable: false),
                    IRFNUMBER = table.Column<string>(name: "IRFNUMBER ", type: "text", nullable: false),
                    INCIDENTDATE = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATERECIEVED = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATEOFACKNOWLEDGEMENT = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SOURCEOFCOMPLAINTS = table.Column<string>(type: "text", nullable: false),
                    COMPLAINANTCONTACT = table.Column<string>(type: "text", nullable: false),
                    CONCERNSRAISED = table.Column<string>(type: "text", nullable: false),
                    DUEDATE = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LETTERTOSTAFF = table.Column<string>(type: "text", nullable: false),
                    INVESTIGATIONOUTCOME = table.Column<string>(type: "text", nullable: false),
                    ACTIONTAKEN = table.Column<string>(type: "text", nullable: false),
                    FINALRESPONSETOFAMILY = table.Column<string>(type: "text", nullable: false),
                    ROOTCAUSE = table.Column<string>(type: "text", nullable: false),
                    REMARK = table.Column<string>(type: "text", nullable: false),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    EvidenceFilePath = table.Column<string>(type: "text", nullable: false),
                    StaffSignature = table.Column<string>(type: "text", nullable: false),
                    ManagerSignature = table.Column<string>(type: "text", nullable: false),
                    ClientSignature = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_ComplainRegister", x => x.ComplainId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_ComplainRegister_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_Client_ComplainRegister_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_EyeHealthMonitoring",
                columns: table => new
                {
                    EyeHealthId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ToolUsed = table.Column<int>(type: "integer", nullable: false),
                    ToolUsedAttach = table.Column<string>(type: "text", nullable: false),
                    MethodUsed = table.Column<int>(type: "integer", nullable: false),
                    MethodUsedAttach = table.Column<string>(type: "text", nullable: false),
                    TargetSet = table.Column<int>(type: "integer", nullable: false),
                    CurrentScore = table.Column<int>(type: "integer", nullable: false),
                    PatientGlasses = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    StatusImage = table.Column<int>(type: "integer", nullable: false),
                    StatusAttach = table.Column<string>(type: "text", nullable: false),
                    PhysicianResponse = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_EyeHealthMonitoring", x => x.EyeHealthId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_EyeHealthMonitoring_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_Client_EyeHealthMonitoring_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_FoodIntake",
                columns: table => new
                {
                    FoodIntakeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Goal = table.Column<int>(type: "integer", nullable: false),
                    CurrentIntake = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    StatusImage = table.Column<int>(type: "integer", nullable: false),
                    StatusAttach = table.Column<string>(type: "text", nullable: false),
                    PhysicianResponse = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_FoodIntake", x => x.FoodIntakeId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_FoodIntake_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_Client_FoodIntake_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_HeartRate",
                columns: table => new
                {
                    HeartRateId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TargetHR = table.Column<int>(type: "integer", nullable: false),
                    TargetHRAttach = table.Column<string>(type: "text", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    GenderAttach = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    BeatsPerSeconds = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    SeeChart = table.Column<int>(type: "integer", nullable: false),
                    SeeChartAttach = table.Column<string>(type: "text", nullable: false),
                    PhysicianResponse = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_HeartRate", x => x.HeartRateId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_HeartRate_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_Client_HeartRate_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_Nutrition",
                columns: table => new
                {
                    NutritionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateFrom = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DateTo = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    MealSpecialNote = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    ShoppingSpecialNote = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    CleaningSpecialNote = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    StaffId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_Nutrition", x => x.NutritionId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_Nutrition_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_Oxygenlvl",
                columns: table => new
                {
                    OxygenLvlId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TargetOxygen = table.Column<int>(type: "integer", nullable: false),
                    TargetOxygenAttach = table.Column<string>(type: "text", nullable: false),
                    CurrentReading = table.Column<string>(type: "text", nullable: false),
                    SeeChart = table.Column<int>(type: "integer", nullable: false),
                    SeeChartAttach = table.Column<string>(type: "text", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    PhysicianResponse = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_Oxygenlvl", x => x.OxygenLvlId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_Oxygenlvl_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_Client_Oxygenlvl_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_PainChart",
                columns: table => new
                {
                    PainChartId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    TypeAttach = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<int>(type: "integer", nullable: false),
                    LocationAttach = table.Column<string>(type: "text", nullable: false),
                    PainLvl = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    StatusImage = table.Column<int>(type: "integer", nullable: false),
                    StatusAttach = table.Column<string>(type: "text", nullable: false),
                    PhysicianResponse = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_PainChart", x => x.PainChartId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_PainChart_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_Client_PainChart_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_PulseRate",
                columns: table => new
                {
                    PulseRateId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TargetPulse = table.Column<int>(type: "integer", nullable: false),
                    TargetPulseAttach = table.Column<string>(type: "text", nullable: false),
                    CurrentPulse = table.Column<string>(type: "text", nullable: false),
                    Chart = table.Column<string>(type: "text", nullable: false),
                    SeeChart = table.Column<int>(type: "integer", nullable: false),
                    SeeChartAttach = table.Column<string>(type: "text", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    PhysicianResponse = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_PulseRate", x => x.PulseRateId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_PulseRate_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_Client_PulseRate_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_Seizure",
                columns: table => new
                {
                    SeizureId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SeizureType = table.Column<int>(type: "integer", nullable: false),
                    SeizureTypeAttach = table.Column<string>(type: "text", nullable: false),
                    SeizureLength = table.Column<int>(type: "integer", nullable: false),
                    SeizureLengthAttach = table.Column<string>(type: "text", nullable: false),
                    Often = table.Column<int>(type: "integer", nullable: false),
                    WhatHappened = table.Column<string>(type: "text", nullable: false),
                    StatusImage = table.Column<int>(type: "integer", nullable: false),
                    StatusAttach = table.Column<string>(type: "text", nullable: false),
                    PhysicianResponse = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_Seizure", x => x.SeizureId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_Seizure_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_Client_Seizure_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_WoundCare",
                columns: table => new
                {
                    WoundCareId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Goal = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    TypeAttach = table.Column<string>(type: "text", nullable: false),
                    UlcerStage = table.Column<int>(type: "integer", nullable: false),
                    UlcerStageAttach = table.Column<string>(type: "text", nullable: false),
                    Measurment = table.Column<int>(type: "integer", nullable: false),
                    MeasurementAttach = table.Column<string>(type: "text", nullable: false),
                    PainLvl = table.Column<int>(type: "integer", nullable: false),
                    Location = table.Column<int>(type: "integer", nullable: false),
                    LocationAttach = table.Column<string>(type: "text", nullable: false),
                    WoundCause = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    StatusImage = table.Column<int>(type: "integer", nullable: false),
                    StatusAttach = table.Column<string>(type: "text", nullable: false),
                    PhysicianResponse = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_WoundCare", x => x.WoundCareId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_WoundCare_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_Client_WoundCare_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientBillTo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    BillTo = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientBillTo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_ClientBillTo_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientCareDetails",
                columns: table => new
                {
                    ClientCareDetailsId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientCareDetailsTaskId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    Risk = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Mitigation = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    Location = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    Remark = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientCareDetails", x => x.ClientCareDetailsId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientCareDetails_tbl_ClientCareDetailsTask_ClientCareD~",
                        column: x => x.ClientCareDetailsTaskId,
                        principalTable: "tbl_ClientCareDetailsTask",
                        principalColumn: "ClientCareDetailsTaskId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_ClientCareDetails_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientCareObj",
                columns: table => new
                {
                    CareObjId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Remark = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientCareObj", x => x.CareObjId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientCareObj_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_ClientCareObj_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientDailyTask",
                columns: table => new
                {
                    DailyTaskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DailyTaskName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    HowToPerformTask = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AmendmentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    Image = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Video = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientDailyTask", x => x.DailyTaskId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientDailyTask_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientHealthCondition",
                columns: table => new
                {
                    CHCId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Condition = table.Column<string>(type: "text", nullable: false),
                    CausesAndTrigger = table.Column<string>(type: "text", nullable: false),
                    Symptoms = table.Column<string>(type: "text", nullable: false),
                    ClientManagingWithCondition = table.Column<string>(type: "text", nullable: false),
                    RiskToClient = table.Column<string>(type: "text", nullable: false),
                    RiskToStaff = table.Column<string>(type: "text", nullable: false),
                    ActionRequiredToStaff = table.Column<string>(type: "text", nullable: false),
                    EscalationsApproach = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientHealthCondition", x => x.CHCId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientHealthCondition_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientHobbies",
                columns: table => new
                {
                    CHId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HId = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientHobbies", x => x.CHId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientHobbies_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_ClientHobbies_tbl_Hobbies_HId",
                        column: x => x.HId,
                        principalTable: "tbl_Hobbies",
                        principalColumn: "HId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientInvoiceRate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ServiceType = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Period = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Rate = table.Column<decimal>(type: "numeric", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientInvoiceRate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_ClientInvoiceRate_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientInvolvingParty",
                columns: table => new
                {
                    ClientInvolvingPartyId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientInvolvingPartyItem = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "character varying(225)", maxLength: 225, nullable: false),
                    Email = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: false),
                    Telephone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Relationship = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientInvolvingParty", x => x.ClientInvolvingPartyId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientInvolvingParty_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientKeyWorkerVoice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KeyWorkerId = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    staffId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientKeyWorkerVoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_ClientKeyWorkerVoice_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_ClientKeyWorkerVoice_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientMatrixAudit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AuditorName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    closingStatement = table.Column<string>(type: "text", nullable: false),
                    IsMedAudit = table.Column<bool>(type: "boolean", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientMatrixAudit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_ClientMatrixAudit_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_ClientMatrixAudit_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientMedication",
                columns: table => new
                {
                    ClientMedicationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MedicationId = table.Column<int>(type: "integer", nullable: true),
                    MedicationManufacturerId = table.Column<int>(type: "integer", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Dossage = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Frequency = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Gap_Hour = table.Column<int>(type: "integer", nullable: true),
                    Route = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StopDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Remark = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    PRNGuideline = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Means = table.Column<int>(type: "integer", nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: true),
                    TimeCritical = table.Column<int>(type: "integer", nullable: true),
                    MedicationRouteId = table.Column<int>(type: "integer", nullable: true),
                    ClientMedImage = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    IsPause = table.Column<bool>(type: "boolean", nullable: false),
                    IsDelete = table.Column<bool>(type: "boolean", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientMedication", x => x.ClientMedicationId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientMedication_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_ClientMedication_tbl_MedicationManufacturer_MedicationM~",
                        column: x => x.MedicationManufacturerId,
                        principalTable: "tbl_MedicationManufacturer",
                        principalColumn: "MedicationManufacturerId");
                    table.ForeignKey(
                        name: "FK_tbl_ClientMedication_tbl_MedicationRoute_MedicationRouteId",
                        column: x => x.MedicationRouteId,
                        principalTable: "tbl_MedicationRoute",
                        principalColumn: "MedicationRoutId");
                    table.ForeignKey(
                        name: "FK_tbl_ClientMedication_tbl_Medication_MedicationId",
                        column: x => x.MedicationId,
                        principalTable: "tbl_Medication",
                        principalColumn: "MedicationId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientRegulatoryContact",
                columns: table => new
                {
                    ClientRegulatoryContactId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BaseRecordItemId = table.Column<int>(type: "integer", nullable: false),
                    DatePerformed = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DueDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Evidence = table.Column<string>(type: "text", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientRegulatoryContact", x => x.ClientRegulatoryContactId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientRegulatoryContact_tbl_BaseRecordItem_Model_BaseRe~",
                        column: x => x.BaseRecordItemId,
                        principalTable: "tbl_BaseRecordItem_Model",
                        principalColumn: "BaseRecordItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_ClientRegulatoryContact_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientRota",
                columns: table => new
                {
                    ClientRotaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientRotaTypeId = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientRota", x => x.ClientRotaId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientRota_tbl_ClientRotaType_ClientRotaTypeId",
                        column: x => x.ClientRotaTypeId,
                        principalTable: "tbl_ClientRotaType",
                        principalColumn: "ClientRotaTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_ClientRota_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientTaskBoard",
                columns: table => new
                {
                    TaskBoardId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TaskName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false),
                    TaskImage = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Attachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientTaskBoard", x => x.TaskBoardId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientTaskBoard_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ComplainRegistorClients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ComplainRegistorId = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ComplainRegistorClients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_ComplainRegistorClients_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_ComplainRegistorClients_tbl_ComplainRegistor_ComplainRe~",
                        column: x => x.ComplainRegistorId,
                        principalTable: "tbl_ComplainRegistor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CuidiBuddy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CuidiBuddyId = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CuidiBuddy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CuidiBuddy_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_CuidiBuddy_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_DutyOnCall",
                columns: table => new
                {
                    DutyOnCallId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RefNo = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    TypeOfDutyCall = table.Column<int>(type: "integer", nullable: true),
                    Subject = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    ClientInitial = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    DateOfIncident = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ReportedBy = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    DetailsOfIncident = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    ActionTaken = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    DetailsRequired = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: true),
                    Remarks = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    Attachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    StaffSignature = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DutyOnCall", x => x.DutyOnCallId);
                    table.ForeignKey(
                        name: "FK_tbl_DutyOnCall_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Enotice_",
                columns: table => new
                {
                    EnoticeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PublishTo = table.Column<Guid>(type: "uuid", nullable: false),
                    Heading = table.Column<string>(type: "text", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: false),
                    PublishBy = table.Column<Guid>(type: "uuid", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Video = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Enotice_", x => x.EnoticeId);
                    table.ForeignKey(
                        name: "FK_tbl_Enotice__tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_EquipmentAssessment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EquipmentName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    EquipmentLocation = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    EquipmentStatus = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Url = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Training = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    HowToUse = table.Column<string>(type: "text", nullable: false),
                    RiskOfClient = table.Column<string>(type: "text", nullable: false),
                    RiskOfStaff = table.Column<string>(type: "text", nullable: false),
                    Environment = table.Column<string>(type: "text", nullable: false),
                    RiskControl = table.Column<string>(type: "text", nullable: false),
                    Attachment = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Attachment1 = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_EquipmentAssessment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_EquipmentAssessment_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_HealthAndLiving",
                columns: table => new
                {
                    HLId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BriefHealth = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    ObserveHealth = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    WakeUp = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    CareSupport = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    MovingAndHandling = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    SupportToBed = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    DehydrationRisk = table.Column<int>(type: "integer", nullable: true),
                    LifeStyle = table.Column<int>(type: "integer", nullable: true),
                    PressureSore = table.Column<int>(type: "integer", nullable: true),
                    ContinenceIssue = table.Column<int>(type: "integer", nullable: true),
                    ContinenceNeeds = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    ContinenceSource = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    ConstraintRequired = table.Column<int>(type: "integer", nullable: true),
                    ConstraintDetails = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    ConstraintAttachment = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    MeansOfComm = table.Column<int>(type: "integer", nullable: true),
                    Smoking = table.Column<int>(type: "integer", nullable: true),
                    AbilityToRead = table.Column<int>(type: "integer", nullable: true),
                    TextFontSize = table.Column<int>(type: "integer", nullable: true),
                    Email = table.Column<int>(type: "integer", nullable: true),
                    FinanceManagement = table.Column<int>(type: "integer", nullable: true),
                    PostalService = table.Column<int>(type: "integer", nullable: true),
                    LetterOpening = table.Column<int>(type: "integer", nullable: true),
                    ShoppingRequired = table.Column<int>(type: "integer", nullable: true),
                    SpecialCleaning = table.Column<int>(type: "integer", nullable: true),
                    LaundaryRequired = table.Column<int>(type: "integer", nullable: true),
                    VideoCallRequired = table.Column<int>(type: "integer", nullable: true),
                    EatingWithStaff = table.Column<int>(type: "integer", nullable: true),
                    AllowChats = table.Column<int>(type: "integer", nullable: true),
                    TeaChocolateCoffee = table.Column<int>(type: "integer", nullable: true),
                    NeighbourInvolment = table.Column<int>(type: "integer", nullable: true),
                    FamilyUpdate = table.Column<int>(type: "integer", nullable: true),
                    AlcoholicDrink = table.Column<int>(type: "integer", nullable: true),
                    TVandMusic = table.Column<int>(type: "integer", nullable: true),
                    SpecialCaution = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_HealthAndLiving", x => x.HLId);
                    table.ForeignKey(
                        name: "FK_tbl_HealthAndLiving_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_HistoryOfFall",
                columns: table => new
                {
                    HistoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Details = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Cause = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    Prevention = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    IsFallOfRisk = table.Column<bool>(type: "boolean", nullable: false),
                    DetailofRisk = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    CauseAndTriger = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    HowToControl = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    UserAwareOfFall = table.Column<bool>(type: "boolean", nullable: false),
                    Escallation = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_HistoryOfFall", x => x.HistoryId);
                    table.ForeignKey(
                        name: "FK_tbl_HistoryOfFall_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_HomeRiskAssessment",
                columns: table => new
                {
                    HomeRiskAssessmentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HeadingId = table.Column<int>(type: "integer", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_HomeRiskAssessment", x => x.HomeRiskAssessmentId);
                    table.ForeignKey(
                        name: "FK_tbl_HomeRiskAssessment_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_HospitalEntry",
                columns: table => new
                {
                    HospitalEntryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    DateAndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    PurposeofAdmission = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    LastDateofAdmission = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ConditionOfAdmission = table.Column<int>(type: "integer", nullable: true),
                    IsFamilyInformed = table.Column<int>(type: "integer", nullable: true),
                    PossibleDateReturn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsHomeCleaned = table.Column<int>(type: "integer", nullable: true),
                    MeansOfTransport = table.Column<int>(type: "integer", nullable: true),
                    Attachment = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Remark = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    StaffSignature = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    StaffInvolved = table.Column<string>(type: "text", nullable: false),
                    PersonToTakeAction = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_HospitalEntry", x => x.HospitalEntryId);
                    table.ForeignKey(
                        name: "FK_tbl_HospitalEntry_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_HospitalExit",
                columns: table => new
                {
                    HospitalExitId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    DateAndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ConditionOnDischarge = table.Column<int>(type: "integer", nullable: true),
                    NumberOfStaffRequiredOnDischarge = table.Column<int>(type: "integer", nullable: true),
                    IsGrosSriesAvaible = table.Column<int>(type: "integer", nullable: true),
                    IsHomeCleaned = table.Column<int>(type: "integer", nullable: true),
                    IsMedicationAvaialable = table.Column<int>(type: "integer", nullable: false),
                    IsServiceUseronRota = table.Column<int>(type: "integer", nullable: true),
                    isRotaTeamInformed = table.Column<int>(type: "integer", nullable: true),
                    isLittleCashAvailableForServiceUser = table.Column<int>(type: "integer", nullable: true),
                    ModeOfMeansOfTrasportBackHome = table.Column<int>(type: "integer", nullable: true),
                    AreEqipmentNeededAvailable = table.Column<int>(type: "integer", nullable: true),
                    AreStaffTrainnedOnEquipmentNeeded = table.Column<int>(type: "integer", nullable: true),
                    AreContinentProductNeedAndAvailable = table.Column<int>(type: "integer", nullable: true),
                    AreLocalSupportOrProgramNeeded = table.Column<int>(type: "integer", nullable: true),
                    WhichSupportIsNeeded = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    IsCarePlanUpdated = table.Column<int>(type: "integer", nullable: true),
                    ReablementRequired = table.Column<int>(type: "integer", nullable: true),
                    Remark = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    StaffSignature = table.Column<string>(type: "text", nullable: false),
                    OfficerToTakeAction = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_HospitalExit", x => x.HospitalExitId);
                    table.ForeignKey(
                        name: "FK_tbl_HospitalExit_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_IncidentReporting",
                columns: table => new
                {
                    IncidentReportingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReportingStaffId = table.Column<int>(type: "integer", nullable: true),
                    StaffInvolvedId = table.Column<int>(type: "integer", nullable: false),
                    IncidentTypeId = table.Column<int>(type: "integer", nullable: false),
                    IncidentDetails = table.Column<string>(type: "text", nullable: false),
                    ActionTaken = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    Witness = table.Column<string>(type: "text", nullable: true),
                    Attachment = table.Column<string>(type: "text", nullable: true),
                    StaffSignature = table.Column<string>(type: "text", nullable: false),
                    ManagerSignature = table.Column<string>(type: "text", nullable: false),
                    ClientSignature = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_IncidentReporting", x => x.IncidentReportingId);
                    table.ForeignKey(
                        name: "FK_tbl_IncidentReporting_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_IncidentReporting_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Incoming_Meds",
                columns: table => new
                {
                    IncomingMedsId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserName = table.Column<Guid>(type: "uuid", nullable: false),
                    StaffName = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<string>(type: "text", nullable: false),
                    ChartImage = table.Column<string>(type: "text", nullable: false),
                    MedsImage = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Incoming_Meds", x => x.IncomingMedsId);
                    table.ForeignKey(
                        name: "FK_tbl_Incoming_Meds_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_InfectionControl",
                columns: table => new
                {
                    InfectionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<int>(type: "integer", nullable: true),
                    Detail = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    Guideline = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    TestDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    VaccStatus = table.Column<int>(type: "integer", nullable: true),
                    Remarks = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_InfectionControl", x => x.InfectionId);
                    table.ForeignKey(
                        name: "FK_tbl_InfectionControl_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_InterestAndObjective",
                columns: table => new
                {
                    GoalId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CareGoal = table.Column<string>(type: "character varying(2056)", maxLength: 2056, nullable: false),
                    Brief = table.Column<string>(type: "character varying(2056)", maxLength: 2056, nullable: false),
                    InterestId = table.Column<int>(type: "integer", nullable: true),
                    LeisureActivity = table.Column<int>(type: "integer", nullable: true),
                    InformalActivity = table.Column<int>(type: "integer", nullable: true),
                    MaintainContact = table.Column<int>(type: "integer", nullable: true),
                    CommunityActivity = table.Column<int>(type: "integer", nullable: true),
                    EventAwarness = table.Column<int>(type: "integer", nullable: true),
                    GoalAndObjective = table.Column<int>(type: "integer", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_InterestAndObjective", x => x.GoalId);
                    table.ForeignKey(
                        name: "FK_tbl_InterestAndObjective_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_InterestAndObjective_tbl_Interest_InterestId",
                        column: x => x.InterestId,
                        principalTable: "tbl_Interest",
                        principalColumn: "InterestId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ManagingTasks",
                columns: table => new
                {
                    TaskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Task = table.Column<int>(type: "integer", nullable: true),
                    Help = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ManagingTasks", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_tbl_ManagingTasks_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_PersonalDetail",
                columns: table => new
                {
                    PersonalDetailId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffSignature = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    ManagerSignature = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    ClientSignature = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PersonalDetail", x => x.PersonalDetailId);
                    table.ForeignKey(
                        name: "FK_tbl_PersonalDetail_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_PersonalHygiene",
                columns: table => new
                {
                    HygieneId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cleaning = table.Column<int>(type: "integer", nullable: false),
                    CleaningTools = table.Column<int>(type: "integer", nullable: false),
                    WhoClean = table.Column<int>(type: "integer", nullable: false),
                    DesiredCleaning = table.Column<int>(type: "integer", nullable: false),
                    CleaningFreq = table.Column<int>(type: "integer", nullable: false),
                    GeneralAppliance = table.Column<int>(type: "integer", nullable: false),
                    DirtyLaundry = table.Column<int>(type: "integer", nullable: false),
                    DryLaundry = table.Column<int>(type: "integer", nullable: false),
                    WashingMachine = table.Column<int>(type: "integer", nullable: false),
                    Ironing = table.Column<int>(type: "integer", nullable: false),
                    LaundryGuide = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    LaundrySupport = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PersonalHygiene", x => x.HygieneId);
                    table.ForeignKey(
                        name: "FK_tbl_PersonalHygiene_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_PersonCentred",
                columns: table => new
                {
                    PersonCentredId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false),
                    Class = table.Column<int>(type: "integer", nullable: false),
                    ExpSupport = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    Focus = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PersonCentred", x => x.PersonCentredId);
                    table.ForeignKey(
                        name: "FK_tbl_PersonCentred_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Pets",
                columns: table => new
                {
                    PetsId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: true),
                    Gender = table.Column<int>(type: "integer", nullable: true),
                    PetActivities = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    MealStorage = table.Column<int>(type: "integer", nullable: true),
                    VetVisit = table.Column<int>(type: "integer", nullable: true),
                    PetInsurance = table.Column<int>(type: "integer", nullable: true),
                    PetCare = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    MealPattern = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Pets", x => x.PetsId);
                    table.ForeignKey(
                        name: "FK_tbl_Pets_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_PhysicalAbility",
                columns: table => new
                {
                    PhysicalId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Description = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Mobility = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PhysicalAbility", x => x.PhysicalId);
                    table.ForeignKey(
                        name: "FK_tbl_PhysicalAbility_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Resources_",
                columns: table => new
                {
                    ResourcesId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PublishTo = table.Column<Guid>(type: "uuid", nullable: false),
                    Heading = table.Column<string>(type: "text", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: false),
                    PublishBy = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Video = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Resources_", x => x.ResourcesId);
                    table.ForeignKey(
                        name: "FK_tbl_Resources__tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_SpecialHealthAndMedication",
                columns: table => new
                {
                    SHMId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AdminLvl = table.Column<int>(type: "integer", nullable: true),
                    MedicationAllergy = table.Column<int>(type: "integer", nullable: true),
                    FamilyMeds = table.Column<int>(type: "integer", nullable: true),
                    LeftoutMedicine = table.Column<int>(type: "integer", nullable: true),
                    NameFormMedicaiton = table.Column<int>(type: "integer", nullable: true),
                    WhoAdminister = table.Column<int>(type: "integer", nullable: true),
                    MedsGPOrder = table.Column<int>(type: "integer", nullable: true),
                    PharmaMARChart = table.Column<int>(type: "integer", nullable: true),
                    TempMARChart = table.Column<int>(type: "integer", nullable: true),
                    MedKeyCode = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    FamilyReturnMed = table.Column<int>(type: "integer", nullable: true),
                    AccessMedication = table.Column<int>(type: "integer", nullable: true),
                    NoMedAccess = table.Column<int>(type: "integer", nullable: true),
                    MedAccessDenial = table.Column<int>(type: "integer", nullable: true),
                    PNRMedReq = table.Column<int>(type: "integer", nullable: true),
                    PNRDoses = table.Column<int>(type: "integer", nullable: true),
                    PNRMedsAdmin = table.Column<int>(type: "integer", nullable: true),
                    OverdoseContact = table.Column<int>(type: "integer", nullable: true),
                    PNRMedsMissing = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    MedicationStorage = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    SpecialStorage = table.Column<int>(type: "integer", nullable: true),
                    PNRMedList = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    Consent = table.Column<int>(type: "integer", nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: true),
                    By = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_SpecialHealthAndMedication", x => x.SHMId);
                    table.ForeignKey(
                        name: "FK_tbl_SpecialHealthAndMedication_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_SpecialHealthCondition",
                columns: table => new
                {
                    HealthCondId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConditionName = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    SourceInformation = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    FeelingBeforeIncident = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    FeelingAfterIncident = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    Frequency = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    LivingActivities = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    Trigger = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    ClientAction = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    ClinicRecommendation = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    LifestyleSupport = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    PlanningHealthCondition = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_SpecialHealthCondition", x => x.HealthCondId);
                    table.ForeignKey(
                        name: "FK_tbl_SpecialHealthCondition_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientSupportPlanGoalAchieve",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientSupportPlanGoalId = table.Column<int>(type: "integer", nullable: false),
                    DeliveryPlan = table.Column<string>(type: "text", nullable: false),
                    TargetDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientSupportPlanGoalAchieve", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_ClientSupportPlanGoalAchieve_tbl_ClientSupportPlanGoal_~",
                        column: x => x.ClientSupportPlanGoalId,
                        principalTable: "tbl_ClientSupportPlanGoal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_OnlineTraningQuestionOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Option = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    OptionMarks = table.Column<int>(type: "integer", nullable: false),
                    OnlineTraningQuestionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_OnlineTraningQuestionOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_OnlineTraningQuestionOptions_tbl_OnlineTraningQuestion_~",
                        column: x => x.OnlineTraningQuestionId,
                        principalTable: "tbl_OnlineTraningQuestion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BelieveTask",
                columns: table => new
                {
                    BelieveTaskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BestId = table.Column<int>(type: "integer", nullable: false),
                    ReasonableBelieve = table.Column<int>(type: "integer", nullable: false),
                    BestInterestAssessmentBestId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BelieveTask", x => x.BelieveTaskId);
                    table.ForeignKey(
                        name: "FK_tbl_BelieveTask_tbl_BestInterestAssessment_BestInterestAsse~",
                        column: x => x.BestInterestAssessmentBestId,
                        principalTable: "tbl_BestInterestAssessment",
                        principalColumn: "BestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CareIssuesTask",
                columns: table => new
                {
                    CareIssuesTaskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BestId = table.Column<int>(type: "integer", nullable: false),
                    Issues = table.Column<int>(type: "integer", nullable: false),
                    BestInterestAssessmentBestId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CareIssuesTask", x => x.CareIssuesTaskId);
                    table.ForeignKey(
                        name: "FK_tbl_CareIssuesTask_tbl_BestInterestAssessment_BestInterestA~",
                        column: x => x.BestInterestAssessmentBestId,
                        principalTable: "tbl_BestInterestAssessment",
                        principalColumn: "BestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_HealthTask",
                columns: table => new
                {
                    HealthTaskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BestId = table.Column<int>(type: "integer", nullable: false),
                    HeadingId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<int>(type: "integer", nullable: false),
                    Answer = table.Column<int>(type: "integer", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    BestInterestAssessmentBestId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_HealthTask", x => x.HealthTaskId);
                    table.ForeignKey(
                        name: "FK_tbl_HealthTask_tbl_BestInterestAssessment_BestInterestAsses~",
                        column: x => x.BestInterestAssessmentBestId,
                        principalTable: "tbl_BestInterestAssessment",
                        principalColumn: "BestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_HealthTask2",
                columns: table => new
                {
                    HealthTask2Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BestId = table.Column<int>(type: "integer", nullable: false),
                    Heading2Id = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<int>(type: "integer", nullable: false),
                    Answer = table.Column<int>(type: "integer", nullable: false),
                    Remark = table.Column<string>(type: "text", nullable: false),
                    BestInterestAssessmentBestId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_HealthTask2", x => x.HealthTask2Id);
                    table.ForeignKey(
                        name: "FK_tbl_HealthTask2_tbl_BestInterestAssessment_BestInterestAsse~",
                        column: x => x.BestInterestAssessmentBestId,
                        principalTable: "tbl_BestInterestAssessment",
                        principalColumn: "BestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_Cleaning",
                columns: table => new
                {
                    CleaningId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NutritionId = table.Column<int>(type: "integer", nullable: false),
                    AreasAndItems = table.Column<int>(type: "integer", nullable: true),
                    Details = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    SafetyHazard = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    LocationOfItem = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    DescOfItem = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    MinuteAlloted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Disposal = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    WhereToGet = table.Column<int>(type: "integer", nullable: true),
                    WhereToKeep = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    SeeVideo = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Image = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    DayOfCleaning = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DateFrom = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DateTo = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StaffId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_Cleaning", x => x.CleaningId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_Cleaning_tbl_Client_Nutrition_NutritionId",
                        column: x => x.NutritionId,
                        principalTable: "tbl_Client_Nutrition",
                        principalColumn: "NutritionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_MealDay",
                columns: table => new
                {
                    ClientMealId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NutritionId = table.Column<int>(type: "integer", nullable: false),
                    MealDayofWeekId = table.Column<int>(type: "integer", nullable: true),
                    ClientMealTypeId = table.Column<int>(type: "integer", nullable: true),
                    TypeId = table.Column<int>(type: "integer", nullable: true),
                    MealDetail = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    HowToPrepare = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    SeeVideo = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Picture = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_MealDay", x => x.ClientMealId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_MealDay_tbl_Client_Nutrition_NutritionId",
                        column: x => x.NutritionId,
                        principalTable: "tbl_Client_Nutrition",
                        principalColumn: "NutritionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_Shopping",
                columns: table => new
                {
                    ShoppingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NutritionId = table.Column<int>(type: "integer", nullable: false),
                    MeansOfPurchase = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    LocationOfPurchase = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Item = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Description = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: true),
                    Amount = table.Column<decimal>(type: "numeric", nullable: true),
                    Image = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    DayOfShopping = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DateFrom = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DateTo = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StaffId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_Shopping", x => x.ShoppingId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_Shopping_tbl_Client_Nutrition_NutritionId",
                        column: x => x.NutritionId,
                        principalTable: "tbl_Client_Nutrition",
                        principalColumn: "NutritionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientMedicationDay",
                columns: table => new
                {
                    ClientMedicationDayId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RotaDayofWeekId = table.Column<int>(type: "integer", nullable: false),
                    ClientMedicationId = table.Column<int>(type: "integer", nullable: false),
                    ClientMedicationId1 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientMedicationDay", x => x.ClientMedicationDayId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientMedicationDay_tbl_ClientMedication_ClientMedicati~",
                        column: x => x.ClientMedicationId,
                        principalTable: "tbl_ClientMedication",
                        principalColumn: "ClientMedicationId");
                    table.ForeignKey(
                        name: "FK_tbl_ClientMedicationDay_tbl_ClientMedication_ClientMedicat~1",
                        column: x => x.ClientMedicationId1,
                        principalTable: "tbl_ClientMedication",
                        principalColumn: "ClientMedicationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_ClientMedicationDay_tbl_RotaDayofWeek_RotaDayofWeekId",
                        column: x => x.RotaDayofWeekId,
                        principalTable: "tbl_RotaDayofWeek",
                        principalColumn: "RotaDayofWeekId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientRotaDays",
                columns: table => new
                {
                    ClientRotaDaysId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientRotaId = table.Column<int>(type: "integer", nullable: false),
                    RotaDayofWeekId = table.Column<int>(type: "integer", nullable: true),
                    RotaId = table.Column<int>(type: "integer", nullable: true),
                    StartTime = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    StopTime = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    WeekDay = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    OtherStaff = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientRotaDays", x => x.ClientRotaDaysId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientRotaDays_tbl_ClientRotaName_RotaId",
                        column: x => x.RotaId,
                        principalTable: "tbl_ClientRotaName",
                        principalColumn: "RotaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_ClientRotaDays_tbl_ClientRota_ClientRotaId",
                        column: x => x.ClientRotaId,
                        principalTable: "tbl_ClientRota",
                        principalColumn: "ClientRotaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_ClientRotaDays_tbl_RotaDayofWeek_RotaDayofWeekId",
                        column: x => x.RotaDayofWeekId,
                        principalTable: "tbl_RotaDayofWeek",
                        principalColumn: "RotaDayofWeekId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_HomeRiskAssessmentTask",
                columns: table => new
                {
                    HomeRiskAssessmentTaskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HomeRiskAssessmentId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<int>(type: "integer", nullable: false),
                    Answer = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_HomeRiskAssessmentTask", x => x.HomeRiskAssessmentTaskId);
                    table.ForeignKey(
                        name: "FK_tbl_HomeRiskAssessmentTask_tbl_HomeRiskAssessment_HomeRiskA~",
                        column: x => x.HomeRiskAssessmentId,
                        principalTable: "tbl_HomeRiskAssessment",
                        principalColumn: "HomeRiskAssessmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_PersonalityTest",
                columns: table => new
                {
                    TestId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GoalId = table.Column<int>(type: "integer", nullable: false),
                    Question = table.Column<int>(type: "integer", nullable: false),
                    Answer = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PersonalityTest", x => x.TestId);
                    table.ForeignKey(
                        name: "FK_tbl_PersonalityTest_tbl_InterestAndObjective_GoalId",
                        column: x => x.GoalId,
                        principalTable: "tbl_InterestAndObjective",
                        principalColumn: "GoalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ConsentCare",
                columns: table => new
                {
                    CareId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonalDetailId = table.Column<int>(type: "integer", nullable: false),
                    Signature = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ConsentCare", x => x.CareId);
                    table.ForeignKey(
                        name: "FK_tbl_ConsentCare_tbl_PersonalDetail_PersonalDetailId",
                        column: x => x.PersonalDetailId,
                        principalTable: "tbl_PersonalDetail",
                        principalColumn: "PersonalDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ConsentLandLine",
                columns: table => new
                {
                    LandlineId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonalDetailId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<int>(type: "integer", nullable: false),
                    Signature = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ConsentLandLine", x => x.LandlineId);
                    table.ForeignKey(
                        name: "FK_tbl_ConsentLandLine_tbl_PersonalDetail_PersonalDetailId",
                        column: x => x.PersonalDetailId,
                        principalTable: "tbl_PersonalDetail",
                        principalColumn: "PersonalDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ConsentMedication",
                columns: table => new
                {
                    ConsentMedicationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonalDetailId = table.Column<int>(type: "integer", nullable: false),
                    OwnMedication = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    FamilyResponsibity = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    AdministratorProcess = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ConsentMedication", x => x.ConsentMedicationId);
                    table.ForeignKey(
                        name: "FK_tbl_ConsentMedication_tbl_PersonalDetail_PersonalDetailId",
                        column: x => x.PersonalDetailId,
                        principalTable: "tbl_PersonalDetail",
                        principalColumn: "PersonalDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_PersonCentredFocus",
                columns: table => new
                {
                    PersonCentredFocusId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonCentredId = table.Column<int>(type: "integer", nullable: false),
                    BaseRecordId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PersonCentredFocus", x => x.PersonCentredFocusId);
                    table.ForeignKey(
                        name: "FK_tbl_PersonCentredFocus_tbl_PersonCentred_PersonCentredId",
                        column: x => x.PersonCentredId,
                        principalTable: "tbl_PersonCentred",
                        principalColumn: "PersonCentredId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientMedicationPeriod",
                columns: table => new
                {
                    ClientMedicationPeriodId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientRotaTypeId = table.Column<int>(type: "integer", nullable: true),
                    ClientMedicationDayId = table.Column<int>(type: "integer", nullable: true),
                    RotaId = table.Column<int>(type: "integer", nullable: true),
                    StartTime = table.Column<string>(type: "text", nullable: false),
                    StopTime = table.Column<string>(type: "text", nullable: false),
                    MedLiveTrackerDelete = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientMedicationPeriod", x => x.ClientMedicationPeriodId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientMedicationPeriod_tbl_ClientMedicationDay_ClientMe~",
                        column: x => x.ClientMedicationDayId,
                        principalTable: "tbl_ClientMedicationDay",
                        principalColumn: "ClientMedicationDayId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_ClientMedicationPeriod_tbl_ClientRotaType_ClientRotaTyp~",
                        column: x => x.ClientRotaTypeId,
                        principalTable: "tbl_ClientRotaType",
                        principalColumn: "ClientRotaTypeId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientRotaTask",
                columns: table => new
                {
                    ClientRotaTaskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RotaTaskId = table.Column<int>(type: "integer", nullable: false),
                    ClientRotaDaysId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientRotaTask", x => x.ClientRotaTaskId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientRotaTask_tbl_ClientRotaDays_ClientRotaDaysId",
                        column: x => x.ClientRotaDaysId,
                        principalTable: "tbl_ClientRotaDays",
                        principalColumn: "ClientRotaDaysId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_ClientRotaTask_tbl_RotaTask_RotaTaskId",
                        column: x => x.RotaTaskId,
                        principalTable: "tbl_RotaTask",
                        principalColumn: "RotaTaskId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ConsentLandlineLog",
                columns: table => new
                {
                    ConsentLandlineLogId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LandlineId = table.Column<int>(type: "integer", nullable: false),
                    BaseRecordId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ConsentLandlineLog", x => x.ConsentLandlineLogId);
                    table.ForeignKey(
                        name: "FK_tbl_ConsentLandlineLog_tbl_ConsentLandLine_LandlineId",
                        column: x => x.LandlineId,
                        principalTable: "tbl_ConsentLandLine",
                        principalColumn: "LandlineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyModel",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyName = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Website = table.Column<string>(type: "text", nullable: false),
                    LogoUrl = table.Column<string>(type: "text", nullable: false),
                    Language = table.Column<string>(type: "text", nullable: false),
                    PostCode = table.Column<string>(type: "text", nullable: false),
                    Telephone = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    Currency = table.Column<string>(type: "text", nullable: false),
                    DateFrom = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateTo = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CurrentCqcRating = table.Column<string>(type: "text", nullable: false),
                    CityOfOperation = table.Column<string>(type: "text", nullable: false),
                    AdminmessageId = table.Column<int>(type: "integer", nullable: true),
                    AdminAdvertisementId = table.Column<int>(type: "integer", nullable: true),
                    IsTrainingModule = table.Column<bool>(type: "boolean", nullable: false),
                    OurPhilosophy = table.Column<string>(type: "text", nullable: false),
                    Purpose = table.Column<string>(type: "text", nullable: false),
                    Complaint = table.Column<string>(type: "text", nullable: false),
                    ContactUs = table.Column<string>(type: "text", nullable: false),
                    PPE = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId1 = table.Column<string>(type: "text", nullable: false),
                    CompanyContactId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyModel", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CompanyContact",
                columns: table => new
                {
                    CompanyContactId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ContactName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    ContactEmail = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    ContactTelephone = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CompanyContact", x => x.CompanyContactId);
                    table.ForeignKey(
                        name: "FK_tbl_CompanyContact_CompanyModel_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "CompanyModel",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_AdlObs_OfficerToAct",
                columns: table => new
                {
                    AdlObsOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    ObservationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_AdlObs_OfficerToAct", x => x.AdlObsOfficerToActId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_assignalertstaff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffAlertId = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_assignalertstaff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_assignalertstaff_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_tbl_assignalertstaff_tbl_staffalert_StaffAlertId",
                        column: x => x.StaffAlertId,
                        principalTable: "tbl_staffalert",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BloodCoag_OfficerToAct",
                columns: table => new
                {
                    BloodCoagOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    BloodRecordId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BloodCoag_OfficerToAct", x => x.BloodCoagOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_BloodCoag_OfficerToAct_tbl_Client_BloodCoagulationRecor~",
                        column: x => x.BloodRecordId,
                        principalTable: "tbl_Client_BloodCoagulationRecord",
                        principalColumn: "BloodRecordId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BloodCoag_Physician",
                columns: table => new
                {
                    BloodCoagPhysicianId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    BloodRecordId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BloodCoag_Physician", x => x.BloodCoagPhysicianId);
                    table.ForeignKey(
                        name: "FK_tbl_BloodCoag_Physician_tbl_Client_BloodCoagulationRecord_B~",
                        column: x => x.BloodRecordId,
                        principalTable: "tbl_Client_BloodCoagulationRecord",
                        principalColumn: "BloodRecordId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BloodCoag_StaffName",
                columns: table => new
                {
                    BloodCoagStaffNameId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    BloodRecordId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BloodCoag_StaffName", x => x.BloodCoagStaffNameId);
                    table.ForeignKey(
                        name: "FK_tbl_BloodCoag_StaffName_tbl_Client_BloodCoagulationRecord_B~",
                        column: x => x.BloodRecordId,
                        principalTable: "tbl_Client_BloodCoagulationRecord",
                        principalColumn: "BloodRecordId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BloodPressure_OfficerToAct",
                columns: table => new
                {
                    BloodPressureOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    BloodPressureId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BloodPressure_OfficerToAct", x => x.BloodPressureOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_BloodPressure_OfficerToAct_tbl_Client_BloodPressure_Blo~",
                        column: x => x.BloodPressureId,
                        principalTable: "tbl_Client_BloodPressure",
                        principalColumn: "BloodPressureId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BloodPressure_Physician",
                columns: table => new
                {
                    BloodPressurePhysicianId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    BloodPressureId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BloodPressure_Physician", x => x.BloodPressurePhysicianId);
                    table.ForeignKey(
                        name: "FK_tbl_BloodPressure_Physician_tbl_Client_BloodPressure_BloodP~",
                        column: x => x.BloodPressureId,
                        principalTable: "tbl_Client_BloodPressure",
                        principalColumn: "BloodPressureId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BloodPressure_StaffName",
                columns: table => new
                {
                    BloodPressureStaffNameId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    BloodPressureId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BloodPressure_StaffName", x => x.BloodPressureStaffNameId);
                    table.ForeignKey(
                        name: "FK_tbl_BloodPressure_StaffName_tbl_Client_BloodPressure_BloodP~",
                        column: x => x.BloodPressureId,
                        principalTable: "tbl_Client_BloodPressure",
                        principalColumn: "BloodPressureId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BMIChart_OfficerToAct",
                columns: table => new
                {
                    BMIChartOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    BMIChartId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BMIChart_OfficerToAct", x => x.BMIChartOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_BMIChart_OfficerToAct_tbl_Client_BMIChart_BMIChartId",
                        column: x => x.BMIChartId,
                        principalTable: "tbl_Client_BMIChart",
                        principalColumn: "BMIChartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BMIChart_Physician",
                columns: table => new
                {
                    BMIChartPhysicianId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    BMIChartId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BMIChart_Physician", x => x.BMIChartPhysicianId);
                    table.ForeignKey(
                        name: "FK_tbl_BMIChart_Physician_tbl_Client_BMIChart_BMIChartId",
                        column: x => x.BMIChartId,
                        principalTable: "tbl_Client_BMIChart",
                        principalColumn: "BMIChartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BMIChart_StaffName",
                columns: table => new
                {
                    BMIChartStaffNameId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    BMIChartId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BMIChart_StaffName", x => x.BMIChartStaffNameId);
                    table.ForeignKey(
                        name: "FK_tbl_BMIChart_StaffName_tbl_Client_BMIChart_BMIChartId",
                        column: x => x.BMIChartId,
                        principalTable: "tbl_Client_BMIChart",
                        principalColumn: "BMIChartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BodyTemp_OfficerToAct",
                columns: table => new
                {
                    BodyTempOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    BodyTempId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BodyTemp_OfficerToAct", x => x.BodyTempOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_BodyTemp_OfficerToAct_tbl_Client_BodyTemp_BodyTempId",
                        column: x => x.BodyTempId,
                        principalTable: "tbl_Client_BodyTemp",
                        principalColumn: "BodyTempId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BodyTemp_Physician",
                columns: table => new
                {
                    BodyTempPhysicianId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    BodyTempId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BodyTemp_Physician", x => x.BodyTempPhysicianId);
                    table.ForeignKey(
                        name: "FK_tbl_BodyTemp_Physician_tbl_Client_BodyTemp_BodyTempId",
                        column: x => x.BodyTempId,
                        principalTable: "tbl_Client_BodyTemp",
                        principalColumn: "BodyTempId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BodyTemp_StaffName",
                columns: table => new
                {
                    BodyTempStaffNameId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    BodyTempId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BodyTemp_StaffName", x => x.BodyTempStaffNameId);
                    table.ForeignKey(
                        name: "FK_tbl_BodyTemp_StaffName_tbl_Client_BodyTemp_BodyTempId",
                        column: x => x.BodyTempId,
                        principalTable: "tbl_Client_BodyTemp",
                        principalColumn: "BodyTempId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BowelMovement_OfficerToAct",
                columns: table => new
                {
                    BowelMovementOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    BowelMovementId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BowelMovement_OfficerToAct", x => x.BowelMovementOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_BowelMovement_OfficerToAct_tbl_Client_BowelMovement_Bow~",
                        column: x => x.BowelMovementId,
                        principalTable: "tbl_Client_BowelMovement",
                        principalColumn: "BowelMovementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BowelMovement_Physician",
                columns: table => new
                {
                    BowelMovementPhysicianId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    BowelMovementId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BowelMovement_Physician", x => x.BowelMovementPhysicianId);
                    table.ForeignKey(
                        name: "FK_tbl_BowelMovement_Physician_tbl_Client_BowelMovement_BowelM~",
                        column: x => x.BowelMovementId,
                        principalTable: "tbl_Client_BowelMovement",
                        principalColumn: "BowelMovementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BowelMovement_StaffName",
                columns: table => new
                {
                    BowelMovementStaffNameId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    BowelMovementId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BowelMovement_StaffName", x => x.BowelMovementStaffNameId);
                    table.ForeignKey(
                        name: "FK_tbl_BowelMovement_StaffName_tbl_Client_BowelMovement_BowelM~",
                        column: x => x.BowelMovementId,
                        principalTable: "tbl_Client_BowelMovement",
                        principalColumn: "BowelMovementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CareObjPersonToAct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CareObjId = table.Column<int>(type: "integer", nullable: false),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CareObjPersonToAct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_CareObjPersonToAct_tbl_ClientCareObj_CareObjId",
                        column: x => x.CareObjId,
                        principalTable: "tbl_ClientCareObj",
                        principalColumn: "CareObjId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_LogAudit",
                columns: table => new
                {
                    LogAuditId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NextDueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsCareExpected = table.Column<string>(type: "text", nullable: false),
                    IsCareDifference = table.Column<string>(type: "text", nullable: false),
                    ProperDocumentation = table.Column<string>(type: "text", nullable: false),
                    ImproperDocumentation = table.Column<string>(type: "text", nullable: false),
                    Communication = table.Column<string>(type: "text", nullable: false),
                    ThinkingServiceUsers = table.Column<string>(type: "text", nullable: false),
                    ThinkingStaff = table.Column<string>(type: "text", nullable: false),
                    ThinkingStaffStop = table.Column<string>(type: "text", nullable: false),
                    Observations = table.Column<string>(type: "text", nullable: false),
                    NameOfAuditor = table.Column<string>(type: "text", nullable: false),
                    ActionRecommended = table.Column<string>(type: "text", nullable: false),
                    ActionTaken = table.Column<string>(type: "text", nullable: false),
                    EvidenceOfActionTaken = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    RepeatOfIncident = table.Column<int>(type: "integer", nullable: false),
                    RotCause = table.Column<string>(type: "text", nullable: false),
                    LessonLearntAndShared = table.Column<string>(type: "text", nullable: false),
                    LogURL = table.Column<string>(type: "text", nullable: false),
                    EvidenceFilePath = table.Column<string>(type: "text", nullable: false),
                    StaffSignature = table.Column<string>(type: "text", nullable: false),
                    ManagerSignature = table.Column<string>(type: "text", nullable: false),
                    ClientSignature = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_LogAudit", x => x.LogAuditId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_LogAudit_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_Client_LogAudit_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_MedAudit",
                columns: table => new
                {
                    MedAuditId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NextDueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GapsInAdmistration = table.Column<int>(type: "integer", nullable: false),
                    RightsOfMedication = table.Column<string>(type: "text", nullable: false),
                    MarChartReview = table.Column<int>(type: "integer", nullable: false),
                    MedicationConcern = table.Column<int>(type: "integer", nullable: false),
                    HardCopyReview = table.Column<int>(type: "integer", nullable: false),
                    ThinkingServiceUsers = table.Column<string>(type: "text", nullable: false),
                    MedicationSupplyEfficiency = table.Column<int>(type: "integer", nullable: false),
                    MedicationInfoUploadEefficiency = table.Column<int>(type: "integer", nullable: false),
                    Observations = table.Column<string>(type: "text", nullable: false),
                    ActionRecommended = table.Column<string>(type: "text", nullable: false),
                    ActionTaken = table.Column<string>(type: "text", nullable: false),
                    EvidenceOfActionTaken = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    RepeatOfIncident = table.Column<int>(type: "integer", nullable: false),
                    RotCause = table.Column<string>(type: "text", nullable: false),
                    LessonLearntAndShared = table.Column<string>(type: "text", nullable: false),
                    LogURL = table.Column<string>(type: "text", nullable: false),
                    Attachment = table.Column<string>(type: "text", nullable: false),
                    StaffSignature = table.Column<string>(type: "text", nullable: false),
                    ManagerSignature = table.Column<string>(type: "text", nullable: false),
                    ClientSignature = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_MedAudit", x => x.MedAuditId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_MedAudit_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_Client_MedAudit_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_MgtVisit",
                columns: table => new
                {
                    VisitId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    NextCheckDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RateServiceRecieving = table.Column<int>(type: "integer", nullable: true),
                    RateManagers = table.Column<int>(type: "integer", nullable: true),
                    HowToComplain = table.Column<int>(type: "integer", nullable: true),
                    ServiceRecommended = table.Column<int>(type: "integer", nullable: true),
                    ImprovementExpect = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    Observation = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    ActionRequired = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    ActionsTakenByMPCC = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    EvidenceOfActionTaken = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RotCause = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    LessonLearntAndShared = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: true),
                    Remarks = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    URL = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Attachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    OfficerToAct = table.Column<string>(type: "text", nullable: false),
                    StaffName = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_MgtVisit", x => x.VisitId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_MgtVisit_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_Program",
                columns: table => new
                {
                    ProgramId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    NextCheckDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ProgramOfChoice = table.Column<int>(type: "integer", nullable: true),
                    DaysOfChoice = table.Column<int>(type: "integer", nullable: true),
                    PlaceLocationProgram = table.Column<int>(type: "integer", nullable: true),
                    DetailsOfProgram = table.Column<int>(type: "integer", nullable: true),
                    Observation = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    ActionRequired = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: true),
                    Remarks = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    URL = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Attachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    OfficerToAct = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_Program", x => x.ProgramId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_Program_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_ServiceWatch",
                columns: table => new
                {
                    WatchId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    NextCheckDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Incident = table.Column<int>(type: "integer", nullable: true),
                    Details = table.Column<int>(type: "integer", nullable: true),
                    Contact = table.Column<int>(type: "integer", nullable: true),
                    Observation = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    ActionRequired = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: true),
                    Remarks = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    URL = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Attachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    PersonToAct = table.Column<string>(type: "text", nullable: false),
                    StaffToAct = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_ServiceWatch", x => x.WatchId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_ServiceWatch_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client_Voice",
                columns: table => new
                {
                    VoiceId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    NextCheckDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RateServiceRecieving = table.Column<int>(type: "integer", nullable: true),
                    RateStaffAttending = table.Column<int>(type: "integer", nullable: true),
                    OfficeStaffSupport = table.Column<int>(type: "integer", nullable: true),
                    AreasOfImprovements = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    SomethingSpecial = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    InterestedInPrograms = table.Column<int>(type: "integer", nullable: true),
                    HealthGoalShortTerm = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    HealthGoalLongTerm = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    ActionRequired = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    ActionsTakenByMPCC = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    EvidenceOfActionTaken = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: true),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Remarks = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    RotCause = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    LessonLearntAndShared = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    URL = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Attachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    OfficerToAct = table.Column<string>(type: "text", nullable: false),
                    CallerName = table.Column<string>(type: "text", nullable: false),
                    GoodStaff = table.Column<string>(type: "text", nullable: false),
                    PoorStaff = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client_Voice", x => x.VoiceId);
                    table.ForeignKey(
                        name: "FK_tbl_Client_Voice_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientTaskBoardAssignedTo",
                columns: table => new
                {
                    TaskBoardAssignedToId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    TaskBoardId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientTaskBoardAssignedTo", x => x.TaskBoardAssignedToId);
                    table.ForeignKey(
                        name: "FK_tbl_ClientTaskBoardAssignedTo_tbl_ClientTaskBoard_TaskBoard~",
                        column: x => x.TaskBoardId,
                        principalTable: "tbl_ClientTaskBoard",
                        principalColumn: "TaskBoardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Complain_OfficerToAct",
                columns: table => new
                {
                    ComplainOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    ComplainId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Complain_OfficerToAct", x => x.ComplainOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_Complain_OfficerToAct_tbl_Client_ComplainRegister_Compl~",
                        column: x => x.ComplainId,
                        principalTable: "tbl_Client_ComplainRegister",
                        principalColumn: "ComplainId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Complain_StaffName",
                columns: table => new
                {
                    ComplainStaffNameId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    ComplainId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Complain_StaffName", x => x.ComplainStaffNameId);
                    table.ForeignKey(
                        name: "FK_tbl_Complain_StaffName_tbl_Client_ComplainRegister_Complain~",
                        column: x => x.ComplainId,
                        principalTable: "tbl_Client_ComplainRegister",
                        principalColumn: "ComplainId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ComplainRegistorStaff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ComplainRegistorId = table.Column<int>(type: "integer", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false),
                    StaffResponse = table.Column<string>(type: "character varying(1056)", maxLength: 1056, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ComplainRegistorStaff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_ComplainRegistorStaff_tbl_ComplainRegistor_ComplainRegi~",
                        column: x => x.ComplainRegistorId,
                        principalTable: "tbl_ComplainRegistor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_createshiftuserroles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ShiftId = table.Column<int>(type: "integer", nullable: false),
                    ClientFacilityId = table.Column<int>(type: "integer", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    StaffJobCategory = table.Column<int>(type: "integer", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndtTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsBook = table.Column<bool>(type: "boolean", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_createshiftuserroles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_createshiftuserroles_tbl_ClientFacility_ClientFacilityId",
                        column: x => x.ClientFacilityId,
                        principalTable: "tbl_ClientFacility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_createshiftuserroles_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_createshiftuserroles_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_tbl_createshiftuserroles_tbl_createshift_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "tbl_createshift",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_DutyOnCallPersonResponsible",
                columns: table => new
                {
                    PersonResponsibleId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false),
                    DutyOnCallId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DutyOnCallPersonResponsible", x => x.PersonResponsibleId);
                    table.ForeignKey(
                        name: "FK_tbl_DutyOnCallPersonResponsible_tbl_DutyOnCall_DutyOnCallId",
                        column: x => x.DutyOnCallId,
                        principalTable: "tbl_DutyOnCall",
                        principalColumn: "DutyOnCallId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_DutyOnCallPersonToAct",
                columns: table => new
                {
                    PersonToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false),
                    DutyOnCallId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DutyOnCallPersonToAct", x => x.PersonToActId);
                    table.ForeignKey(
                        name: "FK_tbl_DutyOnCallPersonToAct_tbl_DutyOnCall_DutyOnCallId",
                        column: x => x.DutyOnCallId,
                        principalTable: "tbl_DutyOnCall",
                        principalColumn: "DutyOnCallId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Equipment",
                columns: table => new
                {
                    EquipmentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonalDetailId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Location = table.Column<int>(type: "integer", nullable: false),
                    ServiceDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NextServiceDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Attachment = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    PersonToAct = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Equipment", x => x.EquipmentId);
                    table.ForeignKey(
                        name: "FK_tbl_Equipment_tbl_PersonalDetail_PersonalDetailId",
                        column: x => x.PersonalDetailId,
                        principalTable: "tbl_PersonalDetail",
                        principalColumn: "PersonalDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ExternalRole",
                columns: table => new
                {
                    ExternalId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Telephone = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ExternalRole", x => x.ExternalId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_EyeHealth_OfficerToAct",
                columns: table => new
                {
                    EyeHealthOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    EyeHealthId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_EyeHealth_OfficerToAct", x => x.EyeHealthOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_EyeHealth_OfficerToAct_tbl_Client_EyeHealthMonitoring_E~",
                        column: x => x.EyeHealthId,
                        principalTable: "tbl_Client_EyeHealthMonitoring",
                        principalColumn: "EyeHealthId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_EyeHealth_Physician",
                columns: table => new
                {
                    EyeHealthPhysicianId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    EyeHealthId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_EyeHealth_Physician", x => x.EyeHealthPhysicianId);
                    table.ForeignKey(
                        name: "FK_tbl_EyeHealth_Physician_tbl_Client_EyeHealthMonitoring_EyeH~",
                        column: x => x.EyeHealthId,
                        principalTable: "tbl_Client_EyeHealthMonitoring",
                        principalColumn: "EyeHealthId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_EyeHealth_StaffName",
                columns: table => new
                {
                    EyeHealthStaffNameId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    EyeHealthId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_EyeHealth_StaffName", x => x.EyeHealthStaffNameId);
                    table.ForeignKey(
                        name: "FK_tbl_EyeHealth_StaffName_tbl_Client_EyeHealthMonitoring_EyeH~",
                        column: x => x.EyeHealthId,
                        principalTable: "tbl_Client_EyeHealthMonitoring",
                        principalColumn: "EyeHealthId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_FilesAndRecord",
                columns: table => new
                {
                    FilesAndRecordId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    Subject = table.Column<string>(type: "text", nullable: false),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    Attachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    FileName = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    FileFormat = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_FilesAndRecord", x => x.FilesAndRecordId);
                    table.ForeignKey(
                        name: "FK_tbl_FilesAndRecord_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_FilesAndRecord_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_FoodIntake_OfficerToAct",
                columns: table => new
                {
                    FoodIntakeOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    FoodIntakeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_FoodIntake_OfficerToAct", x => x.FoodIntakeOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_FoodIntake_OfficerToAct_tbl_Client_FoodIntake_FoodIntak~",
                        column: x => x.FoodIntakeId,
                        principalTable: "tbl_Client_FoodIntake",
                        principalColumn: "FoodIntakeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_FoodIntake_Physician",
                columns: table => new
                {
                    FoodIntakePhysicianId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    FoodIntakeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_FoodIntake_Physician", x => x.FoodIntakePhysicianId);
                    table.ForeignKey(
                        name: "FK_tbl_FoodIntake_Physician_tbl_Client_FoodIntake_FoodIntakeId",
                        column: x => x.FoodIntakeId,
                        principalTable: "tbl_Client_FoodIntake",
                        principalColumn: "FoodIntakeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_FoodIntake_StaffName",
                columns: table => new
                {
                    FoodIntakeStaffNameId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    FoodIntakeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_FoodIntake_StaffName", x => x.FoodIntakeStaffNameId);
                    table.ForeignKey(
                        name: "FK_tbl_FoodIntake_StaffName_tbl_Client_FoodIntake_FoodIntakeId",
                        column: x => x.FoodIntakeId,
                        principalTable: "tbl_Client_FoodIntake",
                        principalColumn: "FoodIntakeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_HeartRate_OfficerToAct",
                columns: table => new
                {
                    HeartRateOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    HeartRateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_HeartRate_OfficerToAct", x => x.HeartRateOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_HeartRate_OfficerToAct_tbl_Client_HeartRate_HeartRateId",
                        column: x => x.HeartRateId,
                        principalTable: "tbl_Client_HeartRate",
                        principalColumn: "HeartRateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_HeartRate_Physician",
                columns: table => new
                {
                    HeartRatePhysicianId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    HeartRateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_HeartRate_Physician", x => x.HeartRatePhysicianId);
                    table.ForeignKey(
                        name: "FK_tbl_HeartRate_Physician_tbl_Client_HeartRate_HeartRateId",
                        column: x => x.HeartRateId,
                        principalTable: "tbl_Client_HeartRate",
                        principalColumn: "HeartRateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_HeartRate_StaffName",
                columns: table => new
                {
                    HeartRateStaffNameId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    HeartRateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_HeartRate_StaffName", x => x.HeartRateStaffNameId);
                    table.ForeignKey(
                        name: "FK_tbl_HeartRate_StaffName_tbl_Client_HeartRate_HeartRateId",
                        column: x => x.HeartRateId,
                        principalTable: "tbl_Client_HeartRate",
                        principalColumn: "HeartRateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_HospitalEntryPersonToTakeAction",
                columns: table => new
                {
                    HospitalEntryPersonToTakeActionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HospitalEntryId = table.Column<int>(type: "integer", nullable: false),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_HospitalEntryPersonToTakeAction", x => x.HospitalEntryPersonToTakeActionId);
                    table.ForeignKey(
                        name: "FK_tbl_HospitalEntryPersonToTakeAction_tbl_HospitalEntry_Hospi~",
                        column: x => x.HospitalEntryId,
                        principalTable: "tbl_HospitalEntry",
                        principalColumn: "HospitalEntryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_HospitalEntryStaffInvolved",
                columns: table => new
                {
                    HospitalEntryStaffInvolvedId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HospitalEntryId = table.Column<int>(type: "integer", nullable: false),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_HospitalEntryStaffInvolved", x => x.HospitalEntryStaffInvolvedId);
                    table.ForeignKey(
                        name: "FK_tbl_HospitalEntryStaffInvolved_tbl_HospitalEntry_HospitalEn~",
                        column: x => x.HospitalEntryId,
                        principalTable: "tbl_HospitalEntry",
                        principalColumn: "HospitalEntryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_HospitalExitOfficerToTakeAction",
                columns: table => new
                {
                    HospitalExitOfficerToTakeActionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HospitalExitId = table.Column<int>(type: "integer", nullable: false),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_HospitalExitOfficerToTakeAction", x => x.HospitalExitOfficerToTakeActionId);
                    table.ForeignKey(
                        name: "FK_tbl_HospitalExitOfficerToTakeAction_tbl_HospitalExit_Hospit~",
                        column: x => x.HospitalExitId,
                        principalTable: "tbl_HospitalExit",
                        principalColumn: "HospitalExitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_IncidentDetailAssignedTo",
                columns: table => new
                {
                    IncidentDetailAssignedToId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false),
                    IncidentDetailId = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_IncidentDetailAssignedTo", x => x.IncidentDetailAssignedToId);
                    table.ForeignKey(
                        name: "FK_tbl_IncidentDetailAssignedTo_tbl_IncidentDetail_IncidentDet~",
                        column: x => x.IncidentDetailId,
                        principalTable: "tbl_IncidentDetail",
                        principalColumn: "IncidentDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_KeyWorker_OfficerToAct",
                columns: table => new
                {
                    KeyWorkerOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KeyWorkerId = table.Column<int>(type: "integer", nullable: false),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    StaffKeyWorkerVoiceKeyWorkerId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_KeyWorker_OfficerToAct", x => x.KeyWorkerOfficerToActId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_KeyWorker_StaffName",
                columns: table => new
                {
                    KeyWorkerWorkteamId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    KeyWorkerId = table.Column<int>(type: "integer", nullable: false),
                    StaffKeyWorkerVoiceKeyWorkerId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_KeyWorker_StaffName", x => x.KeyWorkerWorkteamId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_LogAudit_OfficerToAct",
                columns: table => new
                {
                    LogAuditOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    LogAuditId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_LogAudit_OfficerToAct", x => x.LogAuditOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_LogAudit_OfficerToAct_tbl_Client_LogAudit_LogAuditId",
                        column: x => x.LogAuditId,
                        principalTable: "tbl_Client_LogAudit",
                        principalColumn: "LogAuditId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MedAudit_AuditorName",
                columns: table => new
                {
                    MedAuditStaffNameId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    MedAuditId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MedAudit_AuditorName", x => x.MedAuditStaffNameId);
                    table.ForeignKey(
                        name: "FK_tbl_MedAudit_AuditorName_tbl_Client_MedAudit_MedAuditId",
                        column: x => x.MedAuditId,
                        principalTable: "tbl_Client_MedAudit",
                        principalColumn: "MedAuditId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MedAudit_OfficerToAct",
                columns: table => new
                {
                    MedAuditOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    MedAuditId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MedAudit_OfficerToAct", x => x.MedAuditOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_MedAudit_OfficerToAct_tbl_Client_MedAudit_MedAuditId",
                        column: x => x.MedAuditId,
                        principalTable: "tbl_Client_MedAudit",
                        principalColumn: "MedAuditId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MedComp_OfficerToAct",
                columns: table => new
                {
                    MedCompOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    MedCompId = table.Column<int>(type: "integer", nullable: false),
                    StaffMedCompMedCompId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MedComp_OfficerToAct", x => x.MedCompOfficerToActId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MeetingLogAttende",
                columns: table => new
                {
                    MeetingLogAttendeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    MeetingLogId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MeetingLogAttende", x => x.MeetingLogAttendeId);
                    table.ForeignKey(
                        name: "FK_tbl_MeetingLogAttende_tbl_MeetingLog_MeetingLogId",
                        column: x => x.MeetingLogId,
                        principalTable: "tbl_MeetingLog",
                        principalColumn: "MeetingLogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MeetingLogFacilitator",
                columns: table => new
                {
                    MeetingLogFacilitatorId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    MeetingLogId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MeetingLogFacilitator", x => x.MeetingLogFacilitatorId);
                    table.ForeignKey(
                        name: "FK_tbl_MeetingLogFacilitator_tbl_MeetingLog_MeetingLogId",
                        column: x => x.MeetingLogId,
                        principalTable: "tbl_MeetingLog",
                        principalColumn: "MeetingLogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MeetingLogResponsibleToAct",
                columns: table => new
                {
                    MeetingLogResponsibleId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    MeetingLogId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MeetingLogResponsibleToAct", x => x.MeetingLogResponsibleId);
                    table.ForeignKey(
                        name: "FK_tbl_MeetingLogResponsibleToAct_tbl_MeetingLog_MeetingLogId",
                        column: x => x.MeetingLogId,
                        principalTable: "tbl_MeetingLog",
                        principalColumn: "MeetingLogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_OfficeAttendance",
                columns: table => new
                {
                    AttendanceId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    JobTitle = table.Column<string>(type: "text", nullable: true),
                    Staff = table.Column<int>(type: "integer", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: true),
                    ClockInAddress = table.Column<string>(type: "text", nullable: true),
                    ClockInDistance = table.Column<string>(type: "text", nullable: true),
                    ClockOutAddress = table.Column<string>(type: "text", nullable: true),
                    ClockOutDistance = table.Column<string>(type: "text", nullable: true),
                    StartTime = table.Column<string>(type: "text", nullable: true),
                    StopTime = table.Column<string>(type: "text", nullable: true),
                    ClockIn = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    ClockOut = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    ClockInMethod = table.Column<string>(type: "text", nullable: true),
                    ClockOutMethod = table.Column<string>(type: "text", nullable: true),
                    ClockDiff = table.Column<string>(type: "text", nullable: true),
                    Remark = table.Column<string>(type: "text", nullable: true),
                    Latitude = table.Column<string>(type: "text", nullable: false),
                    Longitude = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_OfficeAttendance", x => x.AttendanceId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_OfficeLocation",
                columns: table => new
                {
                    OfficeLocationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UniqueId = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    Address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Latitude = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Longitude = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ContactPersonFullName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ContactPersonEmail = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ContactPersonPhoneNumber = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_OfficeLocation", x => x.OfficeLocationId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_OneToOne_OfficerToAct",
                columns: table => new
                {
                    OneToOneOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    OneToOneId = table.Column<int>(type: "integer", nullable: false),
                    StaffOneToOneOneToOneId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_OneToOne_OfficerToAct", x => x.OneToOneOfficerToActId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_OxygenLvl_OfficerToAct",
                columns: table => new
                {
                    OxygenLvlOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    OxygenLvlId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_OxygenLvl_OfficerToAct", x => x.OxygenLvlOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_OxygenLvl_OfficerToAct_tbl_Client_Oxygenlvl_OxygenLvlId",
                        column: x => x.OxygenLvlId,
                        principalTable: "tbl_Client_Oxygenlvl",
                        principalColumn: "OxygenLvlId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_OxygenLvl_Physician",
                columns: table => new
                {
                    OxygenLvlPhysicianId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    OxygenLvlId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_OxygenLvl_Physician", x => x.OxygenLvlPhysicianId);
                    table.ForeignKey(
                        name: "FK_tbl_OxygenLvl_Physician_tbl_Client_Oxygenlvl_OxygenLvlId",
                        column: x => x.OxygenLvlId,
                        principalTable: "tbl_Client_Oxygenlvl",
                        principalColumn: "OxygenLvlId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_OxygenLvl_StaffName",
                columns: table => new
                {
                    OxygenLvlStaffNameId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    OxygenLvlId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_OxygenLvl_StaffName", x => x.OxygenLvlStaffNameId);
                    table.ForeignKey(
                        name: "FK_tbl_OxygenLvl_StaffName_tbl_Client_Oxygenlvl_OxygenLvlId",
                        column: x => x.OxygenLvlId,
                        principalTable: "tbl_Client_Oxygenlvl",
                        principalColumn: "OxygenLvlId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_PainChart_OfficerToAct",
                columns: table => new
                {
                    PainChartOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    PainChartId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PainChart_OfficerToAct", x => x.PainChartOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_PainChart_OfficerToAct_tbl_Client_PainChart_PainChartId",
                        column: x => x.PainChartId,
                        principalTable: "tbl_Client_PainChart",
                        principalColumn: "PainChartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_PainChart_Physician",
                columns: table => new
                {
                    PainChartPhysicianId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    PainChartId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PainChart_Physician", x => x.PainChartPhysicianId);
                    table.ForeignKey(
                        name: "FK_tbl_PainChart_Physician_tbl_Client_PainChart_PainChartId",
                        column: x => x.PainChartId,
                        principalTable: "tbl_Client_PainChart",
                        principalColumn: "PainChartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_PainChart_StaffName",
                columns: table => new
                {
                    PainChartStaffNameId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    PainChartId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PainChart_StaffName", x => x.PainChartStaffNameId);
                    table.ForeignKey(
                        name: "FK_tbl_PainChart_StaffName_tbl_Client_PainChart_PainChartId",
                        column: x => x.PainChartId,
                        principalTable: "tbl_Client_PainChart",
                        principalColumn: "PainChartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Program_OfficerToAct",
                columns: table => new
                {
                    ProgramOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProgramId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Program_OfficerToAct", x => x.ProgramOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_Program_OfficerToAct_tbl_Client_Program_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "tbl_Client_Program",
                        principalColumn: "ProgramId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_PulseRate_OfficerToAct",
                columns: table => new
                {
                    PulseRateOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    PulseRateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PulseRate_OfficerToAct", x => x.PulseRateOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_PulseRate_OfficerToAct_tbl_Client_PulseRate_PulseRateId",
                        column: x => x.PulseRateId,
                        principalTable: "tbl_Client_PulseRate",
                        principalColumn: "PulseRateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_PulseRate_Physician",
                columns: table => new
                {
                    PulseRatePhysicianId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    PulseRateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PulseRate_Physician", x => x.PulseRatePhysicianId);
                    table.ForeignKey(
                        name: "FK_tbl_PulseRate_Physician_tbl_Client_PulseRate_PulseRateId",
                        column: x => x.PulseRateId,
                        principalTable: "tbl_Client_PulseRate",
                        principalColumn: "PulseRateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_PulseRate_StaffName",
                columns: table => new
                {
                    PulseRateStaffNameId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    PulseRateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PulseRate_StaffName", x => x.PulseRateStaffNameId);
                    table.ForeignKey(
                        name: "FK_tbl_PulseRate_StaffName_tbl_Client_PulseRate_PulseRateId",
                        column: x => x.PulseRateId,
                        principalTable: "tbl_Client_PulseRate",
                        principalColumn: "PulseRateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_RotaStaff",
                columns: table => new
                {
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    StaffMedRotaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_RotaStaff", x => new { x.StaffId, x.StaffMedRotaId });
                });

            migrationBuilder.CreateTable(
                name: "tbl_SalaryAllowance",
                columns: table => new
                {
                    SalaryAllowanceId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AllowanceType = table.Column<int>(type: "integer", nullable: false),
                    Reoccurent = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    Percentage = table.Column<decimal>(type: "numeric", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_SalaryAllowance", x => x.SalaryAllowanceId);
                    table.ForeignKey(
                        name: "FK_tbl_SalaryAllowance_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_SalaryDeduction",
                columns: table => new
                {
                    SalaryDeductionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AllowanceType = table.Column<int>(type: "integer", nullable: false),
                    Reoccurent = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    Percentage = table.Column<decimal>(type: "numeric", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_SalaryDeduction", x => x.SalaryDeductionId);
                    table.ForeignKey(
                        name: "FK_tbl_SalaryDeduction_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Seizure_OfficerToAct",
                columns: table => new
                {
                    SeizureOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    SeizureId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Seizure_OfficerToAct", x => x.SeizureOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_Seizure_OfficerToAct_tbl_Client_Seizure_SeizureId",
                        column: x => x.SeizureId,
                        principalTable: "tbl_Client_Seizure",
                        principalColumn: "SeizureId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Seizure_Physician",
                columns: table => new
                {
                    SeizurePhysicianId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    SeizureId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Seizure_Physician", x => x.SeizurePhysicianId);
                    table.ForeignKey(
                        name: "FK_tbl_Seizure_Physician_tbl_Client_Seizure_SeizureId",
                        column: x => x.SeizureId,
                        principalTable: "tbl_Client_Seizure",
                        principalColumn: "SeizureId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Seizure_StaffName",
                columns: table => new
                {
                    SeizureStaffNameId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    SeizureId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Seizure_StaffName", x => x.SeizureStaffNameId);
                    table.ForeignKey(
                        name: "FK_tbl_Seizure_StaffName_tbl_Client_Seizure_SeizureId",
                        column: x => x.SeizureId,
                        principalTable: "tbl_Client_Seizure",
                        principalColumn: "SeizureId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Service_OfficerToAct",
                columns: table => new
                {
                    ServiceOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Service_OfficerToAct", x => x.ServiceOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_Service_OfficerToAct_tbl_Client_ServiceWatch_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "tbl_Client_ServiceWatch",
                        principalColumn: "WatchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Service_StaffName",
                columns: table => new
                {
                    ServiceStaffNameId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Service_StaffName", x => x.ServiceStaffNameId);
                    table.ForeignKey(
                        name: "FK_tbl_Service_StaffName_tbl_Client_ServiceWatch_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "tbl_Client_ServiceWatch",
                        principalColumn: "WatchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_SetupStaffHoliday",
                columns: table => new
                {
                    SetupHolidayId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    YearOfEmployment = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TypeOfHoliday = table.Column<int>(type: "integer", nullable: false),
                    YearEndPeriodStartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    HoursSoFar = table.Column<int>(type: "integer", nullable: false),
                    IncrementalDailyHolidayByHrs = table.Column<int>(type: "integer", nullable: false),
                    NumberOfDays = table.Column<int>(type: "integer", nullable: false),
                    Remark = table.Column<string>(type: "text", nullable: false),
                    Attachment = table.Column<string>(type: "text", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_SetupStaffHoliday", x => x.SetupHolidayId);
                    table.ForeignKey(
                        name: "FK_tbl_SetupStaffHoliday_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ShiftBooking",
                columns: table => new
                {
                    ShiftBookingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ShiftDate = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Rota = table.Column<int>(type: "integer", nullable: false),
                    NumberOfStaff = table.Column<int>(type: "integer", nullable: false),
                    StartTime = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    StopTime = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Remark = table.Column<string>(type: "character varying(225)", maxLength: 225, nullable: false),
                    Team_StaffPersonalInfoId = table.Column<int>(type: "integer", nullable: false),
                    DriverRequired = table.Column<bool>(type: "boolean", nullable: false),
                    PublishTo = table.Column<int>(type: "integer", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ShiftBooking", x => x.ShiftBookingId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ShiftBookingBlockedDays",
                columns: table => new
                {
                    ShiftBookingBlockedDaysId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ShiftBookingId = table.Column<int>(type: "integer", nullable: false),
                    Day = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    WeekDay = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ShiftBookingBlockedDays", x => x.ShiftBookingBlockedDaysId);
                    table.ForeignKey(
                        name: "FK_tbl_ShiftBookingBlockedDays_tbl_ShiftBooking_ShiftBookingId",
                        column: x => x.ShiftBookingId,
                        principalTable: "tbl_ShiftBooking",
                        principalColumn: "ShiftBookingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_SpotCheck_OfficerToAct",
                columns: table => new
                {
                    SpotCheckOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    SpotCheckId = table.Column<int>(type: "integer", nullable: false),
                    StaffSpotCheckSpotCheckId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_SpotCheck_OfficerToAct", x => x.SpotCheckOfficerToActId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Staff_AdlObs",
                columns: table => new
                {
                    ObservationID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NextCheckDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Details = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    UnderstandingofEquipment = table.Column<int>(type: "integer", nullable: false),
                    UnderstandingofService = table.Column<int>(type: "integer", nullable: false),
                    UnderstandingofControl = table.Column<int>(type: "integer", nullable: false),
                    FivePrinciples = table.Column<int>(type: "integer", nullable: false),
                    Comments = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    ActionRequired = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    URL = table.Column<string>(type: "text", nullable: false),
                    Attachment = table.Column<string>(type: "text", nullable: false),
                    StaffSignature = table.Column<string>(type: "text", nullable: false),
                    ManagerSignature = table.Column<string>(type: "text", nullable: false),
                    ClientSignature = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Staff_AdlObs", x => x.ObservationID);
                    table.ForeignKey(
                        name: "FK_tbl_Staff_AdlObs_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_Staff_AdlObs_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Staff_KeyWorkerVoice",
                columns: table => new
                {
                    KeyWorkerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NextCheckDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Details = table.Column<string>(type: "text", nullable: false),
                    NotComfortableServices = table.Column<int>(type: "integer", nullable: false),
                    ServicesRequiresTime = table.Column<int>(type: "integer", nullable: false),
                    ServicesRequiresServices = table.Column<Guid>(type: "uuid", nullable: false),
                    WellSupportedServices = table.Column<int>(type: "integer", nullable: false),
                    ChangesWeNeed = table.Column<string>(type: "text", nullable: false),
                    NutritionalChanges = table.Column<string>(type: "text", nullable: false),
                    HealthAndWellNessChanges = table.Column<string>(type: "text", nullable: false),
                    MedicationChanges = table.Column<string>(type: "text", nullable: false),
                    MovingAndHandling = table.Column<string>(type: "text", nullable: false),
                    RiskAssessment = table.Column<string>(type: "text", nullable: false),
                    ActionRequired = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    URL = table.Column<string>(type: "text", nullable: false),
                    Attachment = table.Column<string>(type: "text", nullable: false),
                    StaffSignature = table.Column<string>(type: "text", nullable: false),
                    ManagerSignature = table.Column<string>(type: "text", nullable: false),
                    ClientSignature = table.Column<string>(type: "text", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Staff_KeyWorkerVoice", x => x.KeyWorkerId);
                    table.ForeignKey(
                        name: "FK_tbl_Staff_KeyWorkerVoice_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Staff_MedCompObs",
                columns: table => new
                {
                    MedCompId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NextCheckDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Details = table.Column<string>(type: "text", nullable: false),
                    UnderstandingofMedication = table.Column<int>(type: "integer", nullable: false),
                    UnderstandingofRights = table.Column<int>(type: "integer", nullable: false),
                    ReadingMedicalPrescriptions = table.Column<int>(type: "integer", nullable: false),
                    CarePlan = table.Column<int>(type: "integer", nullable: false),
                    RateStaff = table.Column<int>(type: "integer", nullable: false),
                    ActionRequired = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    URL = table.Column<string>(type: "text", nullable: false),
                    Attachment = table.Column<string>(type: "text", nullable: false),
                    StaffSignature = table.Column<string>(type: "text", nullable: false),
                    ManagerSignature = table.Column<string>(type: "text", nullable: false),
                    ClientSignature = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Staff_MedCompObs", x => x.MedCompId);
                    table.ForeignKey(
                        name: "FK_tbl_Staff_MedCompObs_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_Staff_MedCompObs_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Staff_OneToOne",
                columns: table => new
                {
                    OneToOneId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NextCheckDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Purpose = table.Column<string>(type: "text", nullable: false),
                    PreviousSupervision = table.Column<string>(type: "character varying(38)", maxLength: 38, nullable: false),
                    StaffImprovedInAreas = table.Column<string>(type: "text", nullable: false),
                    CurrentEventArea = table.Column<string>(type: "text", nullable: false),
                    StaffConclusion = table.Column<string>(type: "text", nullable: false),
                    DecisionsReached = table.Column<string>(type: "text", nullable: false),
                    ImprovementRecorded = table.Column<string>(type: "text", nullable: false),
                    ActionRequired = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<string>(type: "character varying(38)", maxLength: 38, nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    URL = table.Column<string>(type: "text", nullable: false),
                    Attachment = table.Column<string>(type: "text", nullable: false),
                    StaffSignature = table.Column<string>(type: "text", nullable: false),
                    ManagerSignature = table.Column<string>(type: "text", nullable: false),
                    ClientSignature = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Staff_OneToOne", x => x.OneToOneId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Staff_Reference",
                columns: table => new
                {
                    StaffReferenceId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ApplicantRole = table.Column<Guid>(type: "uuid", nullable: false),
                    DateofEmployement = table.Column<int>(type: "integer", nullable: false),
                    DateofExit = table.Column<string>(type: "text", nullable: false),
                    RehireStaff = table.Column<string>(type: "text", nullable: false),
                    Relationship = table.Column<string>(type: "text", nullable: false),
                    TeamWork = table.Column<int>(type: "integer", nullable: false),
                    Integrity = table.Column<int>(type: "integer", nullable: false),
                    Knowledgeable = table.Column<int>(type: "integer", nullable: false),
                    WorkUnderPressure = table.Column<int>(type: "integer", nullable: false),
                    Caring = table.Column<int>(type: "integer", nullable: false),
                    PreviousExperience = table.Column<int>(type: "integer", nullable: false),
                    RefreeName = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Contact = table.Column<string>(type: "text", nullable: false),
                    Attachment = table.Column<string>(type: "text", nullable: false),
                    ConfirmedBy = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Staff_Reference", x => x.StaffReferenceId);
                    table.ForeignKey(
                        name: "FK_tbl_Staff_Reference_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Staff_SpotCheck",
                columns: table => new
                {
                    SpotCheckId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NextCheckDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Details = table.Column<string>(type: "text", nullable: false),
                    StaffArriveOnTime = table.Column<int>(type: "integer", nullable: false),
                    StaffDressCode = table.Column<int>(type: "integer", nullable: false),
                    AreaComments = table.Column<string>(type: "text", nullable: false),
                    ActionRequired = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    URL = table.Column<string>(type: "text", nullable: false),
                    Attachment = table.Column<string>(type: "text", nullable: false),
                    StaffSignature = table.Column<string>(type: "text", nullable: false),
                    ManagerSignature = table.Column<string>(type: "text", nullable: false),
                    ClientSignature = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Staff_SpotCheck", x => x.SpotCheckId);
                    table.ForeignKey(
                        name: "FK_tbl_Staff_SpotCheck_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_Staff_SpotCheck_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Staff_SupervisionAppraisal",
                columns: table => new
                {
                    StaffSupervisionAppraisalId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NextCheckDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Details = table.Column<string>(type: "text", nullable: false),
                    StaffRating = table.Column<string>(type: "character varying(38)", maxLength: 38, nullable: false),
                    ProfessionalDevelopment = table.Column<string>(type: "character varying(38)", maxLength: 38, nullable: false),
                    StaffComplaints = table.Column<string>(type: "character varying(38)", maxLength: 38, nullable: false),
                    FiveStarRating = table.Column<string>(type: "text", nullable: false),
                    StaffDevelopment = table.Column<string>(type: "text", nullable: false),
                    StaffAbility = table.Column<string>(type: "text", nullable: false),
                    NoAbilityToSupport = table.Column<string>(type: "text", nullable: false),
                    CondourAndWhistleBlowing = table.Column<string>(type: "text", nullable: false),
                    NoCondourAndWhistleBlowing = table.Column<string>(type: "text", nullable: false),
                    StaffSupportAreas = table.Column<string>(type: "character varying(38)", maxLength: 38, nullable: false),
                    ActionRequired = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<string>(type: "character varying(38)", maxLength: 38, nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    URL = table.Column<string>(type: "text", nullable: false),
                    Attachment = table.Column<string>(type: "text", nullable: false),
                    StaffSignature = table.Column<string>(type: "text", nullable: false),
                    ManagerSignature = table.Column<string>(type: "text", nullable: false),
                    ClientSignature = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Accomplishment = table.Column<string>(type: "text", nullable: true),
                    Likemostaboutthisjob = table.Column<string>(type: "text", nullable: true),
                    Topthreepriorities = table.Column<string>(type: "text", nullable: true),
                    Managementhelped = table.Column<string>(type: "text", nullable: true),
                    Companyvalue = table.Column<string>(type: "text", nullable: true),
                    Goingforward = table.Column<string>(type: "text", nullable: true),
                    Trainingdoyouwish = table.Column<string>(type: "text", nullable: true),
                    Areyouhappyworking = table.Column<string>(type: "text", nullable: true),
                    Wouldyourecommend = table.Column<string>(type: "text", nullable: true),
                    Isthereanytraining = table.Column<string>(type: "text", nullable: true),
                    PreventionofAbuseAndSafeguarding = table.Column<string>(type: "text", nullable: true),
                    ArethereAnyChanges = table.Column<string>(type: "text", nullable: true),
                    DoYouHaveAnyQuestions = table.Column<string>(type: "text", nullable: true),
                    FeedbackFromManager = table.Column<string>(type: "text", nullable: true),
                    BiggestAchievement = table.Column<string>(type: "text", nullable: true),
                    YouContinueToDisplay = table.Column<string>(type: "text", nullable: true),
                    WhatChallenges = table.Column<string>(type: "text", nullable: true),
                    AreThereAnyChallenges = table.Column<string>(type: "text", nullable: true),
                    WhatLearningAndDevelopment = table.Column<string>(type: "text", nullable: true),
                    PromoteIndependence = table.Column<string>(type: "text", nullable: true),
                    WantToAchieve = table.Column<string>(type: "text", nullable: true),
                    CRBinfo = table.Column<string>(type: "text", nullable: true),
                    Anyquestions = table.Column<string>(type: "text", nullable: true),
                    FeedbackFromSupervisor = table.Column<string>(type: "text", nullable: true),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Staff_SupervisionAppraisal", x => x.StaffSupervisionAppraisalId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Staff_Survey",
                columns: table => new
                {
                    StaffSurveyId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NextCheckDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Details = table.Column<string>(type: "text", nullable: false),
                    AdequateTrainingReceived = table.Column<int>(type: "integer", nullable: false),
                    HealthCareServicesSatisfaction = table.Column<int>(type: "integer", nullable: false),
                    SupportFromCompany = table.Column<int>(type: "integer", nullable: false),
                    CompanyManagement = table.Column<int>(type: "integer", nullable: false),
                    AccessToPolicies = table.Column<int>(type: "integer", nullable: false),
                    WorkEnvironmentSuggestions = table.Column<string>(type: "text", nullable: false),
                    AreaRequiringImprovements = table.Column<string>(type: "text", nullable: false),
                    ActionRequired = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    URL = table.Column<string>(type: "text", nullable: false),
                    Attachment = table.Column<string>(type: "text", nullable: false),
                    StaffSignature = table.Column<string>(type: "text", nullable: false),
                    ManagerSignature = table.Column<string>(type: "text", nullable: false),
                    ClientSignature = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Staff_Survey", x => x.StaffSurveyId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Survey_StaffName",
                columns: table => new
                {
                    SurveyWorkteamId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    StaffSurveyId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Survey_StaffName", x => x.SurveyWorkteamId);
                    table.ForeignKey(
                        name: "FK_tbl_Survey_StaffName_tbl_Staff_Survey_StaffSurveyId",
                        column: x => x.StaffSurveyId,
                        principalTable: "tbl_Staff_Survey",
                        principalColumn: "StaffSurveyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffBlackList",
                columns: table => new
                {
                    StaffBlackListId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Comment = table.Column<string>(type: "character varying(225)", maxLength: 225, nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffBlackList", x => x.StaffBlackListId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffBlackList_tbl_Client_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffCompetenceTest",
                columns: table => new
                {
                    StaffCompetenceTestId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Heading = table.Column<string>(type: "text", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffCompetenceTest", x => x.StaffCompetenceTestId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffCompetenceTest_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffCompetenceTestTask",
                columns: table => new
                {
                    StaffCompetenceTestTaskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffCompetenceTestId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<int>(type: "integer", nullable: false),
                    Answer = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    Point = table.Column<int>(type: "integer", nullable: false),
                    Score = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffCompetenceTestTask", x => x.StaffCompetenceTestTaskId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffCompetenceTestTask_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_tbl_StaffCompetenceTestTask_tbl_StaffCompetenceTest_StaffCo~",
                        column: x => x.StaffCompetenceTestId,
                        principalTable: "tbl_StaffCompetenceTest",
                        principalColumn: "StaffCompetenceTestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffEducation",
                columns: table => new
                {
                    StaffEducationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Institution = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Certificate = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: false),
                    Location = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    StartDate = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    EndDate = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    CertificateAttachment = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffEducation", x => x.StaffEducationId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffEmergencyContact",
                columns: table => new
                {
                    StaffEmergencyContactId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    ContactName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Telephone = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Relationship = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffEmergencyContact", x => x.StaffEmergencyContactId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffHealth",
                columns: table => new
                {
                    StaffHealthId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Heading = table.Column<string>(type: "text", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffHealth", x => x.StaffHealthId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffHealth_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffHealthTask",
                columns: table => new
                {
                    StaffHealthTaskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffHealthId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<int>(type: "integer", nullable: false),
                    Answer = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    Point = table.Column<int>(type: "integer", nullable: false),
                    Score = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffHealthTask", x => x.StaffHealthTaskId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffHealthTask_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_tbl_StaffHealthTask_tbl_StaffHealth_StaffHealthId",
                        column: x => x.StaffHealthId,
                        principalTable: "tbl_StaffHealth",
                        principalColumn: "StaffHealthId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffHoliday",
                columns: table => new
                {
                    StaffHolidayId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    YearOfService = table.Column<decimal>(type: "numeric", nullable: false),
                    AllocatedDays = table.Column<decimal>(type: "numeric", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Days = table.Column<decimal>(type: "numeric", nullable: false),
                    Purpose = table.Column<string>(type: "text", nullable: true),
                    Class = table.Column<int>(type: "integer", nullable: false),
                    PersonOnResponsibility = table.Column<string>(type: "text", nullable: true),
                    CopyOfHandover = table.Column<string>(type: "text", nullable: true),
                    Remark = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: true),
                    Attachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: true),
                    Status = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 450, nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffHoliday", x => x.StaffHolidayId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffHoliday_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffInfectionControl",
                columns: table => new
                {
                    InfectionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Guideline = table.Column<string>(type: "text", nullable: false),
                    TestDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    VaccStatus = table.Column<int>(type: "integer", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffInfectionControl", x => x.InfectionId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffInterview",
                columns: table => new
                {
                    StaffInterviewId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Heading = table.Column<string>(type: "text", nullable: false),
                    StaffSignature = table.Column<string>(type: "text", nullable: false),
                    ManagerSignature = table.Column<string>(type: "text", nullable: false),
                    ClientSignature = table.Column<string>(type: "text", nullable: false),
                    InterviewDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    JobPosition = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    PassingMarks = table.Column<int>(type: "integer", nullable: false),
                    ObtainMarks = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffInterview", x => x.StaffInterviewId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffInterviewTask",
                columns: table => new
                {
                    StaffInterviewTaskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffInterviewId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<int>(type: "integer", nullable: false),
                    Answer = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    Point = table.Column<int>(type: "integer", nullable: false),
                    Score = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffInterviewTask", x => x.StaffInterviewTaskId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffInterviewTask_tbl_StaffInterview_StaffInterviewId",
                        column: x => x.StaffInterviewId,
                        principalTable: "tbl_StaffInterview",
                        principalColumn: "StaffInterviewId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffLateness",
                columns: table => new
                {
                    StaffLatenessId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    SN = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Rota = table.Column<int>(type: "integer", nullable: false),
                    TimeCritical = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Reason = table.Column<string>(type: "text", nullable: false),
                    Response = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffLateness", x => x.StaffLatenessId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffLateness_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffMedRota",
                columns: table => new
                {
                    StaffRotaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RotaDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RotaDayofWeekId = table.Column<int>(type: "integer", nullable: true),
                    RotaId = table.Column<int>(type: "integer", nullable: true),
                    Remark = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    ReferenceNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DoseGiven = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Time = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Measurement = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Location = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Feedback = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    ConfirmToGivenRightPerson = table.Column<bool>(type: "boolean", nullable: false),
                    ConfirmToGivenRightPersonTime = table.Column<bool>(type: "boolean", nullable: false),
                    ConfirmRightDoseGiven = table.Column<bool>(type: "boolean", nullable: false),
                    ConfirmMedicationRoute = table.Column<bool>(type: "boolean", nullable: false),
                    ClockInLocation = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    ClockOutLocation = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: true),
                    ClockInTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    ClockOutTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DosePrescribed = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    StaffCommentsOrConcern = table.Column<string>(type: "character varying(2024)", maxLength: 2024, nullable: false),
                    GivenMedicationNotInChart = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Attachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Certify = table.Column<bool>(type: "boolean", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffMedRota", x => x.StaffRotaId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffMedRota_tbl_ClientRotaName_RotaId",
                        column: x => x.RotaId,
                        principalTable: "tbl_ClientRotaName",
                        principalColumn: "RotaId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffOfficeLocation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Location = table.Column<int>(type: "integer", nullable: false),
                    Staff = table.Column<Guid>(type: "uuid", nullable: false),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffOfficeLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_StaffOfficeLocation_tbl_OfficeLocation_Location",
                        column: x => x.Location,
                        principalTable: "tbl_OfficeLocation",
                        principalColumn: "OfficeLocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffPersonalInfo",
                columns: table => new
                {
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    RegistrationId = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Telephone = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ProfilePix = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Address = table.Column<string>(type: "character varying(225)", maxLength: 225, nullable: false),
                    AboutMe = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    Hobbies = table.Column<string>(type: "character varying(225)", maxLength: 225, nullable: false),
                    Email = table.Column<string>(type: "character varying(225)", maxLength: 225, nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Keyworker = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    IdNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false),
                    PostCode = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Rate = table.Column<decimal>(type: "numeric", nullable: true),
                    TeamLeader = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    WorkTeam = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    StaffWorkTeamId = table.Column<int>(type: "integer", nullable: true),
                    Passcode = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CanDrive = table.Column<bool>(type: "boolean", nullable: false),
                    DrivingLicense = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    DrivingLicenseExpiryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RightToWork = table.Column<bool>(type: "boolean", nullable: false),
                    RightToWorkAttachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    RightToWorkExpiryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DBS = table.Column<bool>(type: "boolean", nullable: false),
                    DBSAttachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    DBSExpiryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DBSUpdateNo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    NI = table.Column<bool>(type: "boolean", nullable: false),
                    NIAttachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    NIExpiryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CV = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    CoverLetter = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Self_PYE = table.Column<bool>(type: "boolean", nullable: false),
                    Self_PYEAttachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    IsTeamLeader = table.Column<bool>(type: "boolean", nullable: false),
                    IsKeyWorker = table.Column<bool>(type: "boolean", nullable: false),
                    HasUniform = table.Column<bool>(type: "boolean", nullable: false),
                    HasIdCard = table.Column<bool>(type: "boolean", nullable: false),
                    EmploymentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CategoryId = table.Column<int>(type: "integer", nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    StaffManager = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    JobPositionId = table.Column<int>(type: "integer", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsAgencyStaff = table.Column<bool>(type: "boolean", nullable: false),
                    IsOfficeStaff = table.Column<bool>(type: "boolean", nullable: false),
                    IsApplicant = table.Column<bool>(type: "boolean", nullable: false),
                    ClassOfStaff = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    COSNo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    BRPAttachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    PassportAttachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    GrossSalary = table.Column<decimal>(type: "numeric", nullable: true),
                    RegistrationNo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    HomeOfficeDecisionLetter = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    RightToPractice = table.Column<bool>(type: "boolean", nullable: false),
                    RightToPracticeAttachment = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    RightToPracticeCode = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    RightToPracticeExpiryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffPersonalInfo", x => x.StaffPersonalInfoId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffPersonalInfo_tbl_CategoryOfStaff_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "tbl_CategoryOfStaff",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_StaffPersonalInfo_tbl_JobPosition_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "tbl_JobPosition",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffPersonalInfoComment",
                columns: table => new
                {
                    StaffPersonalInfoCommentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    CommentBy_UserId = table.Column<int>(type: "integer", nullable: true),
                    Comment = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    CommentOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffPersonalInfoComment", x => x.StaffPersonalInfoCommentId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffPersonalInfoComment_tbl_StaffPersonalInfo_StaffPer~",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffPersonalityTest",
                columns: table => new
                {
                    TestId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Question = table.Column<int>(type: "integer", nullable: false),
                    Answer = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffPersonalityTest", x => x.TestId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffPersonalityTest_tbl_StaffPersonalInfo_StaffPersona~",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffRating",
                columns: table => new
                {
                    StaffRatingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    CommentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    SubmittedBy = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffRating", x => x.StaffRatingId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffRating_tbl_Company_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_StaffRating_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffReferee",
                columns: table => new
                {
                    StaffRefereeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Referee = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: true),
                    CompanyName = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: true),
                    Address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: true),
                    PositionofReferee = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    Attachment = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffReferee", x => x.StaffRefereeId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffReferee_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffRegulatoryContact",
                columns: table => new
                {
                    StaffRegulatoryContactId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    BaseRecordItemId = table.Column<int>(type: "integer", nullable: false),
                    DatePerformed = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DueDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Evidence = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffRegulatoryContact", x => x.StaffRegulatoryContactId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffRegulatoryContact_tbl_BaseRecordItem_Model_BaseRec~",
                        column: x => x.BaseRecordItemId,
                        principalTable: "tbl_BaseRecordItem_Model",
                        principalColumn: "BaseRecordItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_StaffRegulatoryContact_tbl_StaffPersonalInfo_StaffPerso~",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffShadowing",
                columns: table => new
                {
                    StaffShadowingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Heading = table.Column<string>(type: "text", nullable: false),
                    StaffSignature = table.Column<string>(type: "text", nullable: false),
                    ManagerSignature = table.Column<string>(type: "text", nullable: false),
                    ClientSignature = table.Column<string>(type: "text", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffShadowing", x => x.StaffShadowingId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffShadowing_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_tbl_StaffShadowing_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffShiftBooking",
                columns: table => new
                {
                    StaffShiftBookingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ShiftBookingId = table.Column<int>(type: "integer", nullable: false),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    RotaId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffShiftBooking", x => x.StaffShiftBookingId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffShiftBooking_tbl_ClientRotaName_RotaId",
                        column: x => x.RotaId,
                        principalTable: "tbl_ClientRotaName",
                        principalColumn: "RotaId");
                    table.ForeignKey(
                        name: "FK_tbl_StaffShiftBooking_tbl_ShiftBooking_ShiftBookingId",
                        column: x => x.ShiftBookingId,
                        principalTable: "tbl_ShiftBooking",
                        principalColumn: "ShiftBookingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_StaffShiftBooking_tbl_StaffPersonalInfo_StaffPersonalIn~",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffTax",
                columns: table => new
                {
                    StaffTaxId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Tax = table.Column<decimal>(type: "numeric", nullable: false),
                    NI = table.Column<decimal>(type: "numeric", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffTax", x => x.StaffTaxId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffTax_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_tbl_StaffTax_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffTeamLead",
                columns: table => new
                {
                    TeamLeadId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Rota = table.Column<int>(type: "integer", nullable: false),
                    ClientInvolved = table.Column<Guid>(type: "uuid", nullable: false),
                    StaffInvolved = table.Column<Guid>(type: "uuid", nullable: false),
                    DidYouObserved = table.Column<string>(type: "text", nullable: false),
                    DidYouDo = table.Column<string>(type: "text", nullable: false),
                    OfficeToDo = table.Column<string>(type: "text", nullable: false),
                    StaffStoppedWorking = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffTeamLead", x => x.TeamLeadId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffTeamLead_tbl_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tbl_Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_tbl_StaffTeamLead_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_tbl_StaffTeamLead_tbl_StaffPersonalInfo_StaffInvolved",
                        column: x => x.StaffInvolved,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffTraining",
                columns: table => new
                {
                    StaffTrainingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Training = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Certificate = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: false),
                    Location = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Trainer = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: false),
                    StartDate = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    ExpiredDate = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    CertificateAttachment = table.Column<string>(type: "text", nullable: true),
                    TrainingType = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffTraining", x => x.StaffTrainingId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffTraining_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffTrainingByList",
                columns: table => new
                {
                    StaffTrainingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", maxLength: 38, nullable: false),
                    Training = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Certificate = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: false),
                    Location = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Trainer = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: false),
                    StartDate = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    ExpiredDate = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    CertificateAttachment = table.Column<string>(type: "text", nullable: true),
                    TrainingType = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffTrainingByList", x => x.StaffTrainingId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffTrainingByList_tbl_StaffPersonalInfo_StaffPersonal~",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffTrainingMatrix",
                columns: table => new
                {
                    MatrixId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffTrainingMatrix", x => x.MatrixId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffTrainingMatrix_tbl_StaffPersonalInfo_StaffPersonal~",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Supervision_OfficerToAct",
                columns: table => new
                {
                    SupervisionOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffSupervisionAppraisalId = table.Column<int>(type: "integer", nullable: false),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Supervision_OfficerToAct", x => x.SupervisionOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_Supervision_OfficerToAct_tbl_StaffPersonalInfo_StaffPer~",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Supervision_OfficerToAct_tbl_Staff_SupervisionAppraisal~",
                        column: x => x.StaffSupervisionAppraisalId,
                        principalTable: "tbl_Staff_SupervisionAppraisal",
                        principalColumn: "StaffSupervisionAppraisalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Supervision_StaffName",
                columns: table => new
                {
                    SupervisionWorkteamId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    StaffSupervisionAppraisalId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Supervision_StaffName", x => x.SupervisionWorkteamId);
                    table.ForeignKey(
                        name: "FK_tbl_Supervision_StaffName_tbl_StaffPersonalInfo_StaffPerson~",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Supervision_StaffName_tbl_Staff_SupervisionAppraisal_St~",
                        column: x => x.StaffSupervisionAppraisalId,
                        principalTable: "tbl_Staff_SupervisionAppraisal",
                        principalColumn: "StaffSupervisionAppraisalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Survey_OfficerToAct",
                columns: table => new
                {
                    SurveyOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    StaffSurveyId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Survey_OfficerToAct", x => x.SurveyOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_Survey_OfficerToAct_tbl_StaffPersonalInfo_StaffPersonal~",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Survey_OfficerToAct_tbl_Staff_Survey_StaffSurveyId",
                        column: x => x.StaffSurveyId,
                        principalTable: "tbl_Staff_Survey",
                        principalColumn: "StaffSurveyId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_TrackingConcernManager",
                columns: table => new
                {
                    TrackingConcernManagerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    TrackingConcernNoteId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_TrackingConcernManager", x => x.TrackingConcernManagerId);
                    table.ForeignKey(
                        name: "FK_tbl_TrackingConcernManager_tbl_StaffPersonalInfo_StaffPerso~",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_TrackingConcernManager_tbl_TrackingConcernNote_Tracking~",
                        column: x => x.TrackingConcernNoteId,
                        principalTable: "tbl_TrackingConcernNote",
                        principalColumn: "Ref",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_TrackingConcernStaff",
                columns: table => new
                {
                    TrackingConcernManagerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    TrackingConcernNoteId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_TrackingConcernStaff", x => x.TrackingConcernManagerId);
                    table.ForeignKey(
                        name: "FK_tbl_TrackingConcernStaff_tbl_StaffPersonalInfo_StaffPersona~",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_TrackingConcernStaff_tbl_TrackingConcernNote_TrackingCo~",
                        column: x => x.TrackingConcernNoteId,
                        principalTable: "tbl_TrackingConcernNote",
                        principalColumn: "Ref",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_User_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_tbl_User_tbl_StaffPersonalInfo_StaffId",
                        column: x => x.StaffId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Visit_OfficerToAct",
                columns: table => new
                {
                    VisitOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    VisitId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Visit_OfficerToAct", x => x.VisitOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_Visit_OfficerToAct_tbl_Client_MgtVisit_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Client_MgtVisit",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Visit_OfficerToAct_tbl_StaffPersonalInfo_StaffPersonalI~",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Visit_StaffName",
                columns: table => new
                {
                    VisitStaffNameId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    VisitId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Visit_StaffName", x => x.VisitStaffNameId);
                    table.ForeignKey(
                        name: "FK_tbl_Visit_StaffName_tbl_Client_MgtVisit_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Client_MgtVisit",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Visit_StaffName_tbl_StaffPersonalInfo_StaffPersonalInfo~",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Voice_CallerName",
                columns: table => new
                {
                    VoiceCallerNameId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    VoiceId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Voice_CallerName", x => x.VoiceCallerNameId);
                    table.ForeignKey(
                        name: "FK_tbl_Voice_CallerName_tbl_Client_Voice_VoiceId",
                        column: x => x.VoiceId,
                        principalTable: "tbl_Client_Voice",
                        principalColumn: "VoiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Voice_CallerName_tbl_StaffPersonalInfo_StaffPersonalInf~",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Voice_GoodStaff",
                columns: table => new
                {
                    VoiceGoodStaffId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    VoiceId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Voice_GoodStaff", x => x.VoiceGoodStaffId);
                    table.ForeignKey(
                        name: "FK_tbl_Voice_GoodStaff_tbl_Client_Voice_VoiceId",
                        column: x => x.VoiceId,
                        principalTable: "tbl_Client_Voice",
                        principalColumn: "VoiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Voice_GoodStaff_tbl_StaffPersonalInfo_StaffPersonalInfo~",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Voice_OfficerToAct",
                columns: table => new
                {
                    VoiceOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    VoiceId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Voice_OfficerToAct", x => x.VoiceOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_Voice_OfficerToAct_tbl_Client_Voice_VoiceId",
                        column: x => x.VoiceId,
                        principalTable: "tbl_Client_Voice",
                        principalColumn: "VoiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Voice_OfficerToAct_tbl_StaffPersonalInfo_StaffPersonalI~",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Voice_PoorStaff",
                columns: table => new
                {
                    VoicePoorStaffId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    VoiceId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Voice_PoorStaff", x => x.VoicePoorStaffId);
                    table.ForeignKey(
                        name: "FK_tbl_Voice_PoorStaff_tbl_Client_Voice_VoiceId",
                        column: x => x.VoiceId,
                        principalTable: "tbl_Client_Voice",
                        principalColumn: "VoiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Voice_PoorStaff_tbl_StaffPersonalInfo_StaffPersonalInfo~",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_WoundCare_OfficerToAct",
                columns: table => new
                {
                    WoundCareOfficerToActId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    WoundCareId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_WoundCare_OfficerToAct", x => x.WoundCareOfficerToActId);
                    table.ForeignKey(
                        name: "FK_tbl_WoundCare_OfficerToAct_tbl_Client_WoundCare_WoundCareId",
                        column: x => x.WoundCareId,
                        principalTable: "tbl_Client_WoundCare",
                        principalColumn: "WoundCareId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_WoundCare_OfficerToAct_tbl_StaffPersonalInfo_StaffPerso~",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_WoundCare_Physician",
                columns: table => new
                {
                    WoundCarePhysicianId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    WoundCareId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_WoundCare_Physician", x => x.WoundCarePhysicianId);
                    table.ForeignKey(
                        name: "FK_tbl_WoundCare_Physician_tbl_Client_WoundCare_WoundCareId",
                        column: x => x.WoundCareId,
                        principalTable: "tbl_Client_WoundCare",
                        principalColumn: "WoundCareId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_WoundCare_Physician_tbl_StaffPersonalInfo_StaffPersonal~",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_WoundCare_StaffName",
                columns: table => new
                {
                    WoundCareStaffNameId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffPersonalInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    WoundCareId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_WoundCare_StaffName", x => x.WoundCareStaffNameId);
                    table.ForeignKey(
                        name: "FK_tbl_WoundCare_StaffName_tbl_Client_WoundCare_WoundCareId",
                        column: x => x.WoundCareId,
                        principalTable: "tbl_Client_WoundCare",
                        principalColumn: "WoundCareId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_WoundCare_StaffName_tbl_StaffPersonalInfo_StaffPersonal~",
                        column: x => x.StaffPersonalInfoId,
                        principalTable: "tbl_StaffPersonalInfo",
                        principalColumn: "StaffPersonalInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffShadowingTask",
                columns: table => new
                {
                    StaffShadowingTaskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffShadowingId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<int>(type: "integer", nullable: false),
                    Answer = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    Point = table.Column<int>(type: "integer", nullable: false),
                    Score = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffShadowingTask", x => x.StaffShadowingTaskId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffShadowingTask_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_tbl_StaffShadowingTask_tbl_StaffShadowing_StaffShadowingId",
                        column: x => x.StaffShadowingId,
                        principalTable: "tbl_StaffShadowing",
                        principalColumn: "StaffShadowingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffShiftBookingDay",
                columns: table => new
                {
                    StaffShiftBookingDayId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffShiftBookingId = table.Column<int>(type: "integer", nullable: false),
                    Day = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    WeekDay = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDelete = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffShiftBookingDay", x => x.StaffShiftBookingDayId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffShiftBookingDay_tbl_StaffShiftBooking_StaffShiftBo~",
                        column: x => x.StaffShiftBookingId,
                        principalTable: "tbl_StaffShiftBooking",
                        principalColumn: "StaffShiftBookingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffTeamLeadTasks",
                columns: table => new
                {
                    TeamLeadTaskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TeamLeadId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    Comments = table.Column<string>(type: "text", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedBy = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffTeamLeadTasks", x => x.TeamLeadTaskId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffTeamLeadTasks_tbl_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_Company",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_tbl_StaffTeamLeadTasks_tbl_StaffTeamLead_TeamLeadId",
                        column: x => x.TeamLeadId,
                        principalTable: "tbl_StaffTeamLead",
                        principalColumn: "TeamLeadId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffTrainingMatrixList",
                columns: table => new
                {
                    TrainingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MatrixId = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffTrainingMatrixList", x => x.TrainingId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffTrainingMatrixList_tbl_StaffTrainingMatrix_MatrixId",
                        column: x => x.MatrixId,
                        principalTable: "tbl_StaffTrainingMatrix",
                        principalColumn: "MatrixId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StaffWorkTeam",
                columns: table => new
                {
                    StaffWorkTeamId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WorkTeam = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StaffWorkTeam", x => x.StaffWorkTeamId);
                    table.ForeignKey(
                        name: "FK_tbl_StaffWorkTeam_tbl_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "tbl_User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_UserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_UserClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_UserClaim_tbl_User_UserId",
                        column: x => x.UserId,
                        principalTable: "tbl_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_UserLogin",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_UserLogin", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_tbl_UserLogin_tbl_User_UserId",
                        column: x => x.UserId,
                        principalTable: "tbl_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_UserRole",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_UserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_tbl_UserRole_tbl_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "tbl_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_UserRole_tbl_User_UserId",
                        column: x => x.UserId,
                        principalTable: "tbl_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_UserToken",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_UserToken", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_tbl_UserToken_tbl_User_UserId",
                        column: x => x.UserId,
                        principalTable: "tbl_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tbl_Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d2c49d5-639c-4e86-abd1-c7da88561541", "d8c9e243-4f54-4b1f-9d1b-6449cb907522", "Staff", "STAFF" },
                    { "93be1e09-c686-4bb2-8e1b-8594f5585dd9", "32a5a6e8-0ade-45fb-a751-f469e975b66d", "SuperAdmin", "SUPERADMIN" },
                    { "acac7fb6-7c4a-4da8-a22e-47caab9928a9", "2fca74f5-8568-4b34-ac21-5b8a91de0372", "Company", "COMPANY" }
                });

            migrationBuilder.InsertData(
                table: "tbl_RotaDayofWeek",
                columns: new[] { "RotaDayofWeekId", "DayofWeek", "Deleted" },
                values: new object[,]
                {
                    { 1, "Monday", false },
                    { 2, "Tuesday", false },
                    { 3, "Wednesday", false },
                    { 4, "Thursday", false },
                    { 5, "Friday", false },
                    { 6, "Saturday", false },
                    { 7, "Sunday", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyModel_UserId1",
                table: "CompanyModel",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_AdlObs_OfficerToAct_ObservationId",
                table: "tbl_AdlObs_OfficerToAct",
                column: "ObservationId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_AdlObs_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_AdlObs_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_AppointmentBookingAttendees_AppointmentBookingId",
                table: "tbl_AppointmentBookingAttendees",
                column: "AppointmentBookingId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_assignalertstaff_CompanyId",
                table: "tbl_assignalertstaff",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_assignalertstaff_StaffAlertId",
                table: "tbl_assignalertstaff",
                column: "StaffAlertId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_assignalertstaff_StaffId",
                table: "tbl_assignalertstaff",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_AuditTrail_ClientId",
                table: "tbl_AuditTrail",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_AuditTrail_CompanyId",
                table: "tbl_AuditTrail",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Balance_ClientId",
                table: "tbl_Balance",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BaseRecordItem_BaseRecordId",
                table: "tbl_BaseRecordItem",
                column: "BaseRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BaseRecordItem_Model_BaseRecordId",
                table: "tbl_BaseRecordItem_Model",
                column: "BaseRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BelieveTask_BestInterestAssessmentBestId",
                table: "tbl_BelieveTask",
                column: "BestInterestAssessmentBestId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BestInterestAssessment_ClientId",
                table: "tbl_BestInterestAssessment",
                column: "ClientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BloodCoag_OfficerToAct_BloodRecordId",
                table: "tbl_BloodCoag_OfficerToAct",
                column: "BloodRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BloodCoag_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_BloodCoag_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BloodCoag_Physician_BloodRecordId",
                table: "tbl_BloodCoag_Physician",
                column: "BloodRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BloodCoag_Physician_StaffPersonalInfoId",
                table: "tbl_BloodCoag_Physician",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BloodCoag_StaffName_BloodRecordId",
                table: "tbl_BloodCoag_StaffName",
                column: "BloodRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BloodCoag_StaffName_StaffPersonalInfoId",
                table: "tbl_BloodCoag_StaffName",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BloodPressure_OfficerToAct_BloodPressureId",
                table: "tbl_BloodPressure_OfficerToAct",
                column: "BloodPressureId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BloodPressure_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_BloodPressure_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BloodPressure_Physician_BloodPressureId",
                table: "tbl_BloodPressure_Physician",
                column: "BloodPressureId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BloodPressure_Physician_StaffPersonalInfoId",
                table: "tbl_BloodPressure_Physician",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BloodPressure_StaffName_BloodPressureId",
                table: "tbl_BloodPressure_StaffName",
                column: "BloodPressureId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BloodPressure_StaffName_StaffPersonalInfoId",
                table: "tbl_BloodPressure_StaffName",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BMIChart_OfficerToAct_BMIChartId",
                table: "tbl_BMIChart_OfficerToAct",
                column: "BMIChartId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BMIChart_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_BMIChart_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BMIChart_Physician_BMIChartId",
                table: "tbl_BMIChart_Physician",
                column: "BMIChartId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BMIChart_Physician_StaffPersonalInfoId",
                table: "tbl_BMIChart_Physician",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BMIChart_StaffName_BMIChartId",
                table: "tbl_BMIChart_StaffName",
                column: "BMIChartId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BMIChart_StaffName_StaffPersonalInfoId",
                table: "tbl_BMIChart_StaffName",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BodyMap_ClientId",
                table: "tbl_BodyMap",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BodyTemp_OfficerToAct_BodyTempId",
                table: "tbl_BodyTemp_OfficerToAct",
                column: "BodyTempId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BodyTemp_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_BodyTemp_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BodyTemp_Physician_BodyTempId",
                table: "tbl_BodyTemp_Physician",
                column: "BodyTempId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BodyTemp_Physician_StaffPersonalInfoId",
                table: "tbl_BodyTemp_Physician",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BodyTemp_StaffName_BodyTempId",
                table: "tbl_BodyTemp_StaffName",
                column: "BodyTempId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BodyTemp_StaffName_StaffPersonalInfoId",
                table: "tbl_BodyTemp_StaffName",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BowelMovement_OfficerToAct_BowelMovementId",
                table: "tbl_BowelMovement_OfficerToAct",
                column: "BowelMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BowelMovement_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_BowelMovement_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BowelMovement_Physician_BowelMovementId",
                table: "tbl_BowelMovement_Physician",
                column: "BowelMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BowelMovement_Physician_StaffPersonalInfoId",
                table: "tbl_BowelMovement_Physician",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BowelMovement_StaffName_BowelMovementId",
                table: "tbl_BowelMovement_StaffName",
                column: "BowelMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BowelMovement_StaffName_StaffPersonalInfoId",
                table: "tbl_BowelMovement_StaffName",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CandidateInterview_CompanyId",
                table: "tbl_CandidateInterview",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CapacityIndicator_CapacityId",
                table: "tbl_CapacityIndicator",
                column: "CapacityId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CareIssuesTask_BestInterestAssessmentBestId",
                table: "tbl_CareIssuesTask",
                column: "BestInterestAssessmentBestId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CareobjectMonitor_ClientId",
                table: "tbl_CareobjectMonitor",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CareObjPersonToAct_CareObjId",
                table: "tbl_CareObjPersonToAct",
                column: "CareObjId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CareObjPersonToAct_StaffPersonalInfoId",
                table: "tbl_CareObjPersonToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CarePlanNutrition_ClientId",
                table: "tbl_CarePlanNutrition",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CareReview_ClientId",
                table: "tbl_CareReview",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CareReview_ClientId1",
                table: "tbl_CareReview",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_chatNotification_CompanyId",
                table: "tbl_chatNotification",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_chatsupport_CompanyId",
                table: "tbl_chatsupport",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ChatSupportAssignedStaff_CompanyId",
                table: "tbl_ChatSupportAssignedStaff",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_chatsupportconversation_ChatSupportId",
                table: "tbl_chatsupportconversation",
                column: "ChatSupportId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_chatsupportconversation_CompanyId",
                table: "tbl_chatsupportconversation",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_AreaCodeId",
                table: "tbl_Client",
                column: "AreaCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_ClientFacilityId",
                table: "tbl_Client",
                column: "ClientFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_CompanyId",
                table: "tbl_Client",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_TeritoryId",
                table: "tbl_Client",
                column: "TeritoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_BloodCoagulationRecord_ClientId",
                table: "tbl_Client_BloodCoagulationRecord",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_BloodCoagulationRecord_ClientId1",
                table: "tbl_Client_BloodCoagulationRecord",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_BloodPressure_ClientId",
                table: "tbl_Client_BloodPressure",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_BloodPressure_ClientId1",
                table: "tbl_Client_BloodPressure",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_BMIChart_ClientId",
                table: "tbl_Client_BMIChart",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_BMIChart_ClientId1",
                table: "tbl_Client_BMIChart",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_BodyTemp_ClientId",
                table: "tbl_Client_BodyTemp",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_BodyTemp_ClientId1",
                table: "tbl_Client_BodyTemp",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_BowelMovement_ClientId",
                table: "tbl_Client_BowelMovement",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_BowelMovement_ClientId1",
                table: "tbl_Client_BowelMovement",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_Cleaning_NutritionId",
                table: "tbl_Client_Cleaning",
                column: "NutritionId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_ComplainRegister_ClientId",
                table: "tbl_Client_ComplainRegister",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_ComplainRegister_ClientId1",
                table: "tbl_Client_ComplainRegister",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_EyeHealthMonitoring_ClientId",
                table: "tbl_Client_EyeHealthMonitoring",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_EyeHealthMonitoring_ClientId1",
                table: "tbl_Client_EyeHealthMonitoring",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_FoodIntake_ClientId",
                table: "tbl_Client_FoodIntake",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_FoodIntake_ClientId1",
                table: "tbl_Client_FoodIntake",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_HeartRate_ClientId",
                table: "tbl_Client_HeartRate",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_HeartRate_ClientId1",
                table: "tbl_Client_HeartRate",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_LogAudit_ClientId",
                table: "tbl_Client_LogAudit",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_LogAudit_ClientId1",
                table: "tbl_Client_LogAudit",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_LogAudit_StaffPersonalInfoId",
                table: "tbl_Client_LogAudit",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_MealDay_NutritionId",
                table: "tbl_Client_MealDay",
                column: "NutritionId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_MealType_CompanyId",
                table: "tbl_Client_MealType",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_MealType_MealType",
                table: "tbl_Client_MealType",
                column: "MealType",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_MedAudit_ClientId",
                table: "tbl_Client_MedAudit",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_MedAudit_ClientId1",
                table: "tbl_Client_MedAudit",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_MedAudit_StaffPersonalInfoId",
                table: "tbl_Client_MedAudit",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_MgtVisit_ClientId",
                table: "tbl_Client_MgtVisit",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_MgtVisit_StaffPersonalInfoId",
                table: "tbl_Client_MgtVisit",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_Nutrition_ClientId",
                table: "tbl_Client_Nutrition",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_Oxygenlvl_ClientId",
                table: "tbl_Client_Oxygenlvl",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_Oxygenlvl_ClientId1",
                table: "tbl_Client_Oxygenlvl",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_PainChart_ClientId",
                table: "tbl_Client_PainChart",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_PainChart_ClientId1",
                table: "tbl_Client_PainChart",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_Program_ClientId",
                table: "tbl_Client_Program",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_Program_StaffPersonalInfoId",
                table: "tbl_Client_Program",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_PulseRate_ClientId",
                table: "tbl_Client_PulseRate",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_PulseRate_ClientId1",
                table: "tbl_Client_PulseRate",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_Seizure_ClientId",
                table: "tbl_Client_Seizure",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_Seizure_ClientId1",
                table: "tbl_Client_Seizure",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_ServiceWatch_ClientId",
                table: "tbl_Client_ServiceWatch",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_ServiceWatch_StaffPersonalInfoId",
                table: "tbl_Client_ServiceWatch",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_Shopping_NutritionId",
                table: "tbl_Client_Shopping",
                column: "NutritionId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_Voice_ClientId",
                table: "tbl_Client_Voice",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_Voice_StaffPersonalInfoId",
                table: "tbl_Client_Voice",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_WoundCare_ClientId",
                table: "tbl_Client_WoundCare",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Client_WoundCare_ClientId1",
                table: "tbl_Client_WoundCare",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientBillTo_ClientId",
                table: "tbl_ClientBillTo",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientCareDetails_ClientCareDetailsTaskId",
                table: "tbl_ClientCareDetails",
                column: "ClientCareDetailsTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientCareDetails_ClientId",
                table: "tbl_ClientCareDetails",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientCareDetailsHeading_CompanyId",
                table: "tbl_ClientCareDetailsHeading",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientCareDetailsHeading_Heading",
                table: "tbl_ClientCareDetailsHeading",
                column: "Heading",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientCareDetailsTask_ClientCareDetailsHeadingId",
                table: "tbl_ClientCareDetailsTask",
                column: "ClientCareDetailsHeadingId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientCareDetailsTask_CompanyId",
                table: "tbl_ClientCareDetailsTask",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientCareObj_ClientId",
                table: "tbl_ClientCareObj",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientCareObj_ClientId1",
                table: "tbl_ClientCareObj",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientChat_CompanyId",
                table: "tbl_ClientChat",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientDailyTask_ClientId",
                table: "tbl_ClientDailyTask",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientFacility_CompanyId",
                table: "tbl_ClientFacility",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientFacilityRisk_CompanyId",
                table: "tbl_ClientFacilityRisk",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientFacilityRisk_FacilityClientId",
                table: "tbl_ClientFacilityRisk",
                column: "FacilityClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientFacilityTask_FacilityClientId",
                table: "tbl_ClientFacilityTask",
                column: "FacilityClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientHealthCondition_ClientId",
                table: "tbl_ClientHealthCondition",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientHobbies_ClientId",
                table: "tbl_ClientHobbies",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientHobbies_HId",
                table: "tbl_ClientHobbies",
                column: "HId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientInvoice_ClientInvoiceSummaryId",
                table: "tbl_ClientInvoice",
                column: "ClientInvoiceSummaryId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientInvoiceRate_ClientId",
                table: "tbl_ClientInvoiceRate",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientInvoiceRecords_ClientInvoiceId",
                table: "tbl_ClientInvoiceRecords",
                column: "ClientInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientInvolvingParty_ClientId",
                table: "tbl_ClientInvolvingParty",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientKeyWorkerVoice_ClientId",
                table: "tbl_ClientKeyWorkerVoice",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientKeyWorkerVoice_CompanyId",
                table: "tbl_ClientKeyWorkerVoice",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientMatrixAudit_ClientId",
                table: "tbl_ClientMatrixAudit",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientMatrixAudit_ClientId1",
                table: "tbl_ClientMatrixAudit",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientMedication_ClientId",
                table: "tbl_ClientMedication",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientMedication_MedicationId",
                table: "tbl_ClientMedication",
                column: "MedicationId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientMedication_MedicationManufacturerId",
                table: "tbl_ClientMedication",
                column: "MedicationManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientMedication_MedicationRouteId",
                table: "tbl_ClientMedication",
                column: "MedicationRouteId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientMedicationDay_ClientMedicationId",
                table: "tbl_ClientMedicationDay",
                column: "ClientMedicationId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientMedicationDay_ClientMedicationId1",
                table: "tbl_ClientMedicationDay",
                column: "ClientMedicationId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientMedicationDay_RotaDayofWeekId",
                table: "tbl_ClientMedicationDay",
                column: "RotaDayofWeekId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientMedicationPeriod_ClientMedicationDayId",
                table: "tbl_ClientMedicationPeriod",
                column: "ClientMedicationDayId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientMedicationPeriod_ClientRotaTypeId",
                table: "tbl_ClientMedicationPeriod",
                column: "ClientRotaTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientPerformanceIndicator_ClientId",
                table: "tbl_ClientPerformanceIndicator",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientPerformanceIndicatorTask_StaffCompetenceTestId",
                table: "tbl_ClientPerformanceIndicatorTask",
                column: "StaffCompetenceTestId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientRegulatoryContact_BaseRecordItemId",
                table: "tbl_ClientRegulatoryContact",
                column: "BaseRecordItemId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientRegulatoryContact_ClientId",
                table: "tbl_ClientRegulatoryContact",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientRota_ClientId",
                table: "tbl_ClientRota",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientRota_ClientRotaTypeId",
                table: "tbl_ClientRota",
                column: "ClientRotaTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientRotaDays_ClientRotaId",
                table: "tbl_ClientRotaDays",
                column: "ClientRotaId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientRotaDays_RotaDayofWeekId",
                table: "tbl_ClientRotaDays",
                column: "RotaDayofWeekId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientRotaDays_RotaId",
                table: "tbl_ClientRotaDays",
                column: "RotaId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientRotaTask_ClientRotaDaysId",
                table: "tbl_ClientRotaTask",
                column: "ClientRotaDaysId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientRotaTask_RotaTaskId",
                table: "tbl_ClientRotaTask",
                column: "RotaTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientServiceDetail_ClientId",
                table: "tbl_ClientServiceDetail",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientServiceDetailItem_ClientServiceDetailId",
                table: "tbl_ClientServiceDetailItem",
                column: "ClientServiceDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientServiceDetailItem_CompanyId",
                table: "tbl_ClientServiceDetailItem",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientServiceDetailReceipt_ClientServiceDetailId",
                table: "tbl_ClientServiceDetailReceipt",
                column: "ClientServiceDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientSupportPlan_ClientId",
                table: "tbl_ClientSupportPlan",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientSupportPlanGoal_ClientSupportPlanId",
                table: "tbl_ClientSupportPlanGoal",
                column: "ClientSupportPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientSupportPlanGoalAchieve_ClientSupportPlanGoalId",
                table: "tbl_ClientSupportPlanGoalAchieve",
                column: "ClientSupportPlanGoalId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientTaskBoard_ClientId",
                table: "tbl_ClientTaskBoard",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientTaskBoardAssignedTo_StaffPersonalInfoId",
                table: "tbl_ClientTaskBoardAssignedTo",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClientTaskBoardAssignedTo_TaskBoardId",
                table: "tbl_ClientTaskBoardAssignedTo",
                column: "TaskBoardId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CommunicationLogApologies_CommunicationLogId",
                table: "tbl_CommunicationLogApologies",
                column: "CommunicationLogId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CommunicationLogAttendees_CommunicationLogId",
                table: "tbl_CommunicationLogAttendees",
                column: "CommunicationLogId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CompanyBank_CompanyId",
                table: "tbl_CompanyBank",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CompanyContact_CompanyId",
                table: "tbl_CompanyContact",
                column: "CompanyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Complain_OfficerToAct_ComplainId",
                table: "tbl_Complain_OfficerToAct",
                column: "ComplainId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Complain_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_Complain_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Complain_StaffName_ComplainId",
                table: "tbl_Complain_StaffName",
                column: "ComplainId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Complain_StaffName_StaffPersonalInfoId",
                table: "tbl_Complain_StaffName",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ComplainRegistorClients_ClientId",
                table: "tbl_ComplainRegistorClients",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ComplainRegistorClients_ComplainRegistorId",
                table: "tbl_ComplainRegistorClients",
                column: "ComplainRegistorId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ComplainRegistorStaff_ComplainRegistorId",
                table: "tbl_ComplainRegistorStaff",
                column: "ComplainRegistorId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ComplainRegistorStaff_StaffId",
                table: "tbl_ComplainRegistorStaff",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ConsentCare_PersonalDetailId",
                table: "tbl_ConsentCare",
                column: "PersonalDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ConsentLandLine_PersonalDetailId",
                table: "tbl_ConsentLandLine",
                column: "PersonalDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ConsentLandlineLog_LandlineId",
                table: "tbl_ConsentLandlineLog",
                column: "LandlineId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ConsentMedication_PersonalDetailId",
                table: "tbl_ConsentMedication",
                column: "PersonalDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_conversation_CompanyId",
                table: "tbl_conversation",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_conversation_InboxId",
                table: "tbl_conversation",
                column: "InboxId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_createshift_CompanyId",
                table: "tbl_createshift",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_createshiftuserroles_ClientFacilityId",
                table: "tbl_createshiftuserroles",
                column: "ClientFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_createshiftuserroles_ClientId",
                table: "tbl_createshiftuserroles",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_createshiftuserroles_CompanyId",
                table: "tbl_createshiftuserroles",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_createshiftuserroles_ShiftId",
                table: "tbl_createshiftuserroles",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_createshiftuserroles_StaffId",
                table: "tbl_createshiftuserroles",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CuidiBuddy_ClientId",
                table: "tbl_CuidiBuddy",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_CuidiBuddy_ClientId1",
                table: "tbl_CuidiBuddy",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DeductionValue_DeductionForAllStaffId",
                table: "tbl_DeductionValue",
                column: "DeductionForAllStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DutyOnCall_ClientId",
                table: "tbl_DutyOnCall",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DutyOnCallPersonResponsible_DutyOnCallId",
                table: "tbl_DutyOnCallPersonResponsible",
                column: "DutyOnCallId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DutyOnCallPersonResponsible_StaffPersonalInfoId",
                table: "tbl_DutyOnCallPersonResponsible",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DutyOnCallPersonToAct_DutyOnCallId",
                table: "tbl_DutyOnCallPersonToAct",
                column: "DutyOnCallId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DutyOnCallPersonToAct_StaffPersonalInfoId",
                table: "tbl_DutyOnCallPersonToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_EmailMessageUser_EmailMessageId",
                table: "tbl_EmailMessageUser",
                column: "EmailMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Enotice__ClientId",
                table: "tbl_Enotice_",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Equipment_PersonalDetailId",
                table: "tbl_Equipment",
                column: "PersonalDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Equipment_PersonToAct",
                table: "tbl_Equipment",
                column: "PersonToAct");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_EquipmentAssessment_ClientId",
                table: "tbl_EquipmentAssessment",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Expenselog_CompanyId",
                table: "tbl_Expenselog",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ExternalRole_UserId",
                table: "tbl_ExternalRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ExternalRoleAccessClient_ExternalAccessId",
                table: "tbl_ExternalRoleAccessClient",
                column: "ExternalAccessId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ExternalRoleAccessStaff_ExternalAccessId",
                table: "tbl_ExternalRoleAccessStaff",
                column: "ExternalAccessId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_EyeHealth_OfficerToAct_EyeHealthId",
                table: "tbl_EyeHealth_OfficerToAct",
                column: "EyeHealthId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_EyeHealth_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_EyeHealth_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_EyeHealth_Physician_EyeHealthId",
                table: "tbl_EyeHealth_Physician",
                column: "EyeHealthId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_EyeHealth_Physician_StaffPersonalInfoId",
                table: "tbl_EyeHealth_Physician",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_EyeHealth_StaffName_EyeHealthId",
                table: "tbl_EyeHealth_StaffName",
                column: "EyeHealthId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_EyeHealth_StaffName_StaffPersonalInfoId",
                table: "tbl_EyeHealth_StaffName",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FilesAndRecord_ClientId",
                table: "tbl_FilesAndRecord",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FilesAndRecord_ClientId1",
                table: "tbl_FilesAndRecord",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FilesAndRecord_StaffPersonalInfoId",
                table: "tbl_FilesAndRecord",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FoodIntake_OfficerToAct_FoodIntakeId",
                table: "tbl_FoodIntake_OfficerToAct",
                column: "FoodIntakeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FoodIntake_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_FoodIntake_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FoodIntake_Physician_FoodIntakeId",
                table: "tbl_FoodIntake_Physician",
                column: "FoodIntakeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FoodIntake_Physician_StaffPersonalInfoId",
                table: "tbl_FoodIntake_Physician",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FoodIntake_StaffName_FoodIntakeId",
                table: "tbl_FoodIntake_StaffName",
                column: "FoodIntakeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FoodIntake_StaffName_StaffPersonalInfoId",
                table: "tbl_FoodIntake_StaffName",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HealthAndLiving_ClientId",
                table: "tbl_HealthAndLiving",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HealthTask_BestInterestAssessmentBestId",
                table: "tbl_HealthTask",
                column: "BestInterestAssessmentBestId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HealthTask2_BestInterestAssessmentBestId",
                table: "tbl_HealthTask2",
                column: "BestInterestAssessmentBestId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HeartRate_OfficerToAct_HeartRateId",
                table: "tbl_HeartRate_OfficerToAct",
                column: "HeartRateId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HeartRate_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_HeartRate_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HeartRate_Physician_HeartRateId",
                table: "tbl_HeartRate_Physician",
                column: "HeartRateId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HeartRate_Physician_StaffPersonalInfoId",
                table: "tbl_HeartRate_Physician",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HeartRate_StaffName_HeartRateId",
                table: "tbl_HeartRate_StaffName",
                column: "HeartRateId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HeartRate_StaffName_StaffPersonalInfoId",
                table: "tbl_HeartRate_StaffName",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HistoryOfFall_ClientId",
                table: "tbl_HistoryOfFall",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HomeRiskAssessment_ClientId",
                table: "tbl_HomeRiskAssessment",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HomeRiskAssessmentTask_HomeRiskAssessmentId",
                table: "tbl_HomeRiskAssessmentTask",
                column: "HomeRiskAssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HospitalEntry_ClientId",
                table: "tbl_HospitalEntry",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HospitalEntryPersonToTakeAction_HospitalEntryId",
                table: "tbl_HospitalEntryPersonToTakeAction",
                column: "HospitalEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HospitalEntryPersonToTakeAction_StaffPersonalInfoId",
                table: "tbl_HospitalEntryPersonToTakeAction",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HospitalEntryStaffInvolved_HospitalEntryId",
                table: "tbl_HospitalEntryStaffInvolved",
                column: "HospitalEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HospitalEntryStaffInvolved_StaffPersonalInfoId",
                table: "tbl_HospitalEntryStaffInvolved",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HospitalExit_ClientId",
                table: "tbl_HospitalExit",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HospitalExitOfficerToTakeAction_HospitalExitId",
                table: "tbl_HospitalExitOfficerToTakeAction",
                column: "HospitalExitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_HospitalExitOfficerToTakeAction_StaffPersonalInfoId",
                table: "tbl_HospitalExitOfficerToTakeAction",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Inbox_CompanyId",
                table: "tbl_Inbox",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_IncidentDetailAssignedTo_IncidentDetailId",
                table: "tbl_IncidentDetailAssignedTo",
                column: "IncidentDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_IncidentDetailAssignedTo_StaffPersonalInfoId",
                table: "tbl_IncidentDetailAssignedTo",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_IncidentReporting_ClientId",
                table: "tbl_IncidentReporting",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_IncidentReporting_ClientId1",
                table: "tbl_IncidentReporting",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_IncomeValue_IncomeForAllStaffId",
                table: "tbl_IncomeValue",
                column: "IncomeForAllStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Incoming_Meds_ClientId",
                table: "tbl_Incoming_Meds",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_InfectionControl_ClientId",
                table: "tbl_InfectionControl",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_InterestAndObjective_ClientId",
                table: "tbl_InterestAndObjective",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_InterestAndObjective_InterestId",
                table: "tbl_InterestAndObjective",
                column: "InterestId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_InterviewQuestion_CompanyId",
                table: "tbl_InterviewQuestion",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Investigation_ClientId",
                table: "tbl_Investigation",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_InvestigationAttachment_InvestigationId",
                table: "tbl_InvestigationAttachment",
                column: "InvestigationId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_KeyIndicatorLog_KeyIndicatorsKeyId",
                table: "tbl_KeyIndicatorLog",
                column: "KeyIndicatorsKeyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_KeyWorker_OfficerToAct_StaffKeyWorkerVoiceKeyWorkerId",
                table: "tbl_KeyWorker_OfficerToAct",
                column: "StaffKeyWorkerVoiceKeyWorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_KeyWorker_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_KeyWorker_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_KeyWorker_StaffName_StaffKeyWorkerVoiceKeyWorkerId",
                table: "tbl_KeyWorker_StaffName",
                column: "StaffKeyWorkerVoiceKeyWorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_KeyWorker_StaffName_StaffPersonalInfoId",
                table: "tbl_KeyWorker_StaffName",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_LogAudit_OfficerToAct_LogAuditId",
                table: "tbl_LogAudit_OfficerToAct",
                column: "LogAuditId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_LogAudit_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_LogAudit_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ManagingTasks_ClientId",
                table: "tbl_ManagingTasks",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MedAudit_AuditorName_MedAuditId",
                table: "tbl_MedAudit_AuditorName",
                column: "MedAuditId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MedAudit_AuditorName_StaffPersonalInfoId",
                table: "tbl_MedAudit_AuditorName",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MedAudit_OfficerToAct_MedAuditId",
                table: "tbl_MedAudit_OfficerToAct",
                column: "MedAuditId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MedAudit_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_MedAudit_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MedComp_OfficerToAct_StaffMedCompMedCompId",
                table: "tbl_MedComp_OfficerToAct",
                column: "StaffMedCompMedCompId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MedComp_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_MedComp_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MeetingActionableItem_MeetingLogId",
                table: "tbl_MeetingActionableItem",
                column: "MeetingLogId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MeetingAgenda_MeetingLogId",
                table: "tbl_MeetingAgenda",
                column: "MeetingLogId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MeetingDiscussions_MeetingLogId",
                table: "tbl_MeetingDiscussions",
                column: "MeetingLogId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MeetingLogAttende_MeetingLogId",
                table: "tbl_MeetingLogAttende",
                column: "MeetingLogId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MeetingLogAttende_StaffPersonalInfoId",
                table: "tbl_MeetingLogAttende",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MeetingLogFacilitator_MeetingLogId",
                table: "tbl_MeetingLogFacilitator",
                column: "MeetingLogId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MeetingLogFacilitator_StaffPersonalInfoId",
                table: "tbl_MeetingLogFacilitator",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MeetingLogResponsibleToAct_MeetingLogId",
                table: "tbl_MeetingLogResponsibleToAct",
                column: "MeetingLogId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MeetingLogResponsibleToAct_StaffPersonalInfoId",
                table: "tbl_MeetingLogResponsibleToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_OfficeAttendance_CreatedBy",
                table: "tbl_OfficeAttendance",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_OfficeAttendance_StaffPersonalInfoId",
                table: "tbl_OfficeAttendance",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_OfficeLocation_CreatedBy",
                table: "tbl_OfficeLocation",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_OneToOne_OfficerToAct_StaffOneToOneOneToOneId",
                table: "tbl_OneToOne_OfficerToAct",
                column: "StaffOneToOneOneToOneId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_OneToOne_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_OneToOne_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_OnlineTrainingBundleCourse_OnlineTrainingBundleId",
                table: "tbl_OnlineTrainingBundleCourse",
                column: "OnlineTrainingBundleId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_OnlineTrainingBundleCourse_OnlineTraningId1",
                table: "tbl_OnlineTrainingBundleCourse",
                column: "OnlineTraningId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_OnlineTrainingBundleCourse_StaffBundleCourseResultId",
                table: "tbl_OnlineTrainingBundleCourse",
                column: "StaffBundleCourseResultId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_OnlineTraininglogQuestion_OnlineTraningId",
                table: "tbl_OnlineTraininglogQuestion",
                column: "OnlineTraningId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_OnlineTraning_ClassId",
                table: "tbl_OnlineTraning",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_OnlineTraning_MaterialId",
                table: "tbl_OnlineTraning",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_OnlineTraningQuestion_OnlineTraningId",
                table: "tbl_OnlineTraningQuestion",
                column: "OnlineTraningId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_OnlineTraningQuestionOptions_OnlineTraningQuestionId",
                table: "tbl_OnlineTraningQuestionOptions",
                column: "OnlineTraningQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_OxygenLvl_OfficerToAct_OxygenLvlId",
                table: "tbl_OxygenLvl_OfficerToAct",
                column: "OxygenLvlId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_OxygenLvl_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_OxygenLvl_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_OxygenLvl_Physician_OxygenLvlId",
                table: "tbl_OxygenLvl_Physician",
                column: "OxygenLvlId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_OxygenLvl_Physician_StaffPersonalInfoId",
                table: "tbl_OxygenLvl_Physician",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_OxygenLvl_StaffName_OxygenLvlId",
                table: "tbl_OxygenLvl_StaffName",
                column: "OxygenLvlId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_OxygenLvl_StaffName_StaffPersonalInfoId",
                table: "tbl_OxygenLvl_StaffName",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PainChart_OfficerToAct_PainChartId",
                table: "tbl_PainChart_OfficerToAct",
                column: "PainChartId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PainChart_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_PainChart_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PainChart_Physician_PainChartId",
                table: "tbl_PainChart_Physician",
                column: "PainChartId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PainChart_Physician_StaffPersonalInfoId",
                table: "tbl_PainChart_Physician",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PainChart_StaffName_PainChartId",
                table: "tbl_PainChart_StaffName",
                column: "PainChartId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PainChart_StaffName_StaffPersonalInfoId",
                table: "tbl_PainChart_StaffName",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PerformanceIndicator_CompanyId",
                table: "tbl_PerformanceIndicator",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PerformanceIndicatorTask_CompanyId",
                table: "tbl_PerformanceIndicatorTask",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PerformanceIndicatorTask_StaffCompetenceTestId",
                table: "tbl_PerformanceIndicatorTask",
                column: "StaffCompetenceTestId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PersonalDetail_ClientId",
                table: "tbl_PersonalDetail",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PersonalHygiene_ClientId",
                table: "tbl_PersonalHygiene",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PersonalityTest_GoalId",
                table: "tbl_PersonalityTest",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PersonCentred_ClientId",
                table: "tbl_PersonCentred",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PersonCentredFocus_PersonCentredId",
                table: "tbl_PersonCentredFocus",
                column: "PersonCentredId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Pets_ClientId",
                table: "tbl_Pets",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PettyCashUsage_PettyCashId",
                table: "tbl_PettyCashUsage",
                column: "PettyCashId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PhysicalAbility_ClientId",
                table: "tbl_PhysicalAbility",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Program_OfficerToAct_ProgramId",
                table: "tbl_Program_OfficerToAct",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Program_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_Program_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PulseRate_OfficerToAct_PulseRateId",
                table: "tbl_PulseRate_OfficerToAct",
                column: "PulseRateId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PulseRate_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_PulseRate_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PulseRate_Physician_PulseRateId",
                table: "tbl_PulseRate_Physician",
                column: "PulseRateId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PulseRate_Physician_StaffPersonalInfoId",
                table: "tbl_PulseRate_Physician",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PulseRate_StaffName_PulseRateId",
                table: "tbl_PulseRate_StaffName",
                column: "PulseRateId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PulseRate_StaffName_StaffPersonalInfoId",
                table: "tbl_PulseRate_StaffName",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Resources__ClientId",
                table: "tbl_Resources_",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "tbl_Role",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_RoleClaim_RoleId",
                table: "tbl_RoleClaim",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_RotaStaff_StaffMedRotaId",
                table: "tbl_RotaStaff",
                column: "StaffMedRotaId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_SalaryAllowance_CompanyId",
                table: "tbl_SalaryAllowance",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_SalaryAllowance_StaffPersonalInfoId",
                table: "tbl_SalaryAllowance",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_SalaryDeduction_CompanyId",
                table: "tbl_SalaryDeduction",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_SalaryDeduction_StaffPersonalInfoId",
                table: "tbl_SalaryDeduction",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Seizure_OfficerToAct_SeizureId",
                table: "tbl_Seizure_OfficerToAct",
                column: "SeizureId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Seizure_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_Seizure_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Seizure_Physician_SeizureId",
                table: "tbl_Seizure_Physician",
                column: "SeizureId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Seizure_Physician_StaffPersonalInfoId",
                table: "tbl_Seizure_Physician",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Seizure_StaffName_SeizureId",
                table: "tbl_Seizure_StaffName",
                column: "SeizureId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Seizure_StaffName_StaffPersonalInfoId",
                table: "tbl_Seizure_StaffName",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Service_OfficerToAct_ServiceId",
                table: "tbl_Service_OfficerToAct",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Service_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_Service_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Service_StaffName_ServiceId",
                table: "tbl_Service_StaffName",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Service_StaffName_StaffPersonalInfoId",
                table: "tbl_Service_StaffName",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_SetupStaffHoliday_CompanyId",
                table: "tbl_SetupStaffHoliday",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_SetupStaffHoliday_StaffPersonalInfoId",
                table: "tbl_SetupStaffHoliday",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ShiftBooking_CreatedBy",
                table: "tbl_ShiftBooking",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ShiftBookingBlockedDays_ShiftBookingId",
                table: "tbl_ShiftBookingBlockedDays",
                column: "ShiftBookingId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_SpecialHealthAndMedication_ClientId",
                table: "tbl_SpecialHealthAndMedication",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_SpecialHealthCondition_ClientId",
                table: "tbl_SpecialHealthCondition",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_SpotCheck_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_SpotCheck_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_SpotCheck_OfficerToAct_StaffSpotCheckSpotCheckId",
                table: "tbl_SpotCheck_OfficerToAct",
                column: "StaffSpotCheckSpotCheckId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Staff_AdlObs_ClientId",
                table: "tbl_Staff_AdlObs",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Staff_AdlObs_ClientId1",
                table: "tbl_Staff_AdlObs",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Staff_AdlObs_StaffId",
                table: "tbl_Staff_AdlObs",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Staff_KeyWorkerVoice_ClientId",
                table: "tbl_Staff_KeyWorkerVoice",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Staff_KeyWorkerVoice_StaffId",
                table: "tbl_Staff_KeyWorkerVoice",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Staff_MedCompObs_ClientId",
                table: "tbl_Staff_MedCompObs",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Staff_MedCompObs_ClientId1",
                table: "tbl_Staff_MedCompObs",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Staff_MedCompObs_StaffId",
                table: "tbl_Staff_MedCompObs",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Staff_OneToOne_StaffId",
                table: "tbl_Staff_OneToOne",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Staff_Reference_ClientId",
                table: "tbl_Staff_Reference",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Staff_Reference_StaffId",
                table: "tbl_Staff_Reference",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Staff_SpotCheck_ClientId",
                table: "tbl_Staff_SpotCheck",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Staff_SpotCheck_ClientId1",
                table: "tbl_Staff_SpotCheck",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Staff_SpotCheck_StaffId",
                table: "tbl_Staff_SpotCheck",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Staff_SupervisionAppraisal_StaffPersonalInfoId",
                table: "tbl_Staff_SupervisionAppraisal",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Staff_Survey_StaffId",
                table: "tbl_Staff_Survey",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_staffalert_CompanyId",
                table: "tbl_staffalert",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_staffalertcountmatrix_CompanyId",
                table: "tbl_staffalertcountmatrix",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_staffalertcountmatrix_StaffAlertId",
                table: "tbl_staffalertcountmatrix",
                column: "StaffAlertId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffBlackList_ClientId1",
                table: "tbl_StaffBlackList",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffBlackList_StaffPersonalInfoId",
                table: "tbl_StaffBlackList",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffCompetenceTest_CompanyId",
                table: "tbl_StaffCompetenceTest",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffCompetenceTest_StaffPersonalInfoId",
                table: "tbl_StaffCompetenceTest",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffCompetenceTestTask_CompanyId",
                table: "tbl_StaffCompetenceTestTask",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffCompetenceTestTask_StaffCompetenceTestId",
                table: "tbl_StaffCompetenceTestTask",
                column: "StaffCompetenceTestId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffEducation_StaffPersonalInfoId",
                table: "tbl_StaffEducation",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffEmergencyContact_StaffPersonalInfoId",
                table: "tbl_StaffEmergencyContact",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffHealth_CompanyId",
                table: "tbl_StaffHealth",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffHealth_StaffPersonalInfoId",
                table: "tbl_StaffHealth",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffHealthTask_CompanyId",
                table: "tbl_StaffHealthTask",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffHealthTask_StaffHealthId",
                table: "tbl_StaffHealthTask",
                column: "StaffHealthId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffHoliday_CompanyId",
                table: "tbl_StaffHoliday",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffHoliday_StaffPersonalInfoId",
                table: "tbl_StaffHoliday",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffIncidentReporting_ClientId",
                table: "tbl_StaffIncidentReporting",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffInfectionControl_StaffPersonalInfoId",
                table: "tbl_StaffInfectionControl",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffInterview_StaffPersonalInfoId",
                table: "tbl_StaffInterview",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffInterviewTask_StaffInterviewId",
                table: "tbl_StaffInterviewTask",
                column: "StaffInterviewId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffLateness_CompanyId",
                table: "tbl_StaffLateness",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffLateness_StaffPersonalInfoId",
                table: "tbl_StaffLateness",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffMedRota_ApplicationUserId",
                table: "tbl_StaffMedRota",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffMedRota_RotaId",
                table: "tbl_StaffMedRota",
                column: "RotaId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffOfficeLocation_Location",
                table: "tbl_StaffOfficeLocation",
                column: "Location");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffOfficeLocation_StaffPersonalInfoId",
                table: "tbl_StaffOfficeLocation",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffPerformance_ClientId",
                table: "tbl_StaffPerformance",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffPerformance_PerformanceSummaryId",
                table: "tbl_StaffPerformance",
                column: "PerformanceSummaryId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffPerformanceHeading_JobPositionId",
                table: "tbl_StaffPerformanceHeading",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffPersonalInfo_CategoryId",
                table: "tbl_StaffPersonalInfo",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffPersonalInfo_JobPositionId",
                table: "tbl_StaffPersonalInfo",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffPersonalInfo_RegistrationId",
                table: "tbl_StaffPersonalInfo",
                column: "RegistrationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffPersonalInfo_StaffWorkTeamId",
                table: "tbl_StaffPersonalInfo",
                column: "StaffWorkTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffPersonalInfoComment_StaffPersonalInfoId",
                table: "tbl_StaffPersonalInfoComment",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffPersonalityTest_StaffPersonalInfoId",
                table: "tbl_StaffPersonalityTest",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffRating_ClientId",
                table: "tbl_StaffRating",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffRating_StaffPersonalInfoId",
                table: "tbl_StaffRating",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffReferee_StaffPersonalInfoId",
                table: "tbl_StaffReferee",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffRegulatoryContact_BaseRecordItemId",
                table: "tbl_StaffRegulatoryContact",
                column: "BaseRecordItemId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffRegulatoryContact_StaffPersonalInfoId",
                table: "tbl_StaffRegulatoryContact",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffRota_RotaId",
                table: "tbl_StaffRota",
                column: "RotaId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffRotaDynamicAddition_CompanyId",
                table: "tbl_StaffRotaDynamicAddition",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffRotaItem_StaffRotaId",
                table: "tbl_StaffRotaItem",
                column: "StaffRotaId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffRotaPartner_StaffRotaId",
                table: "tbl_StaffRotaPartner",
                column: "StaffRotaId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffRotaPeriod_ClientRotaTypeId",
                table: "tbl_StaffRotaPeriod",
                column: "ClientRotaTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffRotaPeriod_StaffRotaId",
                table: "tbl_StaffRotaPeriod",
                column: "StaffRotaId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffRotaTask_StaffRotaPeriodId",
                table: "tbl_StaffRotaTask",
                column: "StaffRotaPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffShadowing_CompanyId",
                table: "tbl_StaffShadowing",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffShadowing_StaffPersonalInfoId",
                table: "tbl_StaffShadowing",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffShadowingTask_CompanyId",
                table: "tbl_StaffShadowingTask",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffShadowingTask_StaffShadowingId",
                table: "tbl_StaffShadowingTask",
                column: "StaffShadowingId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffShiftBooking_RotaId",
                table: "tbl_StaffShiftBooking",
                column: "RotaId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffShiftBooking_ShiftBookingId",
                table: "tbl_StaffShiftBooking",
                column: "ShiftBookingId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffShiftBooking_StaffPersonalInfoId",
                table: "tbl_StaffShiftBooking",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffShiftBookingDay_StaffShiftBookingId",
                table: "tbl_StaffShiftBookingDay",
                column: "StaffShiftBookingId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffTax_CompanyId",
                table: "tbl_StaffTax",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffTax_StaffPersonalInfoId",
                table: "tbl_StaffTax",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffTeamLead_ClientId",
                table: "tbl_StaffTeamLead",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffTeamLead_CompanyId",
                table: "tbl_StaffTeamLead",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffTeamLead_StaffInvolved",
                table: "tbl_StaffTeamLead",
                column: "StaffInvolved");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffTeamLeadTasks_CompanyId",
                table: "tbl_StaffTeamLeadTasks",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffTeamLeadTasks_TeamLeadId",
                table: "tbl_StaffTeamLeadTasks",
                column: "TeamLeadId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffTraining_StaffPersonalInfoId",
                table: "tbl_StaffTraining",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffTrainingByList_StaffPersonalInfoId",
                table: "tbl_StaffTrainingByList",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffTrainingMatrix_StaffPersonalInfoId",
                table: "tbl_StaffTrainingMatrix",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffTrainingMatrixList_MatrixId",
                table: "tbl_StaffTrainingMatrixList",
                column: "MatrixId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_StaffWorkTeam_CreatedBy",
                table: "tbl_StaffWorkTeam",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Supervision_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_Supervision_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Supervision_OfficerToAct_StaffSupervisionAppraisalId",
                table: "tbl_Supervision_OfficerToAct",
                column: "StaffSupervisionAppraisalId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Supervision_StaffName_StaffPersonalInfoId",
                table: "tbl_Supervision_StaffName",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Supervision_StaffName_StaffSupervisionAppraisalId",
                table: "tbl_Supervision_StaffName",
                column: "StaffSupervisionAppraisalId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Survey_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_Survey_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Survey_OfficerToAct_StaffSurveyId",
                table: "tbl_Survey_OfficerToAct",
                column: "StaffSurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Survey_StaffName_StaffSurveyId",
                table: "tbl_Survey_StaffName",
                column: "StaffSurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_TrackingConcernManager_StaffPersonalInfoId",
                table: "tbl_TrackingConcernManager",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_TrackingConcernManager_TrackingConcernNoteId",
                table: "tbl_TrackingConcernManager",
                column: "TrackingConcernNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_TrackingConcernStaff_StaffPersonalInfoId",
                table: "tbl_TrackingConcernStaff",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_TrackingConcernStaff_TrackingConcernNoteId",
                table: "tbl_TrackingConcernStaff",
                column: "TrackingConcernNoteId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "tbl_User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_User_CompanyId",
                table: "tbl_User",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_User_StaffId",
                table: "tbl_User",
                column: "StaffId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "tbl_User",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserClaim_UserId",
                table: "tbl_UserClaim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserLogin_UserId",
                table: "tbl_UserLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserRole_RoleId",
                table: "tbl_UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Visit_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_Visit_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Visit_OfficerToAct_VisitId",
                table: "tbl_Visit_OfficerToAct",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Visit_StaffName_StaffPersonalInfoId",
                table: "tbl_Visit_StaffName",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Visit_StaffName_VisitId",
                table: "tbl_Visit_StaffName",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Voice_CallerName_StaffPersonalInfoId",
                table: "tbl_Voice_CallerName",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Voice_CallerName_VoiceId",
                table: "tbl_Voice_CallerName",
                column: "VoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Voice_GoodStaff_StaffPersonalInfoId",
                table: "tbl_Voice_GoodStaff",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Voice_GoodStaff_VoiceId",
                table: "tbl_Voice_GoodStaff",
                column: "VoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Voice_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_Voice_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Voice_OfficerToAct_VoiceId",
                table: "tbl_Voice_OfficerToAct",
                column: "VoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Voice_PoorStaff_StaffPersonalInfoId",
                table: "tbl_Voice_PoorStaff",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Voice_PoorStaff_VoiceId",
                table: "tbl_Voice_PoorStaff",
                column: "VoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_WoundCare_OfficerToAct_StaffPersonalInfoId",
                table: "tbl_WoundCare_OfficerToAct",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_WoundCare_OfficerToAct_WoundCareId",
                table: "tbl_WoundCare_OfficerToAct",
                column: "WoundCareId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_WoundCare_Physician_StaffPersonalInfoId",
                table: "tbl_WoundCare_Physician",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_WoundCare_Physician_WoundCareId",
                table: "tbl_WoundCare_Physician",
                column: "WoundCareId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_WoundCare_StaffName_StaffPersonalInfoId",
                table: "tbl_WoundCare_StaffName",
                column: "StaffPersonalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_WoundCare_StaffName_WoundCareId",
                table: "tbl_WoundCare_StaffName",
                column: "WoundCareId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyModel_tbl_User_UserId1",
                table: "CompanyModel",
                column: "UserId1",
                principalTable: "tbl_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_AdlObs_OfficerToAct_tbl_StaffPersonalInfo_StaffPersonal~",
                table: "tbl_AdlObs_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_AdlObs_OfficerToAct_tbl_Staff_AdlObs_ObservationId",
                table: "tbl_AdlObs_OfficerToAct",
                column: "ObservationId",
                principalTable: "tbl_Staff_AdlObs",
                principalColumn: "ObservationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_assignalertstaff_tbl_StaffPersonalInfo_StaffId",
                table: "tbl_assignalertstaff",
                column: "StaffId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BloodCoag_OfficerToAct_tbl_StaffPersonalInfo_StaffPerso~",
                table: "tbl_BloodCoag_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BloodCoag_Physician_tbl_StaffPersonalInfo_StaffPersonal~",
                table: "tbl_BloodCoag_Physician",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BloodCoag_StaffName_tbl_StaffPersonalInfo_StaffPersonal~",
                table: "tbl_BloodCoag_StaffName",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BloodPressure_OfficerToAct_tbl_StaffPersonalInfo_StaffP~",
                table: "tbl_BloodPressure_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BloodPressure_Physician_tbl_StaffPersonalInfo_StaffPers~",
                table: "tbl_BloodPressure_Physician",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BloodPressure_StaffName_tbl_StaffPersonalInfo_StaffPers~",
                table: "tbl_BloodPressure_StaffName",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BMIChart_OfficerToAct_tbl_StaffPersonalInfo_StaffPerson~",
                table: "tbl_BMIChart_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BMIChart_Physician_tbl_StaffPersonalInfo_StaffPersonalI~",
                table: "tbl_BMIChart_Physician",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BMIChart_StaffName_tbl_StaffPersonalInfo_StaffPersonalI~",
                table: "tbl_BMIChart_StaffName",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BodyTemp_OfficerToAct_tbl_StaffPersonalInfo_StaffPerson~",
                table: "tbl_BodyTemp_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BodyTemp_Physician_tbl_StaffPersonalInfo_StaffPersonalI~",
                table: "tbl_BodyTemp_Physician",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BodyTemp_StaffName_tbl_StaffPersonalInfo_StaffPersonalI~",
                table: "tbl_BodyTemp_StaffName",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BowelMovement_OfficerToAct_tbl_StaffPersonalInfo_StaffP~",
                table: "tbl_BowelMovement_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BowelMovement_Physician_tbl_StaffPersonalInfo_StaffPers~",
                table: "tbl_BowelMovement_Physician",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_BowelMovement_StaffName_tbl_StaffPersonalInfo_StaffPers~",
                table: "tbl_BowelMovement_StaffName",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_CareObjPersonToAct_tbl_StaffPersonalInfo_StaffPersonalI~",
                table: "tbl_CareObjPersonToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_LogAudit_tbl_StaffPersonalInfo_StaffPersonalInfo~",
                table: "tbl_Client_LogAudit",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_MedAudit_tbl_StaffPersonalInfo_StaffPersonalInfo~",
                table: "tbl_Client_MedAudit",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_MgtVisit_tbl_StaffPersonalInfo_StaffPersonalInfo~",
                table: "tbl_Client_MgtVisit",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Program_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                table: "tbl_Client_Program",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_ServiceWatch_tbl_StaffPersonalInfo_StaffPersonal~",
                table: "tbl_Client_ServiceWatch",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Client_Voice_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                table: "tbl_Client_Voice",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClientTaskBoardAssignedTo_tbl_StaffPersonalInfo_StaffPe~",
                table: "tbl_ClientTaskBoardAssignedTo",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Complain_OfficerToAct_tbl_StaffPersonalInfo_StaffPerson~",
                table: "tbl_Complain_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Complain_StaffName_tbl_StaffPersonalInfo_StaffPersonalI~",
                table: "tbl_Complain_StaffName",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ComplainRegistorStaff_tbl_StaffPersonalInfo_StaffId",
                table: "tbl_ComplainRegistorStaff",
                column: "StaffId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_createshiftuserroles_tbl_StaffPersonalInfo_StaffId",
                table: "tbl_createshiftuserroles",
                column: "StaffId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_DutyOnCallPersonResponsible_tbl_StaffPersonalInfo_Staff~",
                table: "tbl_DutyOnCallPersonResponsible",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_DutyOnCallPersonToAct_tbl_StaffPersonalInfo_StaffPerson~",
                table: "tbl_DutyOnCallPersonToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Equipment_tbl_StaffPersonalInfo_PersonToAct",
                table: "tbl_Equipment",
                column: "PersonToAct",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ExternalRole_tbl_User_UserId",
                table: "tbl_ExternalRole",
                column: "UserId",
                principalTable: "tbl_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_EyeHealth_OfficerToAct_tbl_StaffPersonalInfo_StaffPerso~",
                table: "tbl_EyeHealth_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_EyeHealth_Physician_tbl_StaffPersonalInfo_StaffPersonal~",
                table: "tbl_EyeHealth_Physician",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_EyeHealth_StaffName_tbl_StaffPersonalInfo_StaffPersonal~",
                table: "tbl_EyeHealth_StaffName",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_FilesAndRecord_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                table: "tbl_FilesAndRecord",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_FoodIntake_OfficerToAct_tbl_StaffPersonalInfo_StaffPers~",
                table: "tbl_FoodIntake_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_FoodIntake_Physician_tbl_StaffPersonalInfo_StaffPersona~",
                table: "tbl_FoodIntake_Physician",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_FoodIntake_StaffName_tbl_StaffPersonalInfo_StaffPersona~",
                table: "tbl_FoodIntake_StaffName",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HeartRate_OfficerToAct_tbl_StaffPersonalInfo_StaffPerso~",
                table: "tbl_HeartRate_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HeartRate_Physician_tbl_StaffPersonalInfo_StaffPersonal~",
                table: "tbl_HeartRate_Physician",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HeartRate_StaffName_tbl_StaffPersonalInfo_StaffPersonal~",
                table: "tbl_HeartRate_StaffName",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HospitalEntryPersonToTakeAction_tbl_StaffPersonalInfo_S~",
                table: "tbl_HospitalEntryPersonToTakeAction",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HospitalEntryStaffInvolved_tbl_StaffPersonalInfo_StaffP~",
                table: "tbl_HospitalEntryStaffInvolved",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_HospitalExitOfficerToTakeAction_tbl_StaffPersonalInfo_S~",
                table: "tbl_HospitalExitOfficerToTakeAction",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_IncidentDetailAssignedTo_tbl_StaffPersonalInfo_StaffPer~",
                table: "tbl_IncidentDetailAssignedTo",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_KeyWorker_OfficerToAct_tbl_StaffPersonalInfo_StaffPerso~",
                table: "tbl_KeyWorker_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_KeyWorker_OfficerToAct_tbl_Staff_KeyWorkerVoice_StaffKe~",
                table: "tbl_KeyWorker_OfficerToAct",
                column: "StaffKeyWorkerVoiceKeyWorkerId",
                principalTable: "tbl_Staff_KeyWorkerVoice",
                principalColumn: "KeyWorkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_KeyWorker_StaffName_tbl_StaffPersonalInfo_StaffPersonal~",
                table: "tbl_KeyWorker_StaffName",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_KeyWorker_StaffName_tbl_Staff_KeyWorkerVoice_StaffKeyWo~",
                table: "tbl_KeyWorker_StaffName",
                column: "StaffKeyWorkerVoiceKeyWorkerId",
                principalTable: "tbl_Staff_KeyWorkerVoice",
                principalColumn: "KeyWorkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_LogAudit_OfficerToAct_tbl_StaffPersonalInfo_StaffPerson~",
                table: "tbl_LogAudit_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_MedAudit_AuditorName_tbl_StaffPersonalInfo_StaffPersona~",
                table: "tbl_MedAudit_AuditorName",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_MedAudit_OfficerToAct_tbl_StaffPersonalInfo_StaffPerson~",
                table: "tbl_MedAudit_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_MedComp_OfficerToAct_tbl_StaffPersonalInfo_StaffPersona~",
                table: "tbl_MedComp_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_MedComp_OfficerToAct_tbl_Staff_MedCompObs_StaffMedCompM~",
                table: "tbl_MedComp_OfficerToAct",
                column: "StaffMedCompMedCompId",
                principalTable: "tbl_Staff_MedCompObs",
                principalColumn: "MedCompId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_MeetingLogAttende_tbl_StaffPersonalInfo_StaffPersonalIn~",
                table: "tbl_MeetingLogAttende",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_MeetingLogFacilitator_tbl_StaffPersonalInfo_StaffPerson~",
                table: "tbl_MeetingLogFacilitator",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_MeetingLogResponsibleToAct_tbl_StaffPersonalInfo_StaffP~",
                table: "tbl_MeetingLogResponsibleToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_OfficeAttendance_tbl_StaffPersonalInfo_StaffPersonalInf~",
                table: "tbl_OfficeAttendance",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_OfficeAttendance_tbl_User_CreatedBy",
                table: "tbl_OfficeAttendance",
                column: "CreatedBy",
                principalTable: "tbl_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_OfficeLocation_tbl_User_CreatedBy",
                table: "tbl_OfficeLocation",
                column: "CreatedBy",
                principalTable: "tbl_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_OneToOne_OfficerToAct_tbl_StaffPersonalInfo_StaffPerson~",
                table: "tbl_OneToOne_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_OneToOne_OfficerToAct_tbl_Staff_OneToOne_StaffOneToOneO~",
                table: "tbl_OneToOne_OfficerToAct",
                column: "StaffOneToOneOneToOneId",
                principalTable: "tbl_Staff_OneToOne",
                principalColumn: "OneToOneId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_OxygenLvl_OfficerToAct_tbl_StaffPersonalInfo_StaffPerso~",
                table: "tbl_OxygenLvl_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_OxygenLvl_Physician_tbl_StaffPersonalInfo_StaffPersonal~",
                table: "tbl_OxygenLvl_Physician",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_OxygenLvl_StaffName_tbl_StaffPersonalInfo_StaffPersonal~",
                table: "tbl_OxygenLvl_StaffName",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PainChart_OfficerToAct_tbl_StaffPersonalInfo_StaffPerso~",
                table: "tbl_PainChart_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PainChart_Physician_tbl_StaffPersonalInfo_StaffPersonal~",
                table: "tbl_PainChart_Physician",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PainChart_StaffName_tbl_StaffPersonalInfo_StaffPersonal~",
                table: "tbl_PainChart_StaffName",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Program_OfficerToAct_tbl_StaffPersonalInfo_StaffPersona~",
                table: "tbl_Program_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PulseRate_OfficerToAct_tbl_StaffPersonalInfo_StaffPerso~",
                table: "tbl_PulseRate_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PulseRate_Physician_tbl_StaffPersonalInfo_StaffPersonal~",
                table: "tbl_PulseRate_Physician",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PulseRate_StaffName_tbl_StaffPersonalInfo_StaffPersonal~",
                table: "tbl_PulseRate_StaffName",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_RotaStaff_tbl_StaffMedRota_StaffMedRotaId",
                table: "tbl_RotaStaff",
                column: "StaffMedRotaId",
                principalTable: "tbl_StaffMedRota",
                principalColumn: "StaffRotaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_SalaryAllowance_tbl_StaffPersonalInfo_StaffPersonalInfo~",
                table: "tbl_SalaryAllowance",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_SalaryDeduction_tbl_StaffPersonalInfo_StaffPersonalInfo~",
                table: "tbl_SalaryDeduction",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Seizure_OfficerToAct_tbl_StaffPersonalInfo_StaffPersona~",
                table: "tbl_Seizure_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Seizure_Physician_tbl_StaffPersonalInfo_StaffPersonalIn~",
                table: "tbl_Seizure_Physician",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Seizure_StaffName_tbl_StaffPersonalInfo_StaffPersonalIn~",
                table: "tbl_Seizure_StaffName",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Service_OfficerToAct_tbl_StaffPersonalInfo_StaffPersona~",
                table: "tbl_Service_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Service_StaffName_tbl_StaffPersonalInfo_StaffPersonalIn~",
                table: "tbl_Service_StaffName",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_SetupStaffHoliday_tbl_StaffPersonalInfo_StaffPersonalIn~",
                table: "tbl_SetupStaffHoliday",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ShiftBooking_tbl_User_CreatedBy",
                table: "tbl_ShiftBooking",
                column: "CreatedBy",
                principalTable: "tbl_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_SpotCheck_OfficerToAct_tbl_StaffPersonalInfo_StaffPerso~",
                table: "tbl_SpotCheck_OfficerToAct",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_SpotCheck_OfficerToAct_tbl_Staff_SpotCheck_StaffSpotChe~",
                table: "tbl_SpotCheck_OfficerToAct",
                column: "StaffSpotCheckSpotCheckId",
                principalTable: "tbl_Staff_SpotCheck",
                principalColumn: "SpotCheckId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Staff_AdlObs_tbl_StaffPersonalInfo_StaffId",
                table: "tbl_Staff_AdlObs",
                column: "StaffId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Staff_KeyWorkerVoice_tbl_StaffPersonalInfo_StaffId",
                table: "tbl_Staff_KeyWorkerVoice",
                column: "StaffId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Staff_MedCompObs_tbl_StaffPersonalInfo_StaffId",
                table: "tbl_Staff_MedCompObs",
                column: "StaffId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Staff_OneToOne_tbl_StaffPersonalInfo_StaffId",
                table: "tbl_Staff_OneToOne",
                column: "StaffId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Staff_Reference_tbl_StaffPersonalInfo_StaffId",
                table: "tbl_Staff_Reference",
                column: "StaffId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Staff_SpotCheck_tbl_StaffPersonalInfo_StaffId",
                table: "tbl_Staff_SpotCheck",
                column: "StaffId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Staff_SupervisionAppraisal_tbl_StaffPersonalInfo_StaffP~",
                table: "tbl_Staff_SupervisionAppraisal",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Staff_Survey_tbl_StaffPersonalInfo_StaffId",
                table: "tbl_Staff_Survey",
                column: "StaffId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffBlackList_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                table: "tbl_StaffBlackList",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffCompetenceTest_tbl_StaffPersonalInfo_StaffPersonal~",
                table: "tbl_StaffCompetenceTest",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffEducation_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                table: "tbl_StaffEducation",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffEmergencyContact_tbl_StaffPersonalInfo_StaffPerson~",
                table: "tbl_StaffEmergencyContact",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffHealth_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                table: "tbl_StaffHealth",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffHoliday_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                table: "tbl_StaffHoliday",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffInfectionControl_tbl_StaffPersonalInfo_StaffPerson~",
                table: "tbl_StaffInfectionControl",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffInterview_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                table: "tbl_StaffInterview",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffLateness_tbl_StaffPersonalInfo_StaffPersonalInfoId",
                table: "tbl_StaffLateness",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffMedRota_tbl_User_ApplicationUserId",
                table: "tbl_StaffMedRota",
                column: "ApplicationUserId",
                principalTable: "tbl_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffOfficeLocation_tbl_StaffPersonalInfo_StaffPersonal~",
                table: "tbl_StaffOfficeLocation",
                column: "StaffPersonalInfoId",
                principalTable: "tbl_StaffPersonalInfo",
                principalColumn: "StaffPersonalInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_StaffPersonalInfo_tbl_StaffWorkTeam_StaffWorkTeamId",
                table: "tbl_StaffPersonalInfo",
                column: "StaffWorkTeamId",
                principalTable: "tbl_StaffWorkTeam",
                principalColumn: "StaffWorkTeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_StaffWorkTeam_tbl_User_CreatedBy",
                table: "tbl_StaffWorkTeam");

            migrationBuilder.DropTable(
                name: "tbl_AddressHistory");

            migrationBuilder.DropTable(
                name: "tbl_AdlObs_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_AdminAdvertisement");

            migrationBuilder.DropTable(
                name: "tbl_AdminMessage");

            migrationBuilder.DropTable(
                name: "tbl_AmountRateType");

            migrationBuilder.DropTable(
                name: "tbl_AppMessage");

            migrationBuilder.DropTable(
                name: "tbl_AppointmentBookingAttendees");

            migrationBuilder.DropTable(
                name: "tbl_assignalertstaff");

            migrationBuilder.DropTable(
                name: "tbl_AuditTrail");

            migrationBuilder.DropTable(
                name: "tbl_Balance");

            migrationBuilder.DropTable(
                name: "tbl_BaseRecordItem");

            migrationBuilder.DropTable(
                name: "tbl_BelieveTask");

            migrationBuilder.DropTable(
                name: "tbl_BloodCoag_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_BloodCoag_Physician");

            migrationBuilder.DropTable(
                name: "tbl_BloodCoag_StaffName");

            migrationBuilder.DropTable(
                name: "tbl_BloodPressure_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_BloodPressure_Physician");

            migrationBuilder.DropTable(
                name: "tbl_BloodPressure_StaffName");

            migrationBuilder.DropTable(
                name: "tbl_BMIChart_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_BMIChart_Physician");

            migrationBuilder.DropTable(
                name: "tbl_BMIChart_StaffName");

            migrationBuilder.DropTable(
                name: "tbl_BodyMap");

            migrationBuilder.DropTable(
                name: "tbl_BodyTemp_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_BodyTemp_Physician");

            migrationBuilder.DropTable(
                name: "tbl_BodyTemp_StaffName");

            migrationBuilder.DropTable(
                name: "tbl_BowelMovement_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_BowelMovement_Physician");

            migrationBuilder.DropTable(
                name: "tbl_BowelMovement_StaffName");

            migrationBuilder.DropTable(
                name: "tbl_BundleTrainingResult");

            migrationBuilder.DropTable(
                name: "tbl_CallDetail");

            migrationBuilder.DropTable(
                name: "tbl_CandidateInterview");

            migrationBuilder.DropTable(
                name: "tbl_CandidateInterviewResult");

            migrationBuilder.DropTable(
                name: "tbl_CapacityIndicator");

            migrationBuilder.DropTable(
                name: "tbl_CareIssuesTask");

            migrationBuilder.DropTable(
                name: "tbl_CareobjectMonitor");

            migrationBuilder.DropTable(
                name: "tbl_CareObjPersonToAct");

            migrationBuilder.DropTable(
                name: "tbl_CarePlanNutrition");

            migrationBuilder.DropTable(
                name: "tbl_CareReview");

            migrationBuilder.DropTable(
                name: "tbl_chatNotification");

            migrationBuilder.DropTable(
                name: "tbl_ChatSupportAssignedStaff");

            migrationBuilder.DropTable(
                name: "tbl_chatsupportconversation");

            migrationBuilder.DropTable(
                name: "tbl_ClassOfStaff");

            migrationBuilder.DropTable(
                name: "tbl_Client_Cleaning");

            migrationBuilder.DropTable(
                name: "tbl_Client_MealDay");

            migrationBuilder.DropTable(
                name: "tbl_Client_MealType");

            migrationBuilder.DropTable(
                name: "tbl_Client_Shopping");

            migrationBuilder.DropTable(
                name: "tbl_ClientBillTo");

            migrationBuilder.DropTable(
                name: "tbl_ClientCareDetails");

            migrationBuilder.DropTable(
                name: "tbl_ClientChat");

            migrationBuilder.DropTable(
                name: "tbl_ClientCongnitive");

            migrationBuilder.DropTable(
                name: "tbl_ClientDailyTask");

            migrationBuilder.DropTable(
                name: "tbl_ClientFacilityRisk");

            migrationBuilder.DropTable(
                name: "tbl_ClientFacilityTask");

            migrationBuilder.DropTable(
                name: "tbl_ClientHealthCondition");

            migrationBuilder.DropTable(
                name: "tbl_ClientHobbies");

            migrationBuilder.DropTable(
                name: "tbl_ClientInvoiceRate");

            migrationBuilder.DropTable(
                name: "tbl_ClientInvoiceRecords");

            migrationBuilder.DropTable(
                name: "tbl_ClientInvolvingParty");

            migrationBuilder.DropTable(
                name: "tbl_ClientKeyworkerNotes");

            migrationBuilder.DropTable(
                name: "tbl_ClientKeyWorkerVoice");

            migrationBuilder.DropTable(
                name: "tbl_ClientMatrixAudit");

            migrationBuilder.DropTable(
                name: "tbl_ClientMedicationAdditional");

            migrationBuilder.DropTable(
                name: "tbl_ClientMedicationPeriod");

            migrationBuilder.DropTable(
                name: "tbl_ClientPerformanceIndicatorTask");

            migrationBuilder.DropTable(
                name: "tbl_ClientRegulatoryContact");

            migrationBuilder.DropTable(
                name: "tbl_ClientRotaTask");

            migrationBuilder.DropTable(
                name: "tbl_ClientServiceDetailItem");

            migrationBuilder.DropTable(
                name: "tbl_ClientServiceDetailReceipt");

            migrationBuilder.DropTable(
                name: "tbl_ClientSupportPlanGoalAchieve");

            migrationBuilder.DropTable(
                name: "tbl_ClientTaskBoardAssignedTo");

            migrationBuilder.DropTable(
                name: "tbl_Communication");

            migrationBuilder.DropTable(
                name: "tbl_CommunicationLogApologies");

            migrationBuilder.DropTable(
                name: "tbl_CommunicationLogAttendees");

            migrationBuilder.DropTable(
                name: "tbl_CompanyBank");

            migrationBuilder.DropTable(
                name: "tbl_CompanyContact");

            migrationBuilder.DropTable(
                name: "tbl_CompanyMessage");

            migrationBuilder.DropTable(
                name: "tbl_CompanyOnlineTraining");

            migrationBuilder.DropTable(
                name: "tbl_CompanyPincode");

            migrationBuilder.DropTable(
                name: "tbl_CompanyReception");

            migrationBuilder.DropTable(
                name: "tbl_CompanyTrainingImage");

            migrationBuilder.DropTable(
                name: "tbl_Complain_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_Complain_StaffName");

            migrationBuilder.DropTable(
                name: "tbl_ComplainRegistorClients");

            migrationBuilder.DropTable(
                name: "tbl_ComplainRegistorStaff");

            migrationBuilder.DropTable(
                name: "tbl_Complements");

            migrationBuilder.DropTable(
                name: "tbl_ConsentCare");

            migrationBuilder.DropTable(
                name: "tbl_ConsentData");

            migrationBuilder.DropTable(
                name: "tbl_ConsentLandlineLog");

            migrationBuilder.DropTable(
                name: "tbl_ConsentMedication");

            migrationBuilder.DropTable(
                name: "tbl_ContractTemplate");

            migrationBuilder.DropTable(
                name: "tbl_conversation");

            migrationBuilder.DropTable(
                name: "tbl_createshiftuserroles");

            migrationBuilder.DropTable(
                name: "tbl_CreditCard");

            migrationBuilder.DropTable(
                name: "tbl_CuidiBuddy");

            migrationBuilder.DropTable(
                name: "tbl_DeductionValue");

            migrationBuilder.DropTable(
                name: "tbl_DefaultStaffSupport");

            migrationBuilder.DropTable(
                name: "tbl_Directors");

            migrationBuilder.DropTable(
                name: "tbl_DutyOnCallPersonResponsible");

            migrationBuilder.DropTable(
                name: "tbl_DutyOnCallPersonToAct");

            migrationBuilder.DropTable(
                name: "tbl_EmailMessageUser");

            migrationBuilder.DropTable(
                name: "tbl_Enotice_");

            migrationBuilder.DropTable(
                name: "tbl_Equipment");

            migrationBuilder.DropTable(
                name: "tbl_EquipmentAssessment");

            migrationBuilder.DropTable(
                name: "tbl_EquipmentAssessmentData");

            migrationBuilder.DropTable(
                name: "tbl_Expenselog");

            migrationBuilder.DropTable(
                name: "tbl_ExternalRole");

            migrationBuilder.DropTable(
                name: "tbl_ExternalRoleAccessClient");

            migrationBuilder.DropTable(
                name: "tbl_ExternalRoleAccessStaff");

            migrationBuilder.DropTable(
                name: "tbl_EyeHealth_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_EyeHealth_Physician");

            migrationBuilder.DropTable(
                name: "tbl_EyeHealth_StaffName");

            migrationBuilder.DropTable(
                name: "tbl_FeedBackMatchingWords");

            migrationBuilder.DropTable(
                name: "tbl_FilesAndRecord");

            migrationBuilder.DropTable(
                name: "tbl_FluidIntake");

            migrationBuilder.DropTable(
                name: "tbl_FocusedFeedback");

            migrationBuilder.DropTable(
                name: "tbl_FoodIntake_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_FoodIntake_Physician");

            migrationBuilder.DropTable(
                name: "tbl_FoodIntake_StaffName");

            migrationBuilder.DropTable(
                name: "tbl_HealthAndLiving");

            migrationBuilder.DropTable(
                name: "tbl_HealthCondition");

            migrationBuilder.DropTable(
                name: "tbl_HealthTask");

            migrationBuilder.DropTable(
                name: "tbl_HealthTask2");

            migrationBuilder.DropTable(
                name: "tbl_HeartRate_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_HeartRate_Physician");

            migrationBuilder.DropTable(
                name: "tbl_HeartRate_StaffName");

            migrationBuilder.DropTable(
                name: "tbl_HistoryOfFall");

            migrationBuilder.DropTable(
                name: "tbl_HolidayCategory");

            migrationBuilder.DropTable(
                name: "tbl_HomeRiskAssessmentTask");

            migrationBuilder.DropTable(
                name: "tbl_HospitalEntryPersonToTakeAction");

            migrationBuilder.DropTable(
                name: "tbl_HospitalEntryStaffInvolved");

            migrationBuilder.DropTable(
                name: "tbl_HospitalExitOfficerToTakeAction");

            migrationBuilder.DropTable(
                name: "tbl_IncidentDetailAssignedTo");

            migrationBuilder.DropTable(
                name: "tbl_IncidentReporting");

            migrationBuilder.DropTable(
                name: "tbl_IncidentType");

            migrationBuilder.DropTable(
                name: "tbl_IncomeValue");

            migrationBuilder.DropTable(
                name: "tbl_Incoming_Meds");

            migrationBuilder.DropTable(
                name: "tbl_InfectionControl");

            migrationBuilder.DropTable(
                name: "tbl_Inspection");

            migrationBuilder.DropTable(
                name: "tbl_InterviewQuestion");

            migrationBuilder.DropTable(
                name: "tbl_InvestigationAttachment");

            migrationBuilder.DropTable(
                name: "tbl_JobPositionAccess");

            migrationBuilder.DropTable(
                name: "tbl_KeyIndicatorLog");

            migrationBuilder.DropTable(
                name: "tbl_KeyWorker_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_KeyWorker_StaffName");

            migrationBuilder.DropTable(
                name: "tbl_LogAudit_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_LogAuditSummary");

            migrationBuilder.DropTable(
                name: "tbl_LogAuditTracke");

            migrationBuilder.DropTable(
                name: "tbl_ManagingTasks");

            migrationBuilder.DropTable(
                name: "tbl_MealIntake");

            migrationBuilder.DropTable(
                name: "tbl_MedAudit_AuditorName");

            migrationBuilder.DropTable(
                name: "tbl_MedAudit_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_MedComp_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_MedicationAuditSummary");

            migrationBuilder.DropTable(
                name: "tbl_MedicationAuditTracker");

            migrationBuilder.DropTable(
                name: "tbl_MedicationTrackerDelete");

            migrationBuilder.DropTable(
                name: "tbl_MeetingActionableItem");

            migrationBuilder.DropTable(
                name: "tbl_MeetingAgenda");

            migrationBuilder.DropTable(
                name: "tbl_MeetingDiscussions");

            migrationBuilder.DropTable(
                name: "tbl_MeetingLogAttende");

            migrationBuilder.DropTable(
                name: "tbl_MeetingLogFacilitator");

            migrationBuilder.DropTable(
                name: "tbl_MeetingLogResponsibleToAct");

            migrationBuilder.DropTable(
                name: "tbl_MeetingType");

            migrationBuilder.DropTable(
                name: "tbl_MentalHealthSupport");

            migrationBuilder.DropTable(
                name: "tbl_OfficeAttendance");

            migrationBuilder.DropTable(
                name: "tbl_OneToOne_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_OnlineLogQuestionResults");

            migrationBuilder.DropTable(
                name: "tbl_OnlineQuestionResults");

            migrationBuilder.DropTable(
                name: "tbl_OnlineTrainingAssignStaff");

            migrationBuilder.DropTable(
                name: "tbl_OnlineTrainingBundleAssignStaff");

            migrationBuilder.DropTable(
                name: "tbl_OnlineTrainingBundleCourse");

            migrationBuilder.DropTable(
                name: "tbl_OnlineTraininglogQuestion");

            migrationBuilder.DropTable(
                name: "tbl_OnlineTraningQuestionOptions");

            migrationBuilder.DropTable(
                name: "tbl_OralCare");

            migrationBuilder.DropTable(
                name: "tbl_OxygenLvl_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_OxygenLvl_Physician");

            migrationBuilder.DropTable(
                name: "tbl_OxygenLvl_StaffName");

            migrationBuilder.DropTable(
                name: "tbl_PainChart_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_PainChart_Physician");

            migrationBuilder.DropTable(
                name: "tbl_PainChart_StaffName");

            migrationBuilder.DropTable(
                name: "tbl_PayrollSummary");

            migrationBuilder.DropTable(
                name: "tbl_PerformanceIndicatorTask");

            migrationBuilder.DropTable(
                name: "tbl_Personal");

            migrationBuilder.DropTable(
                name: "tbl_PersonalHygiene");

            migrationBuilder.DropTable(
                name: "tbl_PersonalityTest");

            migrationBuilder.DropTable(
                name: "tbl_PersonCentredFocus");

            migrationBuilder.DropTable(
                name: "tbl_Pets");

            migrationBuilder.DropTable(
                name: "tbl_PettyCashHeading");

            migrationBuilder.DropTable(
                name: "tbl_PettyCashUsage");

            migrationBuilder.DropTable(
                name: "tbl_PhysicalAbility");

            migrationBuilder.DropTable(
                name: "tbl_PlannedDeduction");

            migrationBuilder.DropTable(
                name: "tbl_PlannedIncome");

            migrationBuilder.DropTable(
                name: "tbl_Policies");

            migrationBuilder.DropTable(
                name: "tbl_Policy");

            migrationBuilder.DropTable(
                name: "tbl_Program_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_PulseRate_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_PulseRate_Physician");

            migrationBuilder.DropTable(
                name: "tbl_PulseRate_StaffName");

            migrationBuilder.DropTable(
                name: "tbl_RecentProject");

            migrationBuilder.DropTable(
                name: "tbl_RegisterDeduction");

            migrationBuilder.DropTable(
                name: "tbl_RegisterIncome");

            migrationBuilder.DropTable(
                name: "tbl_ReportedConcern");

            migrationBuilder.DropTable(
                name: "tbl_Resources_");

            migrationBuilder.DropTable(
                name: "tbl_Review");

            migrationBuilder.DropTable(
                name: "tbl_RoleClaim");

            migrationBuilder.DropTable(
                name: "tbl_RotaPin");

            migrationBuilder.DropTable(
                name: "tbl_RotaStaff");

            migrationBuilder.DropTable(
                name: "tbl_SalaryAllowance");

            migrationBuilder.DropTable(
                name: "tbl_SalaryDeduction");

            migrationBuilder.DropTable(
                name: "tbl_Seizure_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_Seizure_Physician");

            migrationBuilder.DropTable(
                name: "tbl_Seizure_StaffName");

            migrationBuilder.DropTable(
                name: "tbl_Service_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_Service_StaffName");

            migrationBuilder.DropTable(
                name: "tbl_ServiceType");

            migrationBuilder.DropTable(
                name: "tbl_ServiceWeek");

            migrationBuilder.DropTable(
                name: "tbl_SetupStaffHoliday");

            migrationBuilder.DropTable(
                name: "tbl_ShiftBookingBlockedDays");

            migrationBuilder.DropTable(
                name: "tbl_SideMenu");

            migrationBuilder.DropTable(
                name: "tbl_SpecialHealthAndMedication");

            migrationBuilder.DropTable(
                name: "tbl_SpecialHealthCondition");

            migrationBuilder.DropTable(
                name: "tbl_SpotCheck_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_Staff_Reference");

            migrationBuilder.DropTable(
                name: "tbl_staffalertcountmatrix");

            migrationBuilder.DropTable(
                name: "tbl_StaffBlackList");

            migrationBuilder.DropTable(
                name: "tbl_StaffCommunication");

            migrationBuilder.DropTable(
                name: "tbl_StaffCompetenceTestTask");

            migrationBuilder.DropTable(
                name: "tbl_StaffContract");

            migrationBuilder.DropTable(
                name: "tbl_StaffEducation");

            migrationBuilder.DropTable(
                name: "tbl_StaffEmergencyContact");

            migrationBuilder.DropTable(
                name: "tbl_StaffHealthTask");

            migrationBuilder.DropTable(
                name: "tbl_StaffHoliday");

            migrationBuilder.DropTable(
                name: "tbl_StaffIncidentReporting");

            migrationBuilder.DropTable(
                name: "tbl_StaffInfectionControl");

            migrationBuilder.DropTable(
                name: "tbl_StaffInterviewTask");

            migrationBuilder.DropTable(
                name: "tbl_StaffLateness");

            migrationBuilder.DropTable(
                name: "tbl_StaffMedRotaAudit");

            migrationBuilder.DropTable(
                name: "tbl_StaffMedTracker");

            migrationBuilder.DropTable(
                name: "tbl_StaffOfficeLocation");

            migrationBuilder.DropTable(
                name: "tbl_StaffPayRollSetting");

            migrationBuilder.DropTable(
                name: "tbl_StaffPerformance");

            migrationBuilder.DropTable(
                name: "tbl_StaffPerformanceHeading");

            migrationBuilder.DropTable(
                name: "tbl_StaffPersonalInfoComment");

            migrationBuilder.DropTable(
                name: "tbl_StaffPersonalityTest");

            migrationBuilder.DropTable(
                name: "tbl_StaffRating");

            migrationBuilder.DropTable(
                name: "tbl_StaffReferee");

            migrationBuilder.DropTable(
                name: "tbl_StaffRegulatoryContact");

            migrationBuilder.DropTable(
                name: "tbl_StaffRotaDynamicAddition");

            migrationBuilder.DropTable(
                name: "tbl_StaffRotaForceRecord");

            migrationBuilder.DropTable(
                name: "tbl_StaffRotaItem");

            migrationBuilder.DropTable(
                name: "tbl_StaffRotaMedAuditSummary");

            migrationBuilder.DropTable(
                name: "tbl_StaffRotaPartner");

            migrationBuilder.DropTable(
                name: "tbl_StaffRotaTask");

            migrationBuilder.DropTable(
                name: "tbl_StaffShadowingTask");

            migrationBuilder.DropTable(
                name: "tbl_StaffShiftBookingDay");

            migrationBuilder.DropTable(
                name: "tbl_StaffTax");

            migrationBuilder.DropTable(
                name: "tbl_StaffTeamLeadTasks");

            migrationBuilder.DropTable(
                name: "tbl_StaffTraining");

            migrationBuilder.DropTable(
                name: "tbl_StaffTrainingByList");

            migrationBuilder.DropTable(
                name: "tbl_StaffTrainingMatrixList");

            migrationBuilder.DropTable(
                name: "tbl_Supervision_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_Supervision_StaffName");

            migrationBuilder.DropTable(
                name: "tbl_Survey_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_Survey_StaffName");

            migrationBuilder.DropTable(
                name: "tbl_TrackingConcernManager");

            migrationBuilder.DropTable(
                name: "tbl_TrackingConcernStaff");

            migrationBuilder.DropTable(
                name: "tbl_Training");

            migrationBuilder.DropTable(
                name: "tbl_TrainingRequirement");

            migrationBuilder.DropTable(
                name: "tbl_TypeOfStaffService");

            migrationBuilder.DropTable(
                name: "tbl_Untowards");

            migrationBuilder.DropTable(
                name: "tbl_UpcomingMeeting");

            migrationBuilder.DropTable(
                name: "tbl_UserClaim");

            migrationBuilder.DropTable(
                name: "tbl_UserLogin");

            migrationBuilder.DropTable(
                name: "tbl_UserRole");

            migrationBuilder.DropTable(
                name: "tbl_UserToken");

            migrationBuilder.DropTable(
                name: "tbl_Visit_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_Visit_StaffName");

            migrationBuilder.DropTable(
                name: "tbl_Voice_CallerName");

            migrationBuilder.DropTable(
                name: "tbl_Voice_GoodStaff");

            migrationBuilder.DropTable(
                name: "tbl_Voice_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_Voice_PoorStaff");

            migrationBuilder.DropTable(
                name: "tbl_Whisttle_Blower");

            migrationBuilder.DropTable(
                name: "tbl_WoundCare_OfficerToAct");

            migrationBuilder.DropTable(
                name: "tbl_WoundCare_Physician");

            migrationBuilder.DropTable(
                name: "tbl_WoundCare_StaffName");

            migrationBuilder.DropTable(
                name: "tbl_Staff_AdlObs");

            migrationBuilder.DropTable(
                name: "tbl_AppointmentBooking");

            migrationBuilder.DropTable(
                name: "tbl_BaseRecord");

            migrationBuilder.DropTable(
                name: "tbl_Client_BloodCoagulationRecord");

            migrationBuilder.DropTable(
                name: "tbl_Client_BloodPressure");

            migrationBuilder.DropTable(
                name: "tbl_Client_BMIChart");

            migrationBuilder.DropTable(
                name: "tbl_Client_BodyTemp");

            migrationBuilder.DropTable(
                name: "tbl_Client_BowelMovement");

            migrationBuilder.DropTable(
                name: "tbl_Capacity");

            migrationBuilder.DropTable(
                name: "tbl_ClientCareObj");

            migrationBuilder.DropTable(
                name: "tbl_chatsupport");

            migrationBuilder.DropTable(
                name: "tbl_Client_Nutrition");

            migrationBuilder.DropTable(
                name: "tbl_ClientCareDetailsTask");

            migrationBuilder.DropTable(
                name: "tbl_Hobbies");

            migrationBuilder.DropTable(
                name: "tbl_ClientInvoice");

            migrationBuilder.DropTable(
                name: "tbl_ClientMedicationDay");

            migrationBuilder.DropTable(
                name: "tbl_ClientPerformanceIndicator");

            migrationBuilder.DropTable(
                name: "tbl_ClientRotaDays");

            migrationBuilder.DropTable(
                name: "tbl_RotaTask");

            migrationBuilder.DropTable(
                name: "tbl_ClientServiceDetail");

            migrationBuilder.DropTable(
                name: "tbl_ClientSupportPlanGoal");

            migrationBuilder.DropTable(
                name: "tbl_ClientTaskBoard");

            migrationBuilder.DropTable(
                name: "tbl_CommunicationLog");

            migrationBuilder.DropTable(
                name: "CompanyModel");

            migrationBuilder.DropTable(
                name: "tbl_Client_ComplainRegister");

            migrationBuilder.DropTable(
                name: "tbl_ComplainRegistor");

            migrationBuilder.DropTable(
                name: "tbl_ConsentLandLine");

            migrationBuilder.DropTable(
                name: "tbl_Inbox");

            migrationBuilder.DropTable(
                name: "tbl_createshift");

            migrationBuilder.DropTable(
                name: "tbl_DeductionForAllStaff");

            migrationBuilder.DropTable(
                name: "tbl_DutyOnCall");

            migrationBuilder.DropTable(
                name: "tbl_EmailMessage");

            migrationBuilder.DropTable(
                name: "tbl_ExternalRoleAccess");

            migrationBuilder.DropTable(
                name: "tbl_Client_EyeHealthMonitoring");

            migrationBuilder.DropTable(
                name: "tbl_Client_FoodIntake");

            migrationBuilder.DropTable(
                name: "tbl_BestInterestAssessment");

            migrationBuilder.DropTable(
                name: "tbl_Client_HeartRate");

            migrationBuilder.DropTable(
                name: "tbl_HomeRiskAssessment");

            migrationBuilder.DropTable(
                name: "tbl_HospitalEntry");

            migrationBuilder.DropTable(
                name: "tbl_HospitalExit");

            migrationBuilder.DropTable(
                name: "tbl_IncidentDetail");

            migrationBuilder.DropTable(
                name: "tbl_IncomeForAllStaff");

            migrationBuilder.DropTable(
                name: "tbl_Investigation");

            migrationBuilder.DropTable(
                name: "tbl_KeyIndicators");

            migrationBuilder.DropTable(
                name: "tbl_Staff_KeyWorkerVoice");

            migrationBuilder.DropTable(
                name: "tbl_Client_LogAudit");

            migrationBuilder.DropTable(
                name: "tbl_Client_MedAudit");

            migrationBuilder.DropTable(
                name: "tbl_Staff_MedCompObs");

            migrationBuilder.DropTable(
                name: "tbl_MeetingLog");

            migrationBuilder.DropTable(
                name: "tbl_Staff_OneToOne");

            migrationBuilder.DropTable(
                name: "tbl_OnlineTrainingBundle");

            migrationBuilder.DropTable(
                name: "tbl_StaffBundleCourseResult");

            migrationBuilder.DropTable(
                name: "tbl_OnlineTraningQuestion");

            migrationBuilder.DropTable(
                name: "tbl_Client_Oxygenlvl");

            migrationBuilder.DropTable(
                name: "tbl_Client_PainChart");

            migrationBuilder.DropTable(
                name: "tbl_PerformanceIndicator");

            migrationBuilder.DropTable(
                name: "tbl_InterestAndObjective");

            migrationBuilder.DropTable(
                name: "tbl_PersonCentred");

            migrationBuilder.DropTable(
                name: "tbl_PettyCash");

            migrationBuilder.DropTable(
                name: "tbl_Client_Program");

            migrationBuilder.DropTable(
                name: "tbl_Client_PulseRate");

            migrationBuilder.DropTable(
                name: "tbl_StaffMedRota");

            migrationBuilder.DropTable(
                name: "tbl_Client_Seizure");

            migrationBuilder.DropTable(
                name: "tbl_Client_ServiceWatch");

            migrationBuilder.DropTable(
                name: "tbl_Staff_SpotCheck");

            migrationBuilder.DropTable(
                name: "tbl_staffalert");

            migrationBuilder.DropTable(
                name: "tbl_StaffCompetenceTest");

            migrationBuilder.DropTable(
                name: "tbl_StaffHealth");

            migrationBuilder.DropTable(
                name: "tbl_StaffInterview");

            migrationBuilder.DropTable(
                name: "tbl_OfficeLocation");

            migrationBuilder.DropTable(
                name: "tbl_StaffPerformanceSummary");

            migrationBuilder.DropTable(
                name: "tbl_BaseRecordItem_Model");

            migrationBuilder.DropTable(
                name: "tbl_StaffRotaPeriod");

            migrationBuilder.DropTable(
                name: "tbl_StaffShadowing");

            migrationBuilder.DropTable(
                name: "tbl_StaffShiftBooking");

            migrationBuilder.DropTable(
                name: "tbl_StaffTeamLead");

            migrationBuilder.DropTable(
                name: "tbl_StaffTrainingMatrix");

            migrationBuilder.DropTable(
                name: "tbl_Staff_SupervisionAppraisal");

            migrationBuilder.DropTable(
                name: "tbl_Staff_Survey");

            migrationBuilder.DropTable(
                name: "tbl_TrackingConcernNote");

            migrationBuilder.DropTable(
                name: "tbl_Role");

            migrationBuilder.DropTable(
                name: "tbl_Client_MgtVisit");

            migrationBuilder.DropTable(
                name: "tbl_Client_Voice");

            migrationBuilder.DropTable(
                name: "tbl_Client_WoundCare");

            migrationBuilder.DropTable(
                name: "tbl_ClientCareDetailsHeading");

            migrationBuilder.DropTable(
                name: "tbl_ClientInvoiceSummary");

            migrationBuilder.DropTable(
                name: "tbl_ClientMedication");

            migrationBuilder.DropTable(
                name: "tbl_ClientRota");

            migrationBuilder.DropTable(
                name: "tbl_RotaDayofWeek");

            migrationBuilder.DropTable(
                name: "tbl_ClientSupportPlan");

            migrationBuilder.DropTable(
                name: "tbl_PersonalDetail");

            migrationBuilder.DropTable(
                name: "tbl_OnlineTraning");

            migrationBuilder.DropTable(
                name: "tbl_Interest");

            migrationBuilder.DropTable(
                name: "tbl_BaseRecord_Model");

            migrationBuilder.DropTable(
                name: "tbl_StaffRota");

            migrationBuilder.DropTable(
                name: "tbl_ShiftBooking");

            migrationBuilder.DropTable(
                name: "tbl_MedicationManufacturer");

            migrationBuilder.DropTable(
                name: "tbl_MedicationRoute");

            migrationBuilder.DropTable(
                name: "tbl_Medication");

            migrationBuilder.DropTable(
                name: "tbl_ClientRotaType");

            migrationBuilder.DropTable(
                name: "tbl_Client");

            migrationBuilder.DropTable(
                name: "tbl_OnlineClass");

            migrationBuilder.DropTable(
                name: "tbl_OnlineMaterialType");

            migrationBuilder.DropTable(
                name: "tbl_ClientRotaName");

            migrationBuilder.DropTable(
                name: "tbl_AreaCode");

            migrationBuilder.DropTable(
                name: "tbl_ClientFacility");

            migrationBuilder.DropTable(
                name: "tbl_Territory");

            migrationBuilder.DropTable(
                name: "tbl_User");

            migrationBuilder.DropTable(
                name: "tbl_Company");

            migrationBuilder.DropTable(
                name: "tbl_StaffPersonalInfo");

            migrationBuilder.DropTable(
                name: "tbl_CategoryOfStaff");

            migrationBuilder.DropTable(
                name: "tbl_JobPosition");

            migrationBuilder.DropTable(
                name: "tbl_StaffWorkTeam");
        }
    }
}
