using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using challenge2.BL;

namespace challenge2.DL
{
    class SignUP
    {
        public string name;
        public string password;
        public string role;
        public static List<signIN> Muser = new List<signIN>();
        public SignUP()
        {

        }

        public static void addIntoList(signIN User)
        {
            Muser.Add(User);
        }

        public static bool readUserData()
        {

            string pathM="user.txt";
            if (File.Exists(pathM))
            {
                StreamReader file = new StreamReader(pathM);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string name = getfield(record, 1);
                    string password = getfield(record, 2);
                    string role = getfield(record, 3);
                    signIN User = new signIN(name, password, role);
                    addIntoList(User);
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
        public static void saveIntoFile(signIN user)
        {
            string filePath = "user.txt";
            StreamWriter file = new StreamWriter(filePath, true);
            file.WriteLine(user.name + "," + user.password+","+user.role);
            file.Flush();
            file.Close();
        }

        public static signIN check(signIN user)
        {
            foreach (signIN storedUser in Muser)
            {
                if (user.name == storedUser.name && user.password == storedUser.password)
                {
                    return storedUser;
                }
            }
            return null;
        }


    }


}
