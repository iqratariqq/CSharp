using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        class Students
        {
            public string name;
            public int rol_no;
            public float cgpa;
        }
        static void Main(string[] args)
        {
            Students s1 = new Students();
            s1.name = "iqra";
            s1.rol_no = 29;
            s1.cgpa = 3.4f;
            Console.WriteLine("name {0}: roll no {1}: cgpa {2}", s1.name, s1.rol_no, s1.cgpa);
            Students s2 = new Students();
            s2.name = "noor";
            s2.rol_no = 12;
            s2.cgpa = 3.7f;
            Console.WriteLine("name {0}: roll no {1}: cgpa {2}", s2.name, s2.rol_no, s2.cgpa);
            Console.ReadKey();
        }
    }
}
