
using System.Collections.Generic;

namespace BlackJack.model.observer
{
    interface IObserver
    {
        void Update(List<Card> m_hand);
    }
}
