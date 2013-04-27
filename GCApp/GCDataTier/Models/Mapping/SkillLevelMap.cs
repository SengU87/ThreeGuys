using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GCDataTier.Models.Mapping
{
    public class SkillLevelMap : EntityTypeConfiguration<SkillLevel>
    {
        public SkillLevelMap()
        {
            // Primary Key
            this.HasKey(t => t.SkillLevelId);

            // Properties
            this.Property(t => t.SkillLevelId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SkillLevel");
            this.Property(t => t.SkillLevelId).HasColumnName("SkillLevelId");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
