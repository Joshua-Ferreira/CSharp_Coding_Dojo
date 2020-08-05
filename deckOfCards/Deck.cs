using System;
using System.Collections.Generic;

namespace deckOfCards
{
    class Deck
    {
        private List<Card> cards = new List<Card>();
        public List<Card> Cards { get { return cards; } }

        public Deck()
        {

            string[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };
            for (int s = 0; s < 4; s++)
            {
                for (int x = 1; x < 14; x++)
                {
                    cards.Add(new Card(x, suits[s]));
                }
            }
        }

        public Card Deal()
        {
            Card holder = cards[0];
            cards.RemoveAt(0);
            return holder;
        }

        public void Reset()
        {
            cards = new Deck().cards;
        }

        public void Shuffle(int shuffs)
        {
            Random rand = new Random();
            for (int x = 0; x <= shuffs; x++)
            {
                int marker1 = rand.Next(0, cards.Count);
                int marker2 = rand.Next(0, cards.Count);
                Card holder = cards[marker1];
                cards[marker1] = cards[marker2];
                cards[marker2] = holder;
            }
        }
    }
}