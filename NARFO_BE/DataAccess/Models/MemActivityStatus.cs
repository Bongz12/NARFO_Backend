using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class MemActivityStatus
    {
        public int MemActivityStatusId { get; set; }
        public bool Owner { get; set; }
        public bool CurrentAssociation { get; set; }
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
        public string MemNo { get; set; }

        public virtual Members MemNoNavigation { get; set; }
    }
}
