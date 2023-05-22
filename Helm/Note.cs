using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helm
{
    internal class Note
    {
        private string name;
        private string content;

        Note(string n, string c)
        {
            name = n;
            content = c;
        }

        public void displayNote(NewNoteForm form)
        {
            form.noteNameTextBox.Text = name;
            form.noteText.Text = content;
        }


    }
}
