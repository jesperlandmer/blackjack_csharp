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
      givePlayerCard(a_deck.GetCard(), a_player, true);
      giveDealerCard(a_deck.GetCard(), a_dealer, true);
      givePlayerCard(a_deck.GetCard(), a_player, true);

      return true;
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
