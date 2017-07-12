using System;

namespace Kalkulator
{
    public static class OneArgumentsCalculatorsFactory
    {
        public static IOneArgumentsOperation CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Sin":
                    return new Sinus();
                case "Cos":
                    return new Cosinus();
                case "Tan":
                    return new Tangens();
                case "ExpPowX":
                    return new ExptoThePowerX();
                case "TenPowX":
                    return new TenToThePowerX();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
