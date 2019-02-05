using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Members
    {
        public int Id { get; set; }
        public string MemNo { get; set; }
        public string Branch { get; set; }
        public string SalesMan { get; set; }
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
        public string MyBonusNo { get; set; }
        public string Sex { get; set; }
        public DateTime? InceptionDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string MemType { get; set; }
        public string Ethicity { get; set; }
        public bool Owner { get; set; }
        public bool CurrentAssociation { get; set; }
        public string CurrnetAssName { get; set; }
        public bool IntHunting { get; set; }
        public bool IntSportShooting { get; set; }
        public bool IntRecreational { get; set; }
        public bool IntSelfDefense { get; set; }
        public bool TypeSsrlr { get; set; }
        public bool TypeSsrsr { get; set; }
        public bool TypeSshg { get; set; }
        public bool TypeSssg { get; set; }
        public bool TypeSsmg { get; set; }
        public bool TypeSssa { get; set; }
        public bool TypeHuntingBiltong { get; set; }
        public bool TypeHuntingTrophy { get; set; }
        public bool TypeHuntingPh { get; set; }
        public bool TypeHuntingOutfitter { get; set; }
        public bool TypeFarifle { get; set; }
        public bool TypeFahg { get; set; }
        public bool TypeFasg { get; set; }
        public bool TypeFasa { get; set; }
        public short? NoOfFa { get; set; }
        public bool PendingRenewal { get; set; }
    }
}
