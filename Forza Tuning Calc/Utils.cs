﻿using Forza_Tuning_Calculator.DTO;
using Forza_Tuning_Calculator.DTO.Constants;
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

        public BaseTune BuildBaseTune(UserInput input, int chassisStiffness)
        {
            var result = new BaseTune();

            result.Drivetrain = input.Drivetrain;
            result.FrontDistrubution = input.Weight.FrontWeight / 100;
            result.RearDistribution = 1 - result.FrontDistrubution;

            result.ChassisStiffness.Setting = chassisStiffness;

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

            baseTune.Aero.FrontRangeMin.StringifyValue(baseTune, AeroConstants.DownforceTitle, FineTuneConstants.Front);
            baseTune.Aero.FrontRangeMax.StringifyValue(baseTune, AeroConstants.DownforceTitle, FineTuneConstants.Rear);

            baseTune.Suspension.Springs.RideHeight.Front.StringifyValue(baseTune, SuspensionConstants.RideHeightTitle, FineTuneConstants.Front);
            baseTune.Suspension.Springs.RideHeight.Rear.StringifyValue(baseTune, SuspensionConstants.RideHeightTitle, FineTuneConstants.Rear);

            SetDiffSettings(baseTune);

            ApplyGlobalStiffnessSettings(baseTune);
        }

        private void ApplyGlobalStiffnessSettings(BaseTune baseTune)
        {
            switch (baseTune.ChassisStiffness.Setting)
            {
                case 1:
                    baseTune.Suspension.Springs.SpringRate.Front = baseTune.Suspension.Springs.SpringRate.Front + baseTune.Suspension.Springs.SpringVariable.FrontVariable;
                    baseTune.Suspension.Springs.SpringRate.Rear = baseTune.Suspension.Springs.SpringRate.Rear + baseTune.Suspension.Springs.SpringVariable.RearVariable;

                    baseTune.ARB.Front = baseTune.ARB.Front + baseTune.ARB.FrontVariable;
                    baseTune.ARB.Rear = baseTune.ARB.Rear + baseTune.ARB.RearVariable;
                    break;

                case -1:
                    baseTune.Suspension.Springs.SpringRate.Front = baseTune.Suspension.Springs.SpringRate.Front - baseTune.Suspension.Springs.SpringVariable.FrontVariable;
                    baseTune.Suspension.Springs.SpringRate.Rear = baseTune.Suspension.Springs.SpringRate.Rear - baseTune.Suspension.Springs.SpringVariable.RearVariable;

                    baseTune.ARB.Front = baseTune.ARB.Front - baseTune.ARB.FrontVariable;
                    baseTune.ARB.Rear = baseTune.ARB.Rear - baseTune.ARB.RearVariable;
                    break;

                case -2:
                    baseTune.Suspension.Springs.SpringRate.Front = baseTune.Suspension.Springs.SpringRate.Front - (baseTune.Suspension.Springs.SpringVariable.FrontVariable * 2);
                    baseTune.Suspension.Springs.SpringRate.Rear = baseTune.Suspension.Springs.SpringRate.Rear - (baseTune.Suspension.Springs.SpringVariable.RearVariable * 2);

                    baseTune.ARB.Front = baseTune.ARB.Front - (baseTune.ARB.FrontVariable * 2);
                    baseTune.ARB.Rear = baseTune.ARB.Rear - (baseTune.ARB.RearVariable * 2);
                    break;

                default:
                    break;
            }
        }

        private void SetDiffSettings(BaseTune baseTune)
        {
            var drivetrain = baseTune.Drivetrain;

            var data = new DataConstants();

            switch (drivetrain)
            {
                case StringConstants.AWD:
                    baseTune.Diff = data.AWDDiff;
                    break;
                case StringConstants.RWD:
                    baseTune.Diff = data.RWDDiff;
                    break;
                case StringConstants.FWD:
                    baseTune.Diff = data.FWDDiff;
                    break;
            }
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
