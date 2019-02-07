using System;
using System.Collections.Generic;

namespace NARFO_BE.Models
{
    public partial class Outlets
    {
        public Outlets()
        {
            Member = new HashSet<Member>();
        }

        public int Owner { get; set; }
        public decimal? TellNumber { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public decimal? PostalCode { get; set; }

        public virtual ICollection<Member> Member { get; set; }
    }
}
