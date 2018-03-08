using System.Collections.Generic;
using Abp;

namespace YkAbp.Application.Install.Dto
{
    public class AppSettingsJsonDto
    {
        public string ConnectionString { get; set; }

        public string WebSiteUrl { get; set; }

        public string ServerSiteUrl { get; set; }

        public List<NameValue> Languages { get; set; }
    }
}