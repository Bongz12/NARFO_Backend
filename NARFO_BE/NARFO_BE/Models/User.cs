using System;
using System.Collections.Generic;

namespace NARFO_BE.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string SalesRep { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime? Registered { get; set; }
        public string InceptionDate { get; set; }
        public string Activated { get; set; }
        public string ExpiryDate { get; set; }
        public string AccountStatus { get; set; }
        public string Tak { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Ethnicity { get; set; }
        public string Role { get; set; }
    }
}
