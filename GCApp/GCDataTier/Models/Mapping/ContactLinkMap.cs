using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GCDataTier.Models.Mapping
{
    public class ContactLinkMap : EntityTypeConfiguration<ContactLink>
    {
        public ContactLinkMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactLinkId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ContactLink");
            this.Property(t => t.ContactLinkId).HasColumnName("ContactLinkId");
            this.Property(t => t.ContactId).HasColumnName("ContactId");
            this.Property(t => t.VolunteerId).HasColumnName("VolunteerId");
            this.Property(t => t.NPOId).HasColumnName("NPOId");

            // Relationships
            this.HasRequired(t => t.Contact)
                .WithMany(t => t.ContactLinks)
                .HasForeignKey(d => d.ContactId);
            this.HasOptional(t => t.NPO)
                .WithMany(t => t.ContactLinks)
                .HasForeignKey(d => d.NPOId);
            this.HasOptional(t => t.Volunteer)
                .WithMany(t => t.ContactLinks)
                .HasForeignKey(d => d.VolunteerId);

        }
    }
}
