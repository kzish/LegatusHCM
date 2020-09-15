using System;
using System.Collections.Generic;

namespace BlazorClient.Server.Models
{
    public partial class MLocalization
    {
        public MLocalization()
        {
            MCompanyBranches = new HashSet<MCompanyBranches>();
        }

        public string Id { get; set; }
        public string LocalizationName { get; set; }
        public string CurrencySymbol { get; set; }
        public string CurrencyIsoCode { get; set; }
        public string CurrencyLongName { get; set; }

        public virtual ICollection<MCompanyBranches> MCompanyBranches { get; set; }
    }
}
