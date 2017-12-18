using Microsoft.Extensions.Configuration;

namespace YkAbp.Core.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
