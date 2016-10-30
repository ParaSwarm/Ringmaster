using System.Collections.Generic;

namespace Ringmaster.Models
{
    public class SuperPokerDeck
    {
        public SuperPokerDeck(Card card1, Card card2, Card card3, Card card4)
        {
            this.Cards = new List<Card>
            {
                card1,
                card2,
                card3,
                card4
            };
        }

        public List<Card> Cards { get; set; }
    }
}
