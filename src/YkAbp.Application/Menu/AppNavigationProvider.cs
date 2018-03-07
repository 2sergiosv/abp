using Abp.Application.Navigation;
using Abp.Localization;
using YkAbp.Core;
using YkAbp.Core.Authorization;

namespace YkAbp.Application.Menu
{
    internal class AppNavigationProvider : NavigationProvider
    {
        public const string MenuName = "AdminPanel";

        public override void SetNavigation(INavigationProviderContext context)
        {
            var menu = context.Manager.Menus[MenuName] = new MenuDefinition(MenuName, new FixedLocalizableString("AdminPanel"));

            menu
                .AddItem(new MenuItemDefinition(
                    YkAbpConsts.Menu.Common.Workbench,
                    L("Workbench"),
                    customData: new
                    {
                        i18n = "Workbench",
                        group = true
                    })
                    .AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Host.Dashboard,
                            L("Home"),
                            url: "/dashboard/host",
                            icon: "icon-home",
                            requiredPermissionName: PermissionNames.Administration_Host_Dashboard,
                            customData: new
                            {
                                i18n = "Home"
                            }
                        )
                    ).AddItem(new MenuItemDefinition(
                            "Shortcuts",
                            L("shortcut"),
                            customData:new
                            {
                                shortcut_root = true,
                                i18n = "shortcut"
                            }
                        )
                    ).AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Host.Tenants,
                            L("Tenants"),
                            url: "/dashboard/tenant",
                            icon: "icon-user-following",
                            requiredPermissionName: PermissionNames.Tenants,
                            customData: new
                            {
                                i18n = "Tenants"
                            }
                        )
                    ).AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Host.Editions,
                            L("Editions"),
                            url: "/dashboard/edition",
                            icon: "icon-layers",
                            requiredPermissionName: PermissionNames.Editions,
                            customData: new
                            {
                                i18n = "Editions"
                            }
                        )
                    ).AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Tenant.Dashboard,
                            L("Dashboard"),
                            url: "/dashboard/tanant-dashboard",
                            icon: "icon-graph",
                            requiredPermissionName: PermissionNames.Tenant_Dashboard,
                            customData: new
                            {
                                i18n = "Dashboard"
                            }
                        )
                    )
                )
            #region admin
                .AddItem(new MenuItemDefinition(
                        YkAbpConsts.Menu.Common.Administration,
                        L("Administration"),
                        customData:new
                        {
                            group = true,
                            i18n = "Administration"
                        }
                    ).AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Common.OrganizationUnits,
                            L("OrganizationUnits"),
                            url: "/admin/organization-unit",
                            icon: "icon-anchor",
                            requiredPermissionName: PermissionNames.Administration_OrganizationUnits,
                            customData: new
                            {
                                i18n = "OrganizationUnits"
                            }
                        )
                    ).AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Common.Roles,
                            L("Roles"),
                            url: "/admin/roles",
                            icon: "icon-credit-card",
                            requiredPermissionName: PermissionNames.Administration_Roles,
                            customData: new
                            {
                                i18n = "Roles"
                            }
                        )
                    ).AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Common.Users,
                            L("Users"),
                            url: "/admin/user",
                            icon: "icon-user",
                            requiredPermissionName: PermissionNames.Administration_Users,
                            customData: new
                            {
                                i18n = "Users",
                                shortcut = true
                            }
                        )
                    ).AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Common.Languages,
                            L("Languages"),
                            url: "/admin/language",
                            icon: "icon-flag",
                            requiredPermissionName: PermissionNames.Administration_Languages,
                            customData: new
                            {
                                i18n = "Languages"
                            }
                        )
                    ).AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Common.AuditLogs,
                            L("AuditLogs"),
                            url: "/admin/audit-log",
                            icon: "icon-book-open",
                            requiredPermissionName: PermissionNames.Administration_AuditLogs,
                            customData: new
                            {
                                i18n = "AuditLogs"
                            }
                        )
                    ).AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Tenant.SubscriptionManagement,
                            L("Subscription"),
                            url: "/admin/subscription",
                            icon: "icon-envelope-letter",
                            requiredPermissionName: PermissionNames.Administration_Tenant_SubscriptionManagement,
                            customData: new
                            {
                                i18n = "Subscription"
                            }
                        )
                    ).AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Common.UiCustomization,
                            L("VisualSettings"),
                            url: "/admin/ui-customization",
                            icon: "icon-grid",
                            requiredPermissionName: PermissionNames.Administration_UiCustomization,
                            customData: new
                            {
                                i18n = "VisualSettings"
                            }
                        )
                    ).AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Host.Settings,
                            L("Settings"),
                            url: "/admin/host-settings",
                            icon: "icon-settings",
                            requiredPermissionName: PermissionNames.Administration_Host_Settings,
                            customData: new
                            {
                                i18n = "Settings"
                            }
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                            YkAbpConsts.Menu.Tenant.Settings,
                            L("Settings"),
                            url: "/admin/tenant-setting",
                            icon: "icon-settings",
                            requiredPermissionName: PermissionNames.Administration_Tenant_Settings,
                            customData: new
                            {
                                i18n = "Settings"
                            }
                        )
                    )
                )
            #endregion
                ;
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, YkAbpConsts.LocalizationSourceName);
        }
    }
}