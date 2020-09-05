using System;
using System.Collections.Generic;

namespace BusinessPartnersMicroService.Models
{
    public partial class MCompanyBranchesContactDetails
    {
        public string Id { get; set; }
        public string CompanyBranchId { get; set; }
        public string ContactItem { get; set; }
        public string ContactItemDescription { get; set; }
        public string ContactItemType { get; set; }

        public virtual ECompanyBranchesContactDetailTypes ContactItemTypeNavigation { get; set; }
    }
}
