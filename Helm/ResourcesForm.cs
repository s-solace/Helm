using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helm
{

    delegate void MyDelegate(string url);

    public partial class ResourcesForm : Form
    {
        public ResourcesForm()
        {
            InitializeComponent();
        }

        private void ResourcesForm_Load(object sender, EventArgs e)
        {

        }

        private void amadorWebsiteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl("https://amador.pleasantonusd.net/");
        }

        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else
                {
                    throw;
                }
            }
        }

        

        private void cleverLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl("https://clever.com/");
        }

        private void addLinkButton_Click(object sender, EventArgs e)
        {

            var dt = new MyDelegate(OpenUrl);

            string ln = linkNameEntry.Text;
            string lu = linkURLEntry.Text;

            //get a reference to the previous existent row
            RowStyle temp = customLinkPanel.RowStyles[customLinkPanel.RowCount - 1];
            //increase customLinkPanel rows count by one
            customLinkPanel.RowCount++;
            //add a new RowStyle as a copy of the previous one
            customLinkPanel.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
            //add the control

            var l = new LinkLabel() { Text = ln };
            // l.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(dt(lu));

            customLinkPanel.Controls.Add(l, 0, customLinkPanel.RowCount - 1);
        }
    }
}
