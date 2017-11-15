using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    class ConsoleView : IView
    {
        private View _view;
        private Stopwatch _stopwatch = Stopwatch.StartNew();

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
            _view = new View(language);
        }
        public void Update(model.Card a_card)
        {
            System.Threading.Thread.Sleep(1500);
            _stopwatch.Stop();
            DisplayCard(a_card);
        }
        public void DisplayWelcomeMessage()
        {
            System.Console.Clear();
            System.Console.WriteLine(_view.GetWelcomeMessage());
        }

        public void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            System.Console.WriteLine(_view.GetPlayerHand());
            DisplayHand(a_hand, a_score);
        }

        public void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            System.Console.WriteLine(_view.GetDealerHand());
            DisplayHand(a_hand, a_score);
        }

        private void DisplayHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            foreach (model.Card c in a_hand)
            {
                DisplayCard(c);
            }

            System.Console.WriteLine(_view.GetScore(a_score));
            System.Console.WriteLine("");
        }

        public void DisplayCard(model.Card a_card)
        {
            System.Console.WriteLine(_view.GetCard(a_card));
        }

        public void DisplayGameOver(bool a_dealerIsWinner)
        {
            System.Console.Write(_view.GetGameOver());

            if (a_dealerIsWinner)
            {
                System.Console.WriteLine(_view.GetDealerWinner());
            }
            else
            {
                System.Console.WriteLine(_view.GetPlayerWinner());
            }

        }
    }
}
