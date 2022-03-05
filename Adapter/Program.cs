using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //INotificationSender notificationSender = new EmailSender();
            INotificationSender notificationSender = new SmsSenderAdapter();
            notificationSender.SendNotification(1, new Notification() { Title = "Test", Body = "Body" });
        }
    }

}
