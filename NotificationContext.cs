using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_Strategies
{
    class NotificationContext
    {
        private Notifier noticationType;

        public NotificationContext()
        {
            this.noticationType = null;
        }

        //Set notification type
        public void setNotificationType(Notifier notificationType)
        {
            this.noticationType = notificationType;
        }

        //Invoke the selected/current nofication type to send notification
        public void sendNotification(string message)
        {
            this.noticationType.Notify(message);
        }
    }
}
