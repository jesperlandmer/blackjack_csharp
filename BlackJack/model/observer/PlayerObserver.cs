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
    }
  }
}
