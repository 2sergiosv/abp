using System.Threading.Tasks;
using Abp.Application.Services;
using YkAbp.Application.Configuration.Host.Dto;

namespace YkAbp.Application.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
