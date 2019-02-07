using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Login
    {
        public Login()
        {
            Member = new HashSet<Member>();
        }

        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Member> Member { get; set; }
    }
}
