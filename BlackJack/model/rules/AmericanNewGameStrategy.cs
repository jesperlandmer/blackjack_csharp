using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class AmericanNewGameStrategy : INewGameStrategy
    {
        public bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player)
        {
            
            givePlayerCard(a_deck, a_player, true);
            giveDealerCard(a_deck, a_dealer, true);
            givePlayerCard(a_deck, a_player, true);
            giveDealerCard(a_deck, a_dealer, false);

            return true;
        }
        private void givePlayerCard(Deck a_deck, Player a_player, bool show)
        {
            Card c;
            c = a_deck.GetCard();
            c.Show(show);
            a_player.DealCard(c);
        }

        private void giveDealerCard(Deck a_deck, Dealer a_dealer, bool show)
        {
            Card c;
            c = a_deck.GetCard();
            c.Show(true);
            a_dealer.DealCard(c);
        }
    }
}
