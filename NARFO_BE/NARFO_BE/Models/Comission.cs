using System;
using System.Collections.Generic;

namespace NARFO_BE.Models
{
    public partial class Comission
    {
        public short ComissionId { get; set; }
        public short? PaymentId { get; set; }
        public DateTime? ComDate { get; set; }
        public string TransactionNo { get; set; }
        public string RepNo { get; set; }
        public string ComType { get; set; }
        public string ClientMemNo { get; set; }
        public decimal? Comission1 { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public string Branch { get; set; }
        public short? Paid { get; set; }
        public string PaymentTransNo { get; set; }
        public decimal? Code { get; set; }

        public virtual CostCode CodeNavigation { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual Transaction TransactionNoNavigation { get; set; }
    }
}
