using System;
using System.Collections.Generic;

namespace LegatusAdmin.Models
{
    public partial class MBankBranches
    {
        public string Id { get; set; }
        public string BranchName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string BankId { get; set; }

        public virtual MBank Bank { get; set; }
    }
}
