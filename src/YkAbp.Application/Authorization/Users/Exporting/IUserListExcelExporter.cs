using System.Collections.Generic;
using YkAbp.Application.Authorization.Users.Dto;
using YkAbp.Application.Dto;

namespace YkAbp.Application.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}