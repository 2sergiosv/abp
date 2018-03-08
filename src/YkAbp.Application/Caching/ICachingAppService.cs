using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YkAbp.Application.Caching.Dto;

namespace YkAbp.Application.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}
