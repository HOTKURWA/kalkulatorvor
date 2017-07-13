using System;

namespace Kalkulator.OneArg
{
    /// <summary>
    /// Class for Expto The Power X function
    /// </summary>
    
    public class ExptoThePowerX : IOneArgumentsOperation
    {
        /// <summary>
        /// Method for Expto The Power X fucntion
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>
      
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}
