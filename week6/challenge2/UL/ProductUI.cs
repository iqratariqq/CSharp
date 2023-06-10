using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challenge2.BL;

namespace challenge2.UL
{
    class ProductUI
    {
        public int productMAenu()
        {
            Console.WriteLine("1.Add product");
            Console.WriteLine("2.view All Product");
            Console.WriteLine("3.find product with highest price");
            Console.WriteLine("4.view Sales Tax Of All product");
            Console.WriteLine("5.product to be Ordered.(less than threshold)");
            Console.WriteLine("press any option");
            int option = int.Parse(Console.ReadLine());
            return option;
        }

        public ProductBL addProducts()
        {
            Console.WriteLine("enter product name");
            string name = Console.ReadLine();
            Console.WriteLine("enter product cetagory");
            string cetagory = Console.ReadLine();
            Console.WriteLine("enter product price");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine("enter product quantity");
            int quantity = int.Parse(Console.ReadLine());
            ProductBL pro = new ProductBL(name, cetagory, price, quantity);
            return pro;

        }

        public void viewProducts(List<ProductBL> products)
        {
            Console.WriteLine("name\t\tcetagory\t\tprice\t\tquantity");
            foreach(ProductBL p in products)
            {
                Console.WriteLine(p.name+"\t\t"+p.category+"\t\t"+p.price+"\t\t"+p.qunatity);
            }
        }
        public void findHigestPrice(ProductBL pro)
        {
            Console.WriteLine("the "+pro.name+" has highest price "+pro.price);
        }

        public void productTobeOrdered(ProductBL pro)
        {
            if (pro != null)
            {
                Console.WriteLine("the " + pro.name + " to be ordered ");
            }
            else
                Console.WriteLine("no product to be ordered");
        }

        public void salexTax(List<ProductBL> p)
        {
            foreach(ProductBL pro in p)
            {
                float tax = pro.calculateTax();
                Console.WriteLine("the tax on "+pro.name+" is"+tax);
            }
        }

    }
}
