namespace BowlingBall;
//Finally, Frame class doesn't need
public class Frame
{
    public int Score { private set; get; }

    public int Add(int pins)
    {
        return Score += pins;
    }
}
