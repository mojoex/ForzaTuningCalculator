using Forza_Tuning_Calculator.DTO.Constants;
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
                        baseTune.Aero.StringFront = $"{baseTune.Aero.Front}" +
                            "% of bar";
                    }

                    if (location == FineTuneConstants.Rear)
                    {
                        baseTune.Aero.StringRear = $"{baseTune.Aero.Rear}" +
                            "% of bar";
                    }

                    break;
            }
        }

        public static void StringifyValue(this double value, BaseTune baseTune, string method)
        {

        }
    }
}
