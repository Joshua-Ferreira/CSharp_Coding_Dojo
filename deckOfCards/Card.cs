using System;

namespace deckOfCards
{

    class Card
    {
        public int val { get; }
        public string suit { get; }
        public string card_name { get; }
        //replaces string val

        public Card(int val, string suit)
        {
            this.suit = suit;
            this.val = val;
            if (val == 1)
            {
                card_name = "Ace";
            }
            else if (val > 1 && val < 11)
            {
                card_name = val.ToString();
            }
            else if (val == 11)
            {
                card_name = "Jack";
            }
            else if (val == 12)
            {
                card_name = "Queen";
            }
            else
            {
                card_name = "King";
            }
        }

    }
}