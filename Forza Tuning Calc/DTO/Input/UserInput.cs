namespace Forza_Tuning_Calculator.DTO.Input
{
    public class UserInput
    {
        public bool WeightBasedTune;

        public string Drivetrain;

        public WeightInput Weight = new WeightInput();

        public DampingInput Damping = new DampingInput();

        public SpringsInput Springs = new SpringsInput();

        public ArbInput ARB = new ArbInput();
    }

    public class WeightInput
    {
        public int WeightKg;

        public double WeightLb;

        public float FrontWeight;
    }

    public class DampingInput
    {
        public float ReboundMin;

        public float ReboundMax;
    }

    public class SpringsInput
    {
        public float Min;

        public float Max;
    }

    public class ArbInput
    {
        public float Min;

        public float Max;
    }
}
