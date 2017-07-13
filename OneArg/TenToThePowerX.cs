using System;

namespace Kalkulator.OneArg
{
    /// <summary>
    /// Class for Ten To The Power X function
    /// </summary>
    public class TenToThePowerX : IOneArgumentsOperation
    {
        /// <summary>
        /// Method for Ten To The Power X fucntion
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>

        public double Calculate(double first)
        {
            return Math.Pow(10,first);
        }
    }
}
