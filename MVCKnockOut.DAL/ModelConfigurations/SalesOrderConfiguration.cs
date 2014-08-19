using System.Data.Entity.ModelConfiguration;
using MVCKnockOut.Model;

namespace MVCKnockOut.DAL.ModelConfigurations
{
    public class SalesOrderConfiguration : EntityTypeConfiguration<SalesOrder>
    {
        public SalesOrderConfiguration()
        {
            Property(e => e.CustomerName).HasMaxLength(30).IsRequired();
            Property(e => e.PONumber).HasMaxLength(10).IsOptional();
        }


    }
}
