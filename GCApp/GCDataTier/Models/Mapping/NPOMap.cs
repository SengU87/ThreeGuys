using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GCDataTier.Models.Mapping
{
    public class NPOMap : EntityTypeConfiguration<NPO>
    {
        public NPOMap()
        {
            // Primary Key
            this.HasKey(t => t.NPOID);

            // Properties
            this.Property(t => t.NPOID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("NPO");
            this.Property(t => t.NPOID).HasColumnName("NPOID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
