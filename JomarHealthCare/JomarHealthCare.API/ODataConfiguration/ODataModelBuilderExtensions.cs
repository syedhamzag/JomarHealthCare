using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.API.ODataConfiguration
{
    public static class ODataModelBuilderExtensions
    {

        static string Namespace = "JomarHealthCare";
        public static IEdmModel GetEdmModel()
        {
            var modelBuilder = new ODataConventionModelBuilder()
            {
                Namespace = Namespace,
                ContainerName = "JomarHealthCareContainer"
            };
            var userEntity = modelBuilder.EntitySet<ApplicationUser>(nameof(ApplicationUser));
            userEntity.EntityType.ConfigureApplicationUser();

            modelBuilder.EntitySet<StaffPersonalInfo>(nameof(StaffPersonalInfo));
            modelBuilder.EntitySet<StaffTraining>(nameof(StaffTraining));
            modelBuilder.EntitySet<StaffInterview>(nameof(StaffInterview));
            modelBuilder.EntitySet<ComplainRegistor>(nameof(ComplainRegistor));
            modelBuilder.EntitySet<OfficeAttendance>(nameof(OfficeAttendance));
            modelBuilder.EntitySet<CompanyMessage>(nameof(CompanyMessage));
            modelBuilder.EntitySet<AppMessage>(nameof(AppMessage));
            modelBuilder.EnableLowerCamelCase();

            return modelBuilder.GetEdmModel();
        }

        public static void ConfigureApplicationUser(this EntityTypeConfiguration<ApplicationUser> config)
        {
            config.Ignore(i => i.PasswordHash);
            config.Ignore(i => i.NormalizedUserName);
            config.Ignore(i => i.Email);
            config.Ignore(i => i.NormalizedEmail);
            config.Ignore(i => i.ConcurrencyStamp);
            config.Ignore(i => i.PhoneNumber);
            config.Ignore(i => i.PhoneNumberConfirmed);
            config.Ignore(i => i.TwoFactorEnabled);
            config.Ignore(i => i.SecurityStamp);

        }


    }
}
