using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Transactions
    {
        public int PaymentId { get; set; }
        public string InvoiceNo { get; set; }
        public string MemNo { get; set; }
        public int? CostCode { get; set; }
        public string Description { get; set; }
        public string Beneficiary { get; set; }
        public string Year { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal? Amount { get; set; }
        public bool Paid { get; set; }
        public DateTime? DatePaid { get; set; }
        public string PaymentMethod { get; set; }
        public string RepTransNo { get; set; }
        public string ReceiptNo { get; set; }
        public string StoreTransNo { get; set; }
        public bool Vatable { get; set; }
        public decimal? Vat { get; set; }
        public string TransactionNo { get; set; }
        public bool Loan { get; set; }
        public string LoanSponsor { get; set; }
        public DateTime? InceptionDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
