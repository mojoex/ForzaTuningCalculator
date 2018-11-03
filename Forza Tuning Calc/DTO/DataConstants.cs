using Forza_Tuning_Calculator.DTO.Constants;
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
    }
}
