using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BlackJack.controller
{
    class PlayGame : model.observer.IObserver
    {
        private model.Game _game;
        private view.IView _view;
        private Stopwatch _stopwatch = Stopwatch.StartNew();

        public PlayGame(model.Game a_game, view.IView a_view)
        {
            _game = a_game;
            _view = a_view;

            _game.SetObserver(this);
        }

        public bool Play()
        {
            GetPlayBoard();

            if (_game.IsGameOver())
            {
                _view.DisplayGameOver(_game.IsDealerWinner());
            }

            view.PlayerAction input = _view.GetMenuOption();

            if (input == view.PlayerAction.DoPlay)
            {
                _game.NewGame();
            }
            else if (input == view.PlayerAction.DoHit)
            {
                _game.Hit();
            }
            else if (input == view.PlayerAction.DoStand)
            {
                _game.Stand();
            }

            return input != view.PlayerAction.DoQuit;
        }

        public void Update()
        {
            System.Threading.Thread.Sleep(1000);
            _stopwatch.Stop();

            GetPlayBoard();
        }

        private void GetPlayBoard()
        {
            _view.DisplayWelcomeMessage();
            _view.DisplayDealerHand(_game.GetDealerHand(), _game.GetDealerScore());
            _view.DisplayPlayerHand(_game.GetPlayerHand(), _game.GetPlayerScore());
        }
    }
}
