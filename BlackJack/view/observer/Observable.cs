using System.Diagnostics;

namespace BlackJack.view.observer
{
    abstract class Observable
    {
        protected Observer o_observer;

        public void o_attachObserver(observer.Observer observer)
        {
            o_observer = observer;
        }

        public void o_eventHandler(string eventName, int eventValue)
        {
            o_observer.o_eventHandler(eventName, eventValue);
        }
    }
}
