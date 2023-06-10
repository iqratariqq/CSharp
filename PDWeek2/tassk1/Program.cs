using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tassk1.BL;


namespace file1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\abdul sattar\\OneDrive\\Desktop\\class\\user.txt";
            string menu_path = "C:\\Users\\abdul sattar\\OneDrive\\Desktop\\class\\menu.txt";
            //--------------------------------------------------------//
            // list of student//
            List<Student> stu = new List<Student>();
            //--------------------------------------------------------//

            //--------------------------------------------------------//
            //LIST FOR MENU\\
            List<Menu> bill = new List<Menu>();
            //--------------------------------------------------------//
            int count = 0;// count for menu-----------
            int option;
            laodData(path, stu);               //-------load data from file of users
            read_menu(menu_path, bill,ref count);      //-------load data from file of menu
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
                    result = signIN(name, password, stu);
                    //##################################################################//
                    //admin interface//
                    //##################################################################//
                    if (result == "admin" || result == "Admin")
                    {
                        char choice='c';
                        do
                        {


                            //##################################################################//
                            //admin interface>>add user
                            //##################################################################//
                            Console.Clear();
                            sub_Menu("admin_Interface");
                           
                            choice = adminInterface();
                            if (choice == '1')
                            {
                                Console.Clear();
                                sub_Menu("admin_Interface_>_addUser");
                                bool isCheck;
                                Console.WriteLine("enter following intputs for check wheather user exist already or not:");
                                Console.WriteLine("enter user name:");
                                string nameS = Console.ReadLine();
                                Console.WriteLine("enter user password:");
                                string passwordS = Console.ReadLine();
                                Console.WriteLine("enter user role:");
                                string role = Console.ReadLine();
                                isCheck = check(nameS, passwordS, stu);
                                if (role == "admin" || role == "Admin" || role == "student" || role == "Student")
                                {
                                    if (isCheck == false)
                                    {


                                        stu.Add(takeInput(nameS, passwordS, role));
                                        save_user_data(path, nameS, passwordS, role);
                                        Console.WriteLine("Add user successfully:");
                                        stoping_Function();
                                    }
                                    else
                                    {

                                        Console.WriteLine("user already exist:");
                                        stoping_Function();
                                    }
                                }
                                if (role != "admin" || role != "Admin" && role == "student" || role == "Student")
                                {
                                    Console.WriteLine("invalid input:");
                                    stoping_Function();
                                }
                            }
                            //##################################################################//
                            //admin interface>>remove user
                            //##################################################################//
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
                                    stoping_Function();
                                }
                                else if (roleR == "student" || roleR == "Student")
                                {

                                    Check_dell = checkD(name_dell, password_dell, roleR, stu);
                                    if (Check_dell == true)
                                    {
                                        int x;
                                        x = takeInput_Removing(name_dell, password_dell, roleR, stu);
                                        if (x > -1)
                                        {
                                            stu.RemoveAt(x);
                                            save_remove_data(path, stu);
                                            Console.WriteLine("remove student successfully:");
                                        }

                                        stoping_Function();
                                    }
                                    else
                                    {

                                        Console.WriteLine("student name or password or role wrong:");
                                        stoping_Function();
                                    }


                                }
                                else if (roleR != "admin" || roleR != "Admin" && roleR == "student" || roleR == "Student")
                                {
                                    Console.WriteLine("invalid input:");
                                    stoping_Function();
                                }
                            }
                            //##################################################################//
                            //admin interface>>change user data
                            //##################################################################//
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
                                        Check_for_change = check_change(nameC, passwordC, stu);
                                        if (Check_for_change == true)
                                        {
                                            Console.WriteLine("enter user new name:");
                                            string name_replace = Console.ReadLine();
                                            Console.WriteLine("enter user new password:");
                                            string password_replace = Console.ReadLine();
                                            Console.WriteLine("enter user new role:");
                                            string role_replace = Console.ReadLine();
                                            change_user(nameC, passwordC, name_replace, password_replace, role_replace, stu);
                                            save_Change_data(path, stu);
                                            Console.WriteLine("change user data successfully:");
                                            stoping_Function();
                                        }
                                        else
                                        {

                                            Console.WriteLine("something wrong:");
                                            stoping_Function();
                                        }
                                    }
                                    else if (roleC != "admin" || roleC != "Admin" || roleC != "student" || roleC != "Student")
                                    {
                                        Console.WriteLine("invalid input:");
                                        stoping_Function();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("press any key to continue:");
                                    stoping_Function();
                                }

                            }
                            //##################################################################//
                            //admin interface>>view user
                            //##################################################################//
                            else if (choice == '4')
                            {
                                Console.Clear();
                                sub_Menu("admin_Interface_>_viewUser");
                                viewUser(stu);
                            }
                            //##################################################################//
                            //admin interface>>menu dispaly
                            //##################################################################//
                            else if (choice == '5')
                            {
                                string options;
                                Console.Clear();
                                sub_Menu("admin_Interface_>_Display_Menu");
                                Console.WriteLine("Do you want to display menu?");
                                options = Console.ReadLine();
                                if (options == "yes" || options == "YES")
                                {
                                    if (count < 7)
                                    {


                                        for (int x = 0; x < 7; x++)
                                        {
                                            Console.Clear();
                                            Menu menu = display_menu();
                                            if (menu == null)
                                            {
                                                Console.WriteLine("invalid price:try again:");
                                                stoping_Function();
                                            }
                                            else
                                            {
                                                sub_Menu("admin_Interface_>_Display_Menu");
                                                Console.WriteLine("you have stored the menu for {0}.", menu.name_of_days);
                                                if ((menu.name_of_days == "sunday" || menu.name_of_days == "SUNDAY") || (menu.name_of_days == "monday" || menu.name_of_days == "MONDAY") || (menu.name_of_days == "tuesday" || menu.name_of_days == "TUESDAY") || (menu.name_of_days == "wednesday" || menu.name_of_days == "WEDNESDAY") || (menu.name_of_days == "thursday" || menu.name_of_days == "THURSDAY") || (menu.name_of_days == "friday" || menu.name_of_days == "FRIDAY") || (menu.name_of_days == "saturday" || menu.name_of_days == "SATURDAY"))
                                                {
                                                    bill.Add(menu);
                                                    save_menu_data(menu_path, bill);
                                                    stoping_Function();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("The day you inputted was wrong. Please try again for the same day.");
                                                    stoping_Function();
                                                    x--; // decrement x to repeat the loop for the same day
                                                }
                                            }
                                        }

                                    }
                                    else if (count >= 7)
                                    {
                                        Console.WriteLine("you already displayed 7 days menu now you can cange menu not able to display:");
                                        stoping_Function();


                                    }
                                    else if (options != "yes" || options != "YES")
                                    {
                                        stoping_Function();

                                    }
                                }
                            }
                            //##################################################################//
                            //admin interface>>change menu
                            //##################################################################//
                            else if (choice == '6')
                            {
                                Console.Clear();
                                sub_Menu("admin_Interface_>_change_Menu");
                                Console.WriteLine("do you want to change the menu?");
                                string ans = Console.ReadLine();
                                if (ans == "yes" || ans == "Yes")
                                {
                                    int price;
                                    bool Check_for_change;
                                    Console.WriteLine("enter the name of day:");
                                    string day = Console.ReadLine();
                                    Console.WriteLine("enter the name of item:");
                                    string item = Console.ReadLine();
                                    Console.WriteLine("enter the price of item:");
                                    if (int.TryParse(Console.ReadLine(), out price))
                                    {
                                        if (day == "sunday" || day == "monday" || day == "tuesday" || day == "wednesday" || day == "thuresday" || day == "friday" || day == "saturday")
                                        {
                                            Check_for_change = check_menu(day, item, price, bill);
                                            if (Check_for_change == true)
                                            {
                                                Console.WriteLine("enter new name of item:");
                                                string name_replace = Console.ReadLine();
                                                Console.WriteLine("enter new price of item:");
                                                int price_replace = int.Parse(Console.ReadLine());
                                                change_menu(day, item, price, name_replace, price_replace, bill);
                                                save_Change_menu(menu_path, bill);
                                                Console.WriteLine("change menu successfully:");
                                                stoping_Function();
                                            }
                                            else
                                            {

                                                Console.WriteLine("something wrong:");
                                                stoping_Function();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("invalid input:");
                                            stoping_Function();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("your price value is invalid please put valid input:");
                                        choice = '6';
                                        stoping_Function();
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("press any key to continue:");
                                    stoping_Function();
                                }

                            }
                            //##################################################################//
                            //admin interface>>view menu
                            //##################################################################//
                            else if (choice == '7')
                            {
                                Console.Clear();
                                sub_Menu("admin_Interface_>_viewMENU");
                                viewMenu(bill);
                            }
                            else if(choice=='a')
                            {
                                Console.WriteLine("invalid input: try again:");
                                stoping_Function();
                            }
                        }
                        while (choice != '8');
                    }
                    //##################################################################//
                    //student interface
                    //##################################################################//
                    else if (result == "student" || result == "Student")
                    {
                        Console.Clear();
                        studentInterface();
                    }
                    else
                    {
                        Console.WriteLine(result);
                        stoping_Function();

                    }

                }

                 else if(option ==-1)
                {
                    Console.WriteLine("invalid output: try again:");
                    stoping_Function();


                }
                            }
            while (option != 2);
        }

        //##################################################################//
        //
        //function for stop the console
        //
        //##################################################################//
        public static void stoping_Function()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("press any key to continue:");
            Console.ReadKey();
            Console.Clear();
        }



        //##################################################################//
        //
        //login
        //
        //##################################################################//

        public static int login()
        {
            int option;
            Console.WriteLine("1.signin:");
            Console.WriteLine("2.exit:");
          if(int.TryParse(Console.ReadLine(),out option))
            {
                return option;
            }
           else
            {
                return -1;
            }
        }
        //##################################################################//
        //CRUD FUNCTIONS FOR USER
        //admin interface>>user data save in file
        //##################################################################//
        public static void save_user_data(string path, string name, string password, string role)
        {
            StreamWriter file = new StreamWriter(path, true);

            file.WriteLine(name + "," + password + "," + role);

            file.Flush();
            file.Close();


        }
        //##################################################################//
        //CRUD FUNCTIONS FOR USER
        //admin interface>> LOAD DATA FROM FILES
        //##################################################################//
        public static void laodData(string path, List<Student> stud)
        {

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    Student s1 = new Student();
                    s1.name = getfield(record, 1);
                    s1.password = getfield(record, 2);
                    s1.role = getfield(record, 3);
                    stud.Add(s1);

                }
                file.Close();

            }
            else
            {
                Console.WriteLine("file not exists:");
            }
            stoping_Function();
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
        //##################################################################//
        //CRUD FUNCTIONS FOR USER
        //admin interface>> CHECK FUNCTION WHEATHER USER IS EXIST  ALREADY OR NOT 
        //##################################################################//
        public static bool check(string nameS, string passwordS, List<Student> stu)
        {

            for (int x = 0; x < stu.Count; x++)
            {
                if (stu[x].name == nameS && stu[x].password == passwordS)
                {
                    return true;
                }
            }
            return false;
        }
        //##################################################################//
      //SIGN in function
        //##################################################################//
        public static string signIN(string nameS, string passwordS, List<Student> stu)
        {
            string role_user;
            for (int x = 0; x < stu.Count; x++)
            {
                if (stu[x].name == nameS && stu[x].password == passwordS)
                {
                    role_user = stu[x].role;
                    return role_user;
                }
            }
            return "user not found ";

        }
        //##################################################################//
        //CRUD FUNCTIONS FOR USER
        //admin interface>> input store in OBJECT for add user
        //##################################################################//
        public static Student takeInput(string names, string passwords, string roll)
        {
            Student s1 = new Student();
            s1.name = names;
            s1.password = passwords;
            s1.role = roll;
            return s1;

        }
        //##################################################################//
        //
        //admin interface
        //##################################################################//
        public static char adminInterface()
        {
            char option;
            Console.WriteLine("1.Add user");
            Console.WriteLine("2.remove student");
            Console.WriteLine("3.change user data");
            Console.WriteLine("4.view user");
            Console.WriteLine("5.display menu of week");
            Console.WriteLine("6.change menu");
            Console.WriteLine("7.view menu");
            Console.WriteLine("8.exit");
            Console.WriteLine("entre one option");
           if( char.TryParse(Console.ReadLine(),out option))
            {
                return option;
            }
           else
            {
                option = 'a';
                return option;

            }
        }
        //##################################################################//
    //student interaface
        //##################################################################//
        public static void studentInterface()
        {
            Console.WriteLine("student");
            stoping_Function();
        }
        //##################################################################//
        // sub menu which show at the top of every printing function
        //##################################################################//
        public static void sub_Menu(string message)
        {
            Console.WriteLine("main Menu > {0}", message);
            Console.WriteLine("--------------");

        }
        //##################################################################//
        //CRUD FUNCTIONS FOR USER
        //admin interface>> chack wheather the input which enter the user are valid are not
        //##################################################################//
        public static int takeInput_Removing(string names, string passwords, string roles, List<Student> stu)
        {
            int index = -1;

            for (int x = 0; x < stu.Count; x++)
            {
                if (stu[x].name == names && stu[x].password == passwords && stu[x].role == roles)
                {
                    index = x;
                }
            }
            return index;

        }
        //##################################################################//
        //CRUD FUNCTIONS FOR USER
        //admin interface>> save the list in file in which user remove 
        //##################################################################//
        public static void save_remove_data(string path, List<Student> stu)
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int x = 0; x < stu.Count; x++)
            {
                file.WriteLine(stu[x].name + "," + stu[x].password + "," + stu[x].role);
            }
            file.Flush();
            file.Close();
        }

        //##################################################################//
        //CRUD FUNCTIONS FOR USER
        //admin interface>> FUNCTION FOR CHECK IF USER EXIST OR NOT FOR REMOVING DATA
        //##################################################################//

        public static bool checkD(string nameS, string passwordS, string roles, List<Student> stu)
        {

            for (int x = 0; x < stu.Count; x++)
            {
                if (stu[x].name == nameS && stu[x].password == passwordS && stu[x].role == roles)
                {
                    return true;
                }
            }
            return false;
        }
        //##################################################################//
        //CRUD FUNCTIONS FOR USER
        //admin interface>> FUNCTION FOR CHECK IF USER EXIST OR NOT FOR CHANGE THE DATA OF USER
        //##################################################################//
        public static bool check_change(string nameS, string passwordS, List<Student> stu)
        {

            for (int x = 0; x < stu.Count; x++)
            {
                if (stu[x].name == nameS && stu[x].password == passwordS)
                {
                    return true;
                }
            }
            return false;
        }
        //##################################################################//
        //CRUD FUNCTIONS FOR USER
        //admin interface>> USER DATA CHANING FUNCTION
        //##################################################################//
        public static void change_user(string oldN, string OldP, string nameS, string passwordS, string roles, List<Student> stu)
        {
            for (int x = 0; x < stu.Count; x++)
            {
                if (stu[x].name == oldN && stu[x].password == OldP)
                {
                    stu[x].name = nameS;
                    stu[x].password = passwordS;
                    stu[x].role = roles;
                }

            }
        }
        public static void save_Change_data(string path, List<Student> stu)
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int x = 0; x < stu.Count; x++)
            {
                file.WriteLine(stu[x].name + "," + stu[x].password + "," + stu[x].role);
            }
            file.Flush();
            file.Close();
        }
        //##################################################################//
        //CRUD FUNCTIONS FOR USER
        //admin interface>> VIEW USERS WHICH IN EXIST IN FILE
        //##################################################################//
        public static void viewUser(List<Student> stu)
        {
            Console.WriteLine("Name\t\tRole");
            for (int x = 0; x < stu.Count; x++)
            {
                Console.WriteLine(stu[x].name + "\t\t" + stu[x].role);
            }
            stoping_Function();
        }

        //##################################################################//
        //CRUD FUNCTIONS FOR MENU
        //admin interface>> FUNCTION FOR DISPALING MENU
        //##################################################################//
        public static Menu display_menu()
        {
            int price;
            Menu s1 = new Menu();
                Console.WriteLine("enter the name of day:");
                s1.name_of_days = Console.ReadLine();
                Console.WriteLine("enter the name of item:");
                s1.item_name = Console.ReadLine();
                Console.WriteLine("enter the price of item:");
                if(int.TryParse(Console.ReadLine(),out price))
                {
                s1.item_price = price;
                return s1;
            }
            else
            {
                return null;
            }
            
        }
        public static void save_menu_data(string pathM, List<Menu> menus)
            {
            StreamWriter file = new StreamWriter(pathM, true);
            for (int x = 0; x < menus.Count; x++)
            {
                file.WriteLine(menus[x].name_of_days + "," + menus[x].item_name + "," + menus[x].item_price);
            }
            file.Flush();
            file.Close();
        }
        //##################################################################//
        //CRUD FUNCTIONS FOR MENU
        //admin interface>> FUNCTION FOR READ DATA FROM MENU FILE 
        //##################################################################//
        public static void read_menu(string pathM, List<Menu> mnu,ref int count)
        {

            if (File.Exists(pathM))
            {
                StreamReader file = new StreamReader(pathM);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    Menu s1 = new Menu();
                    s1.name_of_days = getfield_menu(record, 1);
                    s1.item_name= getfield_menu(record, 2);
                    if (int.TryParse(getfield_menu(record, 3), out int price))
                    {
                        s1.item_price = price;
                    }
                    mnu.Add(s1);
                    count++;

                }
                file.Close();

            }
            else
            {
                Console.WriteLine("file not exists:");
                stoping_Function();
            }
            
        }
        public static string getfield_menu(string record, int field)
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

        public static bool check_menu(string day, string item,int price,List<Menu> bill)
        {

            for (int x = 0; x < bill.Count; x++)
            {
                if (bill[x].name_of_days == day && bill[x].item_name == item&&bill[x].item_price==price)
                {
                    return true;
                }
            }
            return false;
        }

        public static void change_menu(string day, string item,int price,string name_replace,int price_replace,List<Menu> bill)
        {
            for (int x = 0; x < bill.Count; x++)
            {
                if (bill[x].name_of_days == day && bill[x].item_name == item&&bill[x].item_price==price)
                {
                    bill[x].name_of_days = day;
                    bill[x].item_name = name_replace;
                    bill[x].item_price = price_replace;
                }

            }
        }

        public static void save_Change_menu(string menu_path,List<Menu> bill)
        {
            StreamWriter file = new StreamWriter(menu_path, false);
            for (int x = 0; x < bill.Count; x++)
            {
                file.WriteLine(bill[x].name_of_days+ "," + bill[x].item_name + "," + bill[x].item_price);
            }
            file.Flush();
            file.Close();
        }
        //##################################################################//
        //CRUD FUNCTIONS FOR MENU
        //admin interface>> FUNCTION FOR VIEW MENU
        //##################################################################//
        public static void viewMenu(List<Menu> bill)
        {
            Console.WriteLine("day_name\t\titem_name\t\titem_price");
            for (int x = 0; x < bill.Count; x++)
            {
                Console.WriteLine(bill[x].name_of_days+ "\t\t" + bill[x].item_name+"\t\t"+bill[x].item_price);
            }
            stoping_Function();
        }

    }
}


