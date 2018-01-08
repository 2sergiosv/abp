using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using Microsoft.AspNetCore.Hosting;
using YkAbp.Core.Authorization.Roles;
using YkAbp.Core.Authorization.Users;
using YkAbp.Core.Configuration;
using YkAbp.Core.I18N;
using YkAbp.Core.Localization;
using YkAbp.Core.MultiTenancy;
using YkAbp.Core.Timing;

namespace YkAbp.Core
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class YkAbpCoreModule : AbpModule
    {
        private readonly IHostingEnvironment _env;

        public YkAbpCoreModule(IHostingEnvironment env)
        {
            _env = env;
        }

        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);
            
            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = YkAbpConsts.MultiTenancyEnabled;

            // Localization
            YkAbpLocalizationConfigurer.Configure(Configuration.Localization, _env.ContentRootPath);

            // i18n
            YkAbpI18NConfigurer.Configure(_env.ContentRootPath);

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(YkAbpCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
