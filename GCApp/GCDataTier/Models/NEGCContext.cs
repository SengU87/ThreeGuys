using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using GCDataTier.Models.Mapping;

namespace GCDataTier.Models
{
    public partial class NEGCContext : DbContext
    {
        static NEGCContext()
        {
            Database.SetInitializer<NEGCContext>(null);
        }

        public NEGCContext()
            : base("Name=NEGCContext")
        {
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactLink> ContactLinks { get; set; }
        public DbSet<NPO> NPOes { get; set; }
        public DbSet<NPOProject> NPOProjects { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectVolunteer> ProjectVolunteers { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillLevel> SkillLevels { get; set; }
        public DbSet<SkillVolunteer> SkillVolunteers { get; set; }
        //public DbSet<Table> Tables { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        //public DbSet<VolunteerEmail> VolunteerEmails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ContactMap());
            modelBuilder.Configurations.Add(new ContactLinkMap());
            modelBuilder.Configurations.Add(new NPOMap());
            modelBuilder.Configurations.Add(new NPOProjectMap());
            modelBuilder.Configurations.Add(new ProjectMap());
            modelBuilder.Configurations.Add(new ProjectVolunteerMap());
            modelBuilder.Configurations.Add(new SkillMap());
            modelBuilder.Configurations.Add(new SkillLevelMap());
            modelBuilder.Configurations.Add(new SkillVolunteerMap());
            //modelBuilder.Configurations.Add(new TableMap());
            modelBuilder.Configurations.Add(new VolunteerMap());
            //modelBuilder.Configurations.Add(new VolunteerEmailMap());
        }
    }
}
