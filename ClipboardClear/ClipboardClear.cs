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
        private System.Timers.Timer retryClearClipboardTimer;
        private delegate void TimerElapsedDelegate();
        TimerElapsedDelegate timerElapsedDelegate;


        public ClipboardClear()
        {
            InitializeComponent();

            // Set the state of the save button
            validateSaveButton();

            // Hide the window in the system tray to start
            this.ShowInTaskbar = false;
            notifyIcon.Visible = true;
            hideWindow();

            // Prepare the main timer
            clearClipboardTimer = new System.Timers.Timer();
            clearClipboardTimer.Interval = Properties.Settings.Default.TimeToClearClipboard * 1000;
            clearClipboardTimer.AutoReset = false;
            clearClipboardTimer.Elapsed += new System.Timers.ElapsedEventHandler(clearClipboardTimerElapsed);

            // Prepare the retry timer
            retryClearClipboardTimer = new System.Timers.Timer();
            retryClearClipboardTimer.AutoReset = false;
            retryClearClipboardTimer.Interval = 5000;
            retryClearClipboardTimer.Elapsed += new System.Timers.ElapsedEventHandler(clearClipboardTimerElapsed);

            // Setup the delegate
            timerElapsedDelegate = new TimerElapsedDelegate(clearClipboard);

            // Add in the clipboard listener
            AddClipboardFormatListener(this.Handle);
        }

        // Displays the window where all the settings may be configured.
        private void showWindow()
        {
            // Only go through the act of "showing" the window if it is hidden
            if (this.WindowState != FormWindowState.Normal)
            {
                clipboardTimoutNUD.Value = Properties.Settings.Default.TimeToClearClipboard;
                showNotificationsCheckbox.Checked = Properties.Settings.Default.ShowNotifications;
                Show();
                this.WindowState = FormWindowState.Normal;
            }

            // Bring the window into focus
            Activate();
        }

        // Hides the configuration window.
        private void hideWindow()
        {
            this.WindowState = FormWindowState.Minimized;
            Hide();
        }

        // Determines whether or not the save button should be enabled and then enables it accordingly.
        private void validateSaveButton()
        {
            saveButton.Enabled = clipboardTimoutNUD.Value != Properties.Settings.Default.TimeToClearClipboard || showNotificationsCheckbox.Checked != Properties.Settings.Default.ShowNotifications;
        }

        // Restarts the timer to clear the clipboard with the currently set timout interval.
        private void startClearClipboardTimer()
        {
            // Stop the timers (in case they are underway)
            retryClearClipboardTimer.Stop();
            clearClipboardTimer.Stop();

            // Update the interval to the latest value
            clearClipboardTimer.Interval = Properties.Settings.Default.TimeToClearClipboard * 1000;

            // Start up the timer
            clearClipboardTimer.Start();
        }

        // Restart the retry timer
        private void startRetryClearClipboardTimer()
        {
            retryClearClipboardTimer.Stop();
            retryClearClipboardTimer.Start();
        }

        // Event handler for the clearClipboardTimer's elapsed event.
        private void clearClipboardTimerElapsed(object sender, EventArgs e)
        {
            BeginInvoke(timerElapsedDelegate);
        }

        // Clears the clipboard and optionally provides a notification.
        private void clearClipboard()
        {
            try
            {
                Clipboard.Clear();
                if (Properties.Settings.Default.ShowNotifications)
                {
                    notifyIcon.ShowBalloonTip(3000);
                }
            }
            catch (ExternalException) {
                // If the clipboard is busy, restart the retry timer to try again later
                startRetryClearClipboardTimer();
            }
        }

        // Outline courtesy of https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.wndproc?redirectedfrom=MSDN&view=netframework-4.7.2#System_Windows_Forms_Control_WndProc_System_Windows_Forms_Message__
        // Used to intercept changes to the clipboard so that we may deal with them accordingly.
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                // Sent when the contents of the clipboard have changed. (https://docs.microsoft.com/en-us/windows/desktop/dataxchg/wm-clipboardupdate)
                case WM_CLIPBOARDUPDATE:
                    // Only care about clipboard updates when there is something on the clipboard (e.g. ignore our own clear clipboard events)
                    if (Clipboard.GetDataObject() != null && Clipboard.GetDataObject().GetFormats().Length > 0)
                    {
                        startClearClipboardTimer();
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void ClipboardClear_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Get rid of the clipboard listener on exit
            RemoveClipboardFormatListener(Handle);
        }

        private void showNotificationsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            validateSaveButton();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            showWindow();
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TimeToClearClipboard = (int)clipboardTimoutNUD.Value;
            Properties.Settings.Default.ShowNotifications = showNotificationsCheckbox.Checked;
            Properties.Settings.Default.Save();
            validateSaveButton();
        }
    }
}
