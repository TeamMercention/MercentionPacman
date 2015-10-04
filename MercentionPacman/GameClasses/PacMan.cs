﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercentionPacman.GameClasses
{
    class PacMan
    {
        //public Position PacmanPosition { get; set; }
        // Текуща позиция

        private Position pacManPos;

        // public char CurrentDirection { get; set; }
        // Текуща посока

        private string symbol = ((char)67).ToString();
        private ConsoleColor color = ConsoleColor.Yellow;
        public string Direction = "right";
        public string NextDirection = "right";

        // public char NextDirection { get; set; }
        // Следваща посока (ако има натиснат различен бутон от клавиатурата)

        //public int Lives { get; }
        //public int Score { get; }

        public PacMan()
        {
            this.pacManPos = new Position(17, 20);

            // Създаване на нов PacMan със стойности по подразбиране
        }

        public void ResetPacMan()
        {

        }
        public void LostLife()
        {
            // this.Lives--;
        }

        public void EarnPoint()
        {
            //this.Score++;
        }
        public void EarnStar()
        {
            //this.Score += 100;
        }
        public string GetSymbol()
        {
            return this.symbol;
        }
        public int GetPosX()
        {
            return this.pacManPos.X;
        }
        public int GetPosY()
        {
            return this.pacManPos.Y;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public BoardElements CheckCell(string[,] border, string direction)
        {
            switch (direction)
            {
                case "up":
                    switch (border[this.pacManPos.Y - 1, this.pacManPos.X])
                    {
                        case "#":
                            return BoardElements.Wall;
                        case ".":
                            return BoardElements.Dot;
                        case "*":
                            return BoardElements.Star;
                        case "☻":
                            return BoardElements.Monster;
                    }
                    return BoardElements.Empty;
                case "right":
                    switch (border[this.pacManPos.Y, this.pacManPos.X + 1])
                    {
                        case "#":
                            return BoardElements.Wall;
                        case ".":
                            return BoardElements.Dot;
                        case "*":
                            return BoardElements.Star;
                        case "☻":
                            return BoardElements.Monster;
                    }
                    return BoardElements.Empty;
                case "down":
                    switch (border[this.pacManPos.Y + 1, this.pacManPos.X])
                    {
                        case "#":
                            return BoardElements.Wall;
                        case ".":
                            return BoardElements.Dot;
                        case "*":
                            return BoardElements.Star;
                        case "☻":
                            return BoardElements.Monster;
                    }
                    return BoardElements.Empty;
                case "left":
                    switch (border[this.pacManPos.Y, this.pacManPos.X - 1])
                    {
                        case "#":
                            return BoardElements.Wall;
                        case ".":
                            return BoardElements.Dot;
                        case "*":
                            return BoardElements.Star;
                        case "☻":
                            return BoardElements.Monster;
                    }
                    return BoardElements.Empty;
            }
            return BoardElements.Empty;
        }
        public void MoveUp()
        {
            this.pacManPos.Y -= 1;
        }
        public void MoveDown()
        {
            this.pacManPos.Y += 1;
        }
        public void MoveLeft()
        {
            this.pacManPos.X -= 1;
        }
        public void MoveRight()
        {
            this.pacManPos.X += 1;
        }
    }
}


