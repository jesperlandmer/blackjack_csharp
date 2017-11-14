using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    class ConsoleView : Observable, IView
    {
        View consoleView;
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

        public ConsoleView(string language = "")
        {
            consoleView = new View(language);
        }
        public void DisplayWelcomeMessage()
        {
            System.Console.Clear();
            System.Console.WriteLine(consoleView.GetWelcomeMessage());
        }

        public void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            System.Console.WriteLine(consoleView.GetPlayerHand());
            DisplayHand(a_hand, a_score);
        }

        public void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            System.Console.WriteLine(consoleView.GetDealerHand());
            DisplayHand(a_hand, a_score);
        }

        private void DisplayHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            foreach (model.Card c in a_hand)
            {
                DisplayCard(c);
            }

            System.Console.WriteLine(consoleView.GetScore(a_score));
            System.Console.WriteLine(""); //To be removed?
        }

        public void DisplayCard(model.Card a_card)
        {
            System.Console.WriteLine(consoleView.GetCard(a_card));
        }

        public void DisplayGameOver(bool a_dealerIsWinner)
        {
            System.Console.Write(consoleView.GetGameOver());

            if (a_dealerIsWinner)
            {
                System.Console.WriteLine(consoleView.GetDealerWinner());
            }
            else
            {
                System.Console.WriteLine(consoleView.GetPlayerWinner());
            }

        }
    }
}