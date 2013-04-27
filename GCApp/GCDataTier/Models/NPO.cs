using System;
using System.Collections.Generic;

namespace GCDataTier.Models
{
    public partial class NPO
    {
        public NPO()
        {
            this.NPOAddresses = new List<NPOAddress>();
            this.NPOEmails = new List<NPOEmail>();
            this.NPOPhones = new List<NPOPhone>();
            this.NPOProjects = new List<NPOProject>();
        }

        public int NPOID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<NPOAddress> NPOAddresses { get; set; }
        public virtual ICollection<NPOEmail> NPOEmails { get; set; }
        public virtual ICollection<NPOPhone> NPOPhones { get; set; }
        public virtual ICollection<NPOProject> NPOProjects { get; set; }
    }
}
