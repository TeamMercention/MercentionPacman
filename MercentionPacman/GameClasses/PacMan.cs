using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercentionPacman.GameClasses
{
    class PacMan
    {
        // public Position PacmanPosition { get; set; }
        // Текуща позиция

        // public char CurrentDirection { get; set; }
        // Текуща посока

        // public char NextDirection { get; set; }
        // Следваща посока (ако има натиснат различен бутон от клавиатурата)

        // public int Lives { get; }
        // public int Score { get; }

        public PacMan()
        {
            // Създаване на нов PacMan със стойности по подразбиране
        }

        public void LostLife()
        {
            // this.Lives--;
        }

        public void EarnPoint()
        {
            // this.Score++;
        }
    }
}
