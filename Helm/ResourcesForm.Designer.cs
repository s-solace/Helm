namespace Helm
{
    partial class ResourcesForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            usefulLinksLabel = new Label();
            amadorWebsiteLink = new LinkLabel();
            cleverLink = new LinkLabel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(cleverLink, 0, 2);
            tableLayoutPanel1.Controls.Add(usefulLinksLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(amadorWebsiteLink, 0, 1);
            tableLayoutPanel1.Location = new Point(22, 33);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.1463432F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.85366F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Size = new Size(342, 406);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // usefulLinksLabel
            // 
            usefulLinksLabel.Anchor = AnchorStyles.None;
            usefulLinksLabel.AutoSize = true;
            usefulLinksLabel.Location = new Point(136, 13);
            usefulLinksLabel.Name = "usefulLinksLabel";
            usefulLinksLabel.Size = new Size(70, 15);
            usefulLinksLabel.TabIndex = 0;
            usefulLinksLabel.Text = "Useful Links";
            // 
            // amadorWebsiteLink
            // 
            amadorWebsiteLink.Anchor = AnchorStyles.None;
            amadorWebsiteLink.AutoSize = true;
            amadorWebsiteLink.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            amadorWebsiteLink.Location = new Point(92, 68);
            amadorWebsiteLink.Name = "amadorWebsiteLink";
            amadorWebsiteLink.Size = new Size(158, 28);
            amadorWebsiteLink.TabIndex = 1;
            amadorWebsiteLink.TabStop = true;
            amadorWebsiteLink.Text = "Amador Website";
            amadorWebsiteLink.TextAlign = ContentAlignment.MiddleCenter;
            amadorWebsiteLink.LinkClicked += amadorWebsiteLink_LinkClicked;
            // 
            // cleverLink
            // 
            cleverLink.Anchor = AnchorStyles.None;
            cleverLink.AutoSize = true;
            cleverLink.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cleverLink.Location = new Point(138, 154);
            cleverLink.Name = "cleverLink";
            cleverLink.Size = new Size(66, 28);
            cleverLink.TabIndex = 2;
            cleverLink.TabStop = true;
            cleverLink.Text = "Clever";
            cleverLink.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ResourcesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 478);
            Controls.Add(tableLayoutPanel1);
            Name = "ResourcesForm";
            Text = "ResourcesForm";
            Load += ResourcesForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private LinkLabel cleverLink;
        private Label usefulLinksLabel;
        private LinkLabel amadorWebsiteLink;
    }
}