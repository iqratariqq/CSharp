using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using selfAssistance.BL;

namespace selfAssistance.DL
{
    class ShopDL
    {
        public static List<MenuBL> menu = new List<MenuBL>();
        public static void addintoList(MenuBL item)
        {
            Console.ReadKey();
            menu.Add(item);
        }
        public static void storeIntoFile(MenuBL item)
        {
            string path = "menu.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(item.name+","+ item.type+","+item.price);
            file.Flush();
            file.Close();         
        }
        public static bool readFromFile()
        {
            string path = "menu.txt";
            StreamReader file = new StreamReader(path);
            string record ;
            if(File.Exists(path))
            {
while((record=file.ReadLine())!=null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string type = splittedRecord[1];
                    int price = int.Parse(splittedRecord[2]);
                    MenuBL item = new MenuBL(name, type, price);
                    addintoList(item);

                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string chiepestItem()
        {
            int price = int.MaxValue;
            string cheapItem="";
            foreach(MenuBL i in menu)
            {
if(price>i.price)
                {
                    price = i.price;
                }
            }
            foreach(MenuBL x in menu)
            {
                if(price==x.price)
                {
                    cheapItem = x.name; 
                }
            }
            return cheapItem;
        }
       public static int payableAmount(string orderName)
        {
            int price = 0;
            foreach(MenuBL m in menu)
            {
                if(orderName==m.name)
                {
                    price = m.price;
                }
            }
            return price;

        }
        

    }
}
