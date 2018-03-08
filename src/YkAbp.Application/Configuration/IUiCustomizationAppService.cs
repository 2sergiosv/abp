using System.Threading.Tasks;
using Abp.Application.Services;
using YkAbp.Application.Configuration.Dto;

namespace YkAbp.Application.Configuration
{
    public interface IUiCustomizationSettingsAppService : IApplicationService
    {
        Task<UiCustomizationSettingsEditDto> GetUiManagementSettings();

        Task UpdateUiManagementSettings(UiCustomizationSettingsEditDto settings);

        Task UpdateDefaultUiManagementSettings(UiCustomizationSettingsEditDto settings);

        Task UseSystemDefaultSettings();
    }
}
