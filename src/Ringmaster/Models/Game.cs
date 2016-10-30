using System.Collections.Generic;
using System.Linq;

namespace Ringmaster.Models
{
    public class Game
    {
        public Game()
        {
            this.GameDeck = this.BuildGameDeck();
        }

        public bool Active { get; set; }

        private List<Player> Players { get; set; }

        private SuperPokerDeck GameDeck { get; set; }

        public void AddPlayer(string hostName)
        {
            Players.Add(new Player(hostName));
        }

        public SuperPokerDeck GetGameDeck()
        {
            return this.GameDeck;
        }

        private SuperPokerDeck BuildGameDeck()
        {
            var cards = Deck.GenerateDecks(1).First().GetCards();

            return new SuperPokerDeck(cards[0], cards[1], cards[2], cards[3]);
        }
    }
}
