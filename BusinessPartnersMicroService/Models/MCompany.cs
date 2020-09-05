using System;
using System.Collections.Generic;

namespace BusinessPartnersMicroService.Models
{
    public partial class MCompany
    {
        public MCompany()
        {
            MCompanyBranches = new HashSet<MCompanyBranches>();
        }

        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogo { get; set; }

        public virtual ICollection<MCompanyBranches> MCompanyBranches { get; set; }
    }
}
