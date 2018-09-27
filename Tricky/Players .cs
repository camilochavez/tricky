using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tricky
{
    class Players
    {
        char playerO;
        char playerX;
        char actualPlayer;

        public Players()
        {
            playerO = 'O';
            playerX = 'X';
            actualPlayer = 'X';
        }

        public char ActualPlayer
        {
            get
            {
                return actualPlayer;
            }
        }
        public void NextPlayer()
        {
            if (actualPlayer == 'X')
            {
                actualPlayer = playerO;
            }
            else
            {
                actualPlayer = playerX;
            }
        }
    }
}
