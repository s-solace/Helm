namespace Helm
{
    partial class BaseDayForm
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
            HWPanel = new TableLayoutPanel();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            p1Text = new TextBox();
            p2Text = new TextBox();
            p3Text = new TextBox();
            p4Text = new TextBox();
            p5Text = new TextBox();
            p6Text = new TextBox();
            HWPanel.SuspendLayout();
            SuspendLayout();
            // 
            // HWPanel
            // 
            HWPanel.ColumnCount = 2;
            HWPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.82114F));
            HWPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.17886F));
            HWPanel.Controls.Add(p6Text, 2, 6);
            HWPanel.Controls.Add(p5Text, 2, 5);
            HWPanel.Controls.Add(p4Text, 2, 4);
            HWPanel.Controls.Add(p3Text, 2, 3);
            HWPanel.Controls.Add(p2Text, 2, 2);
            HWPanel.Controls.Add(label8, 0, 6);
            HWPanel.Controls.Add(label3, 0, 1);
            HWPanel.Controls.Add(label2, 1, 0);
            HWPanel.Controls.Add(label1, 0, 0);
            HWPanel.Controls.Add(label4, 0, 2);
            HWPanel.Controls.Add(label5, 0, 3);
            HWPanel.Controls.Add(label6, 0, 4);
            HWPanel.Controls.Add(label7, 0, 5);
            HWPanel.Controls.Add(p1Text, 1, 1);
            HWPanel.Location = new Point(23, 35);
            HWPanel.Name = "HWPanel";
            HWPanel.RowCount = 7;
            HWPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 35.3535347F));
            HWPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 64.64646F));
            HWPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            HWPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            HWPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            HWPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            HWPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            HWPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            HWPanel.Size = new Size(490, 396);
            HWPanel.TabIndex = 1;
            HWPanel.Paint += tableLayoutPanel1_Paint;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(27, 360);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 7;
            label8.Text = "6";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(27, 59);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 2;
            label3.Text = "1";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(265, 10);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "HW";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Period";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(27, 121);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 3;
            label4.Text = "2";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(27, 182);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 4;
            label5.Text = "3";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(27, 241);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 5;
            label6.Text = "4";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(27, 301);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 6;
            label7.Text = "5";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // p1Text
            // 
            p1Text.AcceptsReturn = true;
            p1Text.Dock = DockStyle.Fill;
            p1Text.Location = new Point(70, 38);
            p1Text.Multiline = true;
            p1Text.Name = "p1Text";
            p1Text.Size = new Size(417, 57);
            p1Text.TabIndex = 8;
            // 
            // p2Text
            // 
            p2Text.AcceptsReturn = true;
            p2Text.Dock = DockStyle.Fill;
            p2Text.Location = new Point(70, 101);
            p2Text.Multiline = true;
            p2Text.Name = "p2Text";
            p2Text.Size = new Size(417, 55);
            p2Text.TabIndex = 9;
            // 
            // p3Text
            // 
            p3Text.AcceptsReturn = true;
            p3Text.Dock = DockStyle.Fill;
            p3Text.Location = new Point(70, 162);
            p3Text.Multiline = true;
            p3Text.Name = "p3Text";
            p3Text.Size = new Size(417, 55);
            p3Text.TabIndex = 10;
            // 
            // p4Text
            // 
            p4Text.AcceptsReturn = true;
            p4Text.Dock = DockStyle.Fill;
            p4Text.Location = new Point(70, 223);
            p4Text.Multiline = true;
            p4Text.Name = "p4Text";
            p4Text.Size = new Size(417, 52);
            p4Text.TabIndex = 11;
            // 
            // p5Text
            // 
            p5Text.AcceptsReturn = true;
            p5Text.Dock = DockStyle.Fill;
            p5Text.Location = new Point(70, 281);
            p5Text.Multiline = true;
            p5Text.Name = "p5Text";
            p5Text.Size = new Size(417, 55);
            p5Text.TabIndex = 12;
            // 
            // p6Text
            // 
            p6Text.AcceptsReturn = true;
            p6Text.Dock = DockStyle.Fill;
            p6Text.Location = new Point(70, 342);
            p6Text.Multiline = true;
            p6Text.Name = "p6Text";
            p6Text.Size = new Size(417, 51);
            p6Text.TabIndex = 13;
            // 
            // BaseDayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 450);
            Controls.Add(HWPanel);
            Name = "BaseDayForm";
            Text = "BaseDayForm";
            HWPanel.ResumeLayout(false);
            HWPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel HWPanel;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox p1Text;
        private TextBox p6Text;
        private TextBox p5Text;
        private TextBox p4Text;
        private TextBox p3Text;
        private TextBox p2Text;
    }
}