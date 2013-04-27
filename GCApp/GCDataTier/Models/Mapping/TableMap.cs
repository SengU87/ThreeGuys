using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GCDataTier.Models.Mapping
{
    public class TableMap : EntityTypeConfiguration<Table>
    {
        public TableMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Table");
            this.Property(t => t.ContactId).HasColumnName("ContactId");
        }
    }
}
