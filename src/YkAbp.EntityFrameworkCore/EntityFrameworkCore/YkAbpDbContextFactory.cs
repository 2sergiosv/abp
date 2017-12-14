using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using YkAbp.Configuration;
using YkAbp.Web;

namespace YkAbp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class YkAbpDbContextFactory : IDesignTimeDbContextFactory<YkAbpDbContext>
    {
        public YkAbpDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<YkAbpDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            YkAbpDbContextConfigurer.Configure(builder, configuration.GetConnectionString(YkAbpConsts.ConnectionStringName));

            return new YkAbpDbContext(builder.Options);
        }
    }
}
