using System.Threading.Tasks;
using Abp.Application.Services;
using YkAbp.Application.Authorization.Accounts.Dto;

namespace YkAbp.Application.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
