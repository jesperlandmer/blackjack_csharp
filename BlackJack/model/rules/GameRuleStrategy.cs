using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
  class GameRuleStrategy : IGameRules
  {
    public int MaxScore()
    {
      return 21;
    }
    
    public bool IsGameOver(Deck deck, bool hitRule)
    {
      if (deck != null && hitRule != true)
      {
        return true; //Return the new rule
      }
      return false;
    }

    public bool GetWinner(Player player, Dealer dealer)
    {
      return IsEqualDealerWins(player, dealer);
    }

    private bool IsEqualDealerWins (Player player, Dealer dealer)
    {
      if (player.CalcScore() > MaxScore())
      {
        return true;
      }
      else if (dealer.CalcScore() > MaxScore())
      {
        return false;
      }
      return dealer.CalcScore() >= player.CalcScore();
    }

  }
}