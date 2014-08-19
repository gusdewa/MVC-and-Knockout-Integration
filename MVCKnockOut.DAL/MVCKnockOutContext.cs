using System.Data.Entity;
using MVCKnockOut.DAL.ModelConfigurations;
using MVCKnockOut.Model;

namespace MVCKnockOut.DAL
{
    public class MVCKnockOutContext : DbContext
    {
        public MVCKnockOutContext() : base("DefaultConnection")
        {
            
        }

        public DbSet<SalesOrder> SalesOrders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SalesOrderConfiguration());
        }
    }
}