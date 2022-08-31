namespace Calculator
{
    public interface IStringCalculator
    {
        /// <summary>
        /// Calculate value from expression
        /// </summary>
        /// <param name="caluationExpression">The expression that contains two values with operation</param>
        /// <param name="integerResult">The result convert to integer value </param>
        /// <returns>Result of calcuation from expression</returns>
        string Calculate(string caluationExpression, bool integerResult = false);
    }
}
