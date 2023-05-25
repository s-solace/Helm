
namespace Helm
{
    public partial class Reminders : Form
    {

        Calendar openCalendarForm = FormHelper.GetOpenForm<Calendar>();

        public Reminders()
        {
            InitializeComponent();
        }

        private void Reminders_Load(object sender, EventArgs e)
        {
            reminderDatePicker.Format = DateTimePickerFormat.Custom;
            reminderDatePicker.CustomFormat = "MMMM dd, yyyy";

            reminderTimePicker.Format = DateTimePickerFormat.Time;
            reminderTimePicker.ShowCheckBox = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void setReminderButton_Click(object sender, EventArgs e)
        {

            string msg = reminderNameEntry.Text;
            openCalendarForm.startTimer(reminderTimePicker, reminderDatePicker, msg);

            

            notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("C:\\Users\\Harry\\source\\repos\\s-solace\\Helm\\Helm\\Helm\\Images\\notification.ico"));
            notifyIcon1.Text = "";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Reminder has been set!";
            notifyIcon1.BalloonTipText = "Your reminder for \"" + reminderNameEntry.Text +"\" has been set. You will be reminded at the time you have set, if provided, or at 00:00 on the day you chose.";
            notifyIcon1.ShowBalloonTip(100);

            this.Hide();
        }
    }
}
