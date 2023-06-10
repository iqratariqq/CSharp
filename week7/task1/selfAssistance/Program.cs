using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using selfAssistance.UI;
using selfAssistance.BL;
using selfAssistance.DL;

namespace selfAssistance
{
    class Program
    {
        static void Main(string[] args)
        {
            //shop
            Console.WriteLine("Enter the name of the shop:");
            string shopName = Console.ReadLine();

            ShopBL b = new ShopBL(shopName);
            ShopUI shopUI = new ShopUI(b);

            int option;

            if(ShopDL.readFromFile())
            {
                Console.WriteLine("file exist");
                shopUI.clearScrean();
            }
            else
            {
                Console.WriteLine("not exist");
                shopUI.clearScrean();
            }
           
            do
            {
                Console.Clear();
                shopUI.welComMenu(b);
                option = shopUI.menuOption();
                if(option==1)
                {

                    shopUI.addItem();  
                }
                else if(option==2)
                {
                    string cheapestItem = ShopDL.chiepestItem();
                    shopUI.viewCheapestItem(cheapestItem);
                    shopUI.clearScrean();

                }
                else if (option == 3)
                {
                    shopUI.viewDrinkType();
                    shopUI.clearScrean();
                }
                else if (option == 4)
                {
                    shopUI.viewTypeFruit();
                    shopUI.clearScrean();
                }
                else if (option == 5)
                {
                    shopUI.addOrder();
                    shopUI.clearScrean();
                }
                else if (option == 6)
                {
                    shopUI.fulFillOrder(b.orders);
                    shopUI.clearScrean();
                }
                else if (option == 7)
                {
                    shopUI.viewOrderList(b.orders);
                    shopUI.clearScrean();
                }
                else if (option == 8)
                {
                    int price = b.totalPayableAmount();
                    shopUI.viewTotalPayableAmount(price);
                    shopUI.clearScrean();
                }
            } while (option != 9);

        }
    }
}
