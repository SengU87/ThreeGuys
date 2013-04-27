using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GCDataTier.Models.Mapping
{
    public class VolunteerEmailMap : EntityTypeConfiguration<VolunteerEmail>
    {
        public VolunteerEmailMap()
        {
            // Primary Key
            this.HasKey(t => t.VolunteerEmailId);

            // Properties
            this.Property(t => t.VolunteerEmailId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("VolunteerEmail");
            this.Property(t => t.VolunteerEmailId).HasColumnName("VolunteerEmailId");
            this.Property(t => t.VolunteerId).HasColumnName("VolunteerId");
            this.Property(t => t.Email).HasColumnName("Email");

            // Relationships
            this.HasRequired(t => t.Volunteer)
                .WithMany(t => t.VolunteerEmails)
                .HasForeignKey(d => d.VolunteerId);

        }
    }
}
