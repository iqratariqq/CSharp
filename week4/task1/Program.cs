using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.BL;
using System.IO;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            string path = "C:\\Users\\abdul sattar\\OneDrive\\Desktop\\OOP\\week4\\user.txt";
            int option;
            bool check = loadData(path, users);
            if (check)
                Console.WriteLine("Data loaded successFully");
            else
                Console.WriteLine("Data not loaded");
            Console.ReadKey();
            do
            {
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    User user = takeInputWithoutRole();
                    if (user != null)
                    {
                        user = signIn(user, users);
                        if (user == null)
                            Console.WriteLine("invalid input:");
                        else if (user.isAdmin())
                            Console.WriteLine("Admin");
                        else
                            Console.WriteLine("user");
                    }
                }
                if(option==2)
                {
                    User user = takeInputWithRole();
                    if(user!=null)
                    {
                        storeDataInFile(path, user);
                        storeDataInList(users, user);
                    }
                }
                else if (option == -1)
                {
                    Console.WriteLine("invalid output: try again:");
                }
                Console.ReadKey();

            }
            while (option != 3);

        }
        public static int menu()
        {
            int option;
            Console.WriteLine("1.signin:");
            Console.WriteLine("2.exit:");
            if (int.TryParse(Console.ReadLine(), out option))
            {
                return option;
            }
            else
            {
                return -1;
            }
        }



        public static bool loadData(string path, List<User> stud)
        {

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    
                    string name = getfield(record, 1);
                    string password = getfield(record, 2);
                    string role = getfield(record, 3);
                    User s1 = new User(name, password, role);
                    storeDataInList(stud, s1);
                }
                file.Close();
                return true;

            }
            else
            {
                return false;
            }

        }
        public static string getfield(string record, int field)
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

        static User takeInputWithoutRole()
        {
            Console.WriteLine("enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("enter your password:");
            string password = Console.ReadLine();
            if(name!=null&&password!=null)
            {
                User user = new User(name, password);
                return user;
            }
            else
            {
                return null;
            }
            
        }
        static User takeInputWithRole()
        {
            Console.WriteLine("enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("enter password:");
            string password = Console.ReadLine();
            Console.WriteLine("enter role:");
            string role = Console.ReadLine();
            if(name!=null&&password!=null&&role!=null)
            {
                User user = new User(name, password,role);
                return user;
            }
            return null;
        }
        static void storeDataInList(List<User> user,User users)
        {
            user.Add(users);
        }
        static void storeDataInFile(string path,User users)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(users.name + "," + users.password + "," + users.role);
            file.Flush();
            file.Close();   
        }
        static User signIn(User user,List<User> users)
        {
            foreach(User storedUser in users)
            {
                if(user.name==storedUser.name&&user.password==storedUser.password)
                {
                    return storedUser;
                }
            }
            return null;
        }
    }
}
