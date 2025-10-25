using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Application.Repositories.CarePlan;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Application.Repositories.Clients.Rotering;
using JomarHealthCare.Application.Repositories.SendRota;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Repository.Database;
using JomarHealthCare.Repository.Repositories;
using JomarHealthCare.Repository.Repositories.Careplan;
using JomarHealthCare.Repository.Repositories.Clients;
using JomarHealthCare.Repository.Repositories.Clients.Rotering;
using JomarHealthCare.Repository.Repositories.SendRota;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace JomarHealthCare.Repository
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddDatabaseContext(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContextPool<MyCareDbContext>((sp, options) =>
            {
                //options.UseSqlServer(configuration.GetConnectionString("JomarHealthCare"));
                //options.UseNpgsql(configuration.GetConnectionString("ExternalConnection"));
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
                options.EnableSensitiveDataLogging(true);
                //options.AddInterceptors(sp.GetRequiredService<AuditLogInterceptor>());
            })
            .AddRepositories();
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            //Settings
            services.AddScoped<IIncidentTypeRepository, IncidentTypeRepository>();
            services.AddScoped<IReportedConcernRepository, ReportedConcernRepository>();

            //AREA CODE
            services.AddScoped<IAreaCodeRepository, AreaCodeRepository>();

            //BASE
            services.AddScoped<IBaseRecordRepository, BaseRecordRepository>();
            services.AddScoped<IBaseRecordItemRepository, BaseRecordItemRepository>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork>(c => { return c.GetRequiredService<MyCareDbContext>(); });
            
            //COMPANY
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IClassOfStaffRepository, ClassOfStaffRepository>();
            services.AddScoped<ICandidateInterviewRepository, CandidateInterviewRepository>();
            services.AddScoped<ICategoryOfStaffRepository, CategoryOfStaffRepository>();

            //CLIENT
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IClientDailyTaskRepository, ClientDailyTaskRepository>();
            services.AddScoped<IClientHobbiesRepository, ClientHobbiesRepository>();
            services.AddScoped<IClientInvolvingPartyRepository, ClientInvolvingPartyRepository>();
            services.AddScoped<IClientHealthConditionRepository, ClientHealthConditionRepository>();
            services.AddScoped<IClientEquipmentAssessmentRepository, ClientEquipmentAssessmentRepository>();
            services.AddScoped<IHomeRiskAssessmentRepository, HomeRiskAssessmentRepository>();
            services.AddScoped<IClientInvoiceRateRepository, ClientInvoiceRateRepository>();
            services.AddScoped<IClientBillToRepository, ClientBillToRepository>();
            services.AddScoped<IClientInterestAndObjectiveRepository, ClientInterestAndObjectiveRepository>();
            services.AddScoped<IClientDutyOnCallRepository, ClientDutyOnCallRepository>();
            services.AddScoped<IClientMedicationRepository, ClientMedicationRepository>();
            services.AddScoped<IClientProgramRepository, ClientProgramRepository>();
            services.AddScoped<IClientPetRepository, ClientPetRepository>();
            services.AddScoped<IClientInfectionControlRepository, ClientInfectionControlRepository>();
            services.AddScoped<IClientServiceWatchRepository, ClientServiceWatchRepository>();
            services.AddScoped<IClientMgtVisitRepository, ClientMgtVisitRepository>();
            services.AddScoped<IClientVoiceRepository, ClientVoiceRepository>();
            services.AddScoped<IClientBestInterestRepository, ClientBestInterestRepository>();
            services.AddScoped<IClientNutritionRepository, ClientNutritionRepository>();
            services.AddScoped<IClientHospitalEnteryRepository, ClientHospitalEnteryRepository>();
            services.AddScoped<IHospitalExitRepository, HospitalExitRepository>();

            //Rotering
            services.AddScoped<IRotaDayOfWeekRepository, RotaDayOfWeekRepository>();
            services.AddScoped<IRotaTaskRepository,  RotaTaskRepository>();
            services.AddScoped<IClientRotaTypeRepository, ClientRotaTypeRepository>();
            services.AddScoped<IRotaRepository, RotaRepository>();
            services.AddScoped<IClientRotaRepository, ClientRotaRepository>();

            //Rota Sending
            services.AddScoped<IStaffRotaRepository, StaffRotaRepository>();

            //Care Plan
            services.AddScoped<IPersonCentredRepository, PersonCentredRepository>();
            services.AddScoped<IKeyworkerRepository, KeyworkerRepository>();
            services.AddScoped<IKeyIndicatorRepository, KeyIndicatorRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<ICapacityRepository, CapacityRepository>();
            services.AddScoped<IPersonalRepository, PersonalRepository>();
            services.AddScoped<IBodyMapRepository, BodyMapRepository>();
            services.AddScoped<IClientCarePlanNutritionRepository, ClientCarePlanNutritionRepository>();
            services.AddScoped<IClientHealthAndLivingRepository, ClientHealthAndLivingRepository>();
            services.AddScoped<IClientBalanceRepository, ClientBalanceRepository>();
            services.AddScoped<IClientPhysicalAbilityRepository, ClientPhysicalAbilityRepository>();
            services.AddScoped<IClientHistoryOfFallRepository, ClientHistoryOfFallRepository>();
            services.AddScoped<IClientCongnitiveRepository, ClientCongnitiveRepository>();
            services.AddScoped<IClientSpecialHealthAndMedicationRepository, ClientSpecialHealthAndMedicationRepository>();
            services.AddScoped<IPersonalHygieneRepository, PersonalHygieneRepository>();
            services.AddScoped<IOralCareRepository, OralCareRepository>();
            services.AddScoped<IMentalHealthSupportRepository, MentalHealthSupportRepository>();
            services.AddScoped<IConsentDataRepository, ConsentDataRepository>();

            //Equipment Assessment
            services.AddScoped<IEquipmentAssessmentDataRepository, EquipmentAssessmentDataRepository>();

            //HOBBY
            services.AddScoped<IHobbyRepository, HobbyRepository>();

            //HEALTH
            services.AddScoped<IHealthConditionRepository, HealthConditionRepository>();

            //JOB
            services.AddScoped<IJobPositionRepository, JobPositionRepository>();
            services.AddScoped<IJobCategoryRepository, JobCategoryRespository>();

            //POLICY
            services.AddScoped<IPolicyRepository, PolicyRepository>();

            //TERRITORY
            services.AddScoped<ITerritoryRepository, TerritoryRepository>();

            //SERVICE TYPE
            services.AddScoped<IServiceTypeRepository, ServiceTypeRepository>();

            services.AddScoped<IStaffTrainingRepository, StaffTrainingRepository>();
            //STAFF
            services.AddScoped<IStaffEmergencyContactRepository, StaffEmergencyContactRepository>();
            services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
            services.AddScoped<IStaffEducationRepository, StaffEducationRepository>();
            services.AddScoped<IStaffPersonalInfoRepository, StaffPersonalInfoRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IMedicationRepository, MedicationRepository>();
            services.AddScoped<IStaffRefereeRepository, StaffRefereeRepository>();
            services.AddScoped<IMedicationManufacturerRepository, MedicationManufacturerRepository>();
            services.AddScoped<IStaffHolidayRepository, StaffHolidayRepository>();
            services.AddScoped<IStaffAdlObsRepository, StaffAdlObsRepository>();
            services.AddScoped<IStaffContractRepository, StaffContractRepository>();
            services.AddScoped<IStaffHealthRepository, StaffHealthRepository>();
            services.AddScoped<IStaffSpotCheckRepository, StaffSpotCheckRepository>();
            services.AddScoped<IStaffWorkTeamRepository, StaffWorkTeamRepository>();
            services.AddScoped<IMedicationReouteRepository, MedicationRouteRepository>();
            services.AddScoped<IStaffSurveyRepository, StaffSurveyRepository>();
            services.AddScoped<IOneToOneOfficerToActRepository, OneToOneOfficerToActRepository>();
            services.AddScoped<IPettyCashRepository, PettyCashRepository>();

            services.AddScoped<IInterviewQuestionRepository, InterviewQuestionRepository>();
            services.AddScoped<IExpenseLogRepository, ExpenseLogRepository>();
            services.AddScoped<IPettyCashHeadingRepository, PettyCashHeadingRepository>();
            services.AddScoped<ICompanyBankRepository, CompanyBankRepository>();
            services.AddScoped<IPayrollSummaryRepository, PayrollSummaryRepository>();

            services.AddScoped<IRegisterIncomeRepository, RegisterIncomeRepository>();
            services.AddScoped<IRegisterDeductionRepository, RegisterDeductionRepository>();
            services.AddScoped<IStaffInterviewRepository, StaffInterviewRepository>();
            services.AddScoped<IComplainRegistorRepository, ComplainRegistorRepository>();
            services.AddScoped<IOfficeAttendanceRepository, OfficeAttendanceRepository>();
            services.AddScoped<ICompanyMessageRepository, CompanyMessageRepository>();
            services.AddScoped<IAppMessageRepository, AppMessageRepository>();
            services.AddScoped<IStaffMedCompRepository, StaffMedCompRepository>();
            services.AddScoped<IStaffKeyWorkerVoiceRepository, StaffKeyWorkerVoiceRepository>();
            services.AddScoped<IStaffOneToOneRepository, StaffOneToOneRepository>(); 
            services.AddScoped<IStaffSupervisionAppraisalRepository, StaffSupervisionAppraisalRepository>();
            services.AddScoped<IStaffInfectionControlRepository, StaffInfectionControlRepository>();
            services.AddScoped<IStaffPersonalityTestRepository, StaffPersonalityTestRepository>();
            services.AddScoped<IStaffCompetenceTestRepository, StaffCompetenceTestRepository>();
            services.AddScoped<IStaffShadowingRepository, StaffShadowingRepository>();
            services.AddScoped<ISalaryAllowanceRepository, SalaryAllowanceRepository>();
            services.AddScoped<IStaffTrainingByListRepository, StaffTrainingByListRepository>();
            //Task Management
            services.AddScoped<IClientTaskBoardRepository, ClientTaskBoardRepository>();
            // Communication Log
            services.AddScoped<ICommunicationLogRepository, CommunicationLogRepository>();
            services.AddScoped<ICommunicationLogAttendeesRepository, CommunicationLogAttendeesRepository>();
            services.AddScoped<ICommunicationLogApologiesRepository, CommunicationLogApologiesRepository>();
            // Appointment Booking
            services.AddScoped<IAppointmentBookingRepository, AppointmentBookingRepository>();
            services.AddScoped<IAppointmentBookingAttendeesRepository, AppointmentBookingAttendeesRepository>();

            services.AddScoped<IExternalRoleRepository, ExternalRoleRepository>();
            services.AddScoped<IExternalRoleAccessRepository, ExternalRoleAccessRepository>();
            services.AddScoped<IIncidentDetailRepository, IncidentDetailRepository>();
            services.AddScoped<IWhisttleBlowerRepository, WhisttleBlowerRepository>();
            services.AddScoped<IUnitOfWork>(c => { return c.GetRequiredService<MyCareDbContext>(); });
            return services;
        }
    }
}
