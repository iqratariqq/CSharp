using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2a.BL;

namespace task2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("iqra",1000.0f,1033.2f,128.0f);
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.ReadKey();

        }
    }
}
