using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace YkAbp.EntityFrameworkCore.EntityFrameworkCore
{
    public static class YkAbpDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<YkAbpDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<YkAbpDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
