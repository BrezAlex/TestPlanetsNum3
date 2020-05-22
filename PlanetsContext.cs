using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
