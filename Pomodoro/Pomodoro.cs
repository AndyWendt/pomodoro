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
        private int elapsed = 0;

        public Pomodoro()
        {
            InitializeComponent();

            resetCountdownTime();

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

        private void countdown_timer_Tick(object sender, EventArgs e)
        {
            ++elapsed;

            if (timeLeft() == 0)
            {
                countdown_timer.Enabled = false;
            }

            setCountdownTimeText(TimeSpan.FromSeconds(timeLeft()));
        }



        private void reset_Click(object sender, EventArgs e)
        {
            resetCountdownTime();
        }

        private void resetCountdownTime()
        {
            setElapsed(0);
            setCountdownTimeText(TimeSpan.FromSeconds(pomodoroLength));
        }

        private void resetCountdown()
        {
            countdown_timer.Enabled = false;
            setStartPauseButtonEnabled(false);
            resetButtonEnabled(false);
        }

        private void startCountdown()
        {
            countdown_timer.Enabled = true;
            countdown_timer_Tick(this, EventArgs.Empty);
            setStartPauseButtonEnabled(true);
            resetButtonEnabled(true);
        }

        private void pauseCountdown()
        {
            setStartPauseButtonEnabled(false);
            countdown_timer.Enabled = false;
        }

        private void setCountdownTimeText(TimeSpan time)
        {
            countdown_text.Text = string.Format("{0}:{1:00}", time.Minutes, time.Seconds);
        }

        private void setStartPauseButtonEnabled(Boolean state)
        {
            if (state)
            {
                start_pause.Text = "Pause";
            }
            else
            {
                start_pause.Text = "Start";
            }

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
