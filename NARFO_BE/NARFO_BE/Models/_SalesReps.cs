using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NARFO_BE.Models
{
    public class _SalesReps
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string MEMNO { get; set; }
        public string Branch { get; set; }
        public string SURNAME { get; set; }
        public string IDNo { get; set; }

        public string Physical_Address { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Postal_Code { get; set; }

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
