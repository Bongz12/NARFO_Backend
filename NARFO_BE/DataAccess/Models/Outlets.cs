using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Outlets
    {
        public int OutletId { get; set; }
        public string Outlet { get; set; }
        public int? Owner { get; set; }
        public string TelNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
    }
}
