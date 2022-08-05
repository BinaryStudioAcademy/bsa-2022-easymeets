using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMeets.Core.DAL.Context
{
    public class EasyMeetsCoreContext : DbContext
    {
        public DbSet<Sample> Samples { get; private set; }

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
