using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ClipboardClear
{
    public partial class ClipboardClear : Form
    {
        // Courtesy of https://www.fluxbytes.com/csharp/how-to-monitor-for-clipboard-changes-using-addclipboardformatlistener/
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AddClipboardFormatListener(IntPtr hwnd);

        // Courtesy of https://www.fluxbytes.com/csharp/how-to-monitor-for-clipboard-changes-using-addclipboardformatlistener/
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool RemoveClipboardFormatListener(IntPtr hwnd);

        // Courtesy of https://docs.microsoft.com/en-us/windows/desktop/dataxchg/wm-clipboardupdate
        private const int WM_CLIPBOARDUPDATE = 0x031D;

        private System.Timers.Timer clearClipboardTimer;
        private delegate void TimerElapsedDelegate();
        TimerElapsedDelegate timerElapsedDelegate;


        public ClipboardClear()
        {
            InitializeComponent();

            // Set the state of the save button
            validateSaveButton();

            // Hide the window in the system tray to start
            hideWindow();

            // Add in the clipboard listener
            AddClipboardFormatListener(this.Handle);

            // Prepare the timer
            clearClipboardTimer = new System.Timers.Timer();
            clearClipboardTimer.Interval = Properties.Settings.Default.TimeToClearClipboard * 1000;
            clearClipboardTimer.AutoReset = false;
            clearClipboardTimer.Elapsed += new System.Timers.ElapsedEventHandler(clearClipboardTimerElapsed);

            // Setup the delegate
            timerElapsedDelegate = new TimerElapsedDelegate(clearClipboard);
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
            clearClipboardTimer.Interval = Properties.Settings.Default.TimeToClearClipboard * 1000;
            validateSaveButton();
        }

        private void startClearClipboardTimer()
        {
            clearClipboardTimer.Stop();
            clearClipboardTimer.Start();
        }

        private void clearClipboardTimerElapsed(object sender, EventArgs e)
        {
            BeginInvoke(timerElapsedDelegate);
        }

        private void clearClipboard()
        {
            Clipboard.Clear();
            notifyIcon.ShowBalloonTip(3000);
        }

        // Outline courtesy of https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.wndproc?redirectedfrom=MSDN&view=netframework-4.7.2#System_Windows_Forms_Control_WndProc_System_Windows_Forms_Message__
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                // Sent when the contents of the clipboard have changed. (https://docs.microsoft.com/en-us/windows/desktop/dataxchg/wm-clipboardupdate)
                case WM_CLIPBOARDUPDATE:
                    if (Clipboard.GetDataObject() != null && Clipboard.GetDataObject().GetFormats().Length > 0)
                    {
                        startClearClipboardTimer();
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void ClipboardClear_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Get rid of the clipboard listener on exit
            RemoveClipboardFormatListener(Handle);
        }
    }
}
