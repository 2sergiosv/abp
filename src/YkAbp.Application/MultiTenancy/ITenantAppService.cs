using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YkAbp.MultiTenancy.Dto;

namespace YkAbp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
