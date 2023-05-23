
namespace Helm
{
    public partial class Reminders : Form
    {
        IDictionary<string, int> months = new Dictionary<string, int>()
        {
            {"January", 1}, {"February", 2}, {"March", 3}, {"April", 4}, {"May", 5},
            {"June", 6 }, {"July", 7}, {"August", 8}, {"September", 9}, {"October", 10},
            {"November", 11}, {"December", 12}
        };

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
            string[] bob = reminderDatePicker.Text.Split(' ');
            int monthSub;
            months.TryGetValue(bob[0], out monthSub);
            int daySub = Int32.Parse(bob[1].Substring(0, 2));
            int yearSub = Int32.Parse(bob[2]);
            
            if (reminderTimePicker.Checked)
            {
                int hoursSub = reminderTimePicker.Value.Hour;
                int minuteSub = reminderTimePicker.Value.Minute;
                int secondSub = reminderTimePicker.Value.Second;

                DateTime dt = new DateTime(yearSub, monthSub, daySub, hoursSub, minuteSub, secondSub);
                var rh = new ReminderHandler(dt, true);
            } else
            {
                DateTime dt = new DateTime(yearSub, monthSub, daySub);
                var rh = new ReminderHandler(dt, false);
            }

            

            notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("C:\\Users\\Akarsh\\source\\repos\\Helm\\Helm\\Images\\notification.ico"));
            notifyIcon1.Text = "";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Reminder has been set!";
            notifyIcon1.BalloonTipText = "Your reminder for ____ has been set. You will be reminded 5 minutes before and at the time you have set, if provided.";
            notifyIcon1.ShowBalloonTip(100);

            this.Close();
        }
    }
}
