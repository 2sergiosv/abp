using System.Collections.Generic;
using YkAbp.Application.Auditing.Dto;
using YkAbp.Application.Dto;

namespace YkAbp.Application.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
