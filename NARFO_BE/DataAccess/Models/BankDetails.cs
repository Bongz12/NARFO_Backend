using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class BankDetails
    {
        public string BankDetailsId { get; set; }
        public string Company { get; set; }
        public decimal? AccountNumber { get; set; }
        public decimal? ContactNumber { get; set; }
        public string BranchCode { get; set; }
    }
}
