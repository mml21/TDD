using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCoders.BowlingGAme
{
    public class Game
    {
        private int[] rolls = new int[21];
        private int currentRoll = 0;

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int Score()
        {
            int score = 0;
            int firstInFrame = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (IsStrike(firstInFrame)) 
                {
                    score += 10 + NextTwoBallsForStrike(firstInFrame);
                    firstInFrame++;
                }
                else if (IsSpare(firstInFrame)) 
                {
                    score += 10 + NextBallForSpare(firstInFrame);
                    firstInFrame += 2;
                }
                else
                {
                    score += TwoBallsInFrame(firstInFrame);
                    firstInFrame += 2;
                }
            }
            return score;
        }

        private int TwoBallsInFrame(int firstInFrame)
        {
            return rolls[firstInFrame] + rolls[firstInFrame + 1];
        }

        private int NextBallForSpare(int firstInFrame)
        {
            return rolls[firstInFrame + 2];
        }

        private int NextTwoBallsForStrike(int firstInFrame)
        {
            return rolls[firstInFrame + 1] + rolls[firstInFrame + 2];
        }

        private bool IsStrike(int firstInFrame)
        {
            return rolls[firstInFrame] == 10;
        }

        private bool IsSpare(int firstInFrame)
        {
            return rolls[firstInFrame] + rolls[firstInFrame + 1] == 10;
        }
    }
}
