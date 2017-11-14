using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    class ConsoleView : Observable
    {
        private string _language;

        public ConsoleView(string language)
        {
            _language = language;
        }

        public string GetWelcomeMessage()
        {
            switch (_language)
            {
                case "S":
                    return "Hej Black Jack Världen\n Skriv 'p' för att Spela, 'h' för nytt kort, 's' för att stanna 'q' för att avsluta\n";
                default:
                    return "Hello Black Jack World\n Type 'p' to Play, 'h' to Hit, 's' to Stand or 'q' to Quit\n";
            }
        }

        public void DisplayCard(model.Card a_card)
        {
            System.Console.WriteLine("{0} of {1}", a_card.GetValue(), a_card.GetColor());
        }

        public string DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            switch (_language)
            {
                case "S":
                    return "Spelare Har: ";
                default:
                    return "Player Has: ";
            }
        }

        public void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            DisplayHand("Dealer", a_hand, a_score);
        }

        private void DisplayHand(String a_name, IEnumerable<model.Card> a_hand, int a_score)
        {
            System.Console.WriteLine("{0} Has: ", a_name);
            foreach (model.Card c in a_hand)
            {
                DisplayCard(c);
            }

            System.Console.WriteLine("Score: {0}", a_score);
            System.Console.WriteLine("");
        }

        public void DisplayGameOver(bool a_dealerIsWinner)
        {
            System.Console.Write("GameOver: ");
            if (a_dealerIsWinner)
            {
                System.Console.WriteLine("Dealer Won!");
            }
            else
            {
                System.Console.WriteLine("You Won!");
            }

        }
    }
}
