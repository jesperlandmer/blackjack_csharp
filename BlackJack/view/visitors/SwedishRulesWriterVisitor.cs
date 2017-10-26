using System;

namespace BlackJack.view.visitor
{
    class SwedishRulesWriterVisitor : IRulesVisitor
    {
        private int _tabCount = 0;
        private static int playerScore = 0;
        private static int dealerScore = 1;
        public void visitRules(model.rules.IGameFactory m_rules)
        {
            model.rules.IGameRules GameRules = m_rules.GetWinnerRule();

            if (_tabCount < 1)
            {
                Console.WriteLine("Regler:");
                Console.WriteLine("Om en spelare får över {0} poäng, förlorar man", GameRules.MaxScore());
                Console.WriteLine("Om en spelare har högre poäng än dealern, så är dealern vinnare = {0}",
                                    GameRules.DealerScoresHigher(playerScore, dealerScore));
                Console.WriteLine("Om en spelare och en dealer har samma poäng, så är dealern vinnare = {0}\n",
                                    GameRules.EqualScore(playerScore, playerScore));
                _tabCount++;
            }
        }
    }
}
