using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helm
{
    public partial class NewNoteForm : Form
    {
        private ArrayList notes = new ArrayList();

        private NotesForm notesForm;

        public NewNoteForm(NotesForm notesForm)
        {
            InitializeComponent();
            this.notesForm = notesForm;
        }

        private void saveNoteButton_Click(object sender, EventArgs e)
        {
            var n = new Note(noteNameTextBox.Text, noteText.Text);
            notesForm.notesListBox.Items.Add(n.getName());

            notes.Add(n);

            Debug.WriteLine(notesForm.notesListBox.Items);
            
            this.Hide();
        }

        public void displayNotes(int i)
        {
            var n = notes[i] as Note;
            noteNameTextBox.Text = n.getName();
            noteText.Text = n.getContent();
        }

    }
}
