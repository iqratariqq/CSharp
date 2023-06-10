using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challenge01.Bl;

namespace challenge01
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock s = new Clock(3,4,6);
            int time = s.elapsed_time(s);
            Console.WriteLine("elapsed time is: {0} seconds:", time);
            //object 2 for remaing time
            Clock s1 = new Clock(3, 0, 0);
            int remain = s.remaining_time(s1);
            Console.WriteLine("rmaining time is: {0} seconds:", remain);
            //object 3 for find difference in two clock
            Clock s2 = new Clock(24,50,57);
            Clock s3 = s2.apart(s2);
            Console.WriteLine("hours "+s3.hours + ": minutes " + s3.minutes + ": seconds" + s3.seconds);
            Console.ReadKey();
        }
    }
}
