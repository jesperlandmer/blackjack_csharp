namespace BlackJack.model.rules
{
    interface IGameRules
    {
        int MaxScore();
        bool IsGameOver(Deck deck, bool hitRule);
        bool IsDealerWinner(Player player, Dealer dealer);
        bool IsBusted(int score);
        bool DealerScoresHigher(int playerScore, int dealerScore);
        bool EqualScore(int playerScore, int dealerScore);
    }
}
