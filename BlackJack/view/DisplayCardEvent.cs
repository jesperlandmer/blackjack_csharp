
using System.Diagnostics;

namespace BlackJack.view
{
    class DisplayCardEvent : Observer
    {
        private Stopwatch _stopwatch = Stopwatch.StartNew();

        public override void EventHandler(string eventName, int eventValue)
        {
            if (eventName == controller.PlayGame.NEW_CARD && eventValue == 1)
            {
                System.Threading.Thread.Sleep(1000);
                _stopwatch.Stop();
            }
        }
    }
}
