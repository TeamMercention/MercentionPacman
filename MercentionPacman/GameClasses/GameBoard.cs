using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercentionPacman.GameClasses
{
    class GameBoard
    {
        // Game Board-ът ще е матрица от char-ове, които представляват нивото на Pacman

        // char[,] GameBoard

        public GameBoard()
        {
            // GameBoard = new char[height, width];
            // Изграждане на нивото
        }

        public void ChangeElement(int height, int width, BoardElements newElement)
        {
            // switch (newElement)
            // case Wall:
            // GameBoard[height, width] = '#';

            // case Dot:
            // GameBoard[height, width] = '.';
            // ...
        }
    }

    enum BoardElements
    {
        Wall,
        Dot,
        Empty,
        Pacman,
        Monster
    }
}
