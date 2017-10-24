using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    interface IGameRules
    {
        int MaxScore();
        bool IsWinner(Deck deck, bool hitRule);
        bool isEqualDealerWins(Player player, Dealer dealer);
    }
}
