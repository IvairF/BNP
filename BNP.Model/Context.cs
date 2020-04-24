using System.Data.Entity;

namespace BNP.Model
{
    public class Context : DbContext
    {
        static Context()
        {
            
        }

        public void Seed(Context Context)
        {
        }

        public Context()
            : base("Name=Context")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Movimento>()
                    .MapToStoredProcedures();

            modelBuilder.HasDefaultSchema("MOVIMENTO");
        }

        
        public DbSet<Movimento> Movimento { get; set; }
        
    }
}
