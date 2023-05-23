using Microsoft.Toolkit.Uwp.Notifications;

namespace Helm
{
    internal class ReminderHandler
    {

        private DateTime dt;
        bool hasTime;

        Calendar mainForm = FormHelper.GetOpenForm<Calendar>();

        public ReminderHandler(DateTime d, bool b)
        {
            hasTime = b;
            dt = d;
        }

        public void CheckAndSendNotification()
        {
            DateTime currentDateTime = DateTime.Now;

            if (dt == currentDateTime)
            {
                mainForm.DisplayNotification();
            }
        }


    }
}
