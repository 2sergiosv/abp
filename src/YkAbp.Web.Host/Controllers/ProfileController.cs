using Abp.AspNetCore.Mvc.Authorization;
using YkAbp.Core;
using YkAbp.Web.Core.Controllers;

namespace YkAbp.Web.Host.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(IAppFolders appFolders)
            : base(appFolders)
        {
        }
    }
}