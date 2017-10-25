using System.Diagnostics;

namespace BlackJack.view
{
    abstract class Observable
    {
        protected Observer o_observer;

        public void o_attachObserver(Observer observer)
        {
            o_observer = observer;
        }

        public void o_eventHandler(string eventName, int eventValue)
        {
            o_observer.o_eventHandler(eventName, eventValue);
        }
    }
}
