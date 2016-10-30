using System;
using System.Collections.Generic;
using Ringmaster.Utility;

namespace Ringmaster.Models
{
    public class Deck
    {
        private List<Card> Cards { get; set; }

        public List<Card> GetCards()
        {
            return this.Cards;
        }

        public static List<Deck> GenerateDecks(int numberOfDecks)
        {
            var decks = new List<Deck>();

            for (var deckCount = 0; deckCount < numberOfDecks; deckCount++)
            {
                var deck = BuildDeck();
                deck.Cards.Shuffle();
                decks.Add(deck);
            }

            return decks;
        }

        private static Deck BuildDeck()
        {
            var deck = new Deck();

            foreach (CardValue cardValue in Enum.GetValues(typeof(CardValue)))
                for (var cardCount = 0; cardCount < 4; cardCount++)
                    deck.Cards.Add(new Card(cardValue));

            return deck;
        }
    }
}
