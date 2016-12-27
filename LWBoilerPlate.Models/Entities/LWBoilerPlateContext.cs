using System.Data.Entity;

namespace LWBoilerPlate.Models.Entities
{
    public partial class LWBoilerPlateContext : DbContext
    {
        public LWBoilerPlateContext()
            : base("name=LWBoilerPlateContext")
        {
        }

        public virtual DbSet<LW_EXAMPLE> LW_EXAMPLE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public static LWBoilerPlateContext DbEntities { get; set; }

        public static void SetContext(LWBoilerPlateContext context)
        {
            DbEntities = context;
        }

        public static LWBoilerPlateContext GetContext()
        {
            return DbEntities;
        }
    }
}
