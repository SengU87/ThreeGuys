using System;
using System.Collections.Generic;

namespace GCDataTier.Models
{
    public partial class Skill
    {
        public Skill()
        {
            this.SkillVolunteers = new List<SkillVolunteer>();
        }

        public int SkillId { get; set; }
        public string SkillCategory { get; set; }
        public virtual ICollection<SkillVolunteer> SkillVolunteers { get; set; }
    }
}
