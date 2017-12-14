using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using YkAbp.Core.Configuration;

namespace YkAbp.Web.Core.Configuration
{
    public static class HostingEnvironmentExtensions
    {
        public static IConfigurationRoot GetAppConfiguration(this IHostingEnvironment env)
        {
            return AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName, env.IsDevelopment());
        }
    }
}
