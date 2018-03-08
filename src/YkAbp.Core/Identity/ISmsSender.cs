using System.Threading.Tasks;

namespace YkAbp.Core.Identity
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}