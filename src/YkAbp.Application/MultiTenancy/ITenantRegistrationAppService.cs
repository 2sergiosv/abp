using System.Threading.Tasks;
using Abp.Application.Services;
using YkAbp.Application.Editions.Dto;
using YkAbp.Application.MultiTenancy.Dto;

namespace YkAbp.Application.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}