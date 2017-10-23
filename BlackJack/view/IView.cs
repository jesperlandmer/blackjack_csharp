using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    interface IView
    {
        void DisplayWelcomeMessage();
        bool DoPlay(int input);
        bool DoHit(int input);
        bool DoStand(int input);
        bool DoQuit(int input);
        int GetInput();
        void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayGameOver(bool a_dealerIsWinner);
    }
}
