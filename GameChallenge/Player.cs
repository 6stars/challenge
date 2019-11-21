using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GameChallenge
{
    public class Player
    {
        public string Name { get; set; }
        public Dictionary<string, int> TileOverrides { get; set; }

        public int xPosition = 0;
        public int yPosition = 0;
        public List<Move> Moves { get; set; }

    }
}