using Microsoft.AspNetCore.Identity;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Repository.Database;

namespace JomarHealthCare.API
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddIdentityUser(this IServiceCollection services)
        {

            services.AddIdentityCore<ApplicationUser>(opt =>
            {
                opt.User.RequireUniqueEmail = true;
                opt.SignIn.RequireConfirmedEmail = true;
                opt.Password.RequiredLength = 8;
                opt.Password.RequireNonAlphanumeric = true;
                opt.Password.RequireDigit = true;
                opt.Password.RequireLowercase = true;
                opt.Password.RequireUppercase = true;

            })
              .AddUserManager<UserManager<ApplicationUser>>()
              .AddRoles<IdentityRole>()
              .AddEntityFrameworkStores<MyCareDbContext>()
              .AddDefaultTokenProviders()
              .AddTotpTokenProvider();

            return services;
        }
    }
}
