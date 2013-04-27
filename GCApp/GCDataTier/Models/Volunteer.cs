using System;
using System.Collections.Generic;

namespace GCDataTier.Models
{
    public partial class Volunteer
    {
        public Volunteer()
        {
            this.ProjectVolunteers = new List<ProjectVolunteer>();
            this.SkillVolunteers = new List<SkillVolunteer>();
            this.VolunteerAddresses = new List<VolunteerAddress>();
            this.VolunteerEmails = new List<VolunteerEmail>();
            this.VolunteerPhones = new List<VolunteerPhone>();
        }

        public int VolunteerId { get; set; }
        public string SignUpPartyId { get; set; }
        public Nullable<System.DateTime> SignUpDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<ProjectVolunteer> ProjectVolunteers { get; set; }
        public virtual ICollection<SkillVolunteer> SkillVolunteers { get; set; }
        public virtual ICollection<VolunteerAddress> VolunteerAddresses { get; set; }
        public virtual ICollection<VolunteerEmail> VolunteerEmails { get; set; }
        public virtual ICollection<VolunteerPhone> VolunteerPhones { get; set; }
    }
}
