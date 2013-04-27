using System;
using System.Collections.Generic;

namespace GCDataTier.Models
{
    public partial class NPO
    {
        public NPO()
        {
            this.ContactLinks = new List<ContactLink>();
            this.NPOProjects = new List<NPOProject>();
        }

        public int NPOID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ContactLink> ContactLinks { get; set; }
        public virtual ICollection<NPOProject> NPOProjects { get; set; }
    }
}
