namespace Forza_Tuning_Calculator.DTO
{
    public class ResultObject
    {
        public DampingResult Damping = new DampingResult();

        public SpringsResult Springs = new SpringsResult();

        public ArbResult ARBs = new ArbResult();

        public bool BaseComplete;
    }

    public class ArbResult
    {
        public double Front;

        public double FtFront;

        public double FrontVar;

        public int FrontStage;

        public double Rear;

        public double FtRear;

        public int RearStage;

        public double RearVar;
    }

    public class SpringsResult
    {
        public SpringStiffness SpringRate = new SpringStiffness();
    }

    public class SpringStiffness
    {
        public double Front;

        public double FtFront;

        public double FrontVar;

        public int FrontStage;

        public double Rear;

        public double FtRear;

        public double RearVar;

        public int RearStage;
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
