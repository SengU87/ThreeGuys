using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GCDataTier.Models.Mapping
{
    public class NPOPhoneMap : EntityTypeConfiguration<NPOPhone>
    {
        public NPOPhoneMap()
        {
            // Primary Key
            this.HasKey(t => t.NPOPhoneId);

            // Properties
            this.Property(t => t.NPOPhoneId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PhoneNumber)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("NPOPhone");
            this.Property(t => t.NPOPhoneId).HasColumnName("NPOPhoneId");
            this.Property(t => t.NPOId).HasColumnName("NPOId");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");

            // Relationships
            this.HasRequired(t => t.NPO)
                .WithMany(t => t.NPOPhones)
                .HasForeignKey(d => d.NPOId);

        }
    }
}
