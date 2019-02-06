using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class SalesReps
    {
        public int Id { get; set; }
        public string MemNo { get; set; }
        public string Branch { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Idno { get; set; }
        public string PhysicalAddress { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string CellNo { get; set; }
        public string Email { get; set; }
        public string MemType { get; set; }
        public string BankName { get; set; }
        public string AccountType { get; set; }
        public string BranchCode { get; set; }
        public string AccountNo { get; set; }
        public string Frequency { get; set; }
    }
}
