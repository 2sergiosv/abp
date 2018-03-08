using System.Threading.Tasks;
using Abp.Application.Services;

namespace YkAbp.Application.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task UpgradeTenantToEquivalentEdition(int upgradeEditionId);
    }
}
