using Abp.Dependency;
using YkAbp.Core.Configuration;
using YkAbp.Core.Url;
using YkAbp.Web.Core.Url;

namespace MyCompanyName.AbpZeroTemplate.Web.Url
{
    public class WebUrlService : WebUrlServiceBase, IWebUrlService, ITransientDependency
    {
        public WebUrlService(
            IAppConfigurationAccessor configurationAccessor) :
            base(configurationAccessor)
        {
        }

        public override string WebSiteRootAddressFormatKey => "App:ClientRootAddress";

        public override string ServerRootAddressFormatKey => "App:ServerRootAddress";
    }
}