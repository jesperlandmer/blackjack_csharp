﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class RulesFactory : IGameFactory
    {
        public IHitStrategy GetHitRule()
        {
            return new BasicHitStrategy();
        }
        public INewGameStrategy GetNewGameRule()
        {
            return new AmericanNewGameStrategy();
        }
        public IGameRules GetWinnerRule()
        {
            return new GameRuleStrategy();
        }
    }
}
