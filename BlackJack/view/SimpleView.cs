using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    class SimpleView : Observable, IView
    {
        public int DisplayHandsCount{ get; set; }
        private string Language;
        public PlayerAction GetMenuOption()
        {
            switch (System.Console.In.Read())
            {
                case 'p':
                    return PlayerAction.DoPlay;
                case 'h':
                    return PlayerAction.DoHit;
                case 's':
                    return PlayerAction.DoStand;
                case 'q':
                    return PlayerAction.DoQuit;
                default:
                    return PlayerAction.Invalid;
            }
        }

        public void DisplayWelcomeMessage()
        {
            System.Console.Clear();

            switch (Language)
            {
                case "S":
                    System.Console.WriteLine("Hej Black Jack Världen");
                    System.Console.WriteLine("Skriv 'p' för att Spela, 'h' för nytt kort, 's' för att stanna 'q' för att avsluta\n");
                    break;
                default:
                    System.Console.WriteLine("Hello Black Jack World");
                    System.Console.WriteLine("Type 'p' to Play, 'h' to Hit, 's' to Stand or 'q' to Quit\n");
                    break;
            }
        }

        public void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            DisplayHand("Player", a_hand, a_score);
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

        public void DisplayCard(model.Card a_card)
        {
            System.Console.WriteLine("{0} of {1}", a_card.GetValue(), a_card.GetColor());
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
