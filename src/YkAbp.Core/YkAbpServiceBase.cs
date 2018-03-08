using Abp;

namespace YkAbp.Core
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="YkAbpDomainServiceBase"/>.
    /// For application services inherit YkAbpAppServiceBase.
    /// </summary>
    public abstract class YkAbpServiceBase : AbpServiceBase
    {
        protected YkAbpServiceBase()
        {
            LocalizationSourceName = YkAbpConsts.LocalizationSourceName;
        }

        // TODO: Add your common members for all your services. 
    }
}