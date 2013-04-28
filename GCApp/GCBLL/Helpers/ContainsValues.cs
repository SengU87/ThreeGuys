using GCDataTier.Models;

namespace GCBLL.Helpers
{
    public static class ContainsValues
    {
        public static bool Contact(Contact contact)
        {
            bool hasData = !string.IsNullOrEmpty(contact.PhoneNumber) || !string.IsNullOrEmpty(contact.Email) ||
                           !string.IsNullOrEmpty(contact.PhoneNumber) || !string.IsNullOrEmpty(contact.AddressLine1);

            return hasData;
        }
    }
}
