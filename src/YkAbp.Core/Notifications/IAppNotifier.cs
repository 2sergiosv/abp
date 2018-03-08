using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using YkAbp.Core.Authorization.Users;
using YkAbp.Core.MultiTenancy;

namespace YkAbp.Core.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}
