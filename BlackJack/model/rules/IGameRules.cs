using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    interface IGameRules
    {
        int MaxScore();
        bool IsGameOver(Deck deck, bool hitRule);
        bool GetWinner(Player player, Dealer dealer);
    }
}
