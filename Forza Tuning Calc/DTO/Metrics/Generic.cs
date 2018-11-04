namespace Forza_Tuning_Calculator.DTO.Metrics
{
    public class Generic
    {
        public TyrePressureResult TyrePressure = new TyrePressureResult();

        public AeroResult Aero = new AeroResult();

        public DifferentialResult Differential = new DifferentialResult();

        //public GearingResult Gearing = new GearingResult();
    }

    public class TyrePressureResult
    {
        public double FrontPsi = 28;

        public double RearPsi = 28;
    }

    /// <summary>
    /// Percentage value of total bar
    /// </summary>
    public class AeroResult
    {
        public int FrontRangeMin = 55;

        public int FrontRangeMax = 100;

        public string StringFront;

        public int RearRangeMin = 40;

        public int RearRangeMax = 100;

        public string StringRear;
    }

    public class DifferentialResult
    {
        public int FrontAccel;

        public int FrontDecel;

        public int RearAccel;

        public int RearDecel;

        public int Bias;
    }

    public class GearingResult
    {
        // TODO: Finish this
    }
}
