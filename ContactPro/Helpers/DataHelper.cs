using Microsoft.EntityFrameworkCore;

using ContactPro.Data;

namespace ContactPro.Helpers
{
    public class DataHelper
    {
        public static async Task ManageDataAsync(IServiceProvider svcProvider)
        {
            // Get an instance of the db application contxt
            var dbContextSvc = svcProvider.GetRequiredService<ApplicationDbContext>();

            // Migration: This is equivalent to update-database
            await dbContextSvc.Database.MigrateAsync();
        }
    }
}
