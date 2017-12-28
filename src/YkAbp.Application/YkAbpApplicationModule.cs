using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using YkAbp.Application.Menu;
using YkAbp.Core;
using YkAbp.Core.Authorization;

namespace YkAbp.Application
{
    [DependsOn(
        typeof(YkAbpCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class YkAbpApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<YkAbpAuthorizationProvider>();

            Configuration.Navigation.Providers.Add<AppNavigationProvider>();

        }

        public override void Initialize()
        {
            var thisAssembly = typeof(YkAbpApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}
