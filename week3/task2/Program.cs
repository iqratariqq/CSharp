using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.BL;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Student s2 = new Student();
            Console.WriteLine("2nd object"); 
            Console.WriteLine(s2.sname);
            Console.WriteLine(s2.matricMarks);
            Console.WriteLine(s2.fscMarks);
            Console.WriteLine(s2.ecatMarks);
            Console.ReadKey();
        }


    }
}
