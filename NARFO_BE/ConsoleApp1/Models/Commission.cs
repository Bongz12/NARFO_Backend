using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Commission
    {
        public int CommissionId { get; set; }
        public short? PaymentId { get; set; }
        public DateTime? ComDate { get; set; }
        public string TransactionNo { get; set; }
        public string RepNo { get; set; }
        public string ComType { get; set; }
        public string ClientMemNo { get; set; }
        public decimal? Commission1 { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public string Branch { get; set; }
        public bool Paid { get; set; }
        public string PaymentTransNo { get; set; }
    }
}
