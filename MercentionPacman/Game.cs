using MercentionPacman.GameClasses;
using System;
using System.Threading;
namespace MercentionPacman
{
    class Game
    {
        // Global Declarations

        static Random random = new Random();

        // Player
        // Pacman pacman = new Pacman();
        // ...

        // Monsters
        // List<Monster> monsterList = new List<Monster>();
        // ...
        static Monster[] monsterList =
        {
            new Monster(ConsoleColor.Red,33,12),
            new Monster(ConsoleColor.Cyan,34,12),
            new Monster(ConsoleColor.Magenta,35,12),
            new Monster(ConsoleColor.DarkCyan,36,12),

        };

        // Game Board
        static bool[,] border = new bool[28, 69];

        static GameBoard board = new GameBoard();


        // Console Settings
        const int GameWidth = 75;
        const int GameHeight = 30;

        static int pos = 17;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Title = "Mercention Pacman";
            Console.WindowWidth = GameWidth;
            Console.BufferWidth = GameWidth;
            Console.WindowHeight = GameHeight;
            Console.BufferHeight = GameHeight;
            border = SetBordersByCol(border);
            border = SetBordersByRow(border);
            RedrawBoard();

            // Load GUI
            // Ще определя позицията 
            // Към GameBoard ще се добавя отстрани и информация за точките до момента и животите, които остават.

            // Load Player
            // Задава позиция на Pacman. Променя тази позиция на GameBoard-а с иконката на Pacman.

            // Load Monsters
            // Като горното, само че за Monster-и
            LoadMonsters();

            // Game logic
            // Този цикъл ще се изпълнява постоянно, докато играчът не натисне ESC
            while (true)
            {

                Console.OutputEncoding = System.Text.Encoding.Unicode;
                // Read User Key
                // Проверява дали има натиснат бутон от клавиатурата 
                // Ако има - добавя го в pacman.NextDirection
                // ESC = изход, P = пауза

                // Player Movement
                // Проверява дали е възможно да се премести в зададената посока (дали има стена).
                // Извършва преместването на pacman.
                // Ако pacman.NextDirection != pacman.CurrentDirection
                // го премества в новата посока - променя PacmanPosition
                // Записва промените в GameBoard-a

                board.ChangeElement(20, pos, BoardElements.Pacman);
                board.ChangeElement(20, pos - 1, BoardElements.Empty);
                RedrawBoard();
                pos++;
                if (pos > 25)
                {
                    break;
                }
                // Monster Ai
                // Ако Monster-а срещне стигне до стена, избира случайна посока със Random
                // Ако pacman е наблизо може да започне да го гони и т.н.
                // Ако позицията на Pacman и някой Monster съвпадне - загуба на живот
                // и позициите на Pacman и Monster-ите се ресетва.
                // Ако има 0 животи - return false (за да спре цикъла) и Game Over
                for (int i = 0; i < monsterList.Length; i++)
                {
                    if (random.Next(0, 2) != 0)
                    {
                        monsterList[i].Direction = Monster.possibleDirections[random.Next(0, Monster.possibleDirections.Length)];
                    }
                    switch (monsterList[i].Direction)
                    {
                        case "left":
                            if (monsterList[i].CheckLeftCell(monsterList, monsterList[i].GetPosX(), monsterList[i].GetPosY(), border))
                            {
                                monsterList[i].MoveLeft();
                                MoveMonster();
                            }
                            break;
                        case "right":
                            if (monsterList[i].CheckRightCell(monsterList, monsterList[i].GetPosX(), monsterList[i].GetPosY(), border))
                            {
                                monsterList[i].MoveRight();
                                MoveMonster();
                            }
                            break;
                        case "up":
                            if (monsterList[i].CheckUpCell(monsterList, monsterList[i].GetPosX(), monsterList[i].GetPosY(), border))
                            {
                                monsterList[i].MoveUp();
                                MoveMonster();
                            }
                            break;
                        case "down":
                            if (monsterList[i].CheckDownCell(monsterList, monsterList[i].GetPosX(), monsterList[i].GetPosY(), border))
                            {
                                monsterList[i].MoveDown();
                                MoveMonster();
                            }
                            break;
                            //default: break;
                    }
                }
                // Redraw Board
                // Ще изобразява всички настъпили промени в board-а от по-горните методи на екрана.
                // Към него ще се изпълнява пак LoadGUI(), за да добави отстрани точките и животите.
                //break;
                Thread.Sleep(50); // Определя скоростта на играта, ще го променяме ако трябва
            }

            GameOver();
        }

        static void LoadGUI()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(5, 0);
            Console.Write("Score: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(20, 0);
            Console.Write("Lives: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        static void LoadPlayer()
        {

        }

        static void LoadMonsters()
        {
            foreach (var monster in monsterList)
            {
                Console.ForegroundColor = monster.GetColor();
                Console.SetCursorPosition(monster.GetPosX(), monster.GetPosY());
                Console.Write(monster.GetSymbol());
            }

        }
        static void MoveMonster()
        {
            foreach (var monster in monsterList)
            {
                Console.ForegroundColor = monster.GetColor();
                Console.SetCursorPosition(monster.GetPosX(), monster.GetPosY());
                Console.Write(monster.GetSymbol());
                Console.SetCursorPosition(monster.prevPosX, monster.prevPosY);
                Console.Write(' ');
            }

        }

        static void ReadUserKey()
        {

        }

        static void PlayerMovement()
        {

        }

        static void MonsterAi()
        {

        }

        static void RedrawBoard()
        {
            LoadGUI();

            for (int i = 0; i < board.GetBoard.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetBoard.GetLength(1); j++)
                {
                    Console.Write("{0,2}", board.GetBoard[i, j]);
                }
                Console.WriteLine();
            }

        }


        static void GameOver()
        {

        }

        static void WinGame()
        {

        }
        static bool[,] SetBordersByRow(bool[,] border)
        {
            for (int i = 2; i < border.GetLength(0); i++)
            {
                for (int j = 2; j < border.GetLength(1) - 1; j++)
                {
                    switch (i)
                    {
                        case 2:
                        case 19:
                        case 27:
                            if ((j < 35) || (j > 35))
                            {
                                border[i, j] = true;
                            }
                            break;
                        case 7:
                            border[i, j] = true;
                            break;
                        case 9:
                            if ((j < 5) || (j > 15 && j < 55) || (j > 57))
                            {
                                border[i, j] = true;
                            }
                            break;
                        case 11:
                        case 12:
                        case 13:
                        case 15:
                            if (j > 21 && j < 49)
                            {
                                border[i, j] = true;
                            }
                            break;
                        case 14:
                            if ((j < 21) || (j > 49))
                            {
                                border[i, j] = true;
                            }
                            break;
                        case 17:
                            if ((j > 15 && j < 55))
                            {
                                border[i, j] = true;
                            }
                            break;
                        case 21:
                            if (j > 15 && j < 55)
                            {
                                border[i, j] = true;
                            }
                            break;
                        case 24:
                            if ((j < 19) || (j > 21 && j < 35) || (j > 35 && j < 49) ||
                              (j > 51))
                            {
                                border[i, j] = true; ;
                            }
                            break;
                    }
                }

            }
            return border;
        }
        static bool[,] SetBordersByCol(bool[,] border)
        {
            for (int j = 2; j < border.GetLength(1); j++)
            {
                for (int i = 2; i < border.GetLength(0) - 1; i++)
                {
                    switch (i)
                    {

                        case 16:
                        case 17:
                        case 18:
                        case 52:
                        case 53:
                        case 54:
                            if ((i < 26) && i == 28)
                            {
                                border[i, j] = true;
                            }
                            break;
                        case 2:
                        case 3:
                        case 4:
                        case 68:
                        case 67:
                        case 66:
                            if (i < 10 || (j > 18 && j < 23) || j > 23)
                            {
                                border[i, j] = true;
                            }
                            break;
                        case 22:
                        case 23:
                        case 24:
                        case 46:
                        case 47:
                        case 48:
                            if ((i > 6 && i < 20) || (i > 20 && i < 25))
                            {
                                border[i, j] = true;
                            }
                            break;

                        case 35:
                            if (i == 10)
                            {
                                border[i, j] = true;
                            }
                            break;
                        case 33:
                        case 32:
                        case 37:
                        case 38:
                            if (i < 9 || (i > 18 && i < 22) || i > 23)
                            {
                                border[i, j] = true;
                            }
                            break;
                        case 34:
                        case 36:
                            if(i < 9 || (i > 18 && i < 22) || i > 23 || i == 10)
                            {
                                border[i, j] = true;
                            }
                            break;

                    }
                }
            }
            return border;
        }
    }
}
