using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using YkAbp.Web.Core;
using YkAbp.Web.Core.Configuration;

namespace YkAbp.Web.Host.Startup
{
    [DependsOn(
       typeof(YkAbpWebCoreModule))]
    public class YkAbpWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public YkAbpWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(YkAbpWebHostModule).GetAssembly());
        }
    }
}
