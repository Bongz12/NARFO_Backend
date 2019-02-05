using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NARFO_BE.Models
{
    public class _Member
    {
        public int Id { get; set; }
        public string MEMNO { get; set; }
        public string Branch { get; set; }
        public string SalesMan { get; set; }
        public string Username { get; set; }

        public string Title { get; set; }
        public string Firstname { get; set; }
        public string SURNAME { get; set; }
        public string IDNo { get; set; }
        public string Physical_Address { get; set; }

        public string Suburb { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Postal_Code { get; set; }
        public string CellNo { get; set; }

        public string Email { get; set; }
        public string MyBonusNo { get; set; }
        public string Sex { get; set; }
        public string InceptionDate { get; set; }
        public string ExpiryDate { get; set; }

        public string MemType { get; set; }
        public string Ethicity { get; set; }
        public Boolean Owner { get; set; }
        public Boolean CurrentAssociation { get; set; }
        public string CurrnetAssName { get; set; }

        public Boolean IntHunting { get; set; }
        public Boolean IntSportShooting { get; set; }
        public Boolean IntRecreational { get; set; }
        public Boolean IntSelfDefense { get; set; }

        public Boolean TypeSSRLR { get; set; }
        public Boolean TypeSSRSR { get; set; }
        public Boolean TypeSSHG { get; set; }
        public Boolean TypeSSSG { get; set; }

        public Boolean TypeSSMG { get; set; }
        public Boolean TypeSSSA { get; set; }
        public Boolean TypeHuntingBiltong { get; set; }
        public Boolean TypeHuntingTrophy { get; set; }

        public Boolean TypeHuntingPH { get; set; }
        public Boolean TypeHUntingOutfitter { get; set; }
        public Boolean TypeFARifle { get; set; }
        public Boolean TypeHuntTypeFAHGingTrophy { get; set; }

        public Boolean TypeFAHG { get; set; }
        public Boolean TypeFASA { get; set; }
        public Boolean TypeFASG { get; set; }
        public Boolean NoOfFA { get; set; }

        public Boolean PendingRenewal { get; set; }






    }
}
