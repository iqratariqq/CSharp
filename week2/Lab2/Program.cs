using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace week2
{
    class Program
    {
        class Student
        {
            public string name;
            public int roll_no;
            public float cgpa;
        }
       
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.name = "iqra";
            s1.roll_no = 29;
            s1.cgpa = 3.28F;
            Console.WriteLine("name {0} Roll No:{1} CGPA:{2}", s1.name, s1.roll_no, s1.cgpa);
            Console.Read();
                
        }
    }
}
