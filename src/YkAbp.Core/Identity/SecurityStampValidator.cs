using Abp.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using YkAbp.Core.Authorization.Roles;
using YkAbp.Core.Authorization.Users;
using YkAbp.Core.MultiTenancy;

namespace YkAbp.Core.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options, 
            SignInManager signInManager,
            ISystemClock systemClock) 
            : base(options, signInManager, systemClock)
        {
        }
    }
}