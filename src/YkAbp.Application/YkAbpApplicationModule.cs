using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using YkAbp.Application.Menu;
using YkAbp.Core;
using YkAbp.Core.Authorization;

namespace YkAbp.Application
{
    [DependsOn(
        typeof(YkAbpCoreModule)
        )]
    public class YkAbpApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<YkAbpAuthorizationProvider>();

            Configuration.Navigation.Providers.Add<AppNavigationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(YkAbpApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);
        }
    }
}
