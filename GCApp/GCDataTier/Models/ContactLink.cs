using System;
using System.Collections.Generic;

namespace GCDataTier.Models
{
    public partial class ContactLink
    {
        public int ContactLinkId { get; set; }
        public int ContactId { get; set; }
        public Nullable<int> VolunteerId { get; set; }
        public Nullable<int> NPOId { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual NPO NPO { get; set; }
        public virtual Volunteer Volunteer { get; set; }
    }
}
