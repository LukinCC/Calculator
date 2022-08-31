using System.ComponentModel.DataAnnotations;

namespace Repository
{
    /// <summary>
    /// Represent calulator operation history record
    /// </summary>
    public class CalculatorHistory
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Calculation text representation
        /// </summary>
        public string CalcationExpression { get; set; }

    }
}
