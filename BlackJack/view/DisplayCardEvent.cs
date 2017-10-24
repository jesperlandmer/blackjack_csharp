
using System.Diagnostics;

namespace BlackJack.view
{
    class DisplayCardEvent : Observer
    {
        private Stopwatch _stopwatch = Stopwatch.StartNew();

        public override void EventHandler(string eventName)
        {
            if (eventName == controller.PlayGame.NEW_CARD)
            {
                System.Threading.Thread.Sleep(1000);
                _stopwatch.Stop();
            }
        }
    }
}
