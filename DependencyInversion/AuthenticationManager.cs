using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class AuthenticationManager
    {
        private INotificationSender notificationSender;

        public AuthenticationManager(INotificationSender notificationSender)
        {
            this.notificationSender = notificationSender;
        }

        public void Authenticate(User user, string email, string password)
        {
            if(user.Email == email && user.Password == password)
            {
                //EmailNotification emailNotification = new EmailNotification();
                //emailNotification.SendNotification(user);
                notificationSender.SendNotification(user);
            }
        }
    }
}
