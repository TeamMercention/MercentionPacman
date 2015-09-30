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
        static Position[] monsterList =
        {
            new Position(33,12),
            new Position(34,12),
            new Position(35,12),
            new Position(36,12)
        };

        // Game Board

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

                // Redraw Board
                // Ще изобразява всички настъпили промени в board-а от по-горните методи на екрана.
                // Към него ще се изпълнява пак LoadGUI(), за да добави отстрани точките и животите.

                Thread.Sleep(100); // Определя скоростта на играта, ще го променяме ако трябва
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
            foreach (var item in monsterList)
            {

                Console.SetCursorPosition(item.X, item.Y);
                Console.Write("0");
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
    }
}
