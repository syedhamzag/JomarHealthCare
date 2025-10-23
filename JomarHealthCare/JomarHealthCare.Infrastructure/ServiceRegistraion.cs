using Microsoft.Extensions.DependencyInjection;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.HttpServices;
using JomarHealthCare.Infrastructure.Implementations;

namespace JomarHealthCare.Infrastructure
{
    public static class ServiceRegistraion
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services)
        {
            services.AddScoped<IAzureBlobStorageService, AzureBlobStorageService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IUserIdentityService, UserIdentityService>();
          
            return services;
        }

    }
}
