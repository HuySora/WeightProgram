using SQLite.CodeFirst;
using System.Data.Entity;

namespace WeightProgram.Data {
    public class WeightProgramContext : DbContext {
        public DbSet<Customer> Customers { get; set; }

        public WeightProgramContext() : base("name=WeightProgramDb") {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            // Ensure the database is created
            Database.SetInitializer(new SqliteCreateDatabaseIfNotExists<WeightProgramContext>(modelBuilder));
            modelBuilder.Entity<Customer>().ToTable("Customers");
        }
    }
}