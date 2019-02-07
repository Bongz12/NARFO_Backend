using System;
using System.Collections.Generic;

namespace NARFO_BE.Models
{
    public partial class ApplicationLookup
    {
        public int AppLookupId { get; set; }
        public string ApplicationType { get; set; }
        public string Description { get; set; }
        public decimal? UnitStandard { get; set; }
    }
}
