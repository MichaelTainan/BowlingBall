using System;
namespace BowlingBall
{
    public class Game
    {
        private int currentFrame = 1;
        private bool isFirstThrow = true;
        private Scorer scorer = new Scorer();

        public int Score
        {
            get { return ScoreForFrame(currentFrame); }
        }
        public int CurrentFrame
        {
            get { return currentFrame; }
        }

        public void Add(int pins)
        {
            scorer.AddThrow(pins);
            AdjustCurrentFrame(pins);
        }

        private void AdjustCurrentFrame(int pins)
        {
            if (LastBallInFrames(pins))
            {
                isFirstThrow = true;  //sample code lost this statement;
                AdvanceFrame();
            }
            else
                isFirstThrow = false;
        }

        private bool LastBallInFrames(int pins)
        {
            return (Strike(pins)) || (!isFirstThrow);
        }

        private bool Strike(int pins)
        {
            return (isFirstThrow && pins == 10);
        }

        private void AdvanceFrame()
        {
            currentFrame++;
            if (currentFrame > 10)
                currentFrame = 10;
        }

        public int ScoreForFrame(int theFrame)
        {
            return scorer.ScoreForFrame(theFrame);
        }
    }

}

