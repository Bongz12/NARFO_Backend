using System;
using System.Collections.Generic;

namespace NARFO_BE.Models
{
    public partial class Endorsement
    {
        public int EndorsId { get; set; }
        public string MemNo { get; set; }
        public string EndorsementNo { get; set; }
        public string EndorsementType { get; set; }
        public string FireArmType { get; set; }
        public string FireArmMakeModel { get; set; }
        public string Calibre { get; set; }
        public string SerialNumber { get; set; }
        public string Fcasection { get; set; }
        public DateTime? EndorsementDate { get; set; }
        public string Action { get; set; }

        public virtual FireArmType FireArmTypeNavigation { get; set; }
        public virtual Member MemNoNavigation { get; set; }
    }
}
