using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ActivityRegister
    {
        public int ActivityId { get; set; }
        public string MemNo { get; set; }
        public DateTime? ActivityDate { get; set; }
        public string ActivityType { get; set; }
        public string ActivityDescription { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public string FirearmType { get; set; }
        public string Caliber { get; set; }
        public bool? PostalShoot { get; set; }
        public string Score { get; set; }
    }
}
