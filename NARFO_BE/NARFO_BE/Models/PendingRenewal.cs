using System;
using System.Collections.Generic;

namespace NARFO_BE.Models
{
    public partial class PendingRenewal
    {
        public int RenewalD { get; set; }
        public string MemNo { get; set; }
        public int? FeeType { get; set; }
        public short? FinalYear { get; set; }
        public DateTime? RenewalDate { get; set; }
        public decimal? RenewalFee { get; set; }
        public string Outlet { get; set; }
        public short? Paid { get; set; }
        public string SalesRep { get; set; }

        public virtual Member MemNoNavigation { get; set; }
    }
}
