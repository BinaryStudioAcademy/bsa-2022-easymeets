using EasyMeets.Core.BLL.MappingProfiles;
using EasyMeets.Core.BLL.Services;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.WebAPI.Validators;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using AutoMapper;
using EasyMeets.Core.Common.DTO.Zoom;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using RabbitMQ.Client;
using EasyMeets.RabbitMQ.Settings;
using EasyMeets.RabbitMQ.Service;

namespace EasyMeets.Core.WebAPI.Extentions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterCustomServices(this IServiceCollection services, IConfiguration configuration)
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
            services.AddTransient<ITeamSharedService, TeamSharedService>();
            services.AddTransient<IGoogleOAuthService, GoogleOAuthService>();
            services.AddTransient<IZoomService, ZoomService>();
            services.AddHttpClient<IZoomService, ZoomService>();

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

            services.AddRabbitMQInformEveryone(configuration);
        }

        private static void AddRabbitMQInformEveryone(this IServiceCollection services, IConfiguration configuration)
        {
            var producerSettings = new ProducerSettings();
            var consumerSettings = new ConsumerSettings();

            configuration
                .GetSection("RabbitMQConfiguration:Queues:InformProducer")
                .Bind(producerSettings);

            configuration
                .GetSection("RabbitMQConfiguration:Queues:InformConsumer")
                .Bind(consumerSettings);

            var listener = new ConsumerService(consumerSettings);
            listener.ListenQueue();

            services.AddScoped<IInformQueueService>(provider =>
                new InformQueueService(
                    new ProducerService(
                        provider.GetRequiredService<IConnection>(),
                        producerSettings)));
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
    }
}
