using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challenge2.BL;
using challenge2.DL;

namespace challenge2.UL
{
    class Login
    {

        //login
        public  int login()
        {
            int option;
            Console.WriteLine("1.signUP:");
            Console.WriteLine("2.signin:");
            Console.WriteLine("3.exit:");
            if (int.TryParse(Console.ReadLine(), out option))
            {
                return option;
            }
            else
            {
                return -1;
            }
        }

        public  signIN takeInputWithoutRole()
        {
            Console.WriteLine("enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("enter your password:");
            string password = Console.ReadLine();
            if (name != null && password != null)
            {
                signIN user = new signIN(name, password);
                return user;
            }
            else
                return null;

        }


        public signIN takeInputWithRole()
        {
            Console.WriteLine("enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("enter your password:");
            string password = Console.ReadLine();
            Console.WriteLine("enter your role");
            string role = Console.ReadLine();
            if (name != null && password != null&&role!=null)
            {
                signIN user = new signIN(name, password,role);
                return user;
            }
            else
                return null;

        }
    }
}
