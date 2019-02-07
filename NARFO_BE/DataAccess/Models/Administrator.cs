using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Administrator
    {
        public int AdminId { get; set; }
        public string MemType { get; set; }
        public string MemNo { get; set; }

        public virtual Member MemNoNavigation { get; set; }
    }
}
