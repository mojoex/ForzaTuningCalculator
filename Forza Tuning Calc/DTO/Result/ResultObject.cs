namespace Forza_Tuning_Calculator.DTO
{
    public class ResultObject
    {
        public DampingResult Damping = new DampingResult();

        public SpringsResult Springs = new SpringsResult();

        public ArbResult ARBs = new ArbResult();
    }

    public class ArbResult
    {
        public double Front;

        public double FrontVar;

        public double Rear;

        public double RearVar;
    }

    public class SpringsResult
    {
        public SpringStiffness SpringRate = new SpringStiffness();
    }

    public class SpringStiffness
    {
        public double Front;

        public double FrontVar;

        public double Rear;

        public double RearVar;
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
