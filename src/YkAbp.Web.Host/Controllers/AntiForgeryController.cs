using Microsoft.AspNetCore.Antiforgery;
using YkAbp.Controllers;

namespace YkAbp.Web.Host.Controllers
{
    public class AntiForgeryController : YkAbpControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
