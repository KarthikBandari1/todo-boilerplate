using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using todo3.Configuration;
using todo3.Web;

namespace todo3.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class todo3DbContextFactory : IDesignTimeDbContextFactory<todo3DbContext>
    {
        public todo3DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<todo3DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            todo3DbContextConfigurer.Configure(builder, configuration.GetConnectionString(todo3Consts.ConnectionStringName));

            return new todo3DbContext(builder.Options);
        }
    }
}
