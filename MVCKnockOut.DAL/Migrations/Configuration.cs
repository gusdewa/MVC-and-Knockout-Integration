using System.Data.Entity.Migrations;
using MVCKnockOut.Model;

namespace MVCKnockOut.DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MVCKnockOutContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        /// <summary>
        ///     Inserting sample data each time database is updated
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(MVCKnockOutContext context)
        {
            context.SalesOrders.AddOrUpdate(e => e.CustomerName,
                new SalesOrder  {CustomerName = "Dewa", PONumber = "PO123"},
                new SalesOrder  {CustomerName = "Rindha"});
        }
    }
}