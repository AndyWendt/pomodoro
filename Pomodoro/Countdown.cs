using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomodoro
{
    class Countdown
    {
        public int sessionTime { get; set; }
        public int elapsed { get; set; }

        public void incrementElapsed()
        {
            if (finished())
            {
                elapsed = sessionTime;
            }
            else
            {
                ++elapsed;
            }
        }

        public int timeLeft()
        {
            return sessionTime - elapsed;
        }

        public bool finished()
        {
            return timeLeft() <= 0;
        }
    }
}
