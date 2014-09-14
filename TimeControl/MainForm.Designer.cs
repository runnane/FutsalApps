namespace TimeControl
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimerText = new System.Windows.Forms.Label();
            this.btnToggleTimer = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblRestTime = new System.Windows.Forms.Label();
            this.chkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimerText
            // 
            this.lblTimerText.AutoSize = true;
            this.lblTimerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerText.Location = new System.Drawing.Point(0, 9);
            this.lblTimerText.Name = "lblTimerText";
            this.lblTimerText.Size = new System.Drawing.Size(470, 108);
            this.lblTimerText.TabIndex = 2;
            this.lblTimerText.Text = "00:00:000";
            // 
            // btnToggleTimer
            // 
            this.btnToggleTimer.Location = new System.Drawing.Point(18, 111);
            this.btnToggleTimer.Name = "btnToggleTimer";
            this.btnToggleTimer.Size = new System.Drawing.Size(75, 23);
            this.btnToggleTimer.TabIndex = 3;
            this.btnToggleTimer.Text = "Start";
            this.btnToggleTimer.UseVisualStyleBackColor = true;
            this.btnToggleTimer.Click += new System.EventHandler(this.btnToggleTimer_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(99, 111);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "9:00 - Initial",
            "14:00 - Endgame",
            "1:00 - Suspension",
            "4:30",
            "7:00",
            "10:00",
            "15:00"});
            this.comboBox1.Location = new System.Drawing.Point(180, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // lblRestTime
            // 
            this.lblRestTime.AutoSize = true;
            this.lblRestTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestTime.Location = new System.Drawing.Point(15, 137);
            this.lblRestTime.Name = "lblRestTime";
            this.lblRestTime.Size = new System.Drawing.Size(143, 20);
            this.lblRestTime.TabIndex = 6;
            this.lblRestTime.Text = "Remaining time: ";
            // 
            // chkAlwaysOnTop
            // 
            this.chkAlwaysOnTop.AutoSize = true;
            this.chkAlwaysOnTop.Location = new System.Drawing.Point(387, 137);
            this.chkAlwaysOnTop.Name = "chkAlwaysOnTop";
            this.chkAlwaysOnTop.Size = new System.Drawing.Size(92, 17);
            this.chkAlwaysOnTop.TabIndex = 7;
            this.chkAlwaysOnTop.Text = "Always on top";
            this.chkAlwaysOnTop.UseVisualStyleBackColor = true;
            this.chkAlwaysOnTop.CheckedChanged += new System.EventHandler(this.chkAlwaysOnTop_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(482, 14);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 166);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chkAlwaysOnTop);
            this.Controls.Add(this.lblRestTime);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnToggleTimer);
            this.Controls.Add(this.lblTimerText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(497, 204);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(497, 204);
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FutsalApps | TimeControl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimerText;
        private System.Windows.Forms.Button btnToggleTimer;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblRestTime;
        private System.Windows.Forms.CheckBox chkAlwaysOnTop;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

