using Microsoft.Toolkit.Uwp.Notifications;
using System.Diagnostics;

namespace Helm
{
    internal class ReminderHandler
    {

        private DateTime dt;
        bool hasTime;
        string msg;

        Calendar mainForm = FormHelper.GetOpenForm<Calendar>();

        public ReminderHandler(DateTime d, bool b, string msg)
        {
            hasTime = b;
            dt = d;
            this.msg = msg;
        }

        public void CheckAndSendNotification()
        {
            DateTime currentDateTime = DateTime.Now;

            if (dt >= currentDateTime)
            {
                mainForm.DisplayNotification(msg);
            }
        }


    }
}
