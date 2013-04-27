using System;
using System.Collections.Generic;

namespace GCDataTier.Models
{
    public partial class SkillLevel
    {
        public SkillLevel()
        {
            this.Skills = new List<Skill>();
        }

        public int SkillLevelId { get; set; }
        public string SkillLevelDescription { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}
