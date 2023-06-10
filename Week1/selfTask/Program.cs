using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selfTask
{
    class Program
    {
        static void Main(string[] args)
        {
            float age,price,toysP,result,remaining=0;
            Console.WriteLine("enter Lily's age: ");
            age = float.Parse(Console.ReadLine());
            Console.WriteLine("enter washing machine price: ");
            price = float.Parse(Console.ReadLine());
            Console.WriteLine("enter price of each toy: ");
            toysP = float.Parse(Console.ReadLine());
            result = Lily_money(age,toysP);
            if (result>=price)
            {
                remaining = result - price;
                Console.WriteLine("Yes {0}",remaining);
            }
           else
            {
                remaining = price-result;
                Console.WriteLine("no {0}", remaining);
            }
            Console.Read();
        }
        public static float Lily_money(float age, float toyP)
        {
            float countOdd = 0,countEven=0;
            float money =0,money2=0;
            for (int x=1;x<=age; x++)
            {
                if(x%2==0)
                { 
                    money = money + 10;
                    money2 = money2 + money;
          
                    countEven++;
                   
                }
                else if(x%2!=0)
                {
                    countOdd++;
                
                }
            }
            float SavedMoney = money2 - countEven;
            float OddMoney = countOdd * toyP;
            float totalMoney = SavedMoney + OddMoney;
            return totalMoney;

        }

    }
}
