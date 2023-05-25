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
            cleverLink = new LinkLabel();
            usefulLinksLabel = new Label();
            amadorWebsiteLink = new LinkLabel();
            customLinkPanel = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            linkNameEntry = new TextBox();
            linkURLEntry = new TextBox();
            addLinkButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            customLinkPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(cleverLink, 0, 2);
            tableLayoutPanel1.Controls.Add(usefulLinksLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(amadorWebsiteLink, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.Size = new Size(342, 152);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // cleverLink
            // 
            cleverLink.Anchor = AnchorStyles.None;
            cleverLink.AutoSize = true;
            cleverLink.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cleverLink.Location = new Point(138, 115);
            cleverLink.Name = "cleverLink";
            cleverLink.Size = new Size(66, 28);
            cleverLink.TabIndex = 2;
            cleverLink.TabStop = true;
            cleverLink.Text = "Clever";
            cleverLink.TextAlign = ContentAlignment.MiddleCenter;
            cleverLink.LinkClicked += cleverLink_LinkClicked;
            // 
            // usefulLinksLabel
            // 
            usefulLinksLabel.Anchor = AnchorStyles.None;
            usefulLinksLabel.AutoSize = true;
            usefulLinksLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            usefulLinksLabel.Location = new Point(114, 12);
            usefulLinksLabel.Name = "usefulLinksLabel";
            usefulLinksLabel.Size = new Size(114, 28);
            usefulLinksLabel.TabIndex = 0;
            usefulLinksLabel.Text = "Useful Links";
            // 
            // amadorWebsiteLink
            // 
            amadorWebsiteLink.Anchor = AnchorStyles.None;
            amadorWebsiteLink.AutoSize = true;
            amadorWebsiteLink.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            amadorWebsiteLink.Location = new Point(92, 65);
            amadorWebsiteLink.Name = "amadorWebsiteLink";
            amadorWebsiteLink.Size = new Size(158, 28);
            amadorWebsiteLink.TabIndex = 1;
            amadorWebsiteLink.TabStop = true;
            amadorWebsiteLink.Text = "Amador Website";
            amadorWebsiteLink.TextAlign = ContentAlignment.MiddleCenter;
            amadorWebsiteLink.LinkClicked += amadorWebsiteLink_LinkClicked;
            // 
            // customLinkPanel
            // 
            customLinkPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            customLinkPanel.ColumnCount = 1;
            customLinkPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            customLinkPanel.Controls.Add(label1, 0, 0);
            customLinkPanel.Location = new Point(478, 14);
            customLinkPanel.Name = "customLinkPanel";
            customLinkPanel.RowCount = 1;
            customLinkPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            customLinkPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            customLinkPanel.Size = new Size(218, 447);
            customLinkPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 209);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 0;
            label1.Text = "Your Links";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(126, 212);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 2;
            label2.Text = "Custom Links";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 254);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 3;
            label3.Text = "Link Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 345);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 4;
            label4.Text = "Link URL";
            // 
            // linkNameEntry
            // 
            linkNameEntry.BorderStyle = BorderStyle.FixedSingle;
            linkNameEntry.Location = new Point(31, 285);
            linkNameEntry.Name = "linkNameEntry";
            linkNameEntry.Size = new Size(195, 23);
            linkNameEntry.TabIndex = 5;
            // 
            // linkURLEntry
            // 
            linkURLEntry.BorderStyle = BorderStyle.FixedSingle;
            linkURLEntry.Location = new Point(31, 380);
            linkURLEntry.Name = "linkURLEntry";
            linkURLEntry.Size = new Size(195, 23);
            linkURLEntry.TabIndex = 6;
            // 
            // addLinkButton
            // 
            addLinkButton.BackColor = Color.FromArgb(192, 255, 192);
            addLinkButton.Location = new Point(104, 426);
            addLinkButton.Name = "addLinkButton";
            addLinkButton.Size = new Size(165, 35);
            addLinkButton.TabIndex = 7;
            addLinkButton.Text = "Add Link";
            addLinkButton.UseVisualStyleBackColor = false;
            addLinkButton.Click += addLinkButton_Click;
            // 
            // ResourcesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 478);
            Controls.Add(addLinkButton);
            Controls.Add(linkURLEntry);
            Controls.Add(linkNameEntry);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(customLinkPanel);
            Controls.Add(tableLayoutPanel1);
            Name = "ResourcesForm";
            Text = "ResourcesForm";
            Load += ResourcesForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            customLinkPanel.ResumeLayout(false);
            customLinkPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private LinkLabel cleverLink;
        private Label usefulLinksLabel;
        private LinkLabel amadorWebsiteLink;
        private TableLayoutPanel customLinkPanel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox linkNameEntry;
        private TextBox linkURLEntry;
        private Button addLinkButton;
    }
}