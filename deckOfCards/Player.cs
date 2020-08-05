using System;
using System.Collections.Generic;

namespace deckOfCards
{
    class Player
    {
        public string Name { get; }
        public List<Card> hand = new List<Card>();

        public Player(string name)
        {
            this.Name = name;
        }

        public Card draw(Deck deck)
        {
            Card newCard = deck.Deal();
            hand.Add(newCard);
            // System.Console.WriteLine(newCard.card_name + " " + newCard.suit);
            return newCard;
        }

        public Card discard(int index)
        {
            if (index < hand.Count - 1 && index > -1)
            {
                Card holder = hand[index];
                hand.RemoveAt(index);
                return holder;
            }
            return null;
        }

        public void showHand()
        {
            foreach (Card x in hand)
            {
                System.Console.WriteLine(x.card_name + " " + x.suit);
            }
        }
    }
}