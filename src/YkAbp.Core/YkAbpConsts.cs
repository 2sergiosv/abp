﻿namespace YkAbp.Core
{
    public class YkAbpConsts
    {
        public const string LocalizationSourceName = "YkAbp";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public const string DefaultPassPhrase = "gsKxGZ012HLL3MI5";

        public static class Menu
        {
            public static class Common
            {
                public const string Administration = "Administration";
                public const string Roles = "Administration.Roles";
                public const string Users = "Administration.Users";
                public const string AuditLogs = "Administration.AuditLogs";
                public const string OrganizationUnits = "Administration.OrganizationUnits";
                public const string Languages = "Administration.Languages";
                public const string DemoUiComponents = "Administration.DemoUiComponents";
                public const string UiCustomization = "Administration.UiCustomization";
            }

            public static class Host
            {
                public const string Tenants = "Tenants";
                public const string Editions = "Editions";
                public const string Maintenance = "Administration.Maintenance";
                public const string Settings = "Administration.Settings.Host";
                public const string Dashboard = "Dashboard";
            }

            public static class Tenant
            {
                public const string Dashboard = "Dashboard.Tenant";
                public const string Settings = "Administration.Settings.Tenant";
                public const string SubscriptionManagement = "Administration.SubscriptionManagement.Tenant";
            }
        }
    }
}
