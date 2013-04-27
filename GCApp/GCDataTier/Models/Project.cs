using System;
using System.Collections.Generic;

namespace GCDataTier.Models
{
    public partial class Project
    {
        public Project()
        {
            this.NPOProjects = new List<NPOProject>();
            this.ProjectVolunteers = new List<ProjectVolunteer>();
        }

        public int ProjectId { get; set; }
        public string Type { get; set; }
        public string Overview { get; set; }
        public string BusReq { get; set; }
        public string FuncReq { get; set; }
        public string TechReq { get; set; }
        public string AdditionalDetails { get; set; }
        public Nullable<bool> CanBeCompleted { get; set; }
        public Nullable<int> RequiredDevelopers { get; set; }
        public Nullable<int> RequiredDesigners { get; set; }
        public Nullable<int> RequiredSupport { get; set; }
        public Nullable<bool> Agile { get; set; }
        public string NPOTechSkill { get; set; }
        public Nullable<bool> Confirmation { get; set; }
        public Nullable<bool> Accepted { get; set; }
        public string Comments { get; set; }
        public string VettedBy { get; set; }
        public virtual ICollection<NPOProject> NPOProjects { get; set; }
        public virtual ICollection<ProjectVolunteer> ProjectVolunteers { get; set; }
    }
}
