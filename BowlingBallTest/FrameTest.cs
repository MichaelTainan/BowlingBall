using System;
using BowlingBall;

namespace BowlingBallTest
{
    //Finally, Frame class doesn't need
    [TestFixture]
    public class FrameTest
    {
        public FrameTest()
        {
        }

        [Test]
        public void TestScoreNoThrow()
        {
            Frame f = new Frame();
            Assert.AreEqual(0, f.Score);
        }

        [Test]
        public void TestScoreOneThrow()
        {
            Frame f = new Frame();
            f.Add(5);
            Assert.AreEqual(5, f.Score);
        }
    }
}

