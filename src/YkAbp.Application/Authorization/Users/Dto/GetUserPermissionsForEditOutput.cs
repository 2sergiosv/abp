using System.Collections.Generic;
using YkAbp.Application.Authorization.Permissions.Dto;

namespace YkAbp.Application.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}