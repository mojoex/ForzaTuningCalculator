namespace Forza_Tuning_Calc.DTO.Input
{
    public class UserInput
    {
        public WeightInput Weight = new WeightInput();

        public DampingInput Damping = new DampingInput();

        public SpringsInput Springs = new SpringsInput();

        public ArbInput ARBs = new ArbInput();
    }

    public class WeightInput
    {
        public int Weight;

        public float FrontWeight;
    }

    public class DampingInput
    {
        public float ReboundMin;

        public float ReboundMax;
    }

    public class SpringsInput
    {
        public float FrontMin;

        public float FrontMax;

        public float RearMin;

        public float RearMax;
    }

    public class ArbInput
    {
        public float FrontMin;

        public float FrontMax;

        public float RearMin;

        public float RearMax;
    }
}
