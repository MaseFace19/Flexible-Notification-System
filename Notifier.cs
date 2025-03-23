using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_Strategies
{
    internal interface Notifier
    {
        void Notify(string message);
    }



    class EmailService : Notifier
    {
        public EmailService() { }

        public void Notify(string message)
        {

            Console.WriteLine(message);
            Console.WriteLine("Notified using Email notification");
        }

    }

    class SmsService : Notifier
    {
        public SmsService() { }

        public void Notify(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Notified using SMS notification");
        }
    }

    class PushService : Notifier {
        public PushService() { } // is there empy {} get n set shandish short cut?

        public void Notify(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Notified using Push notification");
        }
    
    }

    ///Kinda understand from here but kinda lost on the prompt shadish
    


}
