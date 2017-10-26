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

        public bool IsDealerWinner(Player player, Dealer dealer)
        {
            if (IsBusted(player.CalcScore()))
            {
                return true;
            }
            else if (IsBusted(dealer.CalcScore()))
            {
                return false;
            }
            else if (DealerScoresHigher(player.CalcScore(), dealer.CalcScore())
             | EqualScore(player.CalcScore(), dealer.CalcScore()))
            {
                return true;
            }

            return false;
        }

        public bool IsBusted(int score)
        {
            return score > MaxScore();
        }

        public bool DealerScoresHigher(int playerScore, int dealerScore)
        {
            return dealerScore > playerScore;
        }

        public bool EqualScore(int playerScore, int dealerScore)
        {
            return playerScore == dealerScore;
        }

    }
}