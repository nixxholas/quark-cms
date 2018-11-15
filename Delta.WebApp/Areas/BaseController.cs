using Delta.Core.Notifications;
using Delta.Querying;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Delta.WebApp.Areas
{
    public class BaseController : Controller
    {
        private readonly DomainNotificationHandler _notifications;

        public BaseController(INotificationHandler<DomainNotification> notifications)
        {
            _notifications = (DomainNotificationHandler)notifications;
        }

        public bool IsValidOperation()
        {
            return (!_notifications.HasNotifications());
        }
    }
}