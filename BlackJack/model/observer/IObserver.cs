
using System.Collections.Generic;

namespace BlackJack.model.observer
{
    interface IObserver
    {
        void Update(Card a_card);
    }
}
