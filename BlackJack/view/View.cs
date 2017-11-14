using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    class View
    {
        private string _language;

        public View(string language)
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

        public string GetCard(model.Card a_card)
        {
            switch (_language)
            {
                case "S":
                    if (a_card.GetColor() == model.Card.Color.Hidden)
                    {
                        return "Dolt Kort";
                    }
                    else
                    {
                        return String.Format("{0} {1}", GetCardColors()[(int)a_card.GetColor()], GetCardNumbers()[(int)a_card.GetValue()]);
                    }
                default:
                    return String.Format("{0} of {1}", a_card.GetValue(), a_card.GetColor());
            }
        }

        public string GetPlayerHand()
        {
            switch (_language)
            {
                case "S":
                    return "Spelare Har: ";
                default:
                    return "Player Has: ";
            }
        }

        public string GetDealerHand()
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
                    return String.Format("Poäng: {0}", a_score);
                default:
                    return String.Format("Score: {0}", a_score);
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

        public string GetDealerWinner()
        {
            switch (_language)
            {
                case "S":
                    return "Croupiern Vann!";
                default:
                    return "Dealer Won!";
            }
        }

        public string GetGameOver()
        {
            switch (_language)
            {
                case "S":
                    return "Slut: ";
                default:
                    return "GameOver: ";
            }
        }

        private String[] GetCardColors()
        {
            switch (_language)
            {
                case "S":
                    return new String[(int)model.Card.Color.Count]
                        { "Hjärter", "Spader", "Ruter", "Klöver" };
            }

            throw new Exception("No Language Chosen");
        }

        private String[] GetCardNumbers()
        {
            switch (_language)
            {
                case "S":
                    return new String[(int)model.Card.Value.Count]
                        { "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio", "tio", "knekt", "dam", "kung", "ess" };
            }

            throw new Exception("No Language Chosen");
        }
    }
}
