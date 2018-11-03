using Forza_Tuning_Calculator.DTO.Input;
using Forza_Tuning_Calculator.DTO.Metrics;
using Forza_Tuning_Calculator.DTO.Result;

namespace Forza_Tuning_Calculator
{
    public class Calculations
    {
        public void CalculateDamping(BaseTune baseTune, UserInput input)
        {
            var reboundMin = input.Damping.ReboundMin;
            var reboundMax = input.Damping.ReboundMax;

            baseTune.Suspension.Damping.Rebound.Front = ((reboundMax - reboundMin) * baseTune.FrontDistrubution) + reboundMin;
            baseTune.Suspension.Damping.Rebound.Rear = ((reboundMax - reboundMin) * baseTune.RearDistribution) + reboundMin;

            CalculateBump(baseTune.Suspension.Damping);
        }

        private void CalculateBump(DampingResult input)
        {
            input.Bump.Front50 = input.Rebound.Front * 0.50;
            input.Bump.Front63 = input.Rebound.Front * 0.63;
            input.Bump.Front75 = input.Rebound.Front * 0.75;

            input.Bump.Rear50 = input.Rebound.Rear * 0.50;
            input.Bump.Rear63 = input.Rebound.Rear * 0.63;
            input.Bump.Rear75 = input.Rebound.Rear * 0.75;
        }

        public void CalculateSpringRate(BaseTune baseTune, UserInput input)
        {
            if (input.WeightBasedTune)
            {
                var frontRate = (input.Weight.WeightKg / 2) * baseTune.FrontDistrubution;
                var rearRate = (input.Weight.WeightKg / 2) - baseTune.RearDistribution;

                baseTune.Suspension.Springs.SpringRate.Front = frontRate;
                baseTune.Suspension.Springs.SpringRate.Rear = rearRate;
            }

            else
            {
                var min = input.Springs.Min;
                var max = input.Springs.Max;

                baseTune.Suspension.Springs.SpringRate.Front = ((max - min) * baseTune.FrontDistrubution) + min;
                baseTune.Suspension.Springs.SpringRate.Rear = ((max - min) * baseTune.RearDistribution) + min;

                //result.FrontVar = (result.Front / 4) / 3;
                //result.RearVar = (result.Rear / 4) / 3;
            }

        }

        public void CalculateArbs(BaseTune baseTune, UserInput input)
        {
            var min = input.ARB.Min;
            var max = input.ARB.Max;

            baseTune.ARB.Front = ((max - min) * baseTune.FrontDistrubution) + min;
            baseTune.ARB.Rear = ((max - min) * baseTune.RearDistribution) + min;

            //result.FrontVar = (result.Front / 4) / 3;
            //result.RearVar = (result.Rear / 4) / 3;
        }
    }
}
