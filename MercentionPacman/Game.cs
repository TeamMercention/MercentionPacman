using MercentionPacman.GameClasses;
using System;
using System.Threading.Tasks;
using System.Media;
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
        static Monster[] monsterList =
        {
            new Monster(ConsoleColor.Red,15,8),
            new Monster(ConsoleColor.Cyan,16,12),
            new Monster(ConsoleColor.Magenta,17,12),
            new Monster(ConsoleColor.DarkCyan,18,12),

        };

        // Game Board
        static GameBoard board = new GameBoard();
        static string[,] border = board.GetBoard;

        // Console Settings
        const int GameWidth = 70;
        const int GameHeight = 29;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Title = "Mercention Pacman";
            Console.WindowWidth = GameWidth;
            Console.BufferWidth = GameWidth;
            Console.WindowHeight = GameHeight;
            Console.BufferHeight = GameHeight;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            ShowWelcomeMenu();

            RedrawBoard();
            LoadGUI();
            // Load Player
            // Задава позиция на Pacman. Променя тази позиция на GameBoard-а с иконката на Pacman.

            // Load Monsters
            // Като горното, само че за Monster-и
            LoadMonsters();

            // Game logic
            // Този цикъл ще се изпълнява постоянно, докато играчът не натисне ESC
            while (true)
            {

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

                // Monster Ai
                MonsterAi();
                
                Thread.Sleep(200); // Определя скоростта на играта, ще го променяме ако трябва
            }

            GameOver();
        }

        static void LoadGUI()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(40, 2);
            Console.Write("Level: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(40, 4);
            Console.Write("Score: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(40, 6);
            Console.Write("Lives: ");
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(40, GameHeight - 8);
            Console.Write("{0}", new string('-', 22));
            Console.SetCursorPosition(40, GameHeight - 7);
            Console.Write("|  PRESS P TO PAUSE  |");
            Console.SetCursorPosition(40, GameHeight - 6);
            Console.Write("|  PRESS ESC TO EXIT |");
            Console.SetCursorPosition(40, GameHeight - 5);
            Console.Write("{0}", new string('-', 22));
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
                Console.ForegroundColor = ConsoleColor.White;
                if (monster.GetPosX() != monster.prevPosX || monster.GetPosY() != monster.prevPosY)
                {
                    if (border[monster.prevPosY, monster.prevPosX] == " ")
                    {
                        Console.SetCursorPosition(monster.prevPosX, monster.prevPosY);
                        Console.Write(' ');
                    }
                    else if (border[monster.prevPosY, monster.prevPosX] == ".")
                    {
                        Console.SetCursorPosition(monster.prevPosX, monster.prevPosY);
                        Console.Write('.');
                    }
                    else if (border[monster.prevPosY, monster.prevPosX] == "*")
                    {
                        Console.SetCursorPosition(monster.prevPosX, monster.prevPosY);
                        Console.Write('*');
                    }
                }
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
        }

        static void RedrawBoard()
        {
            for (int i = 0; i < board.GetBoard.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetBoard.GetLength(1); j++)
                {
                    Console.Write("{0}", board.GetBoard[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void ShowWelcomeMenu()
        {
            PlayMusic();
            RedrawBoard();

            int horizontalPos = GameHeight / 2 - 2;
            int verticalPos = GameWidth / 2 - 15;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(verticalPos, horizontalPos);
            Console.WriteLine("|{0}|", new string('-', 28));
            Console.SetCursorPosition(verticalPos, horizontalPos + 1);
            Console.WriteLine("||     PRESS X TO START     ||");
            Console.SetCursorPosition(verticalPos, horizontalPos + 2);
            Console.WriteLine("||     PRESS ESC TO EXIT    ||");
            Console.SetCursorPosition(verticalPos, horizontalPos + 3);
            Console.WriteLine("|{0}|", new string('-', 28));
            Console.ForegroundColor = ConsoleColor.White;

            ConsoleKeyInfo keyPressed = Console.ReadKey(true);
            while (true)
            {
                if (keyPressed.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                else if (keyPressed.Key == ConsoleKey.X)
                {
                    Console.Clear();
                    break;
                }

                keyPressed = Console.ReadKey(true);
            }
        }

        static void GameOver()
        {

        }

        static void WinGame()
        {

        }

        public static void PlayMusic()
        {
            Task.Factory.StartNew(() => Music());
        }

        public static void Music()
        {

            SoundPlayer PacManMusic = new SoundPlayer(MercentionPacman.PacManMusic.pacman_beginning);
            PacManMusic.Play();

        }
    }
}
