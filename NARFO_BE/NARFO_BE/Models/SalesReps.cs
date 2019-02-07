using System;
using System.Collections.Generic;

namespace NARFO_BE.Models
{
    public partial class SalesReps
    {
        public int Id { get; set; }
        public string MemNo { get; set; }
        public string AccountType { get; set; }
        public decimal? AccountNo { get; set; }
        public string Frequency { get; set; }

        public virtual Member MemNoNavigation { get; set; }
    }
}
