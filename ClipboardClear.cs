using System;
using System.Windows.Forms;

namespace ClipboardClear
{
    public partial class ClipboardClear : Form
    {
        public ClipboardClear()
        {
            InitializeComponent();
            hideWindow();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            showWindow();
        }

        private void showWindow()
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;
        }

        private void hideWindow()
        {
            notifyIcon.Visible = true;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void ClipboardClear_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                hideWindow();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showWindow();
        }

        private void notifyIconMenuStripExitItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
