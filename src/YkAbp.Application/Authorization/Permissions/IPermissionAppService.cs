using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YkAbp.Application.Authorization.Permissions.Dto;

namespace YkAbp.Application.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
