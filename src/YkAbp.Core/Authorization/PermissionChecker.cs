using Abp.Authorization;
using YkAbp.Core.Authorization.Roles;
using YkAbp.Core.Authorization.Users;

namespace YkAbp.Core.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
