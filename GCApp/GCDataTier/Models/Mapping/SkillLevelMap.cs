using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GCDataTier.Models.Mapping
{
    public class SkillLevelMap : EntityTypeConfiguration<SkillLevel>
    {
        public SkillLevelMap()
        {
            // Primary Key
            this.HasKey(t => t.SkillLevelDescription);

            // Properties
            this.Property(t => t.SkillLevelDescription)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("SkillLevel");
            this.Property(t => t.SkillLevelId).HasColumnName("SkillLevelId");
            this.Property(t => t.SkillLevelDescription).HasColumnName("SkillLevelDescription");
        }
    }
}
