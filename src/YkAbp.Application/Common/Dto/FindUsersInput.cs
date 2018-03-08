using YkAbp.Application.Dto;

namespace YkAbp.Application.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}