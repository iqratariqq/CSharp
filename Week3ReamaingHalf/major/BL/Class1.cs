using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace major.BL
{
    class Clock
    {
        public int hours;
        public int minutes;
        public int seconds;
        //defult construct
        public Clock()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        // parameter construct
        public Clock(int h)
        {
            hours = h;
        }
        public Clock(int h,int m)
        {
            hours = h;
            minutes = m;
        }
        public Clock(int h,int m,int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        public void increammentSec()
        {
            seconds++;
        }
        public void increammentMin()
        {
            minutes++;
        }
        public void increammentHo()
        {
            hours++;
        }
        public void printTime()
        {
            Console.WriteLine(hours + " " + minutes + " " + seconds);
        }
        public bool isEqual(int h,int m,int s)
        {
            bool isCheck = false;
            if(hours==h&& minutes==m&& seconds==s)
            {
                isCheck = true;
            }
            return isCheck;
        }
        public bool isEqual(Clock temp)
        {
            bool isCheck = false;
            if (hours == temp.hours && minutes == temp.minutes && seconds == temp.seconds)
            {
                isCheck = true;
            }
            return isCheck;
        }

    }

}
