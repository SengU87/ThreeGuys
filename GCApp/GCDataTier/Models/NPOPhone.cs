using System;
using System.Collections.Generic;

namespace GCDataTier.Models
{
    public partial class NPOPhone
    {
        public int NPOPhoneId { get; set; }
        public int NPOId { get; set; }
        public string PhoneNumber { get; set; }
        public virtual NPO NPO { get; set; }
    }
}
