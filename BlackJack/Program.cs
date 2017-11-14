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
            model.Game g = new model.Game();
            view.IView v = new view.ConsoleView(); // new view.ConsoleView("S");
            v.o_attachObserver(new view.DisplayCardEvent());

            controller.PlayGame ctrl = new controller.PlayGame();

            while (ctrl.Play(g, v));
        }
    }
}
