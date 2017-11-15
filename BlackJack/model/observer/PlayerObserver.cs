using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace BlackJack.model.observer
{
  class PlayerObserver
  {
    public List<IObserver> _observers = new List<IObserver>();

    public void AddObserver(IObserver observer)
    {
      Console.WriteLine("Observer added");
      _observers.Add(observer);
      Console.WriteLine("How many observers: ");
      Console.WriteLine(_observers.Count);
      Thread.Sleep(5000);
    }
    public void DeleteObserver(IObserver observer)
    {
      _observers.Remove(observer);
    }
    public void NotifyObserver(List<Card> m_hand)
    {
<<<<<<< HEAD
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
=======
      Thread.Sleep(2000);
      Console.WriteLine("Notified");
      Console.WriteLine("How many observers: ");
      Console.WriteLine(_observers.Count);
      foreach (IObserver o in _observers)
      {
        o.Update(m_hand);
        Console.WriteLine("This part never runs since _observers is empty");
        Thread.Sleep(2000);

      }
>>>>>>> f6cb3a8d3d8ae267aba5d7be73ac54bbb0d533ff
    }
  }
}
