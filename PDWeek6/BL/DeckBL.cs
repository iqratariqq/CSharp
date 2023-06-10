using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cards.BL
{
    class DeckBL
    {
        int remainingCards;
        List<CardBL> cards = new List<CardBL>();
        public DeckBL()
        {
            remainingCards = 52;
            for(int i=1;i<4;i++)
            {
                for(int j=1;j<13;j++)
                {
                    CardBL card = new CardBL(i, j);
                    cards.Add(card);
                    if(j==52)
                    {
                        break;
                    }
                }
            }
        }

        public void shuffle()
        {
            Random rand = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int num = rand.Next(1 + n);
                CardBL temp = cards[num];
                cards[num] = cards[n];
                cards[n] = temp;
            }
          
            
        }
        public int cardsLeft()
        {
            return remainingCards;
        }
        public CardBL dealCard()
        {

            if (remainingCards > 0)
            {
                for (int x = 0; x < cards.Count; x++)
                {
                    remainingCards--;
                    cards.RemoveAt(x);
                    return cards[x];
                }

            }
            return null;
            
        }
    }
}
