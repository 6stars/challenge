using System;
using System.Collections.Generic;
using System.Text;
using GameChallenge;
using Xunit;

namespace UnitTest.GameTests
{
    public class GameTests
    {
        [Fact]
        public static void TestMove()
        {
            var players = new List<Player>();
            var player1 = new Player
            {
                Name = "player1",
                TileOverrides = new Dictionary<string, int>()
                {
                    {"A", 1},
                    {"T", 2},
                    {"L", 6},
                    {"J", 7},
                    {"M", 5},
                    {"U", 7}
                }

            };
            players.Add(player1);


            var game = new Game(players, new List<string>());

            game.Move(player1, MoveType.Right);

            // assert scorecard change and move cost for player


        }
    }
}
