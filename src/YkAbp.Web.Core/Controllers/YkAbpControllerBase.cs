using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;
using YkAbp.Core;

namespace YkAbp.Web.Core.Controllers
{
    public abstract class YkAbpControllerBase: AbpController
    {
        protected YkAbpControllerBase()
        {
            LocalizationSourceName = YkAbpConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
