using System.Diagnostics;

namespace BlackJack.view
{
  class NewCardObserver : IObserver
    {
        public void PauseEventHandler()
        {
        var stopwatch = Stopwatch.StartNew();
        System.Threading.Thread.Sleep(2000);
        stopwatch.Stop();
        }
    }
}
