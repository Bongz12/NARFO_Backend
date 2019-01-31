using System;
using System.Collections.Generic;

namespace NARFO_BE.Models
{
    public partial class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Dob { get; set; }
        public bool Status { get; set; }
    }
}
