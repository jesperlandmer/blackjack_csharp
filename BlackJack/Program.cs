using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            model.rules.IGameFactory Rules = new model.rules.RulesFactory();
            model.Game g = new model.Game(Rules);
            view.IView v = new view.SimpleView(); // new view.SwedishView();
            v.o_attachObserver(new view.DisplayCardEvent());

            controller.PlayGame ctrl = new controller.PlayGame();

            while (ctrl.Play(g, v));
        }
    }
}