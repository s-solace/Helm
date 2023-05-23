using Newtonsoft.Json;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Windows.Forms;

namespace Helm
{
    public partial class Calendar : Form
    {

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
            string json = JsonConvert.SerializeObject(dayDictionary);
            Properties.Settings.Default.MyStringDictionary = json;
            Properties.Settings.Default.Save();
            #endregion

            /*  use this to retrieve JSON to a String Dictionary:
             *  
             *  string json = Properties.Settings.Default.MyStringDictionary;
             *  StringDictionary dayDictionary = JsonConvert.DeserializeObject<StringDictionary>(json);
             */

            InitializeComponent();

            mainNotifyIcon.Icon = new System.Drawing.Icon(Path.GetFullPath("C:\\Users\\Akarsh\\source\\repos\\Helm\\Helm\\Images\\notification.ico"));
            mainNotifyIcon.Text = "";
            mainNotifyIcon.Visible = true;

        }

        private static void Calendar_Load(object sender, EventArgs e)
        {

        }

        private void may1button_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();

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

        public void startTimer(DateTimePicker reminderTimePicker, DateTimePicker reminderDatePicker)
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
                reminderHandler = new ReminderHandler(dt, true);
            }
            else
            {
                DateTime dt = new DateTime(yearSub, monthSub, daySub);
                reminderHandler = new ReminderHandler(dt, false);
            }


            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            reminderHandler.CheckAndSendNotification();
        }

        public void DisplayNotification()
        {
            // Display the notification using the NotifyIcon
            mainNotifyIcon.ShowBalloonTip(3000, "Reminder", "This is the reminder for the thing you set!", ToolTipIcon.Info);
        }

    }
}