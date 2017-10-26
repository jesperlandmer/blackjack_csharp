using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    interface IView
    {
        int DisplayHandsCount{ get; set; }
        void accept(visitor.IRulesVisitor v_rules);
        PlayerAction GetMenuOption();
        void DisplayWelcomeMessage();
        void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayGameOver(bool a_dealerIsWinner);
        void o_attachObserver(observer.Observer o_event);
    }
}
