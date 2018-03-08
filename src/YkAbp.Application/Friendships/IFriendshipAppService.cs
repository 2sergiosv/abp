using System.Threading.Tasks;
using Abp.Application.Services;
using YkAbp.Application.Friendships.Dto;

namespace YkAbp.Application.Friendships
{
    public interface IFriendshipAppService : IApplicationService
    {
        Task<FriendDto> CreateFriendshipRequest(CreateFriendshipRequestInput input);

        Task<FriendDto> CreateFriendshipRequestByUserName(CreateFriendshipRequestByUserNameInput input);

        Task BlockUser(BlockUserInput input);

        Task UnblockUser(UnblockUserInput input);

        Task AcceptFriendshipRequest(AcceptFriendshipRequestInput input);
    }
}
