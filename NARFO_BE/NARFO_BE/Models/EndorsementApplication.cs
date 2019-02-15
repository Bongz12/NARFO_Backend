using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NARFO_BE.Models
{
    public class EndorsementApplication
    {
        [Key]
        public int EndorsAppID { get; set; }

        public string Title { get; set; }
        public Boolean DedicatedStatus { get; set; }
        public string ApplicationType { get; set; }
        public string Section { get; set; }
        public string FireArmType { get; set; }
        public string ActionType { get; set; }
        public string Caliber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string Status { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string Motivation { get; set; }
        public Boolean Declaration { get; set; }

    }
}
