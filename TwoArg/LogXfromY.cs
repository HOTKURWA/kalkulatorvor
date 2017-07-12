using System;

namespace Kalkulator.TwoArg
{
    public class LogXfromY : ITwoArgumentsOperation
    {
        public double Calculate(double first, double second)
        {
            return Math.Log(first,second);
        }
    }
}
