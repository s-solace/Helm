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
    public partial class BaseDayForm : Form
    {

        Reminders remindersForm;

        public BaseDayForm()
        {
            InitializeComponent();
            remindersForm = new Reminders();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createReminderButton_Click(object sender, EventArgs e)
        {
            remindersForm.Show();
        }
    }
}
