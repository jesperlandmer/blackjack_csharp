using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class InternationalNewGameStrategy : INewGameStrategy
    {

        public bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player)
        {
            givePlayerCard(a_deck, a_player, true);
            giveDealerCard(a_deck, a_dealer, true);
            givePlayerCard(a_deck, a_player, true);

            return true;
        }

        public void givePlayerCard(Deck a_deck, Player a_player, bool doShow)
        {
            Card c;
            c = a_deck.GetCard();
            c.Show(doShow);
            a_player.DealCard(c);
        }

        public void giveDealerCard(Deck a_deck, Dealer a_dealer, bool doShow)
        {
            Card c;
            c = a_deck.GetCard();
            c.Show(doShow);
            a_dealer.DealCard(c);
        }
    }
}
