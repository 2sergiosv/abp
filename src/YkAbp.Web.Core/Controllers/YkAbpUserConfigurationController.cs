using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YkAbp.Web.Core.Configuration;

namespace YkAbp.Web.Core.Controllers
{
    public class YkAbpUserConfigurationController: YkAbpControllerBase
    {
        private readonly YkAbpUserConfigurationBuilder _abpUserConfigurationBuilder;

        public YkAbpUserConfigurationController(YkAbpUserConfigurationBuilder abpUserConfigurationBuilder)
        {
            _abpUserConfigurationBuilder = abpUserConfigurationBuilder;
        }

        public async Task<JsonResult> GetAll()
        {
            var userConfig = await _abpUserConfigurationBuilder.GetAll();
            return Json(userConfig);
        }
    }
}
