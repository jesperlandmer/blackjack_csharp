using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace BlackJack.model.observer
{
    class PlayerObservable
    {
        public List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void DeleteObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObserver()
        {
            foreach (IObserver o in _observers)
            {
                o.Update();
            }
        }
    }
}
