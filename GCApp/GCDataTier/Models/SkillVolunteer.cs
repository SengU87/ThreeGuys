using System;
using System.Collections.Generic;

namespace GCDataTier.Models
{
    public partial class SkillVolunteer
    {
        public int SkillVolunteerId { get; set; }
        public int SkillId { get; set; }
        public int VolunteerId { get; set; }
        public string SkillLevelDescription { get; set; }
        public virtual Skill Skill { get; set; }
        public virtual SkillLevel SkillLevel { get; set; }
        public virtual Volunteer Volunteer { get; set; }
    }
}
