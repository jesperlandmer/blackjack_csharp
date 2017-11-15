using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.controller
{
    class PlayGame
    {
        public bool Play(model.Game a_game, view.IView a_view)
        {
            SetListener(a_view);
            a_view.DisplayWelcomeMessage();

            a_view.DisplayDealerHand(a_game.GetDealerHand(), a_game.GetDealerScore());
            a_view.DisplayPlayerHand(a_game.GetPlayerHand(), a_game.GetPlayerScore());

            if (a_game.IsGameOver())
            {
                a_view.DisplayGameOver(a_game.IsDealerWinner());
            }

            view.PlayerAction input = a_view.GetMenuOption();

            if (input == view.PlayerAction.DoPlay)
            {
                a_game.NewGame();
            }
            else if (input == view.PlayerAction.DoHit)
            {
                a_game.Hit();
            }
            else if (input == view.PlayerAction.DoStand)
            {
                a_game.Stand();
            }

            return input != view.PlayerAction.DoQuit;
        }

        public void Update()
        {

        }
        public void SetListener(model.observer.IObserver a_view)
        {
            model.observer.PlayerObserver observer = new model.observer.PlayerObserver();
            observer.AddObserver(a_view);
        }
    }
}
