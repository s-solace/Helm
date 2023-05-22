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
    public partial class NewNoteForm : Form
    {
        public NewNoteForm()
        {
            InitializeComponent();
        }

        private void saveNoteButton_Click(object sender, EventArgs e)
        {
            var n = new Note(noteNameTextBox.Text, noteText.Text);
        }
    }
}
