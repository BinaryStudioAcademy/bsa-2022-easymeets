using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace EasyMeets.Core.DAL.Context;
public class EasyMeetsDbContextFactory : IDesignTimeDbContextFactory<EasyMeetsCoreContext>
{
    public EasyMeetsCoreContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<EasyMeetsCoreContext>();
        optionsBuilder.UseSqlServer("Server=localhost;Database=EasyMeetsCoreDB;Trusted_Connection=True;");
        return new EasyMeetsCoreContext(optionsBuilder.Options);
    }
}
