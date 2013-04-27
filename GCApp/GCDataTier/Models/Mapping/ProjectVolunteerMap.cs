using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GCDataTier.Models.Mapping
{
    public class ProjectVolunteerMap : EntityTypeConfiguration<ProjectVolunteer>
    {
        public ProjectVolunteerMap()
        {
            // Primary Key
            this.HasKey(t => t.ProjectVolunteerId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ProjectVolunteer");
            this.Property(t => t.ProjectVolunteerId).HasColumnName("ProjectVolunteerId");
            this.Property(t => t.ProjectId).HasColumnName("ProjectId");
            this.Property(t => t.VolunteerId).HasColumnName("VolunteerId");
            this.Property(t => t.IsLead).HasColumnName("IsLead");

            // Relationships
            this.HasRequired(t => t.Project)
                .WithMany(t => t.ProjectVolunteers)
                .HasForeignKey(d => d.ProjectId);
            this.HasRequired(t => t.Volunteer)
                .WithMany(t => t.ProjectVolunteers)
                .HasForeignKey(d => d.VolunteerId);

        }
    }
}
