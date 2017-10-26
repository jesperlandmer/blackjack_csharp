using System;

namespace BlackJack.view.visitor
{
    class RulesWriterVisitor : IRulesVisitor
    {
        private int _tabCount = 0;
        private static int playerScore = 0;
        private static int dealerScore = 1;
        public void visitRules(model.rules.IGameFactory m_rules)
        {
            model.rules.IGameRules GameRules = m_rules.GetWinnerRule();

            if (_tabCount < 1)
            {
                Console.WriteLine("Rules:");
                Console.WriteLine("If a player exceeds {0} points, you lose", GameRules.MaxScore());
                Console.WriteLine("If the dealer has higher points than the player, then Dealer Wins = {0}",
                                    GameRules.DealerScoresHigher(playerScore, dealerScore));
                Console.WriteLine("If the dealer and the player has equal score, then Dealer Wins = {0}\n",
                                    GameRules.EqualScore(playerScore, playerScore));
                _tabCount++;
            }
        }
    }
}
