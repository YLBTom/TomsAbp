using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TomsAbp.EntityFrameworkCore
{
    public static class TomsAbpDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TomsAbpDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TomsAbpDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseSqlServer(connection);
        }
    }
}
