using System;
using System.Collections.Generic;

namespace GCDataTier.Models
{
    public partial class ProjectVolunteer
    {
        public int ProjectVolunteerId { get; set; }
        public int ProjectId { get; set; }
        public int VolunteerId { get; set; }
        public Nullable<bool> IsLead { get; set; }
        public virtual Project Project { get; set; }
        public virtual Volunteer Volunteer { get; set; }
    }
}
