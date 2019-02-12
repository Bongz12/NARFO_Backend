using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NARFO_BE.Models
{
    public partial class DedicatedStatus
    {
        public int DedicatedId { get; set; }
        public string MemNo { get; set; }
        public string Dstype { get; set; }
        public string Dsno { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public string Approved { get; set; }
        public DateTime? DateApproved { get; set; }
        public string Motivation { get; set; }
        public string RefusalReason { get; set; }
        public string Termination { get; set; }
        public string TerminationReason { get; set; }
        public string TrsfAssociation { get; set; }
        public decimal? TrsfAssociationFarn { get; set; }
        public string TrasfDsno { get; set; }
        public string Transfare { get; set; }
        public Guid? DocLink { get; set; }

        public virtual Member MemNoNavigation { get; set; }
    }
}
