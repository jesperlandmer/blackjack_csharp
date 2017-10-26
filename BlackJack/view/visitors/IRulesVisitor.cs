namespace BlackJack.view.visitor
{
    interface IRulesVisitor
    {
        void visitRules(model.rules.IGameFactory m_rules);
    }
}
