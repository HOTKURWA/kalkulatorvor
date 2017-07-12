﻿using System;

namespace Kalkulator.TwoArg
{
    public class Xpow1dY : ITwoArgumentsOperation
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, 1/second);
        }
    }
}
