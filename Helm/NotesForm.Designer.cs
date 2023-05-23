namespace Helm
{
    partial class NotesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            notesListBox = new ListBox();
            button1 = new Button();
            openNotesButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(335, 14);
            label1.Name = "label1";
            label1.Size = new Size(131, 37);
            label1.TabIndex = 0;
            label1.Text = "My Notes";
            // 
            // notesListBox
            // 
            notesListBox.FormattingEnabled = true;
            notesListBox.ItemHeight = 15;
            notesListBox.Location = new Point(19, 73);
            notesListBox.Name = "notesListBox";
            notesListBox.ScrollAlwaysVisible = true;
            notesListBox.Size = new Size(183, 334);
            notesListBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(374, 346);
            button1.Name = "button1";
            button1.Size = new Size(238, 78);
            button1.TabIndex = 2;
            button1.Text = "Create Notes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // openNotesButton
            // 
            openNotesButton.Location = new Point(372, 245);
            openNotesButton.Name = "openNotesButton";
            openNotesButton.Size = new Size(237, 71);
            openNotesButton.TabIndex = 3;
            openNotesButton.Text = "Open Selected Notes";
            openNotesButton.UseVisualStyleBackColor = true;
            openNotesButton.Click += openNotesButton_Click;
            // 
            // NotesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(openNotesButton);
            Controls.Add(button1);
            Controls.Add(notesListBox);
            Controls.Add(label1);
            Name = "NotesForm";
            Text = "NotesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        public ListBox notesListBox;
        private Button openNotesButton;
    }
}