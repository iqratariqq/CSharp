﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach(var i in numbers)

            //foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
