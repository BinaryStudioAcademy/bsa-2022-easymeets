using Bogus;
using Bogus.Extensions;
using EasyMeets.Core.Common.Enums;
using EasyMeets.Core.DAL.Context.EntityConfigurations;
using EasyMeets.Core.DAL.Entities;
using EasyMeets.Core.DAL.Entities.Interface;
using Microsoft.EntityFrameworkCore;

namespace EasyMeets.Core.DAL.Context
{
    public static class ModelBuilderExtensions
    {
        public static int SeedNumber = 123456;
        public static void Configure(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SampleConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AdvancedSlotSettingsConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AvailabilitySlotConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CalendarConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ExternalAttendeeAvailabilityConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ExternalAttendeeConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeetingConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(QuestionsConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TeamConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TeamMemberConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SlotMemberConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfig).Assembly);

            foreach (var type in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(ISoftDeletable).IsAssignableFrom(type.ClrType))
                {
                    modelBuilder.SetSoftDeleteFilter(type.ClrType);
                }
            }
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            var availabilitySlots = GenerateAvailabilitySlots();

            modelBuilder.Entity<User>().HasData(GenerateUsers());
            modelBuilder.Entity<Team>().HasData(GenerateTeams());
            modelBuilder.Entity<TeamMember>().HasData(GenerateTeamMembers());
            modelBuilder.Entity<Meeting>().HasData(GenerateMeetings());
            modelBuilder.Entity<AdvancedSlotSettings>().HasData(GenerateSlotSettingsList());
            modelBuilder.Entity<AvailabilitySlot>().HasData(availabilitySlots);
            modelBuilder.Entity<Question>().HasData(GenerateQuestions(availabilitySlots));
            modelBuilder.Entity<EmailTemplate>().HasData(GenerateEmailTemplates());
            modelBuilder.Entity<Calendar>().HasData(GenerateCalendars());
            modelBuilder.Entity<SlotMember>().HasData(GenerateSlotMembers());
            modelBuilder.Entity<ExternalAttendee>().HasData(GenerateExternalAttendee());
            modelBuilder.Entity<ExternalAttendeeAvailability>().HasData(GenerateExternalAttendeeAvailabilities());
            modelBuilder.Entity<CalendarVisibleForTeam>().HasData(GenerateCalendarVisibleForTeams());
            modelBuilder.Entity<Schedule>().HasData(GenerateSchedules());
            modelBuilder.Entity<ScheduleItem>().HasData(GenerateScheduleItems());
        }

        private static IList<User> GenerateUsers(int count = 10)
        {
            var id = 1;

            return new Faker<User>()
                .UseSeed(SeedNumber)
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.Name, f => f.Person.FullName)
                .RuleFor(u => u.Email, f => f.Person.Email)
                .RuleFor(u => u.PhoneNumber, f => f.Person.Phone.ClampLength(1, 10))
                .RuleFor(u => u.ImagePath, f => f.Internet.Avatar())
                .RuleFor(u => u.Language, f => Language.Pl)
                .RuleFor(u => u.DateFormat, f => (DateFormat)f.Random.Int(0, 1))
                .RuleFor(u => u.TimeFormat, f => (TimeFormat)f.Random.Int(0, 1))
                .RuleFor(u => u.TimeZone, f => 0)
                .RuleFor(u => u.Country, f => Country.Ukraine)
                .RuleFor(u => u.IsBanned, f => false)
                .RuleFor(u => u.IsDeleted, f => false)
                .Generate(count);
        }

        private static IList<Team> GenerateTeams(int count = 10)
        {
            var id = 1;

            return new Faker<Team>()
                .UseSeed(SeedNumber)
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.Name, f => f.Company.CompanyName())
                .RuleFor(u => u.PageLink, f => f.Internet.Url())
                .RuleFor(u => u.TimeZone, 0)
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
                .UseSeed(SeedNumber)
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

            var slotId = 1;

            return new Faker<Meeting>()
                .UseSeed(SeedNumber)
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.AvailabilitySlotId, _ => slotId++)
                .RuleFor(u => u.Name, f => f.Lorem.Word().ClampLength(1, 50))
                .RuleFor(u => u.TeamId, f => f.Random.Int(1, 10))
                .RuleFor(u => u.LocationType, f => f.PickRandom<LocationType>())
                .RuleFor(u => u.CreatedBy, f => f.Random.Int(1, 10))
                .RuleFor(u => u.Duration, f => f.Random.Int(10, 60))
                .RuleFor(u => u.StartTime, f => f.Date.Future())
                .RuleFor(u => u.CreatedAt, f => f.Date.Past(2, new DateTime(2021, 7, 20)))
                .RuleFor(u => u.UpdatedAt, f => DateTime.Today)
                .RuleFor(u => u.IsDeleted, f => false)
                .RuleFor(u => u.MeetingLink, f => f.Internet.Url().ClampLength(1, 30))
                .Generate(count);
        }

        private static IList<AdvancedSlotSettings> GenerateSlotSettingsList(int count = 10)
        {
            var id = 1;
            var settingsId = 1;

            return new Faker<AdvancedSlotSettings>()
                .UseSeed(SeedNumber)
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.AvailabilitySlotId, f => settingsId++)
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

            var authorId = 1;

            return new Faker<AvailabilitySlot>()
                .UseSeed(SeedNumber)
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.TeamId, f => f.Random.Int(1, 10))
                .RuleFor(u => u.CreatedBy, f => authorId++)
                .RuleFor(u => u.LocationType, f => f.PickRandom<LocationType>())
                .RuleFor(u => u.Name, f => f.Lorem.Word().ClampLength(1, 50))
                .RuleFor(u => u.WelcomeMessage, f => f.Lorem.Text().ClampLength(1, 300))
                .RuleFor(u => u.Link, f => f.Internet.Url().ClampLength(1, 30))
                .RuleFor(u => u.Type, f => (SlotType)f.Random.Int(0, 1))
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
                .UseSeed(SeedNumber)
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.AddEventsFromTeamId, f => f.Random.Int(1, 10))
                .RuleFor(u => u.UserId, f => f.Random.Int(1, 10))
                .RuleFor(u => u.CreatedBy, f => f.Random.Int(1, 10))
                .RuleFor(u => u.AccessToken, f => f.Lorem.Text().ClampLength(100, 255))
                .RuleFor(u => u.RefreshToken, f => f.Lorem.Text().ClampLength(100, 255))
                .RuleFor(u => u.ConnectedCalendar, f => f.Person.Email.ClampLength(max: 50))
                .RuleFor(u => u.Uid, f => f.Lorem.Text().ClampLength(max: 50))
                .RuleFor(u => u.CheckForConflicts, f => false)
                .RuleFor(u => u.CreatedAt, f => f.Date.Past(2, new DateTime(2021, 7, 20)))
                .RuleFor(u => u.UpdatedAt, f => DateTime.Today)
                .RuleFor(u => u.IsDeleted, f => false)
                .Generate(count);
        }

        private static IList<Question> GenerateQuestions(ICollection<AvailabilitySlot> availabilitySlots, int minOptionalQuestions = 1, int maxOptionalQuestions = 3)
        {
            var random = new Random(SeedNumber);
            var id = 1;

            return availabilitySlots.SelectMany(s =>
            {
                var mandatoryQuestions = new List<Question>()
                {
                    new() { Id = id++, QuestionText = "Name", AvailabilitySlotId = s.Id, IsMandatory = true, IsDeleted = false },
                    new() { Id = id++, QuestionText = "Email", AvailabilitySlotId = s.Id, IsMandatory = true, IsDeleted = false },
                };

                var questions = new Faker<Question>()
                    .UseSeed(SeedNumber)
                    .RuleFor(u => u.Id, f => id++)
                    .RuleFor(u => u.QuestionText, f => f.Lorem.Text().ClampLength(50, 300))
                    .RuleFor(u => u.AvailabilitySlotId, f => s.Id)
                    .RuleFor(u => u.IsMandatory, f => false)
                    .RuleFor(u => u.IsDeleted, f => false)
                    .Generate(random.Next(minOptionalQuestions, maxOptionalQuestions));
                questions.AddRange(mandatoryQuestions);

                return questions;
            }).ToList();
        }

        private static IList<EmailTemplate> GenerateEmailTemplates(int count = 10)
        {
            var id = 1;

            return new Faker<EmailTemplate>()
                .UseSeed(SeedNumber)
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.AvailabilitySlotId, f => f.Random.Int(1, 10))
                .RuleFor(u => u.Subject, f => f.Lorem.Text().ClampLength(5, 30))
                .RuleFor(u => u.Body, f => f.Lorem.Text().ClampLength(50, 300))
                .RuleFor(u => u.TemplateType, f => (TemplateType)f.Random.Int(0, 3))
                .RuleFor(u => u.IsSend, f => true)
                .RuleFor(u => u.IsDeleted, f => false)
                .Generate(count);
        }

        private static IList<SlotMember> GenerateSlotMembers(int count = 10)
        {
            var id = 1;
            var memberId = 1;
            var availabilitySlotId = 1;
            var scheduleId = 1;

            return new Faker<SlotMember>()
                .UseSeed(SeedNumber)
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.MemberId, f => memberId++)
                .RuleFor(u => u.ScheduleId, _ => scheduleId++)
                .RuleFor(u => u.SlotId, f => availabilitySlotId++)
                .RuleFor(u => u.Priority, f => f.Random.Int(1, 10))
                .RuleFor(u => u.IsDeleted, f => false)
                .Generate(count);
        }

        private static IList<ExternalAttendee> GenerateExternalAttendee(int count = 10)
        {
            var id = 1;

            return new Faker<ExternalAttendee>()
                .UseSeed(SeedNumber)
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.AvailabilitySlotId, f => f.Random.Int(1, 10))
                .RuleFor(u => u.Name, f => f.Person.FullName)
                .RuleFor(u => u.Email, f => f.Person.Email.ClampLength(max: 29))
                .RuleFor(u => u.EventTime, f => f.Date.Future())
                .RuleFor(u => u.IsDeleted, f => false)
                .RuleFor(u => u.TimeZone, f => 0)
                .Generate(count);
        }

        private static IList<ExternalAttendeeAvailability> GenerateExternalAttendeeAvailabilities(int count = 10)
        {
            var id = 1;

            return new Faker<ExternalAttendeeAvailability>()
                .UseSeed(SeedNumber)
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
                .UseSeed(SeedNumber)
                .RuleFor(u => u.Id, f => id++)
                .RuleFor(u => u.CalendarId, f => calendarId++)
                .RuleFor(u => u.TeamId, f => teamId++)
                .RuleFor(u => u.IsDeleted, f => false)
                .Generate(count);
        }

        private static IList<Schedule> GenerateSchedules(int count = 10)
        {
            var id = 1;
            return new Faker<Schedule>()
                .UseSeed(SeedNumber)
                .RuleFor(s => s.Id, _ => id++)
                .RuleFor(s => s.IsDeleted, _ => false)
                .RuleFor(s => s.TimeZone, f => f.Random.Int(-11, 11) * 60)
                .RuleFor(s => s.WithTeamMembers, f => f.Random.Bool())
                .Generate(count);
        }

        private static IList<ScheduleItem> GenerateScheduleItems(int count = 70)
        {
            var id = 1;
            var scheduleId = 0;
            var weekIndex = 0;
            return new Faker<ScheduleItem>()
                .UseSeed(SeedNumber)
                .RuleFor(i => i.Id, _ => id++)
                .RuleFor(i => i.IsDeleted, _ => false)
                .RuleFor(i => i.ScheduleId, _ => (scheduleId++ / 7) + 1)
                .RuleFor(i => i.WeekDay, _ => (WeekDay)(weekIndex++ % 7))
                .RuleFor(i => i.IsEnabled, f => f.Random.Bool())
                .RuleFor(i => i.Start, f => TimeSpan.FromHours(f.Random.Int(8, 12)))
                .RuleFor(i => i.End, f => TimeSpan.FromHours(f.Random.Int(13, 18)))
                .Generate(count);
        }
    }
}