using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cards.BL;
using cards.UI;

namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            playerUI playerUI = new playerUI();
            DeckBL deck = new DeckBL();
            CardBL card=new CardBL();
            string valueName="wrong input";
            int option;
            do
            {
                option = playerUI.menu();
                if(option==1)
                {
                    card = deck.dealCard();
                }
                else if(option==2)
                {
                    deck.shuffle();
                }
                else if(option==3)
                {
                    int remainingCards = deck.cardsLeft();
                    playerUI.viewRemaingCards(remainingCards);
                }
                else if (option == 4)
                {
                    string suitName = card.getSuitAsString();
                    playerUI.viewSuitName(suitName);
                }
                else if (option == 5)
                {
                     valueName = card.getValueAsString();
                    if (valueName == "wrong Input")
                    {
                        int value = card.getValue();
                        playerUI.viewValueInInt(value);
                    }
                    else
                    {
                        playerUI.viewValueName(valueName);
                    }
                }
                else if (option == 6)
                {
                    if (valueName == "wrong Input")
                    {
                        string value = card.toint();
                        playerUI.viewBothName(value);
                    }
                    else
                    {
                        string suitAndValueName = card.toString();
                        playerUI.viewBothName(suitAndValueName);
                    }
                }
            }
            while (option != 7);
            Console.ReadKey();
        }
    }
}
