using System;
using System.Collections.Generic;

namespace GCDataTier.Models
{
    public partial class SkillLevel
    {
        public SkillLevel()
        {
            this.SkillVolunteers = new List<SkillVolunteer>();
        }

        public int SkillLevelId { get; set; }
        public string SkillLevelDescription { get; set; }
        public virtual ICollection<SkillVolunteer> SkillVolunteers { get; set; }
    }
}
