using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://th.bing.com/th/id/OIP.AwSrxYWqKYWcj2FBreUz_AHaEx?w=263&h=180&c=7&r=0&o=7&pid=1.7&rm=3",
                UseShellExecute = true
            });

        }
    }
}
