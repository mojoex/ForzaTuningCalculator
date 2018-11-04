namespace Forza_Tuning_Calculator.DTO.Metrics
{
    public class ChassisStiffness
    {
        public bool Softest
        {
            get
            {
                return Setting == -2;
            }
        }

        public bool Soft
        {
            get
            {
                return Setting == -1;
            }
        }

        public bool Average
        {
            get
            {
                return Setting == 0;
            }
        }

        public bool Stiff
        {
            get
            {
                return Setting == 1;
            }
        }

        public int Setting = 0;
    }
}
