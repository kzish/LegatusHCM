using System;
using System.Collections.Generic;

namespace BusinessPartnersMicroService.Models
{
    public partial class PayrollMBusinessPartners
    {
        public string Id { get; set; }
        public string BusinessPartnerId { get; set; }
        public string BankId { get; set; }
        public string BankBranchId { get; set; }
        public string BankAccountNumber { get; set; }
        public decimal? GrossSalary { get; set; }
        public string PaymentCycleId { get; set; }
        public DateTime? LastPayrun { get; set; }

        public virtual MBusinessPartners BusinessPartner { get; set; }
    }
}
