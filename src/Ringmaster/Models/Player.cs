namespace Ringmaster.Models
{
    public class Player
    {
        public Player(string hostName)
        {
            this.HostName = hostName;
        }

        public string HostName { get; set; }
    }
}
