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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClipboardClear));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.clipboardTimeoutLabel = new System.Windows.Forms.Label();
            this.clipboardTimoutNUD = new System.Windows.Forms.NumericUpDown();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clipboardTimoutNUD)).BeginInit();
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
            this.clipboardTimeoutLabel.Location = new System.Drawing.Point(82, 11);
            this.clipboardTimeoutLabel.Name = "clipboardTimeoutLabel";
            this.clipboardTimeoutLabel.Size = new System.Drawing.Size(119, 13);
            this.clipboardTimeoutLabel.TabIndex = 0;
            this.clipboardTimeoutLabel.Text = "Clear the clipboard after";
            // 
            // clipboardTimoutNUD
            // 
            this.clipboardTimoutNUD.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clipboardTimoutNUD.Location = new System.Drawing.Point(61, 44);
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
            this.clipboardTimoutNUD.Size = new System.Drawing.Size(120, 20);
            this.clipboardTimoutNUD.TabIndex = 1;
            this.clipboardTimoutNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clipboardTimoutNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // secondsLabel
            // 
            this.secondsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(187, 47);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(47, 13);
            this.secondsLabel.TabIndex = 2;
            this.secondsLabel.Text = "seconds";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.saveButton, 2);
            this.saveButton.Location = new System.Drawing.Point(104, 80);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // ClipboardClear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClipboardClear";
            this.Text = "Clipboard Clear";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clipboardTimoutNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label clipboardTimeoutLabel;
        private System.Windows.Forms.NumericUpDown clipboardTimoutNUD;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Button saveButton;
    }
}

