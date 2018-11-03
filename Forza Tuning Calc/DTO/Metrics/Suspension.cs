namespace Forza_Tuning_Calculator.DTO.Metrics
{
    public class Suspension
    {
        public SpringsResult Springs = new SpringsResult();

        public DampingResult Damping = new DampingResult();
    }

    public class SpringsResult
    {
        public SpringRate SpringRate = new SpringRate();

        public RideHeight RideHeight = new RideHeight();
    }

    public class RideHeight
    {
        public int Front = 3;

        public string StringFront;

        public int Rear = 3;

        public string StringRear;
    }

    public class SpringRate
    {
        public double Front;

        public double Rear;
    }

    public class DampingResult
    {
        public ReboundResult Rebound = new ReboundResult();

        public BumpResult Bump = new BumpResult();
    }

    public class ReboundResult
    {
        public double Front;

        public double Rear;
    }

    public class BumpResult
    {
        public double Front50;

        public double Front63;

        public double Front75;

        public double Rear50;

        public double Rear63;

        public double Rear75;
    }
}
