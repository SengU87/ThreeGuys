using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GCDataTier.Models.Mapping
{
    public class NPOEmailMap : EntityTypeConfiguration<NPOEmail>
    {
        public NPOEmailMap()
        {
            // Primary Key
            this.HasKey(t => t.NPOEmailId);

            // Properties
            this.Property(t => t.NPOEmailId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("NPOEmail");
            this.Property(t => t.NPOEmailId).HasColumnName("NPOEmailId");
            this.Property(t => t.NPOId).HasColumnName("NPOId");
            this.Property(t => t.Email).HasColumnName("Email");

            // Relationships
            this.HasRequired(t => t.NPO)
                .WithMany(t => t.NPOEmails)
                .HasForeignKey(d => d.NPOId);

        }
    }
}
