using System;
using System.Collections.Generic;

namespace GCDataTier.Models
{
    public partial class VolunteerEmail
    {
        public int VolunteerEmailId { get; set; }
        public int VolunteerId { get; set; }
        public string Email { get; set; }
        public virtual Volunteer Volunteer { get; set; }
    }
}
