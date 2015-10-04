using System;
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
        public int prevPosX;
        public int prevPosY;
        // public char CurrentDirection { get; set; }
        // Текуща посока
        private string symbol = ((char)67).ToString();
        private ConsoleColor color;
        public string Direction = "right";
        public string NextDirection = "right";
        // public char NextDirection { get; set; }
        // Следваща посока (ако има натиснат различен бутон от клавиатурата)

        //public int Lives { get; }
        //public int Score { get; }

        public PacMan(ConsoleColor color, int x, int y)
        {
            this.color = color;
            this.pacManPos = new Position(x, y);
            this.prevPosX = x;
            this.prevPosY = y;
            // Създаване на нов PacMan със стойности по подразбиране
        }

        public void LostLife()
        {
            // this.Lives--;
        }

        public void EarnPoint()
        {
            //this.Score++;
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

        public BoardElements CheckRightCell(string[,] border)
        {
          
            switch (border[this.pacManPos.Y, this.pacManPos.X + 1])
            {
                case "#":
                    return BoardElements.Wall;
                    break;
                case ".":
                    return BoardElements.Dot;
                    break;
                    
               case "☻":
                    return BoardElements.Monster;
                    break;
            }
            return BoardElements.Empty;
        }
        public BoardElements CheckLeftCell(string[,] border)
        {
            switch (border[this.pacManPos.Y, this.pacManPos.X - 1])
            {
                case "#":
                    return BoardElements.Wall;
                    break;
                case ".":
                    return BoardElements.Dot;
                    break;
                    
               case "☻":
                    return BoardElements.Monster;
                    break;
            }
            return BoardElements.Empty;
        }
        public BoardElements CheckUpperCell(string[,] border)
        {
            switch (border[this.pacManPos.Y - 1, this.pacManPos.X])
            {
               case "#":
                    return BoardElements.Wall;
                    break;
                case ".":
                    return BoardElements.Dot;
                    break;
                    
               case "☻":
                    return BoardElements.Monster;
                    break;
            }
            return BoardElements.Empty;
        }
        public BoardElements CheckLowerCell(string[,] border)
        {
            switch (border[this.pacManPos.Y + 1, this.pacManPos.X])
            {
              case "#":
                    return BoardElements.Wall;
                    break;
                case ".":
                    return BoardElements.Dot;
                    break;
                    
               case "☻":
                    return BoardElements.Monster;
                    break;
            }
            return BoardElements.Empty;
        }
        public void MoveUp()
        {

        }
        public void MoveDown()
        {

        }
        public void MoveLeft()
        {

        }
        public void MoveRight()
        {

        }
    }
}


