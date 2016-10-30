namespace Ringmaster.Models
{
    public class Card
    {
        public Card(CardValue value)
        {
            this.Value = value;
        }

        public CardValue Value { get; set; }
    }
}
