namespace Helm
{
    partial class NewNoteForm
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
            noteNameTextBox = new TextBox();
            noteNameLabel = new Label();
            noteText = new TextBox();
            saveNoteButton = new Button();
            SuspendLayout();
            // 
            // noteNameTextBox
            // 
            noteNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            noteNameTextBox.Location = new Point(49, 78);
            noteNameTextBox.Name = "noteNameTextBox";
            noteNameTextBox.Size = new Size(185, 23);
            noteNameTextBox.TabIndex = 0;
            // 
            // noteNameLabel
            // 
            noteNameLabel.AutoSize = true;
            noteNameLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            noteNameLabel.Location = new Point(86, 47);
            noteNameLabel.Name = "noteNameLabel";
            noteNameLabel.Size = new Size(113, 28);
            noteNameLabel.TabIndex = 1;
            noteNameLabel.Text = "Note Name";
            // 
            // noteText
            // 
            noteText.BorderStyle = BorderStyle.FixedSingle;
            noteText.Location = new Point(48, 132);
            noteText.Multiline = true;
            noteText.Name = "noteText";
            noteText.Size = new Size(363, 295);
            noteText.TabIndex = 2;
            // 
            // saveNoteButton
            // 
            saveNoteButton.BackColor = SystemColors.ActiveCaption;
            saveNoteButton.Location = new Point(464, 335);
            saveNoteButton.Name = "saveNoteButton";
            saveNoteButton.Size = new Size(277, 51);
            saveNoteButton.TabIndex = 3;
            saveNoteButton.Text = "Save and Exit";
            saveNoteButton.UseVisualStyleBackColor = false;
            saveNoteButton.Click += saveNoteButton_Click;
            // 
            // NewNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveNoteButton);
            Controls.Add(noteText);
            Controls.Add(noteNameLabel);
            Controls.Add(noteNameTextBox);
            Name = "NewNoteForm";
            Text = "NewNoteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox noteNameTextBox;
        private Label noteNameLabel;
        public TextBox noteText;
        private Button saveNoteButton;
    }
}