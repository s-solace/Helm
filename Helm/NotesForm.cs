using System;
using System.Collections;
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
    public partial class NotesForm : Form
    {
        public ArrayList notes = new ArrayList();

        NewNoteForm newNoteForm;

        public NotesForm()
        {
            InitializeComponent();
            newNoteForm = new NewNoteForm(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!newNoteForm.IsDisposed) 
            {
                newNoteForm.Show();
            }
            else
            {
                newNoteForm = new NewNoteForm(this);
            }
            
        }

        private void openNotesButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < notesListBox.Items.Count; i++)
            {
                if (notesListBox.GetSelected(i)) 
                {
                    if (!newNoteForm.IsDisposed)
                        newNoteForm.Show();
                    else
                        newNoteForm = new NewNoteForm(this);

                    newNoteForm.displayNotes(i);
                }
            }
        }
    }
}
