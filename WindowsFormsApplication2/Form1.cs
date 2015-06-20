using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private int pomodoroLength = 60 * 25;
        private int elapsed;
        private int timeLeft;

        public Form1()
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
                timer1.Enabled = false;
                button1.Text = "Start";
            } else
            {
                resetTime();
                timer1.Enabled = true;
                timer1_Tick(this, EventArgs.Empty);
                button1.Text = "Reset";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft = pomodoroLength - ++elapsed;
            setLabel1();
        }

        private void setLabel1()
        {
            TimeSpan time = TimeSpan.FromSeconds(timeLeft);
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
