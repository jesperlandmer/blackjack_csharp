using System.Diagnostics;

namespace BlackJack.controller
{
    abstract class NewCardObservable
    {
        protected NewCardObserver _observer;

        public void AttachObserver(NewCardObserver observer)
        {
            _observer = observer;
        }

        public void EventHandler(string eventName)
        {
            _observer.EventHandler(eventName);
        }
    }
}
