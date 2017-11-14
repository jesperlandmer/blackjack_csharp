using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    class ConsoleView
    {
        private string _language;

        public ConsoleView(string language)
        {
            _language = language;
        }

        public string GetWelcomeMessage()
        {
            switch (_language)
            {
                case "S":
                    return "Hej Black Jack Världen\n Skriv 'p' för att Spela, 'h' för nytt kort, 's' för att stanna 'q' för att avsluta\n";
                default:
                    return "Hello Black Jack World\n Type 'p' to Play, 'h' to Hit, 's' to Stand or 'q' to Quit\n";
            }
        }

        public string DisplayCard(model.Card a_card)
        {
            return String.Format("{0} of {1}", a_card.GetValue(), a_card.GetColor());
        }

        public string GetPlayerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            switch (_language)
            {
                case "S":
                    return "Spelare Har: ";
                default:
                    return "Player Has: ";
            }
        }

        public string GetDealerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            switch (_language)
            {
                case "S":
                    return "Croupier Har: ";
                default:
                    return "Dealer Has: ";
            }
        }

        public string GetScore(int a_score)
        {
            switch (_language)
            {
                case "S":
                    return String.Format("Score: {0}", a_score);
                default:
                    return String.Format("Poäng: {0}", a_score);
            }
        }

        public string GetPlayerWinner()
        {
            switch (_language)
            {
                case "S":
                    return "Du Vann!";
                default:
                    return "You Won!";
            }
        }

        public string GetDealerWinner(int a_score)
        {
            switch (_language)
            {
                case "S":
                    return "Croupiern Vann!";
                default:
                    return "Dealer Won!";
            }
        }

        public string GetGameOver(bool a_dealerIsWinner)
        {
            switch (_language)
            {
                case "S":
                    return "Slut: ";
                default:
                    return "GameOver: ";
            }
        }
    }
}
