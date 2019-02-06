using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class PendingRenewal
    {
        public int RenewalId { get; set; }
        public string MemNo { get; set; }
        public int? FeeType { get; set; }
        public string FinYear { get; set; }
        public DateTime? RenewalDate { get; set; }
        public decimal? RenewalFee { get; set; }
        public string Outlet { get; set; }
        public bool Paid { get; set; }
        public string SalesRep { get; set; }
    }
}
