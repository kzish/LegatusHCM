using System;
using System.Collections.Generic;

namespace LegatusAdmin.Models
{
    public partial class MCompany
    {
        public MCompany()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
            MCompanyBranches = new HashSet<MCompanyBranches>();
        }

        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogo { get; set; }

        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
        public virtual ICollection<MCompanyBranches> MCompanyBranches { get; set; }
    }
}
