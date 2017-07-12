namespace Kalkulator.TwoArg
{
    public class Division : ITwoArgumentsOperation
    {
        public double Calculate(double first, double second)
        {
            return first / second;
        }
    }
}
