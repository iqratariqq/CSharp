using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challenge2.BL;
using System.IO;

namespace challenge2.DL
{
    class ProductDL
    {
     public static   List<ProductBL> products = new List<ProductBL>();



        public static void addIntoList(ProductBL pro)
        {
            products.Add(pro);
        }
        public static bool readUserData()
        {

            string pathM = "Product.txt";
            if (File.Exists(pathM))
            {
                StreamReader file = new StreamReader(pathM);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string name = getfield(record, 1);
                    string cetagory = getfield(record, 2);
                   float price =float.Parse( getfield(record, 3));
                    int quantity = int.Parse(getfield(record, 4));
                    ProductBL product = new ProductBL(name, cetagory, price, quantity);
                    addIntoList(product);
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
        public static void saveIntoFile(ProductBL pro)
        {
            string filePath = "Product.txt";
            StreamWriter file = new StreamWriter(filePath, true);
            file.WriteLine(pro.name + "," + pro.category + "," + pro.price+","+pro.qunatity);
            file.Flush();
            file.Close();
        }
        public static ProductBL findHighestPrice()
        {
            int Price = 0;

                foreach(ProductBL p in products)
                {
                if(p.price>Price)
                {
                    return p;
                }
                }
            return null;
        }
        public static ProductBL productTobeOrdered()
        {
            foreach (ProductBL p in products)
            {
if(p.qunatity<5)
                {
                    return p;
                }
            }
            return null;
        }

        public static void updateQuantityInFile(ProductBL product)
        {

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].name == product.name)
                {
                    products[i].qunatity = product.qunatity;
                    saveUpdateIntoFile(products);
                    break;
                }
            }


        }



        public static void saveUpdateIntoFile(List<ProductBL> products)
        {
            string filePath = "Product.txt";

            using (StreamWriter file = new StreamWriter(filePath))
            {
                foreach (ProductBL product in products)
                {
                    file.WriteLine(product.name + "," + product.category + "," + product.price + "," + product.qunatity);
                }
            }
        }

    }
}
