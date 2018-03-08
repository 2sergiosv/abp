using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YkAbp.Application.Authorization.Users.Dto;

namespace YkAbp.Application.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
