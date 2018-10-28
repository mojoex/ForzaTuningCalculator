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

        public double Rear;
    }

    public class SpringsResult
    {
        public SpringStiffness SpringRate = new SpringStiffness();
    }

    public class SpringStiffness
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
        public double Front;

        public double Rear;
    }
}
