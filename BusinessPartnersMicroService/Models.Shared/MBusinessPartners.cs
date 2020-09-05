using System;
using System.Collections.Generic;

namespace Shared
{
    public class MBusinessPartners
    {
        public string Id { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string Name { get; set; }
        public string BusinessPartnersCategory { get; set; }
        public string Image { get; set; }
        public string NationalId { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public bool? Active { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string LocalizationId { get; set; }

    }
}
