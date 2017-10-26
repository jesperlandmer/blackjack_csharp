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
            model.rules.IGameFactory m_rules = new model.rules.RulesFactory();

            model.Game g = new model.Game(m_rules);
            view.IView v = new view.SimpleView(m_rules); // new view.SwedishView(m_rules);
            view.visitor.RulesWriterVisitor r = new view.visitor.RulesWriterVisitor();

            v.o_attachObserver(new view.events.DisplayCardEvent());

            controller.PlayGame ctrl = new controller.PlayGame();

            while (ctrl.Play(g, v, r));
        }
    }
}