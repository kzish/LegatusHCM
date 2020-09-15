using System;
using System.Collections.Generic;

namespace BlazorClient.Server.Models
{
    public partial class MCompanyBranches
    {
        public string Id { get; set; }
        public string CompanyBranchName { get; set; }
        public bool IsHeadQuarters { get; set; }
        public string CompanyId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string LocalizationId { get; set; }

        public virtual MCompany Company { get; set; }
        public virtual MLocalization Localization { get; set; }
    }
}
