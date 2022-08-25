using EasyMeets.Core.BLL.MappingProfiles;
using EasyMeets.Core.BLL.Services;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.WebAPI.Validators;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using EasyMeets.Core.WebAPI.DTO;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EasyMeets.Core.WebAPI.Extentions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterCustomServices(this IServiceCollection services)
        {
            services
                .AddControllers()
                .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddTransient<ISampleService, SampleService>();
            services.AddTransient<IAvailabilityService, AvailabilityService>();
            services.AddTransient<IUploadFileService, UploadFileService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ICalendarsService, CalendarsService>();
            services.AddTransient<IMeetingService, MeetingService>();
            services.AddTransient<ITeamService, TeamService>();
        }

        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetAssembly(typeof(SampleProfile)));
            services.AddAutoMapper(Assembly.GetAssembly(typeof(AvailabilityProfile)));
            services.AddAutoMapper(Assembly.GetAssembly(typeof(MeetingProfile)));
            services.AddAutoMapper(Assembly.GetAssembly(typeof(UserProfile)));
        }

        public static void AddValidation(this IServiceCollection services)
        {
            services
                .AddControllers()
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<NewSampleDtoValidator>());
        }

        public static void AddEasyMeetsCoreContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionsString = configuration.GetConnectionString("EasyMeetsCoreDBConnection");
            services.AddDbContext<EasyMeetsCoreContext>(options =>
                options.UseSqlServer(
                    connectionsString,
                    opt => opt.MigrationsAssembly(typeof(EasyMeetsCoreContext).Assembly.GetName().Name)));
        }

        public static void ConfigureJwt(this IServiceCollection services, IConfiguration configuration)
        {
            var authority = configuration["Jwt:Firebase:ValidIssuer"];
            var audience = configuration["Jwt:Firebase:ValidAudience"];
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Authority = authority;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidIssuer = authority,
                        ValidateAudience = true,
                        ValidAudience = audience,
                        ValidateLifetime = true
                    };
                });
        }

        public static void AddFirebaseAdmin(this IServiceCollection services, IConfiguration configuration)
        {
            var jsonSerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver { NamingStrategy = new SnakeCaseNamingStrategy() }
            };

            var serviceAccount = JsonConvert.DeserializeObject<ServiceAccount>(
                File.ReadAllText("service-account-file.json"),
                jsonSerializerSettings);

            if (serviceAccount is not null)
            {
                serviceAccount.PrivateKey = configuration["Firebase_Service_Account_Private_Key"].Replace(@"\n", "\n");
            }
            
            FirebaseApp.Create(new AppOptions
            {
                Credential = GoogleCredential.FromJson(JsonConvert.SerializeObject(serviceAccount, jsonSerializerSettings)),
            });

            services.AddTransient<FirebaseAuth>(_ => FirebaseAuth.DefaultInstance);
        }
    }
}
