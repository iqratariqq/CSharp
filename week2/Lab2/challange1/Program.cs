using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challange1.BL;

namespace challange1
{
    class Program
    {
        static void Main(string[] args)
        {
            product[] s = new product[10];
            char option;
            int count = 0;
            float price;
            do
            {
                Console.Clear();
                option = menu();
                if (option == '1')
                {
                    Console.Clear();
                    s[count] = add_product();
                    count++;
                }
                else if (option == '2')
                {
                    Console.Clear();
                    view_product(s, count);
                }
                else if (option == '3')
                {
                    Console.Clear();
                    price =view_worth(s, count);
                    Console.WriteLine("total worth is {0}", price);
                    Console.ReadKey();
                }
                else if (option == '4')
                {
                    break;
                }
            }
            while (option != 4);
            Console.ReadKey();
        }
        public  static char menu()
        {
            char option;
            Console.WriteLine("1.add product");
            Console.WriteLine("2.view product");
            Console.WriteLine("3.view total worth of product");
            option = char.Parse(Console.ReadLine());
            Console.ReadKey();
            return option;
            

        }
        public static product add_product()
        {
            product s1 = new product();
            Console.WriteLine("enter product ID");
            s1.ID = Console.ReadLine();
            Console.WriteLine("enter product name");
            s1.product_name = Console.ReadLine();
            Console.WriteLine("enter product price");
            s1.product_price = float.Parse(Console.ReadLine());
            Console.WriteLine("enter product category");
            s1.category = Console.ReadLine();
            Console.WriteLine("enter product brand");
            s1.brand_name = Console.ReadLine();
            Console.WriteLine("enter country name");
            s1.country = Console.ReadLine();
            Console.ReadKey();
            return s1;

        }
        public static void view_product( product []s, int count)
        {
            if (count == 0)
            {
                Console.WriteLine("no item add yet:");

            }
            else
            {
                Console.WriteLine("ID:\t\tName:\t\tPrice:\t\tCategory:\t\tBrand:\t\tCountry");
                for (int x = 0; x < count; x++)
                {
                    Console.WriteLine("" + s[x].ID + "\t\t" + s[x].product_name + "\t\t" + s[x].product_price + "\t\t" + s[x].category + "\t\t" + s[x].brand_name + "\t\t" + s[x].country);
                }
            }
        Console.ReadKey();
        }
        public static float view_worth(product[] s, int count)
        {
            float sum = 0.0f;
            if (count==0)
            {
                Console.WriteLine("no item yet:");

            }
            else { 
 for (int x = 0; x < count; x++)
                {
                    sum = s[x].product_price + sum;
                }
            }
                return sum;
            
        }
    }
}
