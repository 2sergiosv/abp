using System.Threading.Tasks;
using YkAbp.Configuration.Dto;

namespace YkAbp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
