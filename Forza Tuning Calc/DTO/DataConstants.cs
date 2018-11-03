using Forza_Tuning_Calculator.DTO.Constants;
using Forza_Tuning_Calculator.DTO.Metrics;
using System.Collections.Generic;

namespace Forza_Tuning_Calculator.DTO
{
    public class DataConstants
    {
        public static List<string> DrivetrainOptions = new List<string>()
        {
            StringConstants.AWD,
            StringConstants.RWD,
            StringConstants.FWD
        };

        public DifferentialResult AWDDiff = new DifferentialResult()
        {
            RearAccel = 80,
            RearDecel = 40,
            FrontAccel = 20,
            FrontDecel = 0,
            Bias = 80
        };

        public DifferentialResult RWDDiff = new DifferentialResult()
        {
            RearAccel = 50,
            RearDecel = 40,
            FrontAccel = -99,
            FrontDecel = -99,
            Bias = -99
        };

        public DifferentialResult FWDDiff = new DifferentialResult()
        {
            RearAccel = -99,
            RearDecel = -99,
            FrontAccel = 50,
            FrontDecel = 20,
            Bias = -99
        };
    }
}
