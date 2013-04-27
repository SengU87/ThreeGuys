using System;
using System.Collections.Generic;

namespace GCDataTier.Models
{
    public partial class NPOProject
    {
        public int NPOProjectId { get; set; }
        public int NPOId { get; set; }
        public int ProjectID { get; set; }
        public virtual NPO NPO { get; set; }
        public virtual Project Project { get; set; }
    }
}
