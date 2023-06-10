using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cards.BL;
namespace cards.UI
{
    class playerUI
    {
        
        public int menu()
        {
            Console.WriteLine("1.dealCards");
            Console.WriteLine("2.suffleCards");
            Console.WriteLine("3.remainingCards");
            Console.WriteLine("4.get your suit name");
            Console.WriteLine("5.get your value name");
            Console.WriteLine("6. get both suit and value name");
            Console.WriteLine("7.EXIT");
            Console.WriteLine("enter any option");
            int option = int.Parse(Console.ReadLine());
            return option;
        }

        public void viewRemaingCards(int cardsLeft)
        {
            Console.WriteLine("the remaing cards are  {0}",cardsLeft);
        }
        public void viewSuitName(string suitName)
        {
            Console.WriteLine("the suit name is "+suitName);
        }

        public void viewValueName(string valueName)
        {
            Console.WriteLine("the value name is " + valueName);
        }

        public void viewBothName(string Names)
        {
            Console.WriteLine(Names);
        }

        public void viewValueInInt(int value)
        {
            Console.WriteLine(" your value have no string ,your value is {0} ",value);
        }
    }
}
