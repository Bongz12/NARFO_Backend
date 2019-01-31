using System;
using System.Collections.Generic;

namespace NARFO_BE.Models
{
    public partial class Members
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
