using System.Threading.Tasks;
using Abp.Configuration;

namespace YkAbp.Core.Timing
{
    public interface ITimeZoneService
    {
        Task<string> GetDefaultTimezoneAsync(SettingScopes scope, int? tenantId);
    }
}
