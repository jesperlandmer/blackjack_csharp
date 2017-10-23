using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class IsEqualRule : IDecideWinner
    {
      public bool CheckWinner()
        {
            return true;
        }
    }
}