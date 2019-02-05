using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class BankDetails
    {
        public int BankDetailsId { get; set; }
        public string Company { get; set; }
        public string AccountNumber { get; set; }
        public string ContraNumber { get; set; }
    }
}
