using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GCDataTier.Models.Mapping
{
    public class SkillVolunteerMap : EntityTypeConfiguration<SkillVolunteer>
    {
        public SkillVolunteerMap()
        {
            // Primary Key
            this.HasKey(t => t.SkillVolunteerId);

            // Properties
            this.Property(t => t.SkillLevelDescription)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("SkillVolunteer");
            this.Property(t => t.SkillVolunteerId).HasColumnName("SkillVolunteerId");
            this.Property(t => t.SkillId).HasColumnName("SkillId");
            this.Property(t => t.VolunteerId).HasColumnName("VolunteerId");
            this.Property(t => t.SkillLevelDescription).HasColumnName("SkillLevelDescription");

            // Relationships
            this.HasRequired(t => t.Skill)
                .WithMany(t => t.SkillVolunteers)
                .HasForeignKey(d => d.SkillId);
            this.HasOptional(t => t.SkillLevel)
                .WithMany(t => t.SkillVolunteers)
                .HasForeignKey(d => d.SkillLevelDescription);
            this.HasRequired(t => t.Volunteer)
                .WithMany(t => t.SkillVolunteers)
                .HasForeignKey(d => d.VolunteerId);

        }
    }
}
