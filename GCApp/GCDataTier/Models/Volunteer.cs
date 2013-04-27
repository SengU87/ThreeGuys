using System;
using System.Collections.Generic;

namespace GCDataTier.Models
{
    public partial class Volunteer
    {
        public Volunteer()
        {
            this.ContactLinks = new List<ContactLink>();
            this.ProjectVolunteers = new List<ProjectVolunteer>();
            this.SkillVolunteers = new List<SkillVolunteer>();
            this.VolunteerEmails = new List<VolunteerEmail>();
        }

        public int VolunteerId { get; set; }
        public string SignUpPartyId { get; set; }
        public Nullable<System.DateTime> SignUpDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<ContactLink> ContactLinks { get; set; }
        public virtual ICollection<ProjectVolunteer> ProjectVolunteers { get; set; }
        public virtual ICollection<SkillVolunteer> SkillVolunteers { get; set; }
        public virtual ICollection<VolunteerEmail> VolunteerEmails { get; set; }
    }
}
