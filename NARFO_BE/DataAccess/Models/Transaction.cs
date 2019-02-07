using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Transaction
    {
        public Transaction()
        {
            Comission = new HashSet<Comission>();
        }

        public short PaymentId { get; set; }
        public int? InvoiceNo { get; set; }
        public string MemNo { get; set; }
        public string Description { get; set; }
        public string Beneficiary { get; set; }
        public DateTime? Year { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal? Amount { get; set; }
        public short? Paid { get; set; }
        public DateTime? DatePaid { get; set; }
        public string PaymentMethod { get; set; }
        public string RepTransNo { get; set; }
        public string ReceiptNo { get; set; }
        public string StoreTransNo { get; set; }
        public short? Vatable { get; set; }
        public decimal? Vat { get; set; }
        public string TransactionNo { get; set; }
        public short? Loan { get; set; }
        public string LoanSponsor { get; set; }
        public DateTime? InceptionDate { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public virtual Member MemNoNavigation { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual ICollection<Comission> Comission { get; set; }
    }
}
