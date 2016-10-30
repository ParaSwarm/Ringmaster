using System.Collections.Generic;

namespace Ringmaster.Models
{
    public class Game
    {
        public bool Active { get; set; }

        private List<Player> Players { get; set; }

        public void AddPlayer(string hostName)
        {
            Players.Add(new Player(hostName));
        }
    }
}
