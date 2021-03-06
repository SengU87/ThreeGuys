using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GCDataTier.Models.Mapping
{
    public class SkillMap : EntityTypeConfiguration<Skill>
    {
        public SkillMap()
        {
            // Primary Key
            this.HasKey(t => t.SkillId);

            // Properties
            this.Property(t => t.SkillCategory)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Skill");
            this.Property(t => t.SkillId).HasColumnName("SkillId");
            this.Property(t => t.SkillCategory).HasColumnName("SkillCategory");
        }
    }
}
