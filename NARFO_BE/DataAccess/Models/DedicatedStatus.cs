using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class DedicatedStatus
    {
        public int DedecatedId { get; set; }
        public string MemNo { get; set; }
        public string Dstype { get; set; }
        public string Dsno { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public bool Approved { get; set; }
        public DateTime? DateApproved { get; set; }
        public string Motivation { get; set; }
        public string RefusalReason { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string TerminationReason { get; set; }
        public string TrsfAssociation { get; set; }
        public string TrsfAssociionFarno { get; set; }
        public string TrasfDsno { get; set; }
        public bool Transfer { get; set; }
        public string DocLink { get; set; }
    }
}
