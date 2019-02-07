using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Payment
    {
        public Payment()
        {
            Comission = new HashSet<Comission>();
            Transaction = new HashSet<Transaction>();
        }

        public short PaymentId { get; set; }
        public string PaymentType { get; set; }
        public string MemNo { get; set; }

        public virtual Member MemNoNavigation { get; set; }
        public virtual ICollection<Comission> Comission { get; set; }
        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
