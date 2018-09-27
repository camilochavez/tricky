using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tricky
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(3, 3);
            board.PrintBoard();
            Console.ReadKey();
        }
    }
}
