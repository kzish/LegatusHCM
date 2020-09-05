using System;
using System.Collections.Generic;

namespace BusinessPartnersMicroService.Models
{
    public partial class MBank
    {
        public MBank()
        {
            MBankBranches = new HashSet<MBankBranches>();
        }

        public string Id { get; set; }
        public string BankName { get; set; }

        public virtual ICollection<MBankBranches> MBankBranches { get; set; }
    }
}
