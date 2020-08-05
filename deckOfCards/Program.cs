using System;

namespace deckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            newDeck.Shuffle(1000);
            for (int i = 0; i < newDeck.Cards.Count; i++)
            {
                System.Console.WriteLine(newDeck.Cards[i].card_name + " " + newDeck.Cards[i].suit);
            }
            System.Console.WriteLine(" ");
            Card test = newDeck.Deal();
            System.Console.WriteLine(test.card_name + " " + test.suit);

            System.Console.WriteLine(" ");
            Player me = new Player("Josh");
            Console.WriteLine(me.Name);
            me.draw(newDeck);
            me.draw(newDeck);
            me.draw(newDeck);
            me.draw(newDeck);
            me.draw(newDeck);
            me.showHand();

            System.Console.WriteLine(" ");
            me.discard(3);
            me.discard(0);
            me.discard(0);
            me.showHand();
            System.Console.WriteLine(" ");
            newDeck.Reset();
            for (int i = 0; i < newDeck.Cards.Count; i++)
            {
                System.Console.WriteLine(newDeck.Cards[i].card_name + " " + newDeck.Cards[i].suit);
            }
        }


    }
}
