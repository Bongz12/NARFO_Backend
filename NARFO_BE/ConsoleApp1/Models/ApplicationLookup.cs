using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ApplicationLookup
    {
        public int AppLookupId { get; set; }
        public string ApplicationType { get; set; }
        public string Description { get; set; }
        public string UnitStandard { get; set; }
    }
}
