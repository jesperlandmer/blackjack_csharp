using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    interface INewGameStrategy
    {
        bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player);
        void givePlayerCard(Card card, Player a_player, bool doShow);
        void giveDealerCard(Card card, Dealer a_dealer, bool doShow);
    }
}
