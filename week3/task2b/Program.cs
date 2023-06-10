using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2b.BL;

namespace task2b
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("iqra", 1000.0f, 1033.2f, 128.0f);
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
           
            Student s2 = new Student("tariq", 10.0f, 133.2f, 18.0f);
            Console.WriteLine("2nd onject:");
            Console.WriteLine(s2.sname);
            Console.WriteLine(s2.matricMarks);
            Console.WriteLine(s2.fscMarks);
            Console.WriteLine(s2.ecatMarks);
            Console.ReadKey();
        }
    }
}
