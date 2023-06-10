using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
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
            Console.WriteLine("enter your name:");
            s1.name = Console.ReadLine();
            Console.WriteLine("enter your roll no:");
            s1.rol_no = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your gpa:");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("you have inputed:");
            Console.WriteLine("name {0}: roll no {1}: cgpa {2}", s1.name, s1.rol_no, s1.cgpa);
            Console.ReadKey();

        }
    }
}
