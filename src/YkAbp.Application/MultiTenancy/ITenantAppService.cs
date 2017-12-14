using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YkAbp.Application.MultiTenancy.Dto;

namespace YkAbp.Application.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
