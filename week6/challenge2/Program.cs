using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challenge2.UL;
using challenge2.BL;
using challenge2.DL;

namespace challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            //load user data
            if(SignUP.readUserData())
            {
                Console.WriteLine( "file exist:");
            
            }

            //load product file
            if(ProductDL.readUserData())
            {
                Console.WriteLine("product file exist:");
            }
            Console.Clear();
            
            //login object
            Login Muser = new Login();
            //signIn object
            signIN signin = new signIN();

            //*************************************??
            //products object
            ProductUI pro = new ProductUI();
            ProductBL p = new ProductBL();

            //customer object
            CostmurUI cust = new CostmurUI();

            int option;
            int choice;
            int press;
            do
            {
                option = Muser.login();
                Console.Clear();
                if (option==1)
                {
                   signin= Muser.takeInputWithRole();
                    SignUP.saveIntoFile(signin);
                    SignUP.addIntoList(signin);
                }
                else if(option==2)
                {
                    Console.Clear();
                    signin = Muser.takeInputWithoutRole();
                    signin = SignUP.check(signin);
                  string role= signin.ischeck();
                    if(role=="admin")
                    {
                        do
                        {
                            choice = pro.productMAenu();
                            if(choice==1)
                            {
                                p = pro.addProducts();
                                ProductDL.addIntoList(p);
                                ProductDL.saveIntoFile(p);
                            }
                            else if(choice==2)
                            {
                                pro.viewProducts(ProductDL.products);
                            }
                            else if(choice==3)
                            {
                                p = ProductDL.findHighestPrice();
                                pro.findHigestPrice(p);
                            }
                            else if(choice==4)
                            {
                                pro.salexTax(ProductDL.products);
                            }
                            else if (choice == 5)
                            {
                                p = ProductDL.productTobeOrdered();
                                pro.productTobeOrdered(p);
                            }
                        } while (choice != 6);

                    }
                    else if (role == "customer")
                    {
                        do
                        {
                            Console.Clear();
                            press = cust.costumerMenu();
                            if (press == 1)
                            {
                                pro.viewProducts(ProductDL.products);
                                Console.ReadLine();
                            }
                            else if (press == 2)
                            {
                               
                                pro.viewProducts(ProductDL.products);
                                p = cust.buyProduct();
                                ProductBL product = ProductDL.products.FirstOrDefault(prod => prod.name == p.name);
                                if (product != null && product.qunatity >= p.qunatity)
                                {
                                    product.decrementInStock(p);
                                    Console.WriteLine("Product purchased successfully.");
                                }
                                else
                                {
                                    Console.WriteLine("Product not available or insufficient quantity.");
                                }
                                Console.ReadLine();
                            }
                            else if (press == 3)
                            {
                               
                                pro.viewProducts(ProductDL.products);
                                p = cust.buyProduct();
                                ProductBL product = ProductDL.products.FirstOrDefault(prod => prod.name == p.name);
                                if (product != null && product.qunatity >= p.qunatity)
                                {
                                    float invoice = product.generteInvoice(p);
                                    cust.viewTotalIncome(invoice);
                                }
                                else
                                {
                                    Console.WriteLine("Product not available or insufficient quantity.");
                                }
                                Console.ReadLine();
                            }

                        } while (press != 4);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            }
            while (option != 3);
            Console.ReadLine();
        }
    }
}
