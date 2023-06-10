using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace signin
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\abdul sattar\\OneDrive\\Desktop\\OPP2\\WEEK1\\record.txt";
            string[] names = new string[3];
            string[] password = new string[3];
            int option;
            do
            {
                readData(path, names, password);
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("enter your name:");
                    string studentN = Console.ReadLine();
                    Console.WriteLine("enter your password:");
                    string studentP = Console.ReadLine();
                    signin(studentN, studentP, names, password);

                }
                else if (option == 2)
                {
                    Console.WriteLine("enter your names:");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter your new password:");
                    string passwords = Console.ReadLine();
                    signUp(path, name, passwords);

                }
            }
            while (option < 3);
            Console.Read();


        }
        public static int menu()
        {
            int option;
            Console.WriteLine("1.signIN:");
            Console.WriteLine("2.signUp:");
            Console.WriteLine("choose one option:");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        public static void signin(string stuName, string stuPass, string[] names, string[] password)
        {
            bool flag = false;
            for (int index = 0; index < 3; index++)
            {
                if (stuName == names[index] && stuPass == password[index])
                {
                    Console.WriteLine("userValid");
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("invalid input");
            }
            Console.ReadKey();
        }
        public static void signUp(string path, string name, string password)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(name + "," + password);
            file.Flush();
            file.Close();


        }
        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if(comma==field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        public static void readData(string path,string[] names,string[]password)
        {
            int x = 0;
            if(File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while((record=file.ReadLine())!=null)
                {
                    names[x] = parseData(record, 1);
                    password[x] = parseData(record, 2);
                    x++;
                    if(x>=3)
                    {
                        break;
                    }
                
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("Not exists");
            }
        }
        
    }
}
