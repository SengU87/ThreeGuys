using System;
using System.Collections.Generic;

namespace GCDataTier.Models
{
    public partial class NPOEmail
    {
        public int NPOEmailId { get; set; }
        public int NPOId { get; set; }
        public string Email { get; set; }
        public virtual NPO NPO { get; set; }
    }
}
