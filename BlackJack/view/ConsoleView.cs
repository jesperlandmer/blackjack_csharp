using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    class ConsoleView : IView, model.observer.IObserver
    {
        private View view;
        private Stopwatch _stopwatch;

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
            view = new View(language);
        }
        public void Update()
        {
            System.Threading.Thread.Sleep(1000);
            _stopwatch.Stop();
        }
        public void DisplayWelcomeMessage()
        {
            System.Console.Clear();
            System.Console.WriteLine(view.GetWelcomeMessage());
        }

        public void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            System.Console.WriteLine(view.GetPlayerHand());
            DisplayHand(a_hand, a_score);
        }

        public void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            System.Console.WriteLine(view.GetDealerHand());
            DisplayHand(a_hand, a_score);
        }

        private void DisplayHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            foreach (model.Card c in a_hand)
            {
                DisplayCard(c);
            }

            System.Console.WriteLine(view.GetScore(a_score));
            System.Console.WriteLine("");
        }

        public void DisplayCard(model.Card a_card)
        {
            System.Console.WriteLine(view.GetCard(a_card));
        }

        public void DisplayGameOver(bool a_dealerIsWinner)
        {
            System.Console.Write(view.GetGameOver());

            if (a_dealerIsWinner)
            {
                System.Console.WriteLine(view.GetDealerWinner());
            }
            else
            {
                System.Console.WriteLine(view.GetPlayerWinner());
            }

        }
    }
}
