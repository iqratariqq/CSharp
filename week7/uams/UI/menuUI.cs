using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uams.UI
{
    class MenuUI
    {
        public  int menu()
        {
            Console.WriteLine("1.add degree");
            Console.WriteLine("2.add student");
            Console.WriteLine("3.generate Merit");
            Console.WriteLine("4.view Registered Students");
            Console.WriteLine("5.view Student for a Specific program");
            Console.WriteLine("6.Register Subjects for a Specific Student");
            Console.WriteLine("7.Calculate fees for all registered students");
            Console.WriteLine("8.Exit");
            int option = int.Parse(Console.ReadLine());
            return option;

        }
    }
}
