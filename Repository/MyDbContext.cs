using System.Data.Entity;

namespace Repository
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("CalculatorDB") { }
        public virtual DbSet<CalculatorHistory> CalculatorHistory { get; set; }
    }
}
