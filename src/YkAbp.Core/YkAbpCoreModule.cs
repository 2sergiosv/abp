using System;
using Abp.Dependency;
using Abp.Modules;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using Abp.Configuration.Startup;
using Castle.MicroKernel.Registration;
using Microsoft.AspNetCore.Hosting;
using YkAbp.Core.Authorization.Roles;
using YkAbp.Core.Authorization.Users;
using YkAbp.Core.Chat;
using YkAbp.Core.Configuration;
using YkAbp.Core.Debugging;
using YkAbp.Core.Emailing;
using YkAbp.Core.Features;
using YkAbp.Core.Friendships;
using YkAbp.Core.Friendships.Cache;
using YkAbp.Core.I18N;
using YkAbp.Core.Localization;
using YkAbp.Core.MultiTenancy;
using YkAbp.Core.MultiTenancy.Payments.Cache;
using YkAbp.Core.Notifications;
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
            // Eable entity history storing
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;
            Configuration.EntityHistory.IsEnabled = true;

            // Allow anonymous uesrs
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);
            
            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = YkAbpConsts.MultiTenancyEnabled;

            //Adding feature providers
            Configuration.Features.Providers.Add<AppFeatureProvider>();

            //Adding setting providers
            Configuration.Settings.Providers.Add<AppSettingProvider>();

            //Adding notification providers
            Configuration.Notifications.Providers.Add<AppNotificationProvider>();

            // Localization
            YkAbpLocalizationConfigurer.Configure(Configuration.Localization, _env.ContentRootPath);

            // i18n
            YkAbpI18NConfigurer.Configure(_env.ContentRootPath);

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            if (DebugHelper.IsDebug)
            {
                //Disabling email sending in debug mode
                Configuration.ReplaceService<IEmailSender, NullEmailSender>(DependencyLifeStyle.Transient);
            }

            Configuration.ReplaceService(typeof(IEmailSenderConfiguration), () =>
            {
                Configuration.IocManager.IocContainer.Register(
                    Component.For<IEmailSenderConfiguration, ISmtpEmailSenderConfiguration>()
                        .ImplementedBy<YkAbpSmtpEmailSenderConfiguration>()
                        .LifestyleTransient()
                );
            });

            Configuration.Caching.Configure(FriendCacheItem.CacheName, cache =>
            {
                cache.DefaultSlidingExpireTime = TimeSpan.FromMinutes(30);
            });

            Configuration.Caching.Configure(PaymentCacheItem.CacheName, cache =>
            {
                cache.DefaultSlidingExpireTime = TimeSpan.FromMinutes(YkAbpConsts.PaymentCacheDurationInMinutes);
            });

        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(YkAbpCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.RegisterIfNot<IChatCommunicator, NullChatCommunicator>();

            IocManager.Resolve<ChatUserStateWatcher>().Initialize();
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
