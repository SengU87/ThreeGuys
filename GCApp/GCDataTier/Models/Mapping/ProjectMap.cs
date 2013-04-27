using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GCDataTier.Models.Mapping
{
    public class ProjectMap : EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            // Primary Key
            this.HasKey(t => t.ProjectId);

            // Properties
            this.Property(t => t.VettedBy)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Project");
            this.Property(t => t.ProjectId).HasColumnName("ProjectId");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Overview).HasColumnName("Overview");
            this.Property(t => t.BusReq).HasColumnName("BusReq");
            this.Property(t => t.FuncReq).HasColumnName("FuncReq");
            this.Property(t => t.TechReq).HasColumnName("TechReq");
            this.Property(t => t.AdditionalDetails).HasColumnName("AdditionalDetails");
            this.Property(t => t.CanBeCompleted).HasColumnName("CanBeCompleted");
            this.Property(t => t.RequiredDevelopers).HasColumnName("RequiredDevelopers");
            this.Property(t => t.RequiredDesigners).HasColumnName("RequiredDesigners");
            this.Property(t => t.RequiredSupport).HasColumnName("RequiredSupport");
            this.Property(t => t.Agile).HasColumnName("Agile");
            this.Property(t => t.NPOTechSkill).HasColumnName("NPOTechSkill");
            this.Property(t => t.Confirmation).HasColumnName("Confirmation");
            this.Property(t => t.Accepted).HasColumnName("Accepted");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.VettedBy).HasColumnName("VettedBy");
        }
    }
}
