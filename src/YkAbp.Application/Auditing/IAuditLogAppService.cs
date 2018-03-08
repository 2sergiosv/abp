using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YkAbp.Application.Auditing.Dto;
using YkAbp.Application.Dto;

namespace YkAbp.Application.Auditing
{
    public interface IAuditLogAppService : IApplicationService
    {
        Task<PagedResultDto<AuditLogListDto>> GetAuditLogs(GetAuditLogsInput input);

        Task<FileDto> GetAuditLogsToExcel(GetAuditLogsInput input);
    }
}