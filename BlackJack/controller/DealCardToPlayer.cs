
using System.Diagnostics;

namespace BlackJack.controller
{
    class DealCardToPlayer : NewCardObserver
    {
        private Stopwatch _stopwatch = Stopwatch.StartNew();

        public override void EventHandler(string eventName)
        {
            if (eventName == PlayGame.NEW_CARD)
            {
                System.Threading.Thread.Sleep(1000);
                _stopwatch.Stop();
            }
        }
    }
}
