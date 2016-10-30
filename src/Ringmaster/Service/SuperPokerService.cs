using System.Collections.Generic;
using Ringmaster.Models;
using System.Linq;

namespace Ringmaster.Service
{
    public class SuperPokerService
    {
        private static List<Game> Games { get; set; }

        public void AddPlayer(string hostName)
        {
            var game = this.GetCurrentGame();

            game.AddPlayer(hostName);
        }

        public SuperPokerDeck GameStart()
        {
            // Return deck when all players are ready

            return this.GetCurrentGame().GetGameDeck();
        }

        private Game GetCurrentGame()
        {
            lock (Games)
            {
                var currentGame = Games.FirstOrDefault(game => game.Active);

                if (currentGame == null)
                {
                    currentGame = new Game { Active = true };
                    Games.Add(currentGame);
                }

                return currentGame;
            }
        }
    }
}
