﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercentionPacman.GameClasses
{
    public class GameBoard
    {
        private static string pacmanIcon = "O";
        // ...

        string[,] board =

            {

                    {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"},
                    {"#","*",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","*","#"},
                    {"#",".","#","#","#","#","#","#",".","#","#","#","#","#","#","#",".","#",".","#","#","#","#","#","#","#",".","#","#","#","#","#","#",".","#"},
                    {"#",".","#"," "," "," "," ","#",".","#"," "," "," "," "," ","#",".","#",".","#"," "," "," "," "," ","#",".","#"," "," "," "," ","#",".","#"},
                    {"#",".","#"," "," "," "," ","#",".","#"," "," "," "," "," ","#",".","#",".","#"," "," "," "," "," ","#",".","#"," "," "," "," ","#",".","#"},
                    {"#",".","#","#","#","#","#","#",".","#","#","#","#","#","#","#",".","#",".","#","#","#","#","#","#","#",".","#","#","#","#","#","#",".","#"},
                    {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#"},
                    {"#",".","#","#","#","#","#","#",".","#","#"," ","#","#","#","#","#","#","#","#","#","#","#"," ","#","#",".","#","#","#","#","#","#",".","#"},
                    {"#",".",".",".",".",".",".",".",".","#","#"," "," "," "," "," "," "," "," "," "," "," "," "," ","#","#",".",".",".",".",".",".",".",".","#"},
                    {"#","#","#","#","#","#","#","#",".","#","#"," ","#","#","#","#"," "," "," ","#","#","#","#"," ","#","#",".","#","#","#","#","#","#","#","#"},
                    {" "," "," "," "," "," "," ","#",".","#","#"," ","#"," "," "," "," "," "," "," "," "," ","#"," ","#","#",".","#"," "," "," "," "," "," "," "},
                    {" "," "," "," "," "," "," ","#",".","#","#"," ","#"," "," "," "," "," "," "," "," "," ","#"," ","#","#",".","#"," "," "," "," "," "," "," "},
                    {"#","#","#","#","#","#","#","#","."," "," "," ","#"," "," "," "," "," "," "," "," "," ","#"," "," "," ",".","#","#","#","#","#","#","#","#"},
                    {"#",".",".",".",".",".",".",".",".","#","#"," ","#"," "," "," "," "," "," "," "," "," ","#"," ","#","#",".",".",".",".",".",".",".",".","#"},
                    {"#","#","#","#","#","#","#","#",".","#","#"," ","#"," "," "," "," "," "," "," "," "," ","#"," ","#","#",".","#","#","#","#","#","#","#","#"},
                    {" "," "," "," "," "," "," ","#",".","#","#"," ","#","#","#","#","#","#","#","#","#","#","#"," ","#","#",".","#"," "," "," "," "," "," "," "},
                    {" "," "," "," "," "," "," ","#",".","#","#"," "," "," "," "," "," "," "," "," "," "," "," "," ","#","#",".","#"," "," "," "," "," "," "," "},
                    {"#","#","#","#","#","#","#","#",".","#","#"," ","#","#","#","#","#","#","#","#","#","#","#"," ","#","#",".","#","#","#","#","#","#","#","#"},
                    {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#"},
                    {"#",".","#","#","#","#","#","#",".","#","#","#","#","#","#","#",".","#",".","#","#","#","#","#","#","#",".","#","#","#","#","#","#",".","#"},
                    {"#",".","#","#","#","#","#","#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#","#","#","#","#","#",".","#"},
                    {"#",".",".",".",".",".","#","#",".","#","#",".","#","#","#","#","#","#","#","#","#","#","#",".","#","#",".","#","#",".",".",".",".",".","#"},
                    {"#","#","#","#","#",".","#","#",".","#","#",".","#","#","#","#","#","#","#","#","#","#","#",".","#","#",".","#","#",".","#","#","#","#","#"},
                    {"#",".",".",".",".",".",".",".",".","#","#",".",".",".",".",".",".","#",".",".",".",".",".",".","#","#",".",".",".",".",".",".",".",".","#"},
                    {"#",".","#","#","#","#","#","#","#","#","#","#","#","#","#","#",".","#",".","#","#","#","#","#","#","#","#","#","#","#","#","#","#",".","#"},
                    {"#",".","#","#","#","#","#","#","#","#","#","#","#","#","#","#",".","#",".","#","#","#","#","#","#","#","#","#","#","#","#","#","#",".","#"},
                    {"#","*",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","*","#"},
                    {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"}

            };

        public string[,] GetBoard
        {
            get { return board; }
        }

        public void ChangeElement(int height, int width, BoardElements newElement)
        {
            // switch (newElement)
            // case Wall:
            // GameBoard[height, width] = '#';

            // case Dot:
            // GameBoard[height, width] = '.';
            // ...

            switch (newElement)
            {
                case BoardElements.Pacman:
                    this.board[height, width] = pacmanIcon;
                    break;
                case BoardElements.Empty:
                    this.board[height, width] = " ";
                    break;
            }



        }
    }

    public enum BoardElements
    {
        Wall,
        Dot,
        Star,
        Empty,
        Pacman,
        Monster
    }
}
