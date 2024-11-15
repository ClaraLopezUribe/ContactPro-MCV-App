using Microsoft.EntityFrameworkCore;

using ContactPro.Data;

namespace ContactPro.Helpers
{
    public static class DataHelper
    {
        public static async Task ManageDataAsync(IServiceProvider svcProvider)
        {
            // Service: Get an instance of db context
            var dbContextSvc = svcProvider.GetRequiredService<ApplicationDbContext>();

            // Migration: This is the programmatic equivalent to Update-Database
            await dbContextSvc.Database.MigrateAsync();
        }
    }
}
