using Forza_Tuning_Calculator.DTO;
using Forza_Tuning_Calculator.DTO.Input;

namespace Forza_Tuning_Calculator
{
    public static class Math
    {
        private static float FrontWeightMulti;
        private static float RearWeightMulti;

        public static void CalculateDamping(this DampingResult result, UserInput input)
        {
            FrontWeightMulti = input.Weight.FrontWeight / 100;
            RearWeightMulti = 1 - FrontWeightMulti;

            result.Rebound = CalculateRebound(input);
            result.Bump = CalculateBump(result.Rebound);
        }

        public static void CalculateSpringRate(this SpringsResult result, UserInput input)
        {
            result.SpringRate = CalculateSpringRate(input);
        }

        public static void CalculateArbs(this ArbResult result, UserInput input)
        {
            var frontMin = input.ARBs.FrontMin;
            var frontMax = input.ARBs.FrontMax;

            var rearMin = input.ARBs.RearMin;
            var rearMax = input.ARBs.RearMax;

            result.Front = ((frontMax - frontMin) * FrontWeightMulti) + frontMin;
            result.Rear = ((rearMax - rearMin) * RearWeightMulti) + frontMin;

            result.FrontVar = (result.Front / 4) / 3;
            result.RearVar = (result.Rear / 4) / 3;
        }

        private static SpringStiffness CalculateSpringRate(UserInput input)
        {
            var result = new SpringStiffness();

            var frontMin = input.Springs.FrontMin;
            var frontMax = input.Springs.FrontMax;

            var rearMin = input.Springs.RearMin;
            var rearMax = input.Springs.RearMax;

            result.Front = ((frontMax - frontMin) * FrontWeightMulti) + frontMin;
            result.Rear = ((rearMax - rearMin) * RearWeightMulti) + frontMin;

            result.FrontVar = (result.Front / 4) / 3;
            result.RearVar = (result.Rear / 4) / 3;

            return result;
        }

        private static ReboundResult CalculateRebound(UserInput input)
        {
            var result = new ReboundResult();

            var min = input.Damping.ReboundMin;
            var max = input.Damping.ReboundMax;

            result.Front = ((max - min) * FrontWeightMulti) + min;
            result.Rear = ((max - min) * RearWeightMulti) + min;

            return result;
        }

        private static BumpResult CalculateBump(ReboundResult input)
        {
            var bumpResult = new BumpResult();

            bumpResult.Front50 = input.Front * 0.50;
            bumpResult.Front63 = input.Front * 0.63;
            bumpResult.Front75 = input.Front * 0.75;

            bumpResult.Rear50 = input.Rear * 0.50;
            bumpResult.Rear63 = input.Rear * 0.63;
            bumpResult.Rear75 = input.Rear * 0.75;

            return bumpResult;
        }
    }
}
