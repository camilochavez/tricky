using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tricky
{
    class Board
    {
        private char[,] places;
        private Players players;

        public Board(int height, int width)
        {
            places = new char[height, width];
            players = new Players();
        }

        public void PrintBoard()
        {
         
            for (int y = 0; y < places.GetLength(0); y++)
            {
                for (int x = 0; x < places.GetLength(0); x++)
                {
                    Console.Write(" _ ");
                }
                Console.WriteLine("");
                for (int x = 0; x < places.GetLength(0); x++)
                {
                    Console.Write("|" + players.ActualPlayer + "|");
                    players.NextPlayer();
                }
                Console.WriteLine("");
            }
        }
    }
}
