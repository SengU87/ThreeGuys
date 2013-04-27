using System;
using System.Collections.Generic;

namespace GCDataTier.Models
{
    public partial class VolunteerAddress
    {
        public int VolunteerAddressId { get; set; }
        public int VolunteerId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public virtual Volunteer Volunteer { get; set; }
    }
}
