using System.Threading.Tasks;
using Abp.Application.Services;
using YkAbp.Application.Sessions.Dto;

namespace YkAbp.Application.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
