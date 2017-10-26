using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.controller
{
    class PlayGame
    {
        public bool Play(model.Game a_game, view.IView a_view, view.visitor.IRulesVisitor v_visitorRules)
        {
            a_view.DisplayWelcomeMessage();
            a_view.accept(v_visitorRules);

            a_view.DisplayDealerHand(a_game.GetDealerHand(), a_game.GetDealerScore());
            a_view.DisplayPlayerHand(a_game.GetPlayerHand(), a_game.GetPlayerScore());
            a_view.DisplayHandsCount++;

            if (a_game.IsGameOver())
            {
                a_view.DisplayGameOver(a_game.IsDealerWinner());
                a_view.DisplayHandsCount = 0;
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
    }
}
