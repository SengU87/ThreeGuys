using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GCDataTier.Models.Mapping
{
    public class ContactMap : EntityTypeConfiguration<Contact>
    {
        public ContactMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactId);

            // Properties
            this.Property(t => t.Email)
                .HasMaxLength(100);

            this.Property(t => t.PhoneNumber)
                .HasMaxLength(100);

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
            this.ToTable("Contact");
            this.Property(t => t.ContactId).HasColumnName("ContactId");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
            this.Property(t => t.AddressLine1).HasColumnName("AddressLine1");
            this.Property(t => t.AddressLine2).HasColumnName("AddressLine2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Zip).HasColumnName("Zip");
            this.Property(t => t.Country).HasColumnName("Country");
        }
    }
}
