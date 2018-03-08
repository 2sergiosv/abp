using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YkAbp.Application.Common.Dto;
using YkAbp.Application.Editions.Dto;

namespace YkAbp.Application.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}