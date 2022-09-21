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
using AutoMapper;
using EasyMeets.Core.Common.DTO.Zoom;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RabbitMQ.Client;
using EasyMeets.RabbitMQ.Settings;
using EasyMeets.RabbitMQ.Service;
using Newtonsoft.Json.Converters;
using EasyMeets.RabbitMQ.Interface;
using EasyMeets.Core.BLL.Services.Queue;

namespace EasyMeets.Core.WebAPI.Extentions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterCustomServices(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddControllers()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                    options.SerializerSettings.Converters.Add(new StringEnumConverter());
                });
            services.AddTransient<ISampleService, SampleService>();
            services.AddTransient<IAvailabilityService, AvailabilityService>();
            services.AddTransient<IUploadFileService, UploadFileService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ICalendarsService, CalendarsService>();
            services.AddTransient<IMeetingService, MeetingService>();
            services.AddTransient<ITeamService, TeamService>();
            services.AddTransient<ITeamSharedService, TeamSharedService>();
            services.AddTransient<IGoogleOAuthService, GoogleOAuthService>();
            services.AddTransient<IZoomService, ZoomService>();
            services.AddTransient<IExternalAttendeeService, ExternalAttendeeService>();
            services.AddHttpClient<IZoomService, ZoomService>();
            services.AddTransient<ICalendarEventService, CalendarEventService>();
            services.AddTransient<IGoogleMeetService, GoogleMeetService>();
            services.AddTransient<ILinkService, LinkService>();
            services.AddTransient<IInvitationService, InvitationService>();
            services.AddRabbitMQ(configuration);
        }

        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetAssembly(typeof(AvailabilityProfile)));
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
        public static void AddRabbitMQ(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(x =>
            {
                var rabbitConnection = new Uri(configuration.GetSection("RabbitMQConfiguration:Uri").Value);

                var connectionFactory = new ConnectionFactory
                { Uri = rabbitConnection };

                return connectionFactory.CreateConnection();
            });

            services.AddRabbitMqEmailSender(configuration);
            services.AddGoogleNotifyConsumer(configuration);
        }

        private static void AddRabbitMqEmailSender(this IServiceCollection services, IConfiguration configuration)
        {
            var settings = configuration
                .GetSection("RabbitMQConfiguration:Queues:EmailProducer")
                .Get<ProducerSettings>();

            services.AddSingleton<IEmailSenderService>(provider =>
                new EmailSenderService(new ProducerService(
                    provider.GetRequiredService<IConnection>(),
                    settings)));
        }

        private static void AddGoogleNotifyConsumer(this IServiceCollection services, IConfiguration configuration)
        {
            var settings = configuration
                .GetSection("RabbitMQConfiguration:Queues:WebHookConsumer")
                .Get<ConsumerSettings>();

            services.AddHostedService(provider =>
                new WebHookListenerService(
                    new ConsumerService(
                        provider.GetRequiredService<IConnection>(),
                        settings),
                    provider));
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
            var serviceAccount = configuration
                .GetSection("FirebaseServiceAccount")
                .Get<ServiceAccount>();

            if (serviceAccount is not null)
            {
                serviceAccount.PrivateKeyId = configuration["Firebase_Service_Account_Private_Id"];
                serviceAccount.PrivateKey = configuration["Firebase_Service_Account_Private_Key"].Replace(@"\n", "\n");
            }

            var jsonSerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver { NamingStrategy = new SnakeCaseNamingStrategy() }
            };

            FirebaseApp.Create(new AppOptions
            {
                Credential = GoogleCredential.FromJson(JsonConvert.SerializeObject(serviceAccount, jsonSerializerSettings)),
            });

            services.AddTransient<FirebaseAuth>(_ => FirebaseAuth.DefaultInstance);
        }
    }
}
