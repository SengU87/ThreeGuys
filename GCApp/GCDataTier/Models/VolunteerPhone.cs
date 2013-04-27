using System;
using System.Collections.Generic;

namespace GCDataTier.Models
{
    public partial class VolunteerPhone
    {
        public int VolunteerPhoneId { get; set; }
        public int VolunteerId { get; set; }
        public string PhoneNumber { get; set; }
        public virtual Volunteer Volunteer { get; set; }
    }
}
