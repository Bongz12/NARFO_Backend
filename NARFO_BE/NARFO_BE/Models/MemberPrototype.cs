using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NARFO_BE.Models
{
    public partial class MemberPrototype
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public MemberPrototype(String Username, String Email) { this.Email = Email; this.Username = Username; }//constructor
    }
}