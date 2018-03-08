using System.Threading.Tasks;
using Abp.Application.Services;
using YkAbp.Application.Configuration.Tenants.Dto;

namespace YkAbp.Application.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
