using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MercentionPacman.GameClasses;
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
        //GameBoard board = new GameBoard();
        // Game Board-ът ще е матрица от стрингове, които представляват нивото на Pacman
        // Повечето неща ще бъдат в клас GameBoard, тук само ще се инициализира, за да могат да се
        // променят позициите на Pacman, Monster-ите по време на игра.

        // Ще се задават и размерите за прозореца на конзолата като константи
        // const int GameBoardWidth = ...;
        // const int GameBoardHeight = ...;

        static void Main(string[] args)
        {
            GameBoard.PrintGameBoard();
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

                // Monster Ai
                // Ако Monster-а срещне стигне до стена, избира случайна посока със Random
                // Ако pacman е наблизо може да започне да го гони и т.н.
                // Ако позицията на Pacman и някой Monster съвпадне - загуба на живот
                // и позициите на Pacman и Monster-ите се ресетва.
                // Ако има 0 животи - return false (за да спре цикъла) и Game Over

                // Redraw Board
                // Ще изобразява всички настъпили промени в board-а от по-горните методи на екрана.
                // Към него ще се изпълнява пак LoadGUI(), за да добави отстрани точките и животите.

                Thread.Sleep(200); // Определя скоростта на играта, ще го променяме ако трябва
            }

            GameOver();
        }

        static void LoadGUI()
        {

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
        }

        static void GameOver()
        {

        }

        static void WinGame()
        {

        }
    }
}
