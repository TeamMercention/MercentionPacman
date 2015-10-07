using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercentionPacman.GameClasses
{
    class Monster
    {
        //69 //28
        private Position monsterPos;
        public int prevPosX;
        public int prevPosY;

        private string symbol = ((char)9787).ToString();
        private ConsoleColor color;
        public string Direction = "up";

        public static string[] possibleDirections =
        {
            "up",
            "down",
            "left",
            "right"
        };
        //private static string direction = possibleDirections[random.Next(0, possibleDirections.Length)];
        public static Random random = new Random();


        public Monster(ConsoleColor color, int x, int y)
        {
            // Създаване на нов Monster със стойности по подразбиране
            this.color = color;
            this.monsterPos = new Position(x, y);
            this.prevPosX = x;
            this.prevPosY = y;
        }

        public bool CheckLeftCell(Monster[] monsterList, int x, int y, string[,] border)
        {
            bool isEmpty = true;
            foreach (var monster in monsterList)
            {
                if (x - 1 == monster.GetPosX() && y == monster.GetPosY())
                {
                    isEmpty = false;
                    break;
                }
            }

            if (border[y, x - 1] == "#")
            {
                isEmpty = false;
            }

            return isEmpty;
        }
        public bool CheckRightCell(Monster[] monsterList, int x, int y, string[,] border)
        {
            bool isEmpty = true;
            foreach (var monster in monsterList)
            {
                if (x + 1 == monster.GetPosX() && y == monster.GetPosY())
                {
                    isEmpty = false;
                    break;
                }
            }

            if (border[y, x + 1] == "#")
            {
                isEmpty = false;
            }


            return isEmpty;
        }
        public bool CheckUpCell(Monster[] monsterList, int x, int y, string[,] border)
        {
            bool isEmpty = true;
            foreach (var monster in monsterList)
            {
                if (x == monster.GetPosX() && y - 1 == monster.GetPosY())
                {
                    isEmpty = false;
                    break;
                }
            }

            if (border[y - 1, x] == "#")
            {
                isEmpty = false;
            }

            return isEmpty;
        }
        public bool CheckDownCell(Monster[] monsterList, int x, int y, string[,] border)
        {
            bool isEmpty = true;
            foreach (var monster in monsterList)
            {
                if (x == monster.GetPosX() && y + 1 == monster.GetPosY())
                {
                    isEmpty = false;
                }
            }

            if (border[y + 1, x] == "#")
            {
                isEmpty = false;
            }

            return isEmpty;
        }
        public string GetSymbol()

        {
            return this.symbol;
        }
        public int GetPosX()
        {
            return this.monsterPos.X;
        
        }
        public int GetPosY()
        {
            return this.monsterPos.Y;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public void EraseMonster()
        {
            Console.SetCursorPosition(prevPosX, prevPosY);
            Console.Write(' ');
        }
        public void MoveRight()
        {
            if (monsterPos.X + 1 < 34)
            {
                prevPosX = monsterPos.X;
                prevPosY = monsterPos.Y;
                monsterPos.X++;
            }
        }
        public void MoveLeft()
        {
            if (monsterPos.X - 1 > 0)
            {
                prevPosX = monsterPos.X;
                prevPosY = monsterPos.Y;
                monsterPos.X--;
            }
        }
        public void MoveDown()
        {
            if (monsterPos.Y + 1 < 28)
            {
                prevPosX = monsterPos.X;
                prevPosY = monsterPos.Y;
                monsterPos.Y++;
            }
        }
        public void MoveUp()
        {
            if (monsterPos.Y - 1 > 0)
            {
                prevPosX = monsterPos.X;
                prevPosY = monsterPos.Y;
                monsterPos.Y--;
            }
        }

    }
}
