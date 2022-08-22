using System;
namespace BowlingBall
{
    public class Scorer
    {
        private int[] throws = new int[21];
        private int currentThrow;
        private int ball;

        public Scorer()
        {
        }

        public void AddThrow(int pins)
        {
            throws[currentThrow++] = pins;
        }

        public int ScoreForFrame(int theFrame)
        {
            ball = 0;
            int score = 0;
            for (int currentFrame = 0;
                currentFrame < theFrame;
                currentFrame++)
            {
                if (Strike()) //Strike
                {
                    score += 10 + NextTwoBallsForStrike;
                    ball++;
                }
                else if (Spare())
                {
                    score += 10 + NextBallsForSpire;
                    ball += 2;
                }
                else
                {
                    score += TwoBallsInFrame;
                    ball += 2;
                }
            }
            return score;
        }

        private int NextTwoBallsForStrike
        {
            get { return (throws[ball + 1] + throws[ball + 2]); }
        }

        private int NextBallsForSpire
        {
            get { return throws[ball + 2]; }
        }

        private int TwoBallsInFrame
        {
            get { return throws[ball] + throws[ball + 1]; }
        }

        private bool Strike()
        {
            return throws[ball] == 10;
        }

        private bool Spare()
        {
            return throws[ball] + throws[ball + 1] == 10;
        }
    }
}

