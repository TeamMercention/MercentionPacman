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

        // public char CurrentDirection { get; set; }
        // Текуща посока

        private string symbol = ((char)67).ToString();
        private ConsoleColor color = ConsoleColor.Yellow;
        public string Direction = "right";
        public string NextDirection = "right";

        // public char NextDirection { get; set; }
        // Следваща посока (ако има натиснат различен бутон от клавиатурата)

        private int score;
        private int lives;
        private int level;

        public int GetScore()
        {
            return this.score;
        }
        public int Lives()
        {
            return this.lives;
        }
        public int GetLevel()
        {
            return this.level;
        }
        public PacMan()
        {
            this.pacManPos = new Position(17, 20);
            this.score = 0;
            this.lives = 3;
            this.level = 1;

            // Създаване на нов PacMan със стойности по подразбиране
        }

        public void ResetPacMan()
        {
            this.pacManPos.X = 17;
            this.pacManPos.Y = 20;
            this.Direction = "right";
            this.NextDirection = "right";
        }
        public void LoseLife()
        {
            this.lives--;
        }

        public void EarnPoint()
        {
            this.score++;
        }
        public void EarnStar()
        {
            this.score += 100;
        }
        public void LevelUp()
        {
            this.level++;
            this.score = 0;
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

        public BoardElements CheckCell(string[,] border, string direction, Monster[] monsterList)
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
                        //case "☻":
                        //  return BoardElements.Monster;
                        default:
                            if (checkIfMonsterAppears(monsterList, this.pacManPos.Y - 1, this.pacManPos.X))
                            {
                                return BoardElements.Monster;
                            }
                            else
                            {
                                return BoardElements.Empty;
                            }
                    }

                //return BoardElements.Empty;
                case "right":
                    switch (border[this.pacManPos.Y, this.pacManPos.X + 1])
                    {
                        case "#":
                            return BoardElements.Wall;
                        case ".":
                            return BoardElements.Dot;
                        case "*":
                            return BoardElements.Star;
                        default:
                            if (checkIfMonsterAppears(monsterList, this.pacManPos.Y, this.pacManPos.X + 1))
                            {
                                return BoardElements.Monster;
                            }
                            else
                            {
                                return BoardElements.Empty;
                            }
                    }

                //return BoardElements.Empty;
                case "down":
                    switch (border[this.pacManPos.Y + 1, this.pacManPos.X])
                    {
                        case "#":
                            return BoardElements.Wall;
                        case ".":
                            return BoardElements.Dot;
                        case "*":
                            return BoardElements.Star;
                        default:
                            if (checkIfMonsterAppears(monsterList, this.pacManPos.Y + 1, this.pacManPos.X))
                            {
                                return BoardElements.Monster;
                            }
                            else
                            {
                                return BoardElements.Empty;
                            }
                    }

                //return BoardElements.Empty;
                case "left":
                    switch (border[this.pacManPos.Y, this.pacManPos.X - 1])
                    {
                        case "#":
                            return BoardElements.Wall;
                        case ".":
                            return BoardElements.Dot;
                        case "*":
                            return BoardElements.Star;
                        default:
                            if (checkIfMonsterAppears(monsterList, this.pacManPos.Y, this.pacManPos.X - 1))
                            {
                                return BoardElements.Monster;
                            }
                            else
                            {
                                return BoardElements.Empty;
                            }
                    }

                //return BoardElements.Empty;
                default:
                    if (checkIfMonsterAppears(monsterList, pacManPos.Y, pacManPos.X))
                    {
                        return BoardElements.Monster;
                    }
                    else
                    {
                        return BoardElements.Empty;
                    }
            }
            //return BoardElements.Empty;
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

        public bool checkIfMonsterAppears(Monster[] monsterList, int pacManPosY, int pacManPosX)
        {
            foreach (var monster in monsterList)
            {
                if (monster.GetPosX() == pacManPosX && monster.GetPosY() == pacManPosY)
                {
                    return true;
                }

            }

            return false;
        }

    }
}


