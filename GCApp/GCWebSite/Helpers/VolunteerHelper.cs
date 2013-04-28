using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GCWebSite.Helpers
{
    public class VolunteerHelper
    {
        public static bool hasVolunteer(GCDataTier.Models.Volunteer objVol, List<GCDataTier.Models.Volunteer> objVols)
        {
            bool bValid = false;

            foreach (GCDataTier.Models.Volunteer vol in objVols)
            {
                if (vol.SignUpPartyId != objVol.SignUpPartyId)
                {
                    bValid = true;
                    break;
                }
            }
            return bValid;      
        }
    }
}