using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class CommissionStructure
    {
        public int CommissionStructureId { get; set; }
        public int? CostCode { get; set; }
        public double? Commission { get; set; }
        public string Description { get; set; }
    }
}
