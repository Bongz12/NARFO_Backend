using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class NextNoValue
    {
        public int NumberId { get; set; }
        public int? NextValue { get; set; }
        public string NumberType { get; set; }
        public string Parameter { get; set; }
        public bool Active { get; set; }
    }
}
