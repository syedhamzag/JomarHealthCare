using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using JomarHealthCare.Application.Configs;
using JomarHealthCare.Application.HttpServices;
using JomarHealthCare.Application.PipelineBehavior;
using Refit;
using System.Reflection;

namespace JomarHealthCare.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            services.AddMediatR((c) =>
            {
                c.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
               // c.AddOpenBehavior(typeof(ValidationBehavior<,>));
            });

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly())
                .AddHttpClientServices(configuration)
                .AddConfigs(configuration);
            return services;
        }

        public static IServiceCollection AddHttpClientServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<ProvidusNipDelegatingHandler>();
            //services.AddScoped<ProvidusVirtualPaymentDelegatingHandler>();
            //services.AddHttpClient("nipservice", r =>
            //{
            //    r.BaseAddress = new Uri(configuration["ProvidusNip:baseUrl"]!);
            //}).AddTypedClient(r => RestService.For<INipService>(r))
            //.AddHttpMessageHandler<ProvidusNipDelegatingHandler>();

            services.AddHttpClient("zeptoEmailService", opt =>
            {
                opt.BaseAddress = new Uri(configuration["ZeptoEmailSetting:BaseUrl"]!);
                opt.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Zoho-enczapikey", configuration["ZeptoEmailSetting:AuthKey"]!);
            }).AddTypedClient(r => RestService.For<IZeptoEmailHttpService>(r));


            return services;
        }

        public static IServiceCollection AddConfigs(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JwtOptions>(configuration.GetSection("JWT"));
            services.Configure<ZeptoEmailSetting>(configuration.GetSection(nameof(ZeptoEmailSetting)));

            return services;
        }

    }
}
