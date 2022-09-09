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
                serviceAccount.PrivateKeyId = "5c4f4c464f15e8e4ec2155870590b7faedb57d90";
                serviceAccount.PrivateKey = "-----BEGIN PRIVATE KEY-----\nMIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQCxyqnSp2jl8Guk\nsQ0e9pYdUlXUebAp+hqxuvHpoNogqguaFZQFRwKU5kIU6e+5sQvUnp+2CKrPPK8w\nZnR/3kUdJ1O6fg+u2LCsv9LlmKaRNL3PxCAgOhTMODdUeFAYIbTQ9uqQ2U9szIYs\nURbjGBKYYAdCSuoxPtCydMn0jaoUkDp1562uvwC0d7gWO70IoKJTLoBxqv7Rlpkl\nzVwCL2feZyM7odrDmUHZHfmqdUFu0cQ65J+kC5DHZ85Bpz9eNQ6gAPKfNkYqxy7+\njnY9njgRXkp6ryUL6NCtSZzoq4RlOj/WrFqsVLgkFNopGNVK0wlJn+1eIQuUBDMx\ntmbWe7chAgMBAAECggEABo7UhVK9Im7eRTmzutVJdSCxtrFKYzH+Z7Y8CBq3bh2O\n3aII2oRAp9pI+vxSw0VTuku61aq3RGQAATBk0mr6tjJO47BmI9/nkMTEaJq4ZQ3Z\n+WphMylLeLse1eVvpuFPZxtEeybBmVTFOjP5sSS3tzzFuTos6Fp4tX3gaptQMkVf\nfymkjJpQb+cp65bcjYK60bYnkCZC+jR0RH5cUr5JKGHn+B2nJCo5JcvxIF6Z8Avz\n0H2BEC3GrS7vNCrVGB2krzDe7XbHglCQOj5zFXRJUlKLMUSeJqvSyrWFj6s+DIpb\nfa4mPhf+xhjC21/l4dXq4cCMp44gSjPrrUoOvL2zdQKBgQDnqCKH7WOc0NFZlBuP\n63EsDoSE2GYStt3+lmOWlzClY6xHxeYAIb4CLzbNK3i1rdpgd+J7ewpjavWsNkkh\nMbCqlk4AoA4CL1lSekNP7EBOwLpTtZgoh3tsUiBGycHO13Hriws3W5FpoX+ooDtM\nO0wSUrT+JFFwpJfTcb0FIs+ZFwKBgQDEeXzH0w6M42TJj7Q9K+UYM3tlYV9RC6gj\nnsd7zlyRscWrhe2vym0FdG7cGB5aeGXNBLqtRHqN8liKhNdgB71d/YAK8bNQ1ZOU\n4YyPvM6YEDgX1K1g49Y0J0t3K59eN/NSUV3tnhB5Wf7Al4FuurF4aO++Wyn5WCpf\nS2B/PZNkhwKBgQC5bBofpMLL3VUEl4ksPG88rW4jCzdAmYC9a9DQ07mLWGmolV3R\nEzEMfJAnzzjyavLVrn/pCIY7J3z3WAhW+ngHQwGyfGpaE14yp0xDp72di6RYpozh\nO/htrprJLmrjzg0QVR4oNDIDU9JjvcVY8kmkjPD0T0uklwozo+GBP+jdBwKBgQCD\n73T8lt05fOXMeKS3Q0e3ZbLiVG32dZZ2PQSGPgBpkfBEi04ecxecxyA+yi9v31O1\nRgy5l7eYpHoSorwib3AZssaOEtqwWIufOYrzZv1wncudLSM0YisQoKaLow6E7ZuG\n1r71duRnKSjqWZMAMXxFeGot8PgRycPCdFKbf1T/9wKBgAYDMrq6MwuGwtw5hJ5m\nsJcXE0xu+gahHdT1wHPgdUgg3DqFDEa4yWXxk0+x1vHqQm8j7wEnin2ohox2z7gg\n7dwgxHyLTxmrZ+xYxRpRl5fC/spuVZfVOh0q/LaZpeb5+ZcPgM9e0Ug9D7LkzaMH\nHlfGrqyZe0x5DMhYe+tj4q+A\n-----END PRIVATE KEY-----".Replace(@"\n", "\n");
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
