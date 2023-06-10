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
            List<Animal> a = new List<Animal>();
            Cat cat1 = new Cat("cat1");
            Cat c = new Cat("cat2");
            Dog d = new Dog("dog1");
            Dog d1 = new Dog("dog2");
            a.Add(cat1);
            a.Add(c);
            a.Add(d);
            a.Add(d1);
            foreach (Animal a1 in a)
            {
                Console.WriteLine(a1.toString());
               a1.greets();
            }
            Console.ReadLine();
        }
    }
}
