namespace ClipboardClear
{
    partial class ClipboardClear
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClipboardClear));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.clipboardTimeoutLabel = new System.Windows.Forms.Label();
            this.clipboardTimoutNUD = new System.Windows.Forms.NumericUpDown();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIconMenuStripShowItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconMenuStripExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clipboardTimoutNUD)).BeginInit();
            this.notifyIconMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.clipboardTimeoutLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.clipboardTimoutNUD, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.secondsLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.saveButton, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 111);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // clipboardTimeoutLabel
            // 
            this.clipboardTimeoutLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clipboardTimeoutLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.clipboardTimeoutLabel, 2);
            this.clipboardTimeoutLabel.Location = new System.Drawing.Point(82, 12);
            this.clipboardTimeoutLabel.Name = "clipboardTimeoutLabel";
            this.clipboardTimeoutLabel.Size = new System.Drawing.Size(119, 13);
            this.clipboardTimeoutLabel.TabIndex = 0;
            this.clipboardTimeoutLabel.Text = "Clear the clipboard after";
            // 
            // clipboardTimoutNUD
            // 
            this.clipboardTimoutNUD.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clipboardTimoutNUD.BackColor = System.Drawing.SystemColors.Window;
            this.clipboardTimoutNUD.Location = new System.Drawing.Point(61, 45);
            this.clipboardTimoutNUD.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.clipboardTimoutNUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.clipboardTimoutNUD.Name = "clipboardTimoutNUD";
            this.clipboardTimoutNUD.ReadOnly = true;
            this.clipboardTimoutNUD.Size = new System.Drawing.Size(120, 20);
            this.clipboardTimoutNUD.TabIndex = 1;
            this.clipboardTimoutNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clipboardTimoutNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.clipboardTimoutNUD.ValueChanged += new System.EventHandler(this.clipboardTimoutNUD_ValueChanged);
            // 
            // secondsLabel
            // 
            this.secondsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(187, 49);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(47, 13);
            this.secondsLabel.TabIndex = 2;
            this.secondsLabel.Text = "seconds";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.saveButton, 2);
            this.saveButton.Location = new System.Drawing.Point(104, 81);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Your clipboard has been cleared!";
            this.notifyIcon.BalloonTipTitle = "Clipboard Clear";
            this.notifyIcon.ContextMenuStrip = this.notifyIconMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Clipboard Clear";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // notifyIconMenuStrip
            // 
            this.notifyIconMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notifyIconMenuStripShowItem,
            this.notifyIconMenuStripExitItem});
            this.notifyIconMenuStrip.Name = "notifyIconMenuStrip";
            this.notifyIconMenuStrip.Size = new System.Drawing.Size(104, 48);
            // 
            // notifyIconMenuStripShowItem
            // 
            this.notifyIconMenuStripShowItem.Name = "notifyIconMenuStripShowItem";
            this.notifyIconMenuStripShowItem.Size = new System.Drawing.Size(103, 22);
            this.notifyIconMenuStripShowItem.Text = "Show";
            this.notifyIconMenuStripShowItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // notifyIconMenuStripExitItem
            // 
            this.notifyIconMenuStripExitItem.Name = "notifyIconMenuStripExitItem";
            this.notifyIconMenuStripExitItem.Size = new System.Drawing.Size(103, 22);
            this.notifyIconMenuStripExitItem.Text = "Exit";
            this.notifyIconMenuStripExitItem.Click += new System.EventHandler(this.notifyIconMenuStripExitItem_Click);
            // 
            // ClipboardClear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClipboardClear";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Clipboard Clear";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClipboardClear_FormClosing);
            this.Resize += new System.EventHandler(this.ClipboardClear_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clipboardTimoutNUD)).EndInit();
            this.notifyIconMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label clipboardTimeoutLabel;
        private System.Windows.Forms.NumericUpDown clipboardTimoutNUD;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIconMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem notifyIconMenuStripShowItem;
        private System.Windows.Forms.ToolStripMenuItem notifyIconMenuStripExitItem;
    }
}

