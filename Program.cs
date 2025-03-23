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


            NotificationContext context = new NotificationContext(new EmailService());
            switch (answer)
            {
                case 1:
                    context = new NotificationContext(new EmailService());
                    break;

                case 2:
                    context = new NotificationContext(new SmsService());
                    break;

                case 3:
                    context = new NotificationContext(new PushService());
                    break;
                default:
                    break;
            }

            if (context != null) context.sendNotification("Notification type has been updated");

        }
    }
}
