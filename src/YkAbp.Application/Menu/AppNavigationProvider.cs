using Abp.Application.Navigation;
using Abp.Localization;
using YkAbp.Core;
using YkAbp.Core.Authorization;

namespace YkAbp.Application.Menu
{
    internal class AppNavigationProvider: NavigationProvider
    {
        public const string MenuName = "AdminPanel";

        public override void SetNavigation(INavigationProviderContext context)
        {
            var menu = context.Manager.Menus[MenuName] = new MenuDefinition(MenuName, new FixedLocalizableString("AdminPanel"));

            menu
                .AddItem(new MenuItemDefinition(
                        YkAbpConsts.Menu.Host.Dashboard,
                        L("Dashboard"),
                        url: "AppAreaName/HostDashboard",
                        icon: "flaticon-line-graph",
                        requiredPermissionName: PermissionNames.Administration_Host_Dashboard
                    )
                ).AddItem(new MenuItemDefinition(
                        YkAbpConsts.Menu.Host.Tenants,
                        L("Tenants"),
                        url: "AppAreaName/Tenants",
                        icon: "flaticon-list-3",
                        requiredPermissionName: PermissionNames.Tenants
                    )
                ).AddItem(new MenuItemDefinition(
                        YkAbpConsts.Menu.Host.Editions,
                        L("Editions"),
                        url: "AppAreaName/Editions",
                        icon: "flaticon-app",
                        requiredPermissionName: PermissionNames.Editions
                    )
                ).AddItem(new MenuItemDefinition(
                        YkAbpConsts.Menu.Tenant.Dashboard,
                        L("Dashboard"),
                        url: "AppAreaName/Dashboard",
                        icon: "flaticon-line-graph",
                        requiredPermissionName: PermissionNames.Tenant_Dashboard
                    )
                ).AddItem(new MenuItemDefinition(
                        YkAbpConsts.Menu.Common.Administration,
                        L("Administration"),
                        icon: "flaticon-interface-8"
                    ).AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Common.OrganizationUnits,
                            L("OrganizationUnits"),
                            url: "AppAreaName/OrganizationUnits",
                            icon: "flaticon-map",
                            requiredPermissionName: PermissionNames.Administration_OrganizationUnits
                        )
                    ).AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Common.Roles,
                            L("Roles"),
                            url: "AppAreaName/Roles",
                            icon: "flaticon-suitcase",
                            requiredPermissionName: PermissionNames.Administration_Roles
                        )
                    ).AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Common.Users,
                            L("Users"),
                            url: "AppAreaName/Users",
                            icon: "flaticon-users",
                            requiredPermissionName: PermissionNames.Administration_Users
                        )
                    ).AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Common.Languages,
                            L("Languages"),
                            url: "AppAreaName/Languages",
                            icon: "flaticon-tabs",
                            requiredPermissionName: PermissionNames.Administration_Languages
                        )
                    ).AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Common.AuditLogs,
                            L("AuditLogs"),
                            url: "AppAreaName/AuditLogs",
                            icon: "flaticon-folder-1",
                            requiredPermissionName: PermissionNames.Administration_AuditLogs
                        )
                    ).AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Host.Maintenance,
                            L("Maintenance"),
                            url: "AppAreaName/Maintenance",
                            icon: "flaticon-lock",
                            requiredPermissionName: PermissionNames.Administration_Host_Maintenance
                        )
                    ).AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Tenant.SubscriptionManagement,
                            L("Subscription"),
                            url: "AppAreaName/SubscriptionManagement",
                            icon: "flaticon-refresh"
                            ,
                            requiredPermissionName: PermissionNames.Administration_Tenant_SubscriptionManagement
                        )
                    ).AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Common.UiCustomization,
                            L("VisualSettings"),
                            url: "AppAreaName/UiCustomization",
                            icon: "flaticon-medical",
                            requiredPermissionName: PermissionNames.Administration_UiCustomization
                        )
                    ).AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Host.Settings,
                            L("Settings"),
                            url: "AppAreaName/HostSettings",
                            icon: "flaticon-settings",
                            requiredPermissionName: PermissionNames.Administration_Host_Settings
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Tenant.Settings,
                            L("Settings"),
                            url: "AppAreaName/Settings",
                            icon: "flaticon-settings",
                            requiredPermissionName: PermissionNames.Administration_Tenant_Settings
                        )
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, YkAbpConsts.LocalizationSourceName);
        }
    }
}