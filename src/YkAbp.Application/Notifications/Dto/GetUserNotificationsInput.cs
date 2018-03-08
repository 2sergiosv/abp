using Abp.Notifications;
using YkAbp.Application.Dto;

namespace YkAbp.Application.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}