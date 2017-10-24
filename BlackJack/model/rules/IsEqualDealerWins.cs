using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class IsEqualDealerWins : IDecideWinner
    {
      public bool IsWinner()
        {
            return true;
        }
    }
}