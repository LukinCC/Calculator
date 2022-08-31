using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository
{
    /// <summary>
    /// Represent calulator operation history record
    /// </summary>
    /// 
    [Table("CalculatorHistory")]
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
        public string CalculationExpression { get; set; }

    }
}
