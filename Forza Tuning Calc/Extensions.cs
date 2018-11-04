using Forza_Tuning_Calculator.DTO.Constants;
using Forza_Tuning_Calculator.DTO.Metrics;
using Forza_Tuning_Calculator.DTO.Result;

namespace Forza_Tuning_Calculator
{
    public static class Extensions
    {
        public static void StringifyValue(this int value, BaseTune baseTune, string method, string location)
        {
            switch (method)
            {
                case SuspensionConstants.RideHeightTitle:
                    if (location == FineTuneConstants.Front)
                    {
                        baseTune.Suspension.Springs.RideHeight.StringFront = $"{baseTune.Suspension.Springs.RideHeight.Front}" +
                            " above min";
                    }

                    if (location == FineTuneConstants.Rear)
                    {
                        baseTune.Suspension.Springs.RideHeight.StringRear = $"{baseTune.Suspension.Springs.RideHeight.Rear}" +
                            " above min";
                    }

                    break;

                case AeroConstants.DownforceTitle:
                    if (location == FineTuneConstants.Front)
                    {
                        baseTune.Aero.StringFront = $"{baseTune.Aero.FrontRangeMin} - {baseTune.Aero.FrontRangeMax}" +
                            "% of bar";
                    }

                    if (location == FineTuneConstants.Rear)
                    {
                        baseTune.Aero.StringRear = $"{baseTune.Aero.RearRangeMin} - {baseTune.Aero.RearRangeMax}" +
                            "% of bar";
                    }

                    break;
            }
        }

        public static void StringifyValue(this double value, BaseTune baseTune, string method)
        {

        }

        public static void GetVariables(this SpringsResult result, int stiffnessSetting)
        {
            result.SpringVariable.FrontVariable = (result.SpringRate.Front / 4) / 3;
            result.SpringVariable.RearVariable = (result.SpringRate.Rear / 4) / 3;
        }

        public static void GetVariables(this AntiRollBars result, int stiffnessSetting)
        {
            result.FrontVariable = (result.Front / 4) / 3;
            result.RearVariable = (result.Rear / 4) / 3;
        }
    }
}
