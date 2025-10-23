
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.OData;
using Serilog;
using JomarHealthCare.Application;
using JomarHealthCare.Infrastructure;
using JomarHealthCare.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                        .Enrich.WithClientIp()
                        .WriteTo.Console()
                        .CreateLogger();
            try
            {
                Log.Information("Starting web application");
                var builder = WebApplication.CreateBuilder(args);
                //ADD AUTO MAPPER
                builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


                builder.Services.AddSerilog(config =>
                {
                    config.ReadFrom.Configuration(builder.Configuration)
                           .Enrich.FromLogContext();
                });
                // Add services to the container.
               // builder.Services.AddMediatR(typeof(CreateClientCommandHandler));

                builder.Services.AddControllers()
                    .AddOData(options =>
                        options
                        .AddRouteComponents("odata/merchant", ODataModelBuilderExtensions.GetEdmModel())
                        .AddRouteComponents("odata/HumanResources", ODataModelBuilderExtensions.GetEdmModel())
                        .Select().Filter().OrderBy().Expand().Count().SetMaxTop(100)
                        );

                builder.Services.AddDataProtection();
                builder.Services.AddHttpContextAccessor();

                builder.Services.AddCors(policy =>
                {
                    policy.AddPolicy("CorsPolicy", opt => opt
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyOrigin());
                });

                builder.Services.AddHttpLogging(logging =>
                {
                    logging.LoggingFields = HttpLoggingFields.All;
                    logging.RequestBodyLogLimit = 4096;
                    logging.ResponseBodyLogLimit = 4096;
                    logging.CombineLogs = true;
                });

                builder.Services
                       .AddProblemDetails()
                       .AddExceptionHandler<GlobalExceptionHandler>()
                       .AddEndpointsApiExplorer()
                       .AddIdentityUser()
                       .AddSwaggerGen()
                       .AddApplicationServices(builder.Configuration)
                       .AddInfrastructureService()
                       .AddDatabaseContext(builder.Configuration);
                // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
                builder.Services.AddOpenApi();

                builder.Services.AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:SecretKey"]!)),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ClockSkew = TimeSpan.Zero
                    };
                    options.TokenValidationParameters.RoleClaimType = ClaimTypes.Role;

                });

                builder.Services.AddAuthorization(opt =>
                {
                    opt.AddPolicy(My360AuthorizationPolicy.SuperAdmin, policy => policy.RequireRole("SuperAdmin"));
                    opt.AddPolicy(My360AuthorizationPolicy.Company, policy => policy.RequireRole("Company"));
                    opt.AddPolicy(My360AuthorizationPolicy.Staff, policy => policy.RequireRole("Staff"));
                    opt.AddPolicy(My360AuthorizationPolicy.All, policy => policy.RequireRole("SuperAdmin", "Company", "Staff"));

                });
                var app = builder.Build();

                // Configure the HTTP request pipeline.
                if (app.Environment.IsDevelopment())
                {

                }
                app.UseCors("CorsPolicy");
                app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseODataRouteDebug();
                app.UseODataBatching();
                app.UseSerilogRequestLogging();
                app.UseHttpsRedirection();
                app.UseStatusCodePages();
                app.UseExceptionHandler();

                app.UseAuthorization();


                app.MapControllers();

                app.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

       
    }
}
