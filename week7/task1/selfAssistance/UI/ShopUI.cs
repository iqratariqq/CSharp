using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using selfAssistance.BL;
using selfAssistance.DL;

namespace selfAssistance.UI
{
    class ShopUI
    {
        public ShopBL s; 

        public ShopUI(ShopBL shop)
        {
            s = shop;
        }
        public void welComMenu(ShopBL p)
        {
            Console.WriteLine("Welcom to the " + p.shopName + " shop");
        }
        public int menuOption()
        {
            Console.WriteLine("1.Add a menu item:");
            Console.WriteLine("2.view the chepiest item in the menu:");
            Console.WriteLine("3.view the drink menu:");
            Console.WriteLine("4.view the food menu:");
            Console.WriteLine("5.Add order:");
            Console.WriteLine("6.fulfill the order:");
            Console.WriteLine("7.view the order list:");
            Console.WriteLine("8.total payable amount:");
            Console.WriteLine("9.exit:");
            Console.WriteLine("enter one option");
            int.TryParse(Console.ReadLine(), out int option);
            return option;
        }
        public  ShopBL ShopName()
        {
            Console.WriteLine("enter the name of shop");
            string name = Console.ReadLine();
            ShopBL shop = new ShopBL(name);
            return shop;
        }
        public void addItem()
        {
            Console.WriteLine("how many item you want to add:");
            int.TryParse(Console.ReadLine(), out int Count);
            List<MenuBL> items = new List<MenuBL>();
            for(int x=0;x<Count;x++)
            {
                Console.WriteLine("enter item name");
                string name = Console.ReadLine();
                Console.WriteLine("enter item type");
                string type = Console.ReadLine();
                Console.WriteLine("enter item price");
                int price = int.Parse(Console.ReadLine());
                MenuBL menu = new MenuBL(name, type, price);
                if (!(items.Contains(menu)))
                {
                    items.Add(menu);
                    ShopDL.addintoList(menu);
                    ShopDL.storeIntoFile(menu);
                }
                else
                {
                    Console.WriteLine("already add this item:");
                    x--;
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();
                }
            }
            ShopBL shop = new ShopBL(items);
        }
        public void viewTypeFruit()
        {
            Console.WriteLine("name\t\ttype\t\tprice");
            foreach(MenuBL i in ShopDL.menu)
            {
            if(i.type=="fruit")
                {
                    Console.WriteLine(i.name+"\t\t"+i.price);
                }
            }
        }

        public void viewDrinkType()
        {
            Console.WriteLine("name\t\ttype\t\tprice");
            foreach (MenuBL i in ShopDL.menu)
            {
                if (i.type == "drink"|| i.type == "Drink")
                {
                    Console.WriteLine(i.name + "\t\t"+i.type+ "\t\t" + i.price);
                }
            }

        }
        public void viewCheapestItem(string itemName)
        {
            Console.WriteLine("the cheapest item is {0}",itemName);
        }
        public void addOrder()
        {

            Console.WriteLine("enter how many order you want to be ordered");
            int count = int.Parse(Console.ReadLine());
            bool isOrderFound = false;
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine("enter your order");
                string order = Console.ReadLine();
                foreach (MenuBL i in ShopDL.menu)
                {
                    if (order == i.name)
                    {
                        Console.WriteLine("order added");
                        s.addOrderIntoList(order);
                        isOrderFound = true;
                    }
                    
                }
                if (!isOrderFound)
                {
                    Console.WriteLine("this item is currently unavailable! try another item");
                    x--;
                    Console.WriteLine("press any key to continue");
                }
                Console.ReadKey();
            
            }
        }
        public void viewTotalPayableAmount(int price)
        {
            Console.WriteLine("the total payable amount is {0}",price);
        }

        public void fulFillOrder(List<string>orders)
        {
if(orders.Count<=0)
            {
                Console.WriteLine("All orders have been fulfilled!");
            }
else if(orders.Count>0)
            {
                for(int x=0;x<orders.Count;x++)
                {
                    Console.WriteLine("the "+orders[x] +" is ready");
                    s.removeOrderFromList(x);
                }
            }
        }

        public void viewOrderList(List<string> orders)
        {
            if(orders.Count>0)
            {
                foreach (var s in orders)
                {
                    Console.WriteLine(s);
                }
            }
            else
            {
                Console.WriteLine("no order found:");
            }
        }
        public void clearScrean()
        {
            Console.WriteLine("press any key to continue:");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
