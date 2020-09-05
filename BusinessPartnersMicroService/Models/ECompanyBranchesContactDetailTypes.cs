using System;
using System.Collections.Generic;

namespace BusinessPartnersMicroService.Models
{
    public partial class ECompanyBranchesContactDetailTypes
    {
        public ECompanyBranchesContactDetailTypes()
        {
            MCompanyBranchesContactDetails = new HashSet<MCompanyBranchesContactDetails>();
        }

        public string Id { get; set; }
        public string ContactItemType { get; set; }

        public virtual ICollection<MCompanyBranchesContactDetails> MCompanyBranchesContactDetails { get; set; }
    }
}
