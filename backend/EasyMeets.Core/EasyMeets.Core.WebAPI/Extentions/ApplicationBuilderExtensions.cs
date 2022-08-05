using EasyMeets.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace EasyMeets.Core.WebAPI.Extentions
{
    public static class ApplicationBuilderExtensions
    {
        public static void UseCodiCoreContext(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
            using var context = scope?.ServiceProvider.GetRequiredService<EasyMeetsCoreContext>();
            context?.Database.Migrate();
        }
    }
}
