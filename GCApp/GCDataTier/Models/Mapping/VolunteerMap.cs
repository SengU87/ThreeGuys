using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GCDataTier.Models.Mapping
{
    public class VolunteerMap : EntityTypeConfiguration<Volunteer>
    {
        public VolunteerMap()
        {
            // Primary Key
            this.HasKey(t => t.VolunteerId);

            // Properties
            this.Property(t => t.SignUpPartyId)
                .HasMaxLength(100);

            this.Property(t => t.FirstName)
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Volunteer");
            this.Property(t => t.VolunteerId).HasColumnName("VolunteerId");
            this.Property(t => t.SignUpPartyId).HasColumnName("SignUpPartyId");
            this.Property(t => t.SignUpDate).HasColumnName("SignUpDate");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
        }
    }
}
