using Abp.Authorization;
using YkAbp.Authorization.Roles;
using YkAbp.Authorization.Users;

namespace YkAbp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
