using System.Diagnostics;

namespace BlackJack.model.observer
{
    class PlayerObserver : IObserver
    {
        private Stopwatch _stopwatch;

        public PlayerObserver()
        {
            _stopwatch = Stopwatch.StartNew();
        }

        public void Update()
        {
            PauseDealCard();
        }
        private void PauseDealCard()
        {
            System.Threading.Thread.Sleep(1000);
            _stopwatch.Stop();
        }
    }
}
