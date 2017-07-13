namespace Kalkulator.TwoArg
{
    /// <summary>
    /// Class for interface function
    /// </summary>
    public interface ITwoArgumentsOperation
    {
        /// <summary>
        /// Method for interface fucntion
        /// </summary>
        /// <param name="first">Input value</param>
        /// <param name="second">Input value</param>
        /// <returns>Calculated value</returns>
        double Calculate(double first, double second);
    }
}
