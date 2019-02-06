using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Members
    {
        public Members()
        {
            Address = new HashSet<Address>();
            MemActivityStatus = new HashSet<MemActivityStatus>();
        }

        public int Id { get; set; }
        public string MemNo { get; set; }
        public string Branch { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Idno { get; set; }
        public string CellNo { get; set; }
        public string Email { get; set; }
        public string MyBonusNo { get; set; }
        public string Sex { get; set; }
        public DateTime? InceptionDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string MemType { get; set; }
        public string Ethnicity { get; set; }
        public string CurrnetAssName { get; set; }
        public bool PendingRenewal { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<MemActivityStatus> MemActivityStatus { get; set; }
    }
}
