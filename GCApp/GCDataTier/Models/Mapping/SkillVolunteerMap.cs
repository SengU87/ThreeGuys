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
            this.Property(t => t.SkillVolunteerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SkillVolunteer");
            this.Property(t => t.SkillVolunteerId).HasColumnName("SkillVolunteerId");
            this.Property(t => t.SkillId).HasColumnName("SkillId");
            this.Property(t => t.VolunteerId).HasColumnName("VolunteerId");
            this.Property(t => t.SkillLevelId).HasColumnName("SkillLevelId");

            // Relationships
            this.HasRequired(t => t.Skill)
                .WithMany(t => t.SkillVolunteers)
                .HasForeignKey(d => d.SkillId);
            this.HasRequired(t => t.Volunteer)
                .WithMany(t => t.SkillVolunteers)
                .HasForeignKey(d => d.VolunteerId);

        }
    }
}
