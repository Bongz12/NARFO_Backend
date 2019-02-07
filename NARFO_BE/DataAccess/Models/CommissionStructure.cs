using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class CommissionStructure
    {
        public decimal? Code { get; set; }
        public string Description { get; set; }
        public int? Commission { get; set; }
        public int ComSid { get; set; }

        public virtual CostCode CodeNavigation { get; set; }
    }
}
