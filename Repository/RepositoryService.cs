using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class RepositoryService : IRepositoryService
    { 
        /// <summary>
        /// Write calulation operation into DB
        /// </summary>
        /// <param name="calculationText">String representation of calculation operation</param>
        /// <returns></returns>
        public bool WriteCalculationHistory(string calculationOperation)
        {

            using (var context = new MyDbContext())
            {

                var calculatorHistory = new CalculatorHistory
                {
                    CalculationExpression = calculationOperation
                };

                context.CalculatorHistory.Add(calculatorHistory);
                context.SaveChanges();
            }

            return true;
        }


        /// <summary>
        /// Read specific number of last calculation operations
        /// </summary>
        /// <param name="numberOfLastOperation">The amount of history record to read</param>
        /// <returns>List of strings containing calculation operation</returns>
        public List<string> ReadCalculationHistory(int numberOfLastOperation)
        {
            List<string> calculationHistory;

            using (var context = new MyDbContext())
            {
                calculationHistory = context.CalculatorHistory.OrderByDescending(o => o.Id).Take(numberOfLastOperation).Select(s => s.CalculationExpression).ToList();

            }

            return calculationHistory;
        }

    }
}
