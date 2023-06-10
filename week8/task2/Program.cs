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
            List<Person> p = new List<Person>();
            Student stu1 = new Student("iqra", "zafarwal", "CS", 2022, 5500.0);
            Student stu2= new Student("noor", "uet", "CS2", 2022, 550.00);
            Staff staff1 = new Staff("mam", "lahore", "university", 1000.0);
            Staff staff2= new Staff("sir", "lahore4", "university2", 2000.0);
            p.Add(stu1);
            p.Add(stu2);
            p.Add(staff1);
            p.Add(staff2);

            foreach(Person pe in p)
            {
                Console.WriteLine(pe.toString());
            }

/*            Console.WriteLine("student1 "+stu1.toString());
            Console.WriteLine("student2 " + stu2.toString());
            Console.WriteLine( "staff1 "+staff1.toString());
            Console.WriteLine("staff2 " + staff2.toString());*/
            Console.ReadKey();
        }
    }
}
