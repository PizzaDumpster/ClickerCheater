namespace ClickerCheater
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblInterval = new Label();
            numInterval = new NumericUpDown();
            lblHotkey = new Label();
            txtHotkey = new TextBox();
            btnStart = new Button();
            btnStop = new Button();
            lblStatus = new Label();
            lblClickCount = new Label();
            clickTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numInterval).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(200, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(258, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Cookie Clicker Cheater";
            // 
            // lblInterval
            // 
            lblInterval.AutoSize = true;
            lblInterval.Font = new Font("Segoe UI", 10F);
            lblInterval.Location = new Point(30, 80);
            lblInterval.Name = "lblInterval";
            lblInterval.Size = new Size(151, 19);
            lblInterval.TabIndex = 1;
            lblInterval.Text = "Click Interval (µs):";
            // 
            // numInterval
            // 
            numInterval.DecimalPlaces = 0;
            numInterval.Location = new Point(200, 78);
            numInterval.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numInterval.Name = "numInterval";
            numInterval.Size = new Size(150, 23);
            numInterval.TabIndex = 2;
            numInterval.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // lblHotkey
            // 
            lblHotkey.AutoSize = true;
            lblHotkey.Font = new Font("Segoe UI", 10F);
            lblHotkey.Location = new Point(30, 130);
            lblHotkey.Name = "lblHotkey";
            lblHotkey.Size = new Size(162, 19);
            lblHotkey.TabIndex = 3;
            lblHotkey.Text = "Hotkey (F6=Start/Stop):";
            // 
            // txtHotkey
            // 
            txtHotkey.Location = new Point(200, 128);
            txtHotkey.Name = "txtHotkey";
            txtHotkey.ReadOnly = true;
            txtHotkey.Size = new Size(150, 23);
            txtHotkey.TabIndex = 4;
            txtHotkey.Text = "F6";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnStart.Location = new Point(100, 180);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(120, 40);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start (F6)";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnStop.Location = new Point(250, 180);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(120, 40);
            btnStop.TabIndex = 6;
            btnStop.Text = "Stop (F6)";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(180, 240);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(106, 20);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status: Idle";
            // 
            // lblClickCount
            // 
            lblClickCount.AutoSize = true;
            lblClickCount.Font = new Font("Segoe UI", 10F);
            lblClickCount.Location = new Point(160, 280);
            lblClickCount.Name = "lblClickCount";
            lblClickCount.Size = new Size(136, 19);
            lblClickCount.TabIndex = 8;
            lblClickCount.Text = "Total Clicks: 0";
            // 
            // clickTimer
            // 
            clickTimer.Tick += clickTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 331);
            Controls.Add(lblClickCount);
            Controls.Add(lblStatus);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(txtHotkey);
            Controls.Add(lblHotkey);
            Controls.Add(numInterval);
            Controls.Add(lblInterval);
            Controls.Add(lblTitle);
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cookie Clicker Cheater";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)numInterval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblInterval;
        private NumericUpDown numInterval;
        private Label lblHotkey;
        private TextBox txtHotkey;
        private Button btnStart;
        private Button btnStop;
        private Label lblStatus;
        private Label lblClickCount;
        private System.Windows.Forms.Timer clickTimer;
    }
}
