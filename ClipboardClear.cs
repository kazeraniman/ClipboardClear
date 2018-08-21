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
            clipboardTimoutNUD.Value = Properties.Settings.Default.TimeToClearClipboard;
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

        private void clipboardTimoutNUD_ValueChanged(object sender, EventArgs e)
        {
            validateSaveButton();
        }

        private void validateSaveButton()
        {
            saveButton.Enabled = clipboardTimoutNUD.Value != Properties.Settings.Default.TimeToClearClipboard;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TimeToClearClipboard = (int)clipboardTimoutNUD.Value;
            Properties.Settings.Default.Save();
            validateSaveButton();
        }
    }
}
