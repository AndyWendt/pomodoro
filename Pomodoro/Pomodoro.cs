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
        private int pomodoroLength = 25 * 60;
        private int elapsed = 0;

        public Pomodoro()
        {
            InitializeComponent();

            countdown_timer.Interval = 1000; // aka 1 second
            countdown_timer.Tick += countdown_timer_Tick;

            start_pause.Click += start_pause_Click;

            reset.Click += reset_Click;
        }

        private void start_pause_Click(object sender, EventArgs e)
        {
            if (countdown_timer.Enabled)
            {
                pauseCountdown();
            }
            else
            {
                startCountdown();
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            resetCountdown();
        }

        private void countdown_timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft() <= 0)
            {
                stopCountdown();
            }

            incrementElapsedTime();

            setCountdownTimeText(TimeSpan.FromSeconds(timeLeft()));
        }

        private void incrementElapsedTime()
        {
            if (timeLeft() <= 0)
            {
                elapsed = pomodoroLength;
            } else
            {
                ++elapsed;
            }
        }

        private void stopCountdown()
        {
            countdown_timer.Enabled = false;
            start_pause.Text = "Start";
            startPauseButtonEnabled(false);
        }

        private void resetCountdown()
        {
            setElapsed(0);
            countdown_timer.Enabled = false;
            start_pause.Text = "Start";
            resetButtonEnabled(false);
            startPauseButtonEnabled(true);
            setCountdownTimeText(TimeSpan.FromSeconds(pomodoroLength));
        }

        private void startCountdown()
        {
            countdown_timer.Enabled = true;
            countdown_timer_Tick(this, EventArgs.Empty);
            start_pause.Text = "Pause";
            resetButtonEnabled(true);
        }

        private void pauseCountdown()
        {
            start_pause.Text = "Start";
            countdown_timer.Enabled = false;
        }

        private void startPauseButtonEnabled(Boolean enabled)
        {
           start_pause.Enabled = enabled;
        }

        private void setCountdownTimeText(TimeSpan time)
        {
            countdown_text.Text = string.Format("{0}:{1:00}", time.Minutes, time.Seconds);
        }

        private void resetButtonEnabled(Boolean enabled)
        {
            reset.Enabled = enabled;
        }

        private int timeLeft()
        {
            return pomodoroLength - elapsed;
        }

        private int getElapsed()
        {
            return elapsed;
        }

        private void setElapsed(int seconds)
        {
            elapsed = seconds;
        }
    }
}
