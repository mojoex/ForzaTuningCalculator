using Forza_Tuning_Calculator.DTO.Metrics;

namespace Forza_Tuning_Calculator.DTO.Result
{
    public class BaseTune
    {
        public double FrontDistrubution;

        public double RearDistribution;

        public bool BaseComplete;

        public string Drivetrain;

        public ChassisStiffness ChassisStiffness = new ChassisStiffness();

        public TyrePressureResult TyrePressure = new TyrePressureResult();

        public Alignment Alignment = new Alignment();

        public AntiRollBars ARB = new AntiRollBars();

        public Suspension Suspension = new Suspension();

        public AeroResult Aero = new AeroResult();

        public DifferentialResult Diff = new DifferentialResult();

        //public GearingResult Gearing = new GearingResult();
    }
}
