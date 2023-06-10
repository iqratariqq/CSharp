using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using major.BL;

namespace major
{
    class Program
    {
        static void Main(string[] args)
        {
            //default constructor
            Clock empty_time = new Clock();
            Console.WriteLine("empty time:");
            empty_time.printTime();

            // parameterized with one parameter
            Clock hours_time = new Clock(8);
            Console.WriteLine("Hours Time:");
            hours_time.printTime();

            // parameterized with two parameter
            Clock minute_time = new Clock(8,7);
            Console.WriteLine("Hours and minutes Time:");
            minute_time.printTime();

            // parameterized with three parameter
            Clock full_time = new Clock(8, 7,10);
            Console.WriteLine("full Time:");
            full_time.printTime();

            //increament second
            full_time.increammentSec();
            Console.WriteLine("Full time(increament seconds):");
            full_time.printTime();

            //increament minutes
            full_time.increammentMin();
            Console.WriteLine("Full time(increament minutes):");
            full_time.printTime();

            //increament hours
            full_time.increammentHo();
            Console.WriteLine("Full time(increament hours):");
            full_time.printTime();

            //check if equal
            bool flag = full_time.isEqual(9, 8, 11);
            Console.WriteLine("flag {0}", flag);

            //check if equal with object
            Clock obj = new Clock(10,12,11);
            flag = full_time.isEqual(obj);
            Console.WriteLine("object flag" + flag);
            Console.ReadKey();


        }
    }
}
