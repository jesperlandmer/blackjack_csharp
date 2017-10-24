using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class RulesFactory
    {
        public IHitStrategy GetHitRule()
        {
            return new BasicHitStrategy();
        }

        public INewGameStrategy GetNewGameRule()
        {
            return new AmericanNewGameStrategy();
        }

        //ToDo Change names on the classes to match the specific rule
        public IDecideWinner GetWinnerRule()
        {
            return new IsEqualDealerWins();
        }
    }
}
