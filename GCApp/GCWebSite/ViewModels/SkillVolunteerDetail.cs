using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GCDataTier.Models;

namespace GCWebSite.ViewModels
{
    public class SkillVolunteerDetail
    {
        public SkillVolunteer SkillVolunteer { get; set; }
        public Volunteer Volunteer { get; set; }
    }
}