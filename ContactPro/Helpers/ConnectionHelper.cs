using Npgsql;

namespace ContactPro.Helpers
{
    public class ConnectionHelper
    {
        public static string GetConnectionString(IConfiguration configuration)
        {
            var connetionString = configuration.GetSection("pgSettings")["pgConnection"];

            var databaseUrl = Environment.GetEnvironmentVariable("DATABASE_URL");

            return string.IsNullOrEmpty(databaseUrl) ? connetionString : BuildConnectionString(databaseUrl);
        }

        // Build a connection string from the environment (i.e. Heroku or Railway)
        private static string BuildConnectionString(string databaseUrl)
        {
            var databaseUri = new Uri(databaseUrl);
            var userInfo = databaseUri.UserInfo.Split(':');
            var builder = new NpgsqlConnectionStringBuilder
            {
                Host = databaseUri.Host,
                Port = databaseUri.Port,
                Username = userInfo[0],
                Password = userInfo[1],
                Database = databaseUri.LocalPath.TrimStart('/'),
                SslMode = SslMode.Require,
                TrustServerCertificate = true
            };

            return builder.ToString();

        }
    }
}
