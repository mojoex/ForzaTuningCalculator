using Forza_Tuning_Calculator.DTO;

namespace Forza_Tuning_Calculator
{
    /// <summary>
    /// Fine tuning calculations for suspension and other aspects
    /// http://i.imgur.com/byemI.jpg
    /// </summary>
    public class FineTuning
    {
        public static double GetFineTunedVariable(int stage)
        {
            if (stage <= -4)
            {
                return 0.2;
            }

            if (stage >= 1)
            {
                return 1.2;
            }

            switch (stage)
            {
                case -3:
                    return 0.5;
                case -2:
                    return 0.8;
                case -1:
                    return 1;
            }

            return 99;
        }

        /// <summary>
        /// Reduces spring and arb stiffness
        /// </summary>
        /// <param name="result"></param>
        public static void AdjustOverallStiffness(ResultObject result, bool stiffen)
        {
            result.Springs.SpringRate.FrontStage--;
            result.Springs.SpringRate.RearStage--;

            result.ARBs.FrontStage--;
            result.ARBs.RearStage--;

            if (result.Springs.SpringRate.FrontStage == 0)
            {
                result.Springs.SpringRate.FtFront = result.Springs.SpringRate.Front;
            }

            if (result.Springs.SpringRate.RearStage == 0)
            {
                result.Springs.SpringRate.FtRear = result.Springs.SpringRate.Rear;
            }

            if (result.ARBs.FrontStage == 0)
            {
                result.ARBs.FtFront = result.ARBs.Front;
            }

            if (result.ARBs.FrontStage == 0)
            {
                result.ARBs.FtFront = result.ARBs.Front;
            }

            else if (result.Springs.SpringRate.FrontStage != 0)
            {
                AdjustSpringRate(result.Springs, "front", stiffen);
            }

            else if (result.Springs.SpringRate.RearStage != 0)
            {
                AdjustSpringRate(result.Springs, "rear", stiffen);
            }

            else if (result.ARBs.FrontStage != 0)
            {
                AdjustArbStiffness(result.ARBs, "front", stiffen);
            }

            else if (result.ARBs.RearStage != 0)
            {
                AdjustArbStiffness(result.ARBs, "rear", stiffen);
            }
        }

        private static void AdjustArbStiffness(ArbResult aRBs, string arb, bool stiffen)
        {
            if (arb == "front")
            {
                var frontMulti = GetFineTunedVariable(aRBs.FrontStage);

                var frontRateVar = aRBs.FrontVar * frontMulti;

                if (stiffen)
                {
                    aRBs.FtFront = aRBs.Front + frontRateVar;
                }

                else
                {
                    aRBs.FtFront = aRBs.Front - frontRateVar;
                }
            }

            else
            {
                var rearMulti = GetFineTunedVariable(aRBs.FrontStage);

                var rearRateVar = aRBs.RearVar * rearMulti;

                if (stiffen)
                {
                    aRBs.FtRear = aRBs.Rear + rearRateVar;
                }

                else
                {
                    aRBs.FtRear = aRBs.Rear - rearRateVar;
                }
            }
        }

        private static void AdjustSpringRate(SpringsResult springs, string spring, bool stiffen)
        {
            if (spring == "front")
            {
                var frontSpringMulti = GetFineTunedVariable(springs.SpringRate.FrontStage);

                var frontRateVar = springs.SpringRate.FrontVar * frontSpringMulti;

                if (stiffen)
                {
                    springs.SpringRate.FtFront = springs.SpringRate.Front + frontRateVar;
                }

                else
                {
                    springs.SpringRate.FtFront = springs.SpringRate.Front - frontRateVar;
                }
            }

            else
            {
                var rearSpringMulti = GetFineTunedVariable(springs.SpringRate.FrontStage);

                var rearRateVar = springs.SpringRate.RearVar * rearSpringMulti;

                if (stiffen)
                {
                    springs.SpringRate.FtRear = springs.SpringRate.Rear + rearRateVar;
                }

                else
                {
                    springs.SpringRate.FtRear = springs.SpringRate.Rear - rearRateVar;
                }
            }
        }
    }
}
