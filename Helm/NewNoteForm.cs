using System.Collections;
using System.Diagnostics;


namespace Helm
{
    public partial class NewNoteForm : Form
    {
        

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

            notesForm.notes.Add(n);

            Debug.WriteLine(notesForm.notesListBox.Items);
            
            this.Hide();
        }

        public void displayNotes(int i)
        {
            var n = notesForm.notes[i] as Note;
            noteNameTextBox.Text = n.getName();
            noteText.Text = n.getContent();
        }

    }
}
