using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using copyCons.BL;

namespace copyCons
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.sname = "ali";
            Console.WriteLine("defult:" + s.sname);
            Student s1 = new Student();
            s1 = s;
            s1.sname = "iqra";
            s1.fscMarks = 103.0f;
            s1.matricMarks = 990.0f;
            s1.ecatMarks = 390.0f;
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.ReadKey();


        }
    }
}
