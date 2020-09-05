using System;
using System.Collections.Generic;

namespace BusinessPartnersMicroService.Models
{
    public partial class PayrollEPaymentCycleTypes
    {
        public string Id { get; set; }
        public string PaymentCycleName { get; set; }
        public string CompanyId { get; set; }
    }
}
