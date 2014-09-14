using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeControl
{
    public partial class MainForm : Form
    {
        internal DateTime start;
        internal DateTime realStart;
        internal bool paused;
        internal DateTime pausedAt;

        internal Color ToggleColor = Color.Yellow;
        internal Color defaultColor = Color.LightGray;

        internal TimeSpan roundTime
        {
            get
            {
                switch (comboBox1.SelectedIndex)
                {

                    case 0:
                        return new TimeSpan(0, 9, 00);
                    case 1:
                        return new TimeSpan(0, 14, 00);
                    case 2:
                        return new TimeSpan(0, 1, 00);
                    case 3:
                        return new TimeSpan(0, 4, 30);
                    case 4:
                        return new TimeSpan(0, 7, 00);
                    case 5:
                        return new TimeSpan(0, 15, 00);
                    case 6:
                        return new TimeSpan(0, 10, 00);
                    default:
                        return new TimeSpan(0, 1, 00);


                }

            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnToggleTimer_Click(object sender, EventArgs e)
        {

            if (paused || timer1.Enabled)
            {
                timer1.Enabled = false;

                timer1.Stop();
                btnToggleTimer.Text = "Start";
                btnPause.Enabled = false;
                paused = false;
                btnPause.Text = "Pause";
                if (timer2.Enabled)
                {
                    timer2.Stop();
                    this.BackColor = defaultColor;
                }

            }
            else
            {
                timer1.Enabled = true;
                realStart = start = DateTime.Now;
                timer1.Start();
                btnToggleTimer.Text = "Stopp";
                btnPause.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeSpan tsp = DateTime.Now - start;
            lblTimerText.Text = tsp.Minutes.ToString("D2") + ":" + tsp.Seconds.ToString("D2") + ":" + tsp.Milliseconds.ToString("D3");
            TimeSpan rtsp = (roundTime - tsp);
            lblRestTime.Text = "Resterende tid: " + rtsp.Minutes.ToString("D2") + ":" + rtsp.Seconds.ToString("D2") + ":" + rtsp.Milliseconds.ToString("D3")
                + "   (" + rtsp.Minutes.ToString("D2") + "m " + rtsp.Seconds.ToString("D2") + "s)";
            if (rtsp.TotalSeconds < 0)
            {
                this.ToggleColor = Color.Red;
                if (!timer2.Enabled)
                    timer2.Start();
            }
            else if (rtsp.TotalSeconds < 30)
            {
                this.ToggleColor = Color.Yellow;
                if (!timer2.Enabled)
                    timer2.Start();
            }
            else
            {
                timer2.Stop();
            }
            //double res1 = ((roundTime.TotalSeconds - rtsp.TotalSeconds) / roundTime.TotalSeconds);
            //int res = (int)res1*1000;
            try
            {
                progressBar1.Maximum = (int)roundTime.TotalSeconds;
                progressBar1.Value = (int)(roundTime.TotalSeconds - rtsp.TotalSeconds);
                //progressBar1.Update();
                progressBar1.Refresh();
            }
            catch (Exception)
            {

            }
           // label1.Text = (res1*1000).ToString();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (!paused)
            {
                pausedAt = DateTime.Now;
                timer1.Stop();
                btnPause.Text = "Fortsett";
                paused = true;
                if (timer2.Enabled)
                {
                    timer2.Stop();
                    this.BackColor = defaultColor;
                }


            }else{
                TimeSpan tsp = DateTime.Now - pausedAt;
                start = start.Add(tsp);

                timer1.Start();
                btnPause.Text = "Pause";
                paused = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.BackColor = this.BackColor == this.ToggleColor ? defaultColor : this.ToggleColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer2.Interval = 250;
            comboBox1.SelectedIndex = 0;

        }

        private void chkAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {

            this.TopMost = chkAlwaysOnTop.Checked;
        }


    }
}
