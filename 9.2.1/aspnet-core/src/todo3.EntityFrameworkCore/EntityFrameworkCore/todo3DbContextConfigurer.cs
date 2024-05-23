using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace todo3.EntityFrameworkCore
{
    public static class todo3DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<todo3DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<todo3DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
