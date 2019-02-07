using System;
using System.Collections.Generic;

namespace NARFO_BE.Models
{
    public partial class Member
    {
        public Member()
        {
            Activity = new HashSet<Activity>();
            Administrator = new HashSet<Administrator>();
            DedicatedStatus = new HashSet<DedicatedStatus>();
            Endorsement = new HashSet<Endorsement>();
            Payment = new HashSet<Payment>();
            PendingRenewalNavigation = new HashSet<PendingRenewal>();
            Qualification = new HashSet<Qualification>();
            SalesReps = new HashSet<SalesReps>();
            Transaction = new HashSet<Transaction>();
        }

        public string MemNo { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Idno { get; set; }
        public string PhysicalAddress { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public short? PostalCode { get; set; }
        public decimal? CellNo { get; set; }
        public string Email { get; set; }
        public decimal? MyBonusNo { get; set; }
        public string Sex { get; set; }
        public DateTime? InceptionDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string MemType { get; set; }
        public string Ethinicity { get; set; }
        public int? Owner { get; set; }
        public string CurrentAssociation { get; set; }
        public string CurrentAssName { get; set; }
        public short? IntHunting { get; set; }
        public short? IntShooting { get; set; }
        public short? IntSportShooting { get; set; }
        public short? IntRecretional { get; set; }
        public short? IntSelfDefence { get; set; }
        public short? TypeSsrlr { get; set; }
        public short? TypeSsrsr { get; set; }
        public short? TypeSshg { get; set; }
        public short? TypeSssg { get; set; }
        public short? TypeSsmg { get; set; }
        public short? TypeSssa { get; set; }
        public short? TypeHuntingBiltong { get; set; }
        public short? TypeHuntingTrophy { get; set; }
        public short? TypeHuntingPh { get; set; }
        public short? TypeHuntingOutfitter { get; set; }
        public short? TypeFarifle { get; set; }
        public short? TypeFahg { get; set; }
        public short? TypeFasg { get; set; }
        public short? TypeFasa { get; set; }
        public short? NoOfFa { get; set; }
        public short? PendingRenewal { get; set; }
        public int? ClubId { get; set; }
        public string Password { get; set; }
        public int? LoginId { get; set; }

        public virtual Club Club { get; set; }
        public virtual Login EmailNavigation { get; set; }
        public virtual Outlets OwnerNavigation { get; set; }
        public virtual ICollection<Activity> Activity { get; set; }
        public virtual ICollection<Administrator> Administrator { get; set; }
        public virtual ICollection<DedicatedStatus> DedicatedStatus { get; set; }
        public virtual ICollection<Endorsement> Endorsement { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<PendingRenewal> PendingRenewalNavigation { get; set; }
        public virtual ICollection<Qualification> Qualification { get; set; }
        public virtual ICollection<SalesReps> SalesReps { get; set; }
        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
