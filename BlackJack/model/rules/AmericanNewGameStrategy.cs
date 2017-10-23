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
            // a_player.DealCard(givecard(a_deck.GetCard(), true));

            // a_dealer.DealCard(givecard(a_deck.GetCard(), true))
            givePlayerCard(a_deck.GetCard(), a_player, true);
            giveDealerCard(a_deck.GetCard(), a_dealer, true);
            givePlayerCard(a_deck.GetCard(), a_player, true);
            giveDealerCard(a_deck.GetCard(), a_dealer, false);

            return true;
        }
        public Card givecard(Card card, bool doShow)
        {
            card.Show(doShow);
            return card;
        }
        public void givePlayerCard(Card card, Player a_player, bool doShow)
        {
            card.Show(doShow);
            a_player.DealCard(card);
        }

        public void giveDealerCard(Card card, Dealer a_dealer, bool doShow)
        {
            card.Show(doShow);
            a_dealer.DealCard(card);
        }
    }
}
