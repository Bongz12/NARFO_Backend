using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public string PhysicalAddress { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string MemNo { get; set; }

        public virtual Members MemNoNavigation { get; set; }
    }
}
