using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challenge2.BL;

namespace challenge2.UL
{
    class CostmurUI
    {
        public int costumerMenu()
        {
            Console.WriteLine("1.view All product");
            Console.WriteLine("2.buy product");
            Console.WriteLine("3.generate invoice");
            Console.WriteLine("4.exit");
            Console.WriteLine("press any option");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public ProductBL buyProduct()
        {
            Console.WriteLine("enter the name of product you want to buy:");
            string name = Console.ReadLine();
            Console.WriteLine("how many quntity you want to buy:");
            int quantity = int.Parse(Console.ReadLine());
            ProductBL p = new ProductBL(name, quantity);
            return p;
        }

        public void viewTotalIncome(float inVoice)
        {
            Console.WriteLine("Your Total invoice is " + inVoice);
        }
    }
}
