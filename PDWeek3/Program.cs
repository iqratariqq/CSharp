using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace file1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\abdul sattar\\OneDrive\\Desktop\\newproject\\users.txt";
            string[] names = new string[100];
            string[] passwords = new string[100];
            string[] roles = new string[100];
            int count = 0;
            //int countS=count+1;
            int option;
            laodData(path, ref count, names, passwords, roles);
            Console.WriteLine(count);
            Console.ReadKey();
            do
            {

                Console.Clear();
                option = login();
                Console.Clear();
                if (option == 1)
                {
                    sub_Menu("singIn");
                    string result;
                    Console.WriteLine("enter your name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter your password:");
                    string password = Console.ReadLine();
                    result = signIN(name, password, count, names, passwords, roles);
                    if (result == "admin" || result == "Admin")
                    {
                        char choice;
                        do
                        {


                           
                            Console.Clear();
                            sub_Menu("admin_Interface");
                            choice = adminInterface();
                            if (choice == '1')
                            {
                                Console.Clear();
                                sub_Menu("admin_Interface_>_addUser");
                                bool isCheck;
                                Console.WriteLine("enter user name:");
                                string nameS = Console.ReadLine();
                                Console.WriteLine("enter user password:");
                                string passwordS = Console.ReadLine();
                                Console.WriteLine("enter user role:");
                                string role = Console.ReadLine();
                                isCheck = check(nameS, passwordS, count, names, passwords);
                                if (role == "admin" || role == "Admin" || role == "student" || role == "Student")
                                {
                                    if (isCheck == false)
                                    {
                                        add_user(nameS, passwordS, role, ref count, names, passwords, roles);
                                        save_user_data(path, nameS, passwordS, role);
                                        Console.WriteLine("Add user successfully:");
                                        Console.ReadKey();
                                    }
                                    else
                                    {

                                        Console.WriteLine("user already exist:");
                                        Console.ReadKey();
                                    }
                                }
                                if (role != "admin" || role != "Admin" && role == "student" || role == "Student")
                                {
                                    Console.WriteLine("invalid input:");
                                    Console.ReadKey();
                                }
                            }
                            else if (choice == '2')
                            {
                                Console.Clear();
                                sub_Menu("admin_Interface_>_removeUser");
                                bool Check_dell;
                                Console.WriteLine("enter user name:");
                                string name_dell = Console.ReadLine();
                                Console.WriteLine("enter user password:");
                                string password_dell = Console.ReadLine();
                                Console.WriteLine("enter user role:");
                                string roleR = Console.ReadLine();
                                if (roleR == "admin" || roleR == "Admin")
                                {
                                    Console.WriteLine("you can't remove admin:");
                                    Console.ReadKey();
                                }
                                else if (roleR == "student" || roleR == "Student")
                                {

                                    Check_dell = checkD(name_dell, password_dell, count, names, passwords);
                                    if (Check_dell == true)
                                    {
                                        removeS(name_dell, password_dell, roleR, ref count, names, passwords, roles);
                                        save_remove_data(path, count, names, passwords, roles);
                                        Console.WriteLine("remove student successfully:");
                                        Console.ReadKey();
                                    }
                                    else
                                    {

                                        Console.WriteLine("student name or password wrong:");
                                        Console.ReadKey();
                                    }


                                }
                                else if (roleR != "admin" || roleR != "Admin" && roleR == "student" || roleR == "Student")
                                {
                                    Console.WriteLine("invalid input:");
                                    Console.ReadKey();
                                }
                            }
                            else if (choice == '3')
                            {
                                Console.Clear();
                                sub_Menu("admin_Interface_>_changeUser_data");
                                Console.WriteLine("do you want to change the user data?");
                                string ans = Console.ReadLine();
                                if (ans == "yes" || ans == "Yes")
                                {
                                    bool Check_for_change;
                                    Console.WriteLine("enter user name:");
                                    string nameC = Console.ReadLine();
                                    Console.WriteLine("enter user password:");
                                    string passwordC = Console.ReadLine();
                                    Console.WriteLine("enter user role:");
                                    string roleC = Console.ReadLine();
                                    if (roleC == "admin" || roleC == "Admin" || roleC == "student" || roleC == "Student")
                                    {
                                        Check_for_change = check_change(nameC, passwordC, count, names, passwords);
                                        if (Check_for_change == true)
                                        {
                                            Console.WriteLine("enter user new name:");
                                            string name_replace = Console.ReadLine();
                                            Console.WriteLine("enter user new password:");
                                            string password_replace = Console.ReadLine();
                                            Console.WriteLine("enter user new role:");
                                            string role_replace = Console.ReadLine();
                                            change_user(nameC, passwordC, name_replace, password_replace, role_replace, count, names, passwords, roles);
                                            save_Change_data(path, count, names, passwords, roles);
                                            Console.WriteLine("change user data successfully:");
                                            Console.ReadKey();
                                        }
                                        else
                                        {

                                            Console.WriteLine("something wrong:");
                                            Console.ReadKey();
                                        }
                                    }
                                    else if (roleC != "admin" || roleC != "Admin" || roleC != "student" || roleC != "Student")
                                    {
                                        Console.WriteLine("invalid input:");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                   break;
                                }

                            }
                            else if (choice == '4')
                            {
                                Console.Clear();
                                sub_Menu("admin_Interface_>_viewUser");
                                viewUser(names, roles,count);
                            }
                        }
                        while (choice != '5');
                    }
                    else if (result == "student" || result == "Student")
                    {
                        Console.Clear();
                        studentInterface();
                    }
                    else
                    {
                        Console.WriteLine(result);
                        Console.ReadKey();
                    }
         
                }
            }
            while (option != 2);
            Console.ReadKey();
        }
        public static int login()
        {
            int option;
            Console.WriteLine("1.signin:");
            Console.WriteLine("2.exit:");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        public static void save_user_data(string path,  string name, string password, string role)
        {
            StreamWriter file = new StreamWriter(path, true);
   
                file.WriteLine(name + "," + password+ "," + role);
            
            file.Flush();
            file.Close();


        }
        public static void laodData(string path, ref int count, string[] name, string[] password, string[] role)
        {

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    name[count] = getfield(record, 1);
                    password[count] = getfield(record, 2);
                    role[count] = getfield(record, 3);
                    count++;

                }
                file.Close();

            }
            else
            {
                Console.WriteLine("file not exists:");
            }
            Console.ReadKey();
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
        public static bool check(string nameS, string passwordS, int count, string[] name, string[] password)
        {

            for (int x = 0; x < count; x++)
            {
                if (name[x] == nameS && password[x] == passwordS)
                {
                    return true;
                }
            }
            return false;
        }
        public static string signIN(string nameS, string passwordS, int count, string[] name, string[] password, string[] role)
        {
            string role_user;
            for (int x = 0; x < count; x++)
            {
                if (name[x] == nameS && password[x] == passwordS)
                {
                    role_user = role[x];
                    return role_user;
                }
            }
            return "user not found ";

        }
        public static void add_user(string nameS, string passwordS, string roles, ref int count, string[] name, string[] password, string[] role)
        {
            name[count] = nameS;
            password[count] = passwordS;
            role[count] = roles;
            count++;
        }
        public static char adminInterface()
        {
            char option;
            Console.WriteLine("1.Add user");
            Console.WriteLine("2.remove student");
            Console.WriteLine("3.change user data");
            Console.WriteLine("4.view user");
            Console.WriteLine("5.exit");
            Console.WriteLine("entre one option");
            option = char.Parse(Console.ReadLine());
            Console.ReadKey();
            return option;

        }
        public static void studentInterface()
        {
            Console.WriteLine("student");
            Console.ReadKey();
        }
        public static void sub_Menu(string message)
        {
            Console.WriteLine("main Menu > {0}", message);
            Console.WriteLine("--------------");

        }
        public static void removeS(string nameS, string passwordS, string roles, ref int count, string[] name, string[] password, string[] role)
        {
            for (int x = 0; x < count; x++)
            {
                if (nameS == name[x] && passwordS == password[x] && roles == role[x])
                {
                    name[x] = name[x + 1];
                    password[x] = password[x + 1];
                    role[count] = role[x + 1];
                    count--;
                }
            }

        }
        public static void save_remove_data(string path,int count, string []name, string[] password, string[] role)
        {
            StreamWriter file = new StreamWriter(path, false);
            for(int x=0;x<count;x++)
            {
                file.WriteLine(name[x] + ","+password[x] + "," + role[x]);
            }
            file.Flush();
            file.Close();
        }
        public static bool checkD(string nameS, string passwordS, int count, string[] name, string[] password)
        {

            for (int x = 0; x < count; x++)
            {
                if (name[x] == nameS && password[x] == passwordS)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool check_change(string nameS, string passwordS, int count, string[] name, string[] password)
        {

            for (int x = 0; x < count; x++)
            {
                if (name[x] == nameS && password[x] == passwordS)
                {
                    return true;
                }
            }
            return false;
        }
        public static void change_user(string oldN,string OldP,string nameS, string passwordS, string roles,  int count, string[] name, string[] password, string[] role)
        {
        for(int x=0;x<count;x++)
            {
                if(name[x]==oldN && password[x]==OldP)
                {
                    name[x] = nameS;
                    password[x] = passwordS;
                    role[x] = roles;
                }
 
            }
        }
        public static void save_Change_data(string path, int count, string[] name, string[] password, string[] role)
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int x = 0; x < count; x++)
            {
                file.WriteLine(name[x] + "," + password[x] + "," + role[x]);
            }
            file.Flush();
            file.Close();
        }
        public static void viewUser(string[] name, string[] role,int count)
        {
            Console.WriteLine("Name\t\tRole");
            for(int x=0;x<count;x++)
            {
                Console.WriteLine(name[x] + "\t\t" + role[x]);
            }
            Console.ReadKey();
        }
    }  
}


