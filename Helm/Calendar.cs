using Newtonsoft.Json;
using System.Collections.Specialized;

namespace Helm
{
    public partial class Calendar : Form
    {

        private Button[] days = new Button[31];

        StringDictionary dayDictionary = new StringDictionary();


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
        }

        private void Calendar_Load(object sender, EventArgs e)
        {

        }

        private void may1button_Click(object sender, EventArgs e)
        {
            var baseDayForm = new BaseDayForm();
            baseDayForm.Show();
            // plwAW HWLP MW
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}