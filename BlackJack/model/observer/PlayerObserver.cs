using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BlackJack.model.observer
{
    class PlayerObserver
    {
        private List<IObserver> _observers = new List<IObserver>();
        private List<Card> _hand = new List<Card>();

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
            foreach(IObserver o in _observers)
            {
                o.Update();
            }
        }
    }
}
