using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using pd.BL;

namespace pd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stu = new List<Student>();
            /*string path = "C:\\Users\\abdul sattar\\OneDrive\\Desktop\\OPP2\\pd\\bin\\Debug\\recordfile.txt";*/
            string path= "recordfile.txt";
            char option;
            readData(path, stu);
            do
            {


                Console.Clear();
                option = menu();
                if (option == '1')
                {
                    Console.Clear();

                    Console.WriteLine("enter your name:");
                    string studentN = Console.ReadLine();
                    Console.WriteLine("enter your password:");
                    string studentP = Console.ReadLine();
                    signin(studentN, studentP, stu);
                }

            } while (option != 2);
            Console.ReadKey();
            }
        public static char menu()
        {
            char option;
            Console.WriteLine("1.signIN:");
            Console.WriteLine("2.Exit:");
            Console.WriteLine("choose one option:");
            option = char.Parse(Console.ReadLine());
            return option;
        }
        public static void signin(string stuName, string stuPass, List<Student> s1)
        {
            bool flag = false;
            for (int index = 0; index < s1.Count; index++)
            {
                if (stuName == s1[index].name && stuPass == s1[index].password)
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
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        public static void readData(string path, List<Student>stu)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    Student s1 = new Student();
                    s1.name = parseData(record, 1);
                    s1.password = parseData(record, 2);
                    s1.role = parseData(record, 3);
                    stu.Add(s1);
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("Not exists");
                Console.ReadLine();
            }
        }
    }
}
