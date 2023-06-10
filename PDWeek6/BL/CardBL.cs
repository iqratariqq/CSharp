using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cards.BL
{
    class CardBL
    {
        private int suit;
        private int value;
        public CardBL()
        {

        }
        public CardBL(int suit,int value)
        {
            this.suit = suit;
            this.value = value;
        }
        public string getSuitAsString()
        {
            string MySuit="Wrong input";
           if(this.suit==1)
            {
                MySuit = "clubs";
            }
           else if(this.suit==2)
            {
                MySuit = "diamond";
            }
            else if (this.suit == 3)
            {
                MySuit = "spades";
            }
            else if (this.suit == 4)
            {
                MySuit = "hearts";
            }
           return MySuit;
        }
        public string getValueAsString()
        {
            string myValue = "wrong Input";
            if (this.value == 1)
            {
                myValue = "Ace";
            }
            else if (this.value == 11)
            {
                myValue = "jack";
            }
            else if (this.value == 12)
            {
                myValue = "queen";
            }
            else if (this.value == 13)
            {
                myValue = "king";
            }
            return myValue;
        }
        public string toString()
        {
            return getValueAsString() + " of " + getSuitAsString();
        }
        public int getValue()
        {
            return this.value;
        }

        public string toint()
        {
            return getValue() + " of " + getSuitAsString();
        }
    }
}