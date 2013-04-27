using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GCDataTier.Models.Mapping
{
    public class VolunteerAddressMap : EntityTypeConfiguration<VolunteerAddress>
    {
        public VolunteerAddressMap()
        {
            // Primary Key
            this.HasKey(t => t.VolunteerAddressId);

            // Properties
            this.Property(t => t.VolunteerAddressId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AddressLine1)
                .HasMaxLength(100);

            this.Property(t => t.AddressLine2)
                .HasMaxLength(100);

            this.Property(t => t.City)
                .HasMaxLength(100);

            this.Property(t => t.State)
                .HasMaxLength(100);

            this.Property(t => t.Zip)
                .HasMaxLength(100);

            this.Property(t => t.Country)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("VolunteerAddress");
            this.Property(t => t.VolunteerAddressId).HasColumnName("VolunteerAddressId");
            this.Property(t => t.VolunteerId).HasColumnName("VolunteerId");
            this.Property(t => t.AddressLine1).HasColumnName("AddressLine1");
            this.Property(t => t.AddressLine2).HasColumnName("AddressLine2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Zip).HasColumnName("Zip");
            this.Property(t => t.Country).HasColumnName("Country");

            // Relationships
            this.HasRequired(t => t.Volunteer)
                .WithMany(t => t.VolunteerAddresses)
                .HasForeignKey(d => d.VolunteerId);

        }
    }
}
