using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.BL;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Custmer> custmers = new List<Custmer>();
            int option;
            Custmer custmer = null;
            Product products = null;
            List<Product> product = null;
            do
            {
                option = menu();
                if(option==1)
                {
                    custmer = takeInPutForInformation();
                    storeInformationInList(custmers, custmer);
                }
              else  if(option==2)
                {
                    products = addProducts();
                    custmer.storeInList(products);
                }
                else if(option==3)
                {
                    viewCustmerInformation(custmers);
                }
                else if(option==4)
                {
                    product = custmer.getAllProduct();
                    viewAllProduct(product);
                }
                else if(option==5)
                {
                    float tex = products.calculateText(custmer);
                    viewTex(tex);
                }

            }
            while (option != 6);
            Console.ReadKey();
        }
        public static int menu()
        {
            Console.WriteLine("1.enter information of custmer:");
            Console.WriteLine("2.enter products:");
            Console.WriteLine("3.view custmer information:");
            Console.WriteLine("4.view total purchased:");
            Console.WriteLine("5.calculate tex:");
            Console.WriteLine("6.exit:");
                
            int option = int.Parse(Console.ReadLine());
            return option;

        }
        public static Custmer takeInPutForInformation()
        {
            Custmer custmer = new Custmer();
            Console.WriteLine("enter your name: ");
            custmer.custmerName = Console.ReadLine();
            Console.WriteLine("enter your contact number: ");
            custmer.custmerContact = Console.ReadLine();
            Console.WriteLine("enter your adress: ");
            custmer.custmerAdress = Console.ReadLine();
            return custmer;

        }
        public static void storeInformationInList(List<Custmer> cus,Custmer custmer)
        {
            cus.Add(custmer);
        }
        public static Product addProducts()
        {
            Product products = new Product();
            Console.WriteLine("enter product name:");
            products.name = Console.ReadLine();
            Console.WriteLine("enter product category:");
            products.category = Console.ReadLine();
            Console.WriteLine("enter product price:");
         
            products.price = float.Parse(Console.ReadLine());
            return products;

        }
        public static void viewCustmerInformation(List<Custmer>custmers)
        {
            Console.WriteLine("name\t\tcontact\t\t\tadress:");
            foreach(Custmer storedCust in custmers)
            {
                Console.WriteLine(storedCust.custmerName + "\t\t" + storedCust.custmerContact + "\t\t" + storedCust.custmerAdress);
            }
        }
        public static void viewAllProduct(List<Product> pro)
        {
            Console.WriteLine("name\t\tCetagory\t\t\tprice:");
            foreach (Product storedPro in pro)
            {
                Console.WriteLine(storedPro.name + "\t\t" + storedPro.category+ "\t\t" + storedPro.price);
            }
        }
        public static void viewTex(float tex)
        {
            Console.WriteLine("total tex is:" + tex);
        }
    }
}
