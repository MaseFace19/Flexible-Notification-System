using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_Strategies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationContext context = new NotificationContext();
            Console.WriteLine("Please select how you would like to recieve your notifications :");
            Console.WriteLine("1) Email");
            Console.WriteLine("2) SMS");
            Console.WriteLine("3) Push Notifications");
            int answer = 0;
            try
            {
                answer = int.Parse(Console.ReadLine());
            }catch(Exception e)
            {
                Console.WriteLine("Invalid choice (The option you chose is invalid)");
            }


            
            switch (answer)
            {
                case 1:
                    context.setNotificationType(new EmailService());
                    break;

                case 2:
                    context.setNotificationType(new SmsService());
                    break;

                case 3:
                    context.setNotificationType(new PushService());
                    break;
                default:
                    break;
            }

            if (context != null) context.sendNotification("Notification type has been updated");

        }
    }
}
