using Abp.Application.Services;
using YkAbp.Application.Dto;
using YkAbp.Application.Logging.Dto;

namespace YkAbp.Application.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
