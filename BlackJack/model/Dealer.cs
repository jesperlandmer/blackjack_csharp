using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model
{
  class Dealer : Player
  {
    private Deck m_deck = null;
    
    private rules.INewGameStrategy m_newGameRule;
    private rules.IHitStrategy m_hitRule;
    private rules.IGameRules m_basicRule;


    public Dealer(rules.IGameFactory a_rulesFactory)
    {
      m_newGameRule = a_rulesFactory.GetNewGameRule();
      m_hitRule = a_rulesFactory.GetHitRule();
      m_basicRule = a_rulesFactory.GetWinnerRule();
    }

    public bool NewGame(Player a_player)
    {
      if (m_deck == null || IsGameOver())
      {
        m_deck = new Deck();
        ClearHand();
        a_player.ClearHand();
        return m_newGameRule.NewGame(m_deck, this, a_player);
      }
      return false;
    }

    public bool Hit(Player a_player)
    {
      if (m_deck != null && a_player.CalcScore() < m_basicRule.MaxScore() && !IsGameOver())
      {
        Card c;
        c = m_deck.GetCard();
        c.Show(true);
        a_player.DealCard(c);

        return true;
      }
      return false;
    }

    public bool Stand()
    {
      if (m_deck != null)
      {
        Card c;
        this.ShowHand();

        do
        {
          c = m_deck.GetCard();
          c.Show(true);
          this.DealCard(c);
        }
        while (m_hitRule.DoHit(this) == true)
        ;

        return true;
      }
      return false;
    }

    public bool IsDealerWinner(Player a_player)
    {
      return m_basicRule.IsDealerWinner(a_player, this);
    }

    public bool IsGameOver()
    {
      return m_basicRule.IsGameOver(m_deck, m_hitRule.DoHit(this));
    }
  }
}
