
using System.Diagnostics;

namespace BlackJack.view
{
    class DisplayCardEvent : Observer
    {
        public const string NEW_CARD = "PlayGame::NewCard";

        private Stopwatch _stopwatch = Stopwatch.StartNew();

        public override void o_eventHandler(string eventName, int eventValue)
        {
            if (eventName == NEW_CARD && eventValue == 1)
            {
                System.Threading.Thread.Sleep(1000);
                _stopwatch.Stop();
            }
        }
    }
}
