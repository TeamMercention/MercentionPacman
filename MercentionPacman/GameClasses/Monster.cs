using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercentionPacman.GameClasses
{
    class Monster
    {
        // public Position MonsterPosition { get; set; }
        // Текуща позиция

        // public char CurrentDirection { get; set; }
        // Текуща посока

        // public char NextDirection { get; set; }
        // Следваща посока (когато Monster-а достигне стена и трябва да смени посоката си,
        // играта ще задава новата посока чрез това поле)

        // public int Counter { get; }
        // Този брояч ще се използва, за да се забавя скоростта на Monster-ите.
        // Например ако един while цикъл се изпълнява за 200 ms в Main метода,
        // ако зададем на брояча да брои до 1, то Monster-а ще презкача един while цикъл
        // и ще изпълнява действие на всеки 400 ms

        // private int maxCounter = 1;
        // Максимална граница на брояча, след достигането на която той ще се нулира

        public Monster()
        {
            // Създаване на нов Monster със стойности по подразбиране
            // ...
            // this.Counter = 0
        }
    }
}
