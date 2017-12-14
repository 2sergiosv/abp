using System.Threading.Tasks;
using YkAbp.Application.Configuration.Dto;

namespace YkAbp.Application.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
