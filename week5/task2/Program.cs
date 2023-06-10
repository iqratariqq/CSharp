using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.BL;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bookChapter = new List<string>();
            Book book=null;
            int option;
            do
            {
                option = menu();
                if(option==1)
                {
                    Console.WriteLine("enter the book chapters name:");
                    for(int x=0;x<3;x++)
                    {
                        string name = Console.ReadLine();
                        bookChapter.Add(name);
                    }
                    book = takeInput(bookChapter);
                }
                else if(option==2)
                {
                    if (book != null)
                    {
                        setBookmark(book);
                    }
                    else
                    {
                        Console.WriteLine("enter the book information 1st:");
                    }
                }
                else if (option == 3)
                {
                    if (book != null)
                    {
                        getbookMark(book); ;
                    }
                    else
                    {
                        Console.WriteLine("enter the book information 1st:");
                    }
                }
                else if(option==4)
                {
                    if (book != null)
                    {
                        getbookPrice(book);
                    }
                    else
                    {
                        Console.WriteLine("enter the book information 1st:");
                    }
                }
                else if (option == 5)
                {
                    if (book != null)
                    {
                        setbookprice(book);
                    }
                    else
                    {
                        Console.WriteLine("enter the book information 1st:");
                    }
                }
                else if (option == 6)
                {
                    if (book != null)
                    {
                        getbookChapter(book);
                    }
                    else
                    {
                        Console.WriteLine("enter the book information 1st:");
                    }
                }

            }
            while (option != 7);
            Console.WriteLine("enter the book Chapters name");
            for (int x = 0; x < 3; x++)
            {
                string chapNam = Console.ReadLine();
                bookChapter.Add(chapNam);
            }
           
            Console.ReadKey();
        }
        public static int menu()
        {
            Console.WriteLine("1.enter information for for book");
            Console.WriteLine("2.set bookMark:");
            Console.WriteLine("3.get bookMark:");
            Console.WriteLine("4.get book price:");
            Console.WriteLine("5.setbook price:");
            Console.WriteLine("6.get book chapter:");
            Console.WriteLine("7.exist:");
            int option = int.Parse(Console.ReadLine());
            return option;
        }

        public  static Book takeInput(List<string> chapname)
        {
            
            Console.WriteLine("enter the auther name:");
            string name = Console.ReadLine();
            Console.WriteLine("enter the book pages");
            int page = int.Parse(Console.ReadLine());

            Console.WriteLine("enter book price:");
            int price = int.Parse(Console.ReadLine());
            Book oneB = new Book(name, page, chapname, price);
            return oneB;

        }
        public static void setBookmark(Book a)
        {
            Console.WriteLine("enter the mark:");
            int mark = int.Parse(Console.ReadLine());
            a.setBookMark(mark);
        }
        public static void getbookMark(Book a)
        {
            int mark = a.getBookMark();
            if (mark == -1)
            {
                Console.WriteLine("no book marks set:");
            }
            else
                Console.WriteLine("book mark is " + mark);
        }
        public static void setbookprice(Book a)
        {
            Console.WriteLine("enter the new price of book:");
            int mark = int.Parse(Console.ReadLine());
            a.setBookPrice(mark);
        }
        public static void getbookPrice(Book a)
        {
            int mark = a.getPrice();
                Console.WriteLine("book price is " + mark);
        }
        public static void getbookChapter(Book a)
        {
            Console.WriteLine("enter chapter number:");
            int no = int.Parse(Console.ReadLine());
            string chapter = a.getChapter(no);
            Console.WriteLine("book chapter is :" + chapter);
        }
    }
}
