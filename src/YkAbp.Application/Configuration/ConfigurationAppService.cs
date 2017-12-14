using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using YkAbp.Application.Configuration.Dto;
using YkAbp.Core.Configuration;

namespace YkAbp.Application.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : YkAbpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
