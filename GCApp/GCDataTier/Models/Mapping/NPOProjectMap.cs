using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GCDataTier.Models.Mapping
{
    public class NPOProjectMap : EntityTypeConfiguration<NPOProject>
    {
        public NPOProjectMap()
        {
            // Primary Key
            this.HasKey(t => t.NPOProjectId);

            // Properties
            this.Property(t => t.NPOProjectId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("NPOProject");
            this.Property(t => t.NPOProjectId).HasColumnName("NPOProjectId");
            this.Property(t => t.NPOId).HasColumnName("NPOId");
            this.Property(t => t.ProjectID).HasColumnName("ProjectID");

            // Relationships
            this.HasRequired(t => t.NPO)
                .WithMany(t => t.NPOProjects)
                .HasForeignKey(d => d.NPOId);
            this.HasRequired(t => t.Project)
                .WithMany(t => t.NPOProjects)
                .HasForeignKey(d => d.ProjectID);

        }
    }
}
