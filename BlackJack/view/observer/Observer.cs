
namespace BlackJack.view
{
    abstract class Observer
    {
        public abstract void EventHandler(string eventName, int eventValue);
    }
}
