using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class CostCode
    {
        public CostCode()
        {
            Comission = new HashSet<Comission>();
            CommissionStructure = new HashSet<CommissionStructure>();
        }

        public decimal Code { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Comission> Comission { get; set; }
        public virtual ICollection<CommissionStructure> CommissionStructure { get; set; }
    }
}
