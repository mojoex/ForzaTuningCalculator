namespace Forza_Tuning_Calculator
{
    /// <summary>
    /// Fine tuning calculations for suspension and other aspects
    /// http://i.imgur.com/byemI.jpg
    /// </summary>
    public class FineTuning
    {
        //public static double GetFineTuneMultiplier(int stage)
        //{
        //    if (stage <= -4)
        //    {
        //        return 0.2;
        //    }

        //    if (stage >= 1)
        //    {
        //        return 1.2;
        //    }

        //    switch (stage)
        //    {
        //        case -3:
        //            return 0.5;
        //        case -2:
        //            return 0.8;
        //        case -1:
        //            return 1;
        //    }

        //    return 99;
        //}

        //public static void AdjustRebound(ResultObject result, bool stiffen, string location)
        //{
        //    if (stiffen && location == FineTuneConstants.Front)
        //    {
        //        result.Damping.Rebound.FrontStage++;
        //    }

        //    if (!stiffen && location == FineTuneConstants.Front)
        //    {
        //        result.Damping.Rebound.FrontStage--;
        //    }

        //    if (stiffen && location == FineTuneConstants.Rear)
        //    {
        //        result.Damping.Rebound.RearStage++;
        //    }

        //    if (!stiffen && location == FineTuneConstants.Rear)
        //    {
        //        result.Damping.Rebound.RearStage--;
        //    }

        //    if (result.Damping.Rebound.FrontStage == 0 && location == FineTuneConstants.Front)
        //    {
        //        result.Damping.Rebound.FtFront = result.Damping.Rebound.Front;
        //    }

        //    if (result.Damping.Rebound.RearStage == 0 && location == FineTuneConstants.Rear)
        //    {
        //        result.Damping.Rebound.FtRear = result.Damping.Rebound.Rear;
        //    }

        //    if (result.Damping.Rebound.FrontStage != 0 && location == FineTuneConstants.Front)
        //    {
        //        AdjustReboundStiffness(result, stiffen, FineTuneConstants.Front);
        //    }

        //    if (result.Damping.Rebound.RearStage != 0 && location == FineTuneConstants.Rear)
        //    {

        //    }
        //}

        //private static void AdjustReboundStiffness(ResultObject result, bool stiffen, string location)
        //{
        //    if (location == FineTuneConstants.Front)
        //    {
        //        var frontMulti = GetFineTuneMultiplier(result.Damping.Rebound.FrontStage);

        //        var frontRateVar = result.Damping.Rebound.FrontVar * frontMulti;

        //        if (stiffen)
        //        {
        //            if (result.Damping.Rebound.FtFront != 0)
        //            {
        //                result.Damping.Rebound.FtFront = result.Damping.Rebound.FtFront + frontRateVar;
        //            }

        //            else
        //            {
        //                result.Damping.Rebound.FtFront = result.Damping.Rebound.Front + frontRateVar;
        //            }
        //        }

        //        else
        //        {
        //            if (result.Damping.Rebound.FtFront != 0)
        //            {
        //                result.Damping.Rebound.FtFront = result.Damping.Rebound.FtFront - frontRateVar;
        //            }

        //            else
        //            {
        //                result.Damping.Rebound.FtFront = result.Damping.Rebound.Front - frontRateVar;
        //            }
        //        }
        //    }

        //    else
        //    {
        //        var rearMulti = GetFineTuneMultiplier(result.Damping.Rebound.RearStage);

        //        var rearRateVar = result.Damping.Rebound.RearVar * rearMulti;

        //        if (stiffen)
        //        {
        //            if (result.Damping.Rebound.FtRear != 0)
        //            {
        //                result.Damping.Rebound.FtRear = result.Damping.Rebound.FtRear + rearRateVar;
        //            }

        //            else
        //            {
        //                result.Damping.Rebound.FtRear = result.Damping.Rebound.Rear + rearRateVar;
        //            }
        //        }

        //        else
        //        {
        //            if (result.Damping.Rebound.FtRear != 0)
        //            {
        //                result.Damping.Rebound.FtRear = result.Damping.Rebound.FtRear - rearRateVar;
        //            }

        //            else
        //            {
        //                result.Damping.Rebound.FtRear = result.Damping.Rebound.Rear - rearRateVar;
        //            }
        //        }
        //    }
        //}

        ///// <summary>
        ///// Reduces spring and arb stiffness
        ///// </summary>
        ///// <param name="result"></param>
        //public static void AdjustOverallStiffness(ResultObject result, bool stiffen)
        //{
        //    if (stiffen)
        //    {
        //        result.ARB.FrontStage++;
        //        result.ARB.RearStage++;

        //        result.Springs.SpringRate.FrontStage++;
        //        result.Springs.SpringRate.RearStage++;
        //    }

        //    else if (!stiffen)
        //    {
        //        result.ARB.FrontStage--;
        //        result.ARB.RearStage--;

        //        result.Springs.SpringRate.FrontStage--;
        //        result.Springs.SpringRate.RearStage--;
        //    }

        //    if (result.Springs.SpringRate.FrontStage == 0)
        //    {
        //        result.Springs.SpringRate.FtFront = result.Springs.SpringRate.Front;
        //    }

        //    if (result.Springs.SpringRate.RearStage == 0)
        //    {
        //        result.Springs.SpringRate.FtRear = result.Springs.SpringRate.Rear;
        //    }

        //    if (result.ARB.FrontStage == 0)
        //    {
        //        result.ARB.FtFront = result.ARB.Front;
        //    }

        //    if (result.ARB.RearStage == 0)
        //    {
        //        result.ARB.FtRear = result.ARB.Rear;
        //    }

        //    if (result.Springs.SpringRate.FrontStage != 0)
        //    {
        //        AdjustSpringRate(result.Springs, FineTuneConstants.Front, stiffen);
        //    }

        //    if (result.Springs.SpringRate.RearStage != 0)
        //    {
        //        AdjustSpringRate(result.Springs, FineTuneConstants.Rear, stiffen);
        //    }

        //    if (result.ARB.FrontStage != 0)
        //    {
        //        AdjustArbStiffness(result.ARB, FineTuneConstants.Front, stiffen);
        //    }

        //    if (result.ARB.RearStage != 0)
        //    {
        //        AdjustArbStiffness(result.ARB, FineTuneConstants.Rear, stiffen);
        //    }
        //}

        //private static void AdjustArbStiffness(ArbResult setting, string arb, bool stiffen)
        //{
        //    if (arb == FineTuneConstants.Front)
        //    {
        //        var frontMulti = GetFineTuneMultiplier(setting.FrontStage);

        //        var frontRateVar = setting.FrontVar * frontMulti;

        //        if (stiffen)
        //        {
        //            if (setting.FtFront != 0)
        //            {
        //                setting.FtFront = setting.FtFront + frontRateVar;
        //            }

        //            else
        //            {
        //                setting.FtFront = setting.Front + frontRateVar;
        //            }
        //        }

        //        else
        //        {
        //            if (setting.FtFront != 0)
        //            {
        //                setting.FtFront = setting.FtFront - frontRateVar;
        //            }

        //            else
        //            {
        //                setting.FtFront = setting.Front - frontRateVar;
        //            }
        //        }
        //    }

        //    else
        //    {
        //        var rearMulti = GetFineTuneMultiplier(setting.RearStage);

        //        var rearRateVar = setting.RearVar * rearMulti;

        //        if (stiffen)
        //        {
        //            if (setting.FtRear != 0)
        //            {
        //                setting.FtRear = setting.FtRear + rearRateVar;
        //            }

        //            else
        //            {
        //                setting.FtRear = setting.Rear + rearRateVar;
        //            }
        //        }

        //        else
        //        {
        //            if (setting.FtRear != 0)
        //            {
        //                setting.FtRear = setting.FtRear - rearRateVar;
        //            }

        //            else
        //            {
        //                setting.FtRear = setting.Rear - rearRateVar;
        //            }
        //        }
        //    }
        //}

        //private static void AdjustSpringRate(SpringsResult springs, string spring, bool stiffen)
        //{
        //    if (spring == FineTuneConstants.Front)
        //    {
        //        var frontSpringMulti = GetFineTuneMultiplier(springs.SpringRate.FrontStage);

        //        var frontRateVar = springs.SpringRate.FrontVar * frontSpringMulti;

        //        if (stiffen)
        //        {
        //            if (springs.SpringRate.FtFront != 0)
        //            {
        //                springs.SpringRate.FtFront = springs.SpringRate.FtFront + frontRateVar;
        //            }

        //            else
        //            {
        //                springs.SpringRate.FtFront = springs.SpringRate.Front + frontRateVar;
        //            }
        //        }

        //        else
        //        {
        //            if (springs.SpringRate.FtFront != 0)
        //            {
        //                springs.SpringRate.FtFront = springs.SpringRate.FtFront - frontRateVar;
        //            }

        //            else
        //            {
        //                springs.SpringRate.FtFront = springs.SpringRate.Front - frontRateVar;
        //            }
        //        }
        //    }

        //    else
        //    {
        //        var rearSpringMulti = GetFineTuneMultiplier(springs.SpringRate.RearStage);

        //        var rearRateVar = springs.SpringRate.RearVar * rearSpringMulti;

        //        if (stiffen)
        //        {
        //            if (springs.SpringRate.FtRear != 0)
        //            {
        //                springs.SpringRate.FtRear = springs.SpringRate.FtRear + rearRateVar;
        //            }

        //            else
        //            {
        //                springs.SpringRate.FtRear = springs.SpringRate.Rear + rearRateVar;
        //            }
        //        }

        //        else
        //        {
        //            if (springs.SpringRate.FtRear != 0)
        //            {
        //                springs.SpringRate.FtRear = springs.SpringRate.FtRear - rearRateVar;
        //            }

        //            else
        //            {
        //                springs.SpringRate.FtRear = springs.SpringRate.Rear - rearRateVar;
        //            }
        //        }
        //    }
        //}
    }
}
