using System.Collections.Specialized;
using System.Diagnostics;
using System.Windows.Forms;

namespace Helm
{
    public partial class Calendar : Form
    {

        List<System.Windows.Forms.Timer> timers = new List<System.Windows.Forms.Timer>();

        IDictionary<string, int> months = new Dictionary<string, int>()
        {
            {"January", 1}, {"February", 2}, {"March", 3}, {"April", 4}, {"May", 5},
            {"June", 6 }, {"July", 7}, {"August", 8}, {"September", 9}, {"October", 10},
            {"November", 11}, {"December", 12}
        };

        private Button[] days = new Button[31];

        StringDictionary dayDictionary = new StringDictionary();

        private System.Windows.Forms.Timer timer;
        ReminderHandler reminderHandler;

        public Calendar()
        {

            #region JSON Dictionary
            /*string json = JsonConvert.SerializeObject(dayDictionary);
            Properties.Settings.Default.MyStringDictionary = json;
            Properties.Settings.Default.Save();*/
            #endregion

            #region JSON -> string dict
            /*  use this to retrieve JSON to a String Dictionary:
             *  
             *  string json = Properties.Settings.Default.MyStringDictionary;
             *  StringDictionary dayDictionary = JsonConvert.DeserializeObject<StringDictionary>(json);
             */
            #endregion

            InitializeComponent();

            string iconPath = System.IO.Path.Combine(Application.StartupPath, "Images", "notification.ico");

            // mainNotifyIcon.Icon = new Icon(Path.GetFullPath("C:\\Users\\Harry\\source\\repos\\s-solace\\Helm\\Helm\\Helm\\Images\\notification.ico"));
            mainNotifyIcon.Icon = new Icon(iconPath);
            mainNotifyIcon.Text = "";
            mainNotifyIcon.Visible = true;

        }

        private static void Calendar_Load(object sender, EventArgs e)
        {

        }

        private void ResourcesButton_Click(object sender, EventArgs e)
        {
            var resourceFrom = new ResourcesForm();
            resourceFrom.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NotesForm notesForm = new NotesForm();
            notesForm.Show();
        }

        public void startTimer(DateTimePicker reminderTimePicker, DateTimePicker reminderDatePicker, string msg)
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
                reminderHandler = new ReminderHandler(dt, true, msg);
            }
            else
            {
                DateTime dt = new DateTime(yearSub, monthSub, daySub);
                reminderHandler = new ReminderHandler(dt, false, msg);
            }


            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            timers.Add(timer);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (reminderHandler.CheckAndSendNotification())
            {
                // Stop the timer
                System.Windows.Forms.Timer currentTimer = (System.Windows.Forms.Timer)sender;
                currentTimer.Stop();

                // Remove the timer from the list
                timers.Remove(currentTimer);
            }
        }

        public void DisplayNotification(string notif)
        {
            // Display the notification using the NotifyIcon
            mainNotifyIcon.ShowBalloonTip(3000, "Reminder", "This is the reminder for \'" + notif + "\'!", ToolTipIcon.Info);
        }

        private void wednesdayLabel_Click(object sender, EventArgs e)
        {

        }

        #region Calendar Buttons

        private void may1button_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
        }
        #endregion
    }
}