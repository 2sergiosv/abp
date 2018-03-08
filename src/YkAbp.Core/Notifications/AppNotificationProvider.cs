using Abp.Authorization;
using Abp.Localization;
using Abp.Notifications;
using YkAbp.Core.Authorization;

namespace YkAbp.Core.Notifications
{
    public class AppNotificationProvider : NotificationProvider
    {
        public override void SetNotifications(INotificationDefinitionContext context)
        {
            context.Manager.Add(
                new NotificationDefinition(
                    AppNotificationNames.NewUserRegistered,
                    displayName: L("NewUserRegisteredNotificationDefinition"),
                    permissionDependency: new SimplePermissionDependency(PermissionNames.Administration_Users)
                    )
                );

            context.Manager.Add(
                new NotificationDefinition(
                    AppNotificationNames.NewTenantRegistered,
                    displayName: L("NewTenantRegisteredNotificationDefinition"),
                    permissionDependency: new SimplePermissionDependency(PermissionNames.Tenants)
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, YkAbpConsts.LocalizationSourceName);
        }
    }
}
