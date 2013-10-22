using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCoders.BowlingGAme
{
    public class Game
    {
        private int score = 0;

        public void Roll(int pins)
        {
            score += pins;
        }

        public int Score()
        {
            return score;
        }
    }
}
