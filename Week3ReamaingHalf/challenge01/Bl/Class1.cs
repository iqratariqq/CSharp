using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge01.Bl
{
    class Clock
    {
        public int hours;
        public int minutes;
        public int seconds;

        public Clock(int H,int M,int S)
        {
            hours = H;
            minutes = M;
            seconds = S;
        }
        public Clock()
        {
            hours = 24;
            minutes = 60;
            seconds = 60;

        }
        public   int elapsed_time(Clock current)
        {
            int time = 0;
            time = ((current.hours * 3600 )+( current.minutes * 60) + current.seconds);
            return time;

        }
        public  int remaining_time(Clock remain)
        {
            int time = 0;
            time = 86400 - ((remain.hours * 3600) + (remain.minutes * 60) + remain.seconds);
            return time;
        }

        public Clock apart(Clock time)
        {
            Clock s = new Clock();
            Clock s1 = new Clock();
            s.hours = s1.hours-time.hours;
            s.minutes =s1.minutes-time.minutes;
            s.seconds =s1.seconds-time.seconds;
            
            return s;
        }
    }
}
