using System.Threading.Tasks;
using YkAbp.Application.Sessions.Dto;

namespace YkAbp.Web.Core.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
