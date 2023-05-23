namespace Helm
{
    partial class Reminders
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            reminderNameEntry = new TextBox();
            reminderDatePicker = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            reminderTimePicker = new DateTimePicker();
            setReminderButton = new Button();
            notifyIcon1 = new NotifyIcon(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 93);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 0;
            label1.Text = "Reminder Name";
            // 
            // reminderNameEntry
            // 
            reminderNameEntry.BorderStyle = BorderStyle.FixedSingle;
            reminderNameEntry.Location = new Point(47, 124);
            reminderNameEntry.Name = "reminderNameEntry";
            reminderNameEntry.Size = new Size(209, 23);
            reminderNameEntry.TabIndex = 1;
            // 
            // reminderDatePicker
            // 
            reminderDatePicker.CustomFormat = "";
            reminderDatePicker.ImeMode = ImeMode.On;
            reminderDatePicker.Location = new Point(47, 225);
            reminderDatePicker.MinDate = new DateTime(2023, 5, 18, 0, 0, 0, 0);
            reminderDatePicker.Name = "reminderDatePicker";
            reminderDatePicker.Size = new Size(188, 23);
            reminderDatePicker.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(91, 201);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 3;
            label2.Text = "Choose Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(91, 270);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 5;
            label3.Text = "Choose Time";
            // 
            // reminderTimePicker
            // 
            reminderTimePicker.CustomFormat = "";
            reminderTimePicker.Format = DateTimePickerFormat.Time;
            reminderTimePicker.ImeMode = ImeMode.On;
            reminderTimePicker.Location = new Point(47, 294);
            reminderTimePicker.MinDate = new DateTime(2023, 5, 18, 0, 0, 0, 0);
            reminderTimePicker.Name = "reminderTimePicker";
            reminderTimePicker.ShowCheckBox = true;
            reminderTimePicker.ShowUpDown = true;
            reminderTimePicker.Size = new Size(188, 23);
            reminderTimePicker.TabIndex = 4;
            reminderTimePicker.Value = new DateTime(2023, 5, 18, 15, 0, 0, 0);
            reminderTimePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // setReminderButton
            // 
            setReminderButton.Location = new Point(476, 291);
            setReminderButton.Name = "setReminderButton";
            setReminderButton.Size = new Size(163, 48);
            setReminderButton.TabIndex = 6;
            setReminderButton.Text = "Set Reminder";
            setReminderButton.UseVisualStyleBackColor = true;
            setReminderButton.Click += setReminderButton_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Reminders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(setReminderButton);
            Controls.Add(label3);
            Controls.Add(reminderTimePicker);
            Controls.Add(label2);
            Controls.Add(reminderDatePicker);
            Controls.Add(reminderNameEntry);
            Controls.Add(label1);
            Name = "Reminders";
            Text = "Reminders";
            Load += Reminders_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox reminderNameEntry;
        private DateTimePicker reminderDatePicker;
        private Label label2;
        private Label label3;
        private DateTimePicker reminderTimePicker;
        private Button setReminderButton;
        private NotifyIcon notifyIcon1;
    }
}