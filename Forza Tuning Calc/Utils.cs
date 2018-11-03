using Forza_Tuning_Calculator.DTO.Input;
using Forza_Tuning_Calculator.DTO.Result;
using System.Windows.Forms;

namespace Forza_Tuning_Calculator
{
    public class Utils
    {
        private Calculations _calculate;

        public Utils()
        {
            _calculate = new Calculations();
        }

        public BaseTune BuildBaseTune(UserInput input)
        {
            var result = new BaseTune();

            result.Drivetrain = input.Drivetrain;
            result.FrontDistrubution = input.Weight.FrontWeight / 100;
            result.RearDistribution = 1 - result.FrontDistrubution;

            return result;
        }

        public void ShowError(string source)
        {
            if (!string.IsNullOrEmpty(source))
            {
                MessageBox.Show($"Please use a valid value for {source}", "Invalid input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public double GetWeightInLbs(int weightKg)
        {
            var weightlb = weightKg * 2.20462;

            return weightlb;
        }

        public void BaseTuneCalculations(BaseTune baseTune, UserInput input)
        {
            _calculate.CalculateSpringRate(baseTune, input);

            _calculate.CalculateDamping(baseTune, input);

            _calculate.CalculateArbs(baseTune, input);
        }

        public void FineTuneOverallStiffness(FineTune fineTune, string method)
        {
            //switch (method)
            //{
            //    case FineTuneConstants.Soften:
            //        FineTuning.AdjustOverallStiffness(result, false);
            //        break;
            //    case FineTuneConstants.Stiffen:
            //        FineTuning.AdjustOverallStiffness(result, true);
            //        break;
            //}
        }

        public void FineTuneRebound(FineTune fineTune, string method, string location)
        {
            //switch (method)
            //{
            //    case FineTuneConstants.Soften:
            //        FineTuning.AdjustRebound(result, false, location);
            //        break;
            //    case FineTuneConstants.Stiffen:
            //        FineTuning.AdjustRebound(result, true, location);
            //        break;
            //}
        }

        public void AdjustRideHeight(FineTune fineTune, string method, string location)
        {
            //switch (method)
            //{
            //    case FineTuneConstants.Lower:
            //        if (location == FineTuneConstants.Front)
            //        {
            //            if (result.Springs.Height.Front >= 0)
            //            {
            //                result.Springs.Height.Front--;
            //            }
            //        }

            //        else
            //        {
            //            if (result.Springs.Height.Rear >= 0)
            //            {
            //                result.Springs.Height.Rear--;
            //            }
            //        }

            //        break;
            //}
        }

        public void CornerEntryUs(FineTune fineTune)
        {
            //if (result.Alignment.CastorAngleStage == 0)
            //{
            //    result.Alignment.CastorAngleStage = 1;
            //    result.Alignment.CastorAngle = result.Alignment.CastorAngle + 0.5;
            //}

            //if (result.Springs.Height.Front == result.Alignment.CastorAngleStage && result.Alignment.CastorAngle < 6.5)
            //{
            //    result.Alignment.CastorAngleStage++;
            //    result.Alignment.CastorAngle = result.Alignment.CastorAngle + 0.5;
            //}

            //if (result.Alignment.CastorAngleStage > result.Alignment.ToeOutStage)
            //{
            //    result.Alignment.ToeOutStage++;
            //    result.Alignment.ToeOut = result.Alignment.ToeOut + 0.1;
            //}

            //if (result.Alignment.ToeOutStage > result.Springs.Height.Front)
            //{
            //    AdjustRideHeight(result, FineTuneConstants.Lower, FineTuneConstants.Front);
            //}
        }
    }
}
