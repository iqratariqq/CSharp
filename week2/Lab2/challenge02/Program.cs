using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using challenge02.BL;

namespace challenge02
{
    class Program
    {
        static void Main(string[] args)
        {
            sign[] s = new sign[10];
            string path = "C:\\Users\\abdul sattar\\OneDrive\\Desktop\\OOP\\week2\\challenge02\\recordfil.txt";
            char option;
            int count = 0;
            readData(path, s, ref count);
            do
            {
              
               
                Console.Clear();
                option = menu();
                if(option=='1')
                {
                    Console.Clear();

                    Console.WriteLine("enter your name:");
                    string studentN = Console.ReadLine();
                    Console.WriteLine("enter your password:");
                    string studentP = Console.ReadLine();
                        signin(studentN, studentP, s, count);
                }
                else if (option == '2')
                {
                    Console.Clear();
                    Console.WriteLine("enter your names:");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter your new password:");
                    string passwords = Console.ReadLine();
                    bool isCheck = check(name, passwords, s, count);
                        if (isCheck == false)
                    {
                        Console.WriteLine("sign Up Succesful:");
                        signUp(path, name, passwords,s,ref count);
                    }
                    else
                    {
                        Console.WriteLine("user already exist:");
                    }
                }
                Console.ReadKey();
                        }
            while (option != 3);
            Console.ReadKey();
        }

        public static char menu()
        {
            char option;
            Console.WriteLine("1.signIN:");
            Console.WriteLine("2.signUp:");
            Console.WriteLine("choose one option:");
            option = char.Parse(Console.ReadLine());
            return option;
        }
        public static void signin(string stuName, string stuPass, sign[]s1,int count)
        {
            bool flag = false;
            for (int index = 0; index < count; index++)
            {
                if (stuName ==s1[index].name && stuPass == s1[index].password)
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
        public static bool check(string name, string password,sign[] s, int count)
        {
            bool isCheck = false;
            for(int x=0;x<count;x++)
            {
                if(name==s[x].name&& password==s[x].password)
                {
                    return true;
                }
            }
            return isCheck;
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
        public static void readData(string path, sign []s,ref int count)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    sign s1 = new sign();
                    s[count] = s1;
                    s[count].name = parseData(record, 1);
                    s[count].password = parseData(record, 2);
                    count++;
                    x++;
                    if(x>10)
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
        public static void signUp(string path, string name, string passwords,sign []s,ref int count)
        {
            sign s1 = new sign();
            s[count] = s1;
            s[count].name = name;
            s[count].password = passwords;
            count++;
           StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(name + "," + passwords);
            file.Flush();
            file.Close();


        }

    }
}

