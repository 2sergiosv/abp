using System.Threading.Tasks;
using Abp.Application.Services;
using YkAbp.Application.Install.Dto;

namespace YkAbp.Application.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}