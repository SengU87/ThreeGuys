using System;
using System.Collections.Generic;

namespace GCDataTier.Models
{
    public partial class Contact
    {
        public Contact()
        {
            this.ContactLinks = new List<ContactLink>();
        }

        public int ContactId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public virtual ICollection<ContactLink> ContactLinks { get; set; }
    }
}
