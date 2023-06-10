using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.BL;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hostelite std = new Hostelite();
            std.name = "iqra";
            std.roomNumber = 12;
            Console.WriteLine(std.name + "is Allocated room"+std.roomNumber);
            Console.ReadKey();
        }
    }
}
