using Bogus;
using Bogus.Extensions;
using EasyMeets.Core.Common.Enums;
using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMeets.Core.DAL.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Configure(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SampleConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AdvancedSlotSettingsConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AvailabilitySlotConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CalendarConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ExternalAttendeeAvailabilityConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ExternalAttendeeConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LocationConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeetingConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(QuestionsConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TeamConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TeamMemberConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TeamMemberMeetingConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfig).Assembly);
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(GenerateUsers());
            modelBuilder.Entity<Location>().HasData(GenerateLocations());
            modelBuilder.Entity<Team>().HasData(GenerateTeams());
            modelBuilder.Entity<TeamMember>().HasData(GenerateTeamMembers());
            modelBuilder.Entity<Meeting>().HasData(GenerateMeetings());
            modelBuilder.Entity<AdvancedSlotSettings>().HasData(GenerateSlotSettingsList());
            modelBuilder.Entity<AvailabilitySlot>().HasData(GenerateAvailabilitySlots());
            modelBuilder.Entity<Question>().HasData(GenerateQuestions());
            modelBuilder.Entity<Calendar>().HasData(GenerateCalendars());
            modelBuilder.Entity<TeamMemberMeeting>().HasData(GenerateTeamMemberMeetings());
            modelBuilder.Entity<ExternalAttendee>().HasData(GenerateExternalAttendee());
            modelBuilder.Entity<ExternalAttendeeAvailability>().HasData(GenerateExternalAttendeeAvailabilities());
            modelBuilder.Entity<CalendarVisibleForTeam>().HasData(GenerateCalendarVisibleForTeams());
            modelBuilder.Entity<UserSlot>().HasData(GenerateUserSlots());
        }

        private static IList<User> GenerateUsers(int count = 10)
        {
            var id = 1;

            return new Faker<User>()
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.Name, f => f.Person.FullName)
                .RuleFor(u => u.Email, f => f.Person.Email)
                .RuleFor(u => u.PhoneNumber, f => f.Person.Phone.ClampLength(1, 10))
                .RuleFor(u => u.ImagePath, f => f.Internet.Avatar())
                .RuleFor(u => u.IsBanned, f => false)
                .RuleFor(u => u.IsDeleted, f => false)
                .Generate(count);
        }
        
        private static IList<Team> GenerateTeams(int count = 10)
        {
            var id = 1;

            return new Faker<Team>()
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.Name, f => f.Company.CompanyName())
                .RuleFor(u => u.PageLink, f => f.Internet.Url())
                .RuleFor(u => u.TimeZone, f => f.Date.TimeZoneString().ClampLength(1, 9))
                .RuleFor(u => u.Description, f => f.Lorem.Text().ClampLength(1, 299))
                .RuleFor(u => u.IsDeleted, f => false)
                .Generate(count);
        }
        
        private static IList<TeamMember> GenerateTeamMembers(int count = 10)
        {
            var id = 1;
            var userId = 1;
            var teamId = 1;
            return new Faker<TeamMember>()
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.UserId, f => userId++)
                .RuleFor(u => u.TeamId, f => teamId++)
                .RuleFor(u => u.Role, f => (Role)f.Random.Int(1, 2))
                .RuleFor(u => u.Status, f => (Status)f.Random.Int(1, 2))
                .RuleFor(u => u.IsDeleted, f => false)
                .Generate(count);
        }
        
        private static IList<Meeting> GenerateMeetings(int count = 10)
        {
            var id = 1;
            
            return new Faker<Meeting>()
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.Name, f => f.Lorem.Word().ClampLength(1, 50))
                .RuleFor(u => u.Description, f => f.Lorem.Text().ClampLength(1, 50))
                .RuleFor(u => u.TeamId, f => f.Random.Int(1, 10))
                .RuleFor(u => u.LocationId, f => f.Random.Int(1, 5))
                .RuleFor(u => u.CreatedBy, f => f.Random.Int(1, 10))
                .RuleFor(u => u.Duration, f => f.Random.Int(10, 60))
                .RuleFor(u => u.StartTime, f => f.Date.Future())
                .RuleFor(u => u.CreatedAt, f => f.Date.Past(2, new DateTime(2021, 7, 20)))
                .RuleFor(u => u.UpdatedAt, f => DateTime.Today)
                .RuleFor(u => u.IsDeleted, f => false)
                .Generate(count);
        }
        
        private static IList<AdvancedSlotSettings> GenerateSlotSettingsList(int count = 10)
        {
            var id = 1;
            var slotId = 1;
            
            return new Faker<AdvancedSlotSettings>()
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.ActivityType, f => (ActivityType)f.Random.Int(1, 3))
                .RuleFor(u => u.Days, f => f.Random.Int(1, 30))
                .RuleFor(u => u.StartDate, f => DateTime.Today.AddDays(1))
                .RuleFor(u => u.MaxNumberOfBookings, f => f.Random.Int(1, 10))
                .RuleFor(u => u.PaddingMeeting, f => f.Random.Int(1, 15))
                .RuleFor(u => u.MinBookingMeetingDifference, f => f.Random.Int(1, 5))
                .RuleFor(u => u.Color, f => (Color)f.Random.Int(1, 8))
                .RuleFor(u => u.IsDeleted, f => false)
                .Generate(count);
        }
        
        private static IList<AvailabilitySlot> GenerateAvailabilitySlots(int count = 10)
        {
            var id = 1;
            var settingsId = 1;
            var authorId = 1;
            
            return new Faker<AvailabilitySlot>()
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.TeamId, f => f.Random.Int(1, 10))
                .RuleFor(u => u.CreatedBy, f => authorId++)
                .RuleFor(u => u.LocationId, f => f.Random.Int(1, 5))
                .RuleFor(u => u.AdvancedSlotSettingsId, f => settingsId++)
                .RuleFor(u => u.Name, f => f.Lorem.Word().ClampLength(1, 50))
                .RuleFor(u => u.WelcomeMessage, f => f.Lorem.Text().ClampLength(1, 300))
                .RuleFor(u => u.Link, f => f.Internet.Url().ClampLength(1, 30))
                .RuleFor(u => u.Type, f => (SlotType)f.Random.Int(1, 2))
                .RuleFor(u => u.Size, f => f.Random.Int(15, 60))
                .RuleFor(u => u.Frequency, f => f.Random.Int(15, 30))
                .RuleFor(u => u.Language, f => "Ukrainian")
                .RuleFor(u => u.BookingsPerDay, f => f.Random.Int(1, 5))
                .RuleFor(u => u.AllowToAddGuests, f => true)
                .RuleFor(u => u.TimeZoneVisibility, f => true)
                .RuleFor(u => u.IsEnabled, f => true)
                .RuleFor(u => u.IsVisible, f => true)
                .RuleFor(u => u.CreatedAt, f => f.Date.Past(2, new DateTime(2021, 7, 20)))
                .RuleFor(u => u.UpdatedAt, f => DateTime.Today)
                .RuleFor(u => u.IsDeleted, f => false)
                .Generate(count);
        }
        
        private static IList<Calendar> GenerateCalendars(int count = 10)
        {
            var id = 1;
            
            return new Faker<Calendar>()
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.AddEventsFromTeamId, f => f.Random.Int(1, 10))
                .RuleFor(u => u.UserId, f => f.Random.Int(1, 10))
                .RuleFor(u => u.CreatedBy, f => f.Random.Int(1, 10))
                .RuleFor(u => u.CheckForConflicts, f => false)
                .RuleFor(u => u.CreatedAt, f => f.Date.Past(2, new DateTime(2021, 7, 20)))
                .RuleFor(u => u.UpdatedAt, f => DateTime.Today)
                .RuleFor(u => u.IsDeleted, f => false)
                .Generate(count);
        }
        
        private static IList<Question> GenerateQuestions(int count = 10)
        {
            var id = 1;
            
            return new Faker<Question>()
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.AvailabilitySlotId, f => f.Random.Int(1, 10))
                .RuleFor(u => u.Text, f => f.Lorem.Text().ClampLength(50, 300))
                .RuleFor(u => u.IsDeleted, f => false)
                .Generate(count);
        }
        
        private static IList<TeamMemberMeeting> GenerateTeamMemberMeetings(int count = 10)
        {
            var id = 1;
            var memberId = 1;
            var eventId = 1;
            
            return new Faker<TeamMemberMeeting>()
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.MemberId, f => memberId++)
                .RuleFor(u => u.EventId, f => eventId++)
                .RuleFor(u => u.Priority, f => f.Random.Int(1, 10))
                .RuleFor(u => u.IsDeleted, f => false)
                .Generate(count);
        }
        
        private static IList<ExternalAttendee> GenerateExternalAttendee(int count = 10)
        {
            var id = 1;
            
            return new Faker<ExternalAttendee>()
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.AvailabilitySlotId, f => f.Random.Int(1, 10))
                .RuleFor(u => u.Name, f => f.Person.FullName)
                .RuleFor(u => u.Email, f => f.Person.Email.ClampLength(30))
                .RuleFor(u => u.EventTime, f => f.Date.Future())
                .RuleFor(u => u.IsDeleted, f => false)
                .Generate(count);
        }
        
        private static IList<ExternalAttendeeAvailability> GenerateExternalAttendeeAvailabilities(int count = 10)
        {
            var id = 1;
            
            return new Faker<ExternalAttendeeAvailability>()
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.ExternalAttendeeId, f => f.Random.Int(1, 10))
                .RuleFor(u => u.StartEvent, f => DateTime.Now.AddDays(1))
                .RuleFor(u => u.EndEvent, f => DateTime.Now.AddDays(2))
                .RuleFor(u => u.IsDeleted, f => false)
                .Generate(count);
        }
        
        private static IList<CalendarVisibleForTeam> GenerateCalendarVisibleForTeams(int count = 10)
        {
            var id = 1;
            var calendarId = 1;
            var teamId = 1;
            
            return new Faker<CalendarVisibleForTeam>()
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.CalendarId, f => calendarId++)
                .RuleFor(u => u.TeamId, f => teamId++)
                .RuleFor(u => u.IsDeleted, f => false)
                .Generate(count);
        }
        
        private static IList<UserSlot> GenerateUserSlots(int count = 10)
        {
            var id = 1;
            var userId = 1;
            var slotId = 1;
            
            return new Faker<UserSlot>()
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.UserId, f => userId++)
                .RuleFor(u => u.AvailabilitySlotId, f => slotId++)
                .RuleFor(u => u.IsDeleted, f => false)
                .Generate(count);
        }

        
        private static IList<Location> GenerateLocations()
        {
            return new List<Location>()
            {
                new()
                {
                    Id = 1,
                    Name = "Zoom",
                    IsDeleted = false
                },
                new()
                {
                    Id = 2,
                    Name = "GoogleMeet",
                    IsDeleted = false
                },
                new()
                {
                    Id = 3,
                    Name = "Discord",
                    IsDeleted = false
                },
                new()
                {
                    Id = 4,
                    Name = "Skype",
                    IsDeleted = false
                },
                new()
                {
                    Id = 5,
                    Name = "Slack",
                    IsDeleted = false
                }
            };
        }
    }
}