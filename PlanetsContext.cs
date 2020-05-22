using System.Data.Entity;

namespace TestPlanetsNum3
{
    class PlanetsContext:DbContext
    {
        public PlanetsContext()
            : base("DbConnection")
        { }
        public DbSet<Planets> Planets { get; set; }
    }
}
