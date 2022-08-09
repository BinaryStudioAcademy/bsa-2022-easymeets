using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMeets.Core.DAL.Context
{
    public class EasyMeetsCoreContext : DbContext
    {
        public DbSet<Sample> Samples { get; private set; }
        public DbSet<AdvancedSlotSettings> AdvancedSlotSettings { get; private set; }
        public DbSet<AvailabilitySlot> AvailabilitySlots { get; private set; }
        public DbSet<Calendar> Calendars { get; private set; }
        public DbSet<CalendarVisibleForTeam> CalendarVisibleForTeams { get; private set; }
        public DbSet<ExternalAttendee> ExternalAttendees { get; private set; }
        public DbSet<ExternalAttendeeAvailability> ExternalAttendeeAvailabilities { get; private set; }
        public DbSet<Location> Locations { get; private set; }
        public DbSet<Meeting> Meetings { get; private set; }
        public DbSet<Question> Questions { get; private set; }
        public DbSet<Team> Teams { get; private set; }
        public DbSet<TeamMember> TeamMembers { get; private set; }
        public DbSet<TeamMemberMeeting> TeamMemberMeetings { get; private set; }
        public DbSet<User> Users { get; private set; }
        public DbSet<UserSlot> UserSlot { get; private set; }

        public EasyMeetsCoreContext(DbContextOptions<EasyMeetsCoreContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Configure();
            modelBuilder.Seed();
        }
    }
}
