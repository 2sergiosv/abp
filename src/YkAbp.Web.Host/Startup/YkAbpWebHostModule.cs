using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using YkAbp.Core.Configuration;
using YkAbp.Web.Core;

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

        public override void PreInitialize()
        {

        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(YkAbpWebHostModule).GetAssembly());
        }
    }
}
