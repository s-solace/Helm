using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helm
{
    public partial class Reminders : Form
    {
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
    }
}
