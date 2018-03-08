using System.Collections.Generic;

namespace YkAbp.Application.MultiTenancy.HostDashboard.Dto
{
    public class GetRecentTenantsOutput
    {
        public List<RecentTenant> RecentTenants;

        public GetRecentTenantsOutput(List<RecentTenant> recentTenants)
        {
            RecentTenants = recentTenants;
        }
    }
}