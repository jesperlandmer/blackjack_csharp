using System.Diagnostics;

namespace BlackJack.view
{
    abstract class Observable
    {
        protected Observer o_observer;

        public void AttachObserver(Observer observer)
        {
            o_observer = observer;
        }

        public void EventHandler(string eventName, int eventValue)
        {
            o_observer.EventHandler(eventName, eventValue);
        }
    }
}
