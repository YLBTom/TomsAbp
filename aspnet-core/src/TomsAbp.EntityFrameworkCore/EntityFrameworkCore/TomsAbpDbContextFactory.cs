using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TomsAbp.Configuration;
using TomsAbp.Web;

namespace TomsAbp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TomsAbpDbContextFactory : IDesignTimeDbContextFactory<TomsAbpDbContext>
    {
        public TomsAbpDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TomsAbpDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TomsAbpDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TomsAbpConsts.ConnectionStringName));

            return new TomsAbpDbContext(builder.Options);
        }
    }
}
