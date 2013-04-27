using System;
using System.Collections.Generic;

namespace GCDataTier.Models
{
    public partial class NPOAddress
    {
        public int NPOAddressId { get; set; }
        public int NPOId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public virtual NPO NPO { get; set; }
    }
}
