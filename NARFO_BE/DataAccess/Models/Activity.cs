using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Activity
    {
        public int ActiviryId { get; set; }
        public string ActivityType { get; set; }
        public string MemNo { get; set; }
        public DateTime? ActivityDate { get; set; }
        public string ActivityDescription { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public string FirearmType { get; set; }
        public string Caliber { get; set; }
        public short? PostalShoot { get; set; }
        public double? Score { get; set; }

        public virtual Member MemNoNavigation { get; set; }
    }
}
