using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS
{
    internal class ContactPerson
    {
        private String _firstname;
        private String _lastname;
        private String _phonenumber;
        private String _email;
        private NotificationMethod _notificationMethod;

        public void SetNotificationMethod(NotificationMethod notificationMethod)
        {
            _notificationMethod = notificationMethod;
        }

        public void Notify(string message)
        {
            if(_notificationMethod.GetType() == typeof(SMS))
            {
                SMS.Send(_phonenumber,message);
            }
            else
            {
                Email.Send(_email, "Warning", message);
            }
        }
    }
}
