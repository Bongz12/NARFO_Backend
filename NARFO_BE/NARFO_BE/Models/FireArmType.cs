using System;
using System.Collections.Generic;

namespace NARFO_BE.Models
{
    public partial class FireArmType
    {
        public FireArmType()
        {
            Endorsement = new HashSet<Endorsement>();
        }

        public string FireArmType1 { get; set; }

        public virtual ICollection<Endorsement> Endorsement { get; set; }
    }
}
