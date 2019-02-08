using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NARFO_BE.Models
{
    public partial class SalesRepsPrototype
    {
        public string Firstname { get; set; }
        public string SURNAME { get; set; }

        public SalesRepsPrototype(string Firstname, string SURNAME) { this.Firstname = Firstname; this.SURNAME = SURNAME; }
    }
}