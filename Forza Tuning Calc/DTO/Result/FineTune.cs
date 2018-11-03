using Forza_Tuning_Calculator.DTO.Metrics;

namespace Forza_Tuning_Calculator.DTO.Result
{
    public class FineTune
    {
        public TyrePressureResult TyrePressure = new TyrePressureResult();

        public Alignment Alignment = new Alignment();

        public AntiRollBars ARB = new AntiRollBars();

        public Suspension Suspension = new Suspension();

        public AeroResult Aero = new AeroResult();

        public DifferentialResult Diff = new DifferentialResult();
    }
}
