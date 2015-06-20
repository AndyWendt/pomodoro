using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class Pomodoro : Form
    {
        private int pomodoroLength = 60 * 25;
        private int elapsed;
        private int timeLeft;

        public Pomodoro()
        {
            InitializeComponent();
            resetTime();
            setLabel1Initial();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            button1.Text = "Start";
            
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                setLabel1Initial();
                resetTimer();
            }
            else
            {
                resetTime();
                timer1.Enabled = true;
                timer1_Tick(this, EventArgs.Empty);
                button1.Text = "Reset";
            }
        }

        private void resetTimer()
        {
            timer1.Enabled = false;
            button1.Text = "Start";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft = pomodoroLength - ++elapsed;

            if (timeLeft <= 0)
            {
                setLabel1(TimeSpan.FromSeconds(0));
                timer1.Enabled = false;
            } else
            {
                setLabel1(TimeSpan.FromSeconds(timeLeft));
            }
            
        }

        private void setLabel1(TimeSpan time)
        {
            label1.Text = string.Format("{0}:{1:00}", time.Minutes, time.Seconds);
        }

        private void setLabel1Initial()
        {
            label1.Text = "25:00";
        }

        private void resetTime()
        {
            elapsed = 0;
            timeLeft = pomodoroLength;
        }
    }
}
