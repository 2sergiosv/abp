using Abp.Domain.Services;

namespace YkAbp.Core
{
    public abstract class YkAbpDomainServiceBase : DomainService
    {
        // TODO: Add your common members for all your domain services. 

        protected YkAbpDomainServiceBase()
        {
            LocalizationSourceName = YkAbpConsts.LocalizationSourceName;
        }
    }
}