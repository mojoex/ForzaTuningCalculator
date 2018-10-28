﻿using Forza_Tuning_Calc.DTO;
using Forza_Tuning_Calc.DTO.Input;
using System.Windows.Forms;

namespace Forza_Tuning_Calc
{
    public class Utils
    {
        private Form _calc;

        public Utils(Form calc)
        {
            _calc = calc;
        }

        public ResultObject PerformCalculations(UserInput input)
        {
            var result = new ResultObject();

            result.Damping.CalculateDamping(input);

            result.Springs.CalculateSpringRate(input);

            result.ARBs.CalculateArbs(input);

            return result;
        }
    }
}
