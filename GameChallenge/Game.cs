using System.Collections.Generic;

namespace GameChallenge
{
    public class Game
    {
        private const string start = "$";
        private const string finish = "@";
        private const string wall = "*";

        public List<Player> Players { get; set; }

        public Dictionary<Player, List<Move>> ScoreCard { get; set; }

        public List<string> Board { get; set; }

        public Game(List<Player> players, List<string> board)
        {
            Players = players;
            Board = board;
        }

        public void Move(Player player, MoveType moveDirection)
        {
            // calculate score for Move


        }

    }
}