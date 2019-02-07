using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NARFO_BE.Models
{
    public class _Member
    {
        public int Id { get; set; }
        public string MEMNO { get; set; }
        public string Password { get; set; }
        public string Branch { get; set; }
        public string SalesMan { get; set; }
        public string Username { get; set; }

        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string IDNo { get; set; }
        [Column("Physical Address")]
        public string Physical_Address { get; set; }

        public string Suburb { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        [Column("Postal Code")]
        public string Postal_Code { get; set; }
        public string CellNo { get; set; }

        public string Email { get; set; }
        public string MyBonusNo { get; set; }
        public string Sex { get; set; }
        public string InceptionDate { get; set; }
        public string ExpiryDate { get; set; }

        public string MemType { get; set; }
        public string Ethicity { get; set; }
        public bool Owner { get; set; }
        public bool CurrentAssociation { get; set; }
        public string CurrnetAssName { get; set; }

        public bool IntHunting { get; set; }
        public bool IntSportShooting { get; set; }
        public bool IntRecreational { get; set; }
        public bool IntSelfDefense { get; set; }

        public bool TypeSSRLR { get; set; }
        public bool TypeSSRSR { get; set; }
        public bool TypeSSHG { get; set; }
        public bool TypeSSSG { get; set; }

        public bool TypeSSMG { get; set; }
        public bool TypeSSSA { get; set; }
        public bool TypeHuntingBiltong { get; set; }
        public bool TypeHuntingTrophy { get; set; }

        public bool TypeHuntingPH { get; set; }
        public bool TypeHUntingOutfitter { get; set; }
        public bool TypeFARifle { get; set; }
        public bool TypeHuntTypeFAHGingTrophy { get; set; }

        public bool TypeFAHG { get; set; }
        public bool TypeFASA { get; set; }
        public bool TypeFASG { get; set; }
        public bool NoOfFA { get; set; }

        public bool PendingRenewal { get; set; }






    }
}
