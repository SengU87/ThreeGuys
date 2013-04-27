using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GCDataTier.Models.Mapping
{
    public class VolunteerPhoneMap : EntityTypeConfiguration<VolunteerPhone>
    {
        public VolunteerPhoneMap()
        {
            // Primary Key
            this.HasKey(t => t.VolunteerPhoneId);

            // Properties
            this.Property(t => t.VolunteerPhoneId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PhoneNumber)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("VolunteerPhone");
            this.Property(t => t.VolunteerPhoneId).HasColumnName("VolunteerPhoneId");
            this.Property(t => t.VolunteerId).HasColumnName("VolunteerId");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");

            // Relationships
            this.HasRequired(t => t.Volunteer)
                .WithMany(t => t.VolunteerPhones)
                .HasForeignKey(d => d.VolunteerId);

        }
    }
}
