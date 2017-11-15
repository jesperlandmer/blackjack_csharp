using System.Collections.Generic;
using System.Diagnostics;

namespace BlackJack.model.observer
{
    class PlayerObserver
    {
        private IObserver _observer;

        public void AddObserver(IObserver observer)
        {
            _observer = observer;
        }
        public void DeleteObserver(IObserver observer)
        {
            _observer = default(IObserver);
        }
        public void NotifyObserver()
        {
            _observer.Update();
        }
    }
}
