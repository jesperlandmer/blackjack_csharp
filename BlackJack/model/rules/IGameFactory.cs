using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    interface IGameFactory
    {
        IHitStrategy GetHitRule();
        INewGameStrategy GetNewGameRule();
        IGameRules GetWinnerRule();
    }
}
