using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.Models
{
    public partial class narfoContext : DbContext
    {
        public narfoContext()
        {
        }

        public narfoContext(DbContextOptions<narfoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actions> Actions { get; set; }
        public virtual DbSet<ActivityLookup> ActivityLookup { get; set; }
        public virtual DbSet<ActivityRegister> ActivityRegister { get; set; }
        public virtual DbSet<ApplicationLookup> ApplicationLookup { get; set; }
        public virtual DbSet<BankDetails> BankDetails { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<CertificationLookUp> CertificationLookUp { get; set; }
        public virtual DbSet<Club> Club { get; set; }
        public virtual DbSet<Commission> Commission { get; set; }
        public virtual DbSet<CommissionStructure> CommissionStructure { get; set; }
        public virtual DbSet<CostCode> CostCode { get; set; }
        public virtual DbSet<DedicatedStatus> DedicatedStatus { get; set; }
        public virtual DbSet<Dslookup> Dslookup { get; set; }
        public virtual DbSet<EndorsementLookup> EndorsementLookup { get; set; }
        public virtual DbSet<Endorsements> Endorsements { get; set; }
        public virtual DbSet<FirearmType> FirearmType { get; set; }
        public virtual DbSet<MemberTypeLookUp> MemberTypeLookUp { get; set; }
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<NextNoValue> NextNoValue { get; set; }
        public virtual DbSet<Outlets> Outlets { get; set; }
        public virtual DbSet<PendingRenewal> PendingRenewal { get; set; }
        public virtual DbSet<Prefixes> Prefixes { get; set; }
        public virtual DbSet<Qualification> Qualification { get; set; }
        public virtual DbSet<QualificationLookUp> QualificationLookUp { get; set; }
        public virtual DbSet<SalesReps> SalesReps { get; set; }
        public virtual DbSet<SectionLookup> SectionLookup { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=dev.retrotest.co.za;Initial Catalog=narfo;Persist Security Info=False;User ID=group2;Password=jtn8TVNQMW_28esy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<Actions>(entity =>
            {
                entity.HasKey(e => e.ShortCode);

                entity.Property(e => e.ShortCode)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Action).HasMaxLength(50);
            });

            modelBuilder.Entity<ActivityLookup>(entity =>
            {
                entity.HasKey(e => e.Activity);

                entity.Property(e => e.Activity)
                    .HasMaxLength(255)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ActivityRegister>(entity =>
            {
                entity.HasKey(e => e.ActivityId);

                entity.Property(e => e.ActivityId)
                    .HasColumnName("ActivityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityDate).HasColumnType("datetime");

                entity.Property(e => e.ActivityType).HasMaxLength(50);

                entity.Property(e => e.Caliber).HasMaxLength(30);

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");

                entity.Property(e => e.FirearmType).HasMaxLength(50);

                entity.Property(e => e.MemNo).HasMaxLength(10);

                entity.Property(e => e.Score).HasMaxLength(255);
            });

            modelBuilder.Entity<ApplicationLookup>(entity =>
            {
                entity.HasKey(e => e.AppLookupId);

                entity.ToTable("Application Lookup");

                entity.Property(e => e.AppLookupId)
                    .HasColumnName("AppLookupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationType)
                    .HasColumnName("Application Type")
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.UnitStandard).HasMaxLength(10);
            });

            modelBuilder.Entity<BankDetails>(entity =>
            {
                entity.Property(e => e.BankDetailsId).HasColumnName("BankDetailsID");

                entity.Property(e => e.AccountNumber)
                    .HasColumnName("Account Number")
                    .HasMaxLength(50);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ContraNumber)
                    .HasColumnName("Contra Number")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(e => e.Branch1);

                entity.Property(e => e.Branch1)
                    .HasColumnName("Branch")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<CertificationLookUp>(entity =>
            {
                entity.Property(e => e.CertificationLookupId)
                    .HasColumnName("CertificationLookupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<Club>(entity =>
            {
                entity.Property(e => e.ClubId)
                    .HasColumnName("ClubID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Administration).HasMaxLength(50);

                entity.Property(e => e.ClubEmail).HasMaxLength(50);

                entity.Property(e => e.ClubName).HasMaxLength(50);

                entity.Property(e => e.ClubPostAdd1).HasMaxLength(50);

                entity.Property(e => e.ClubPostAdd2).HasMaxLength(50);

                entity.Property(e => e.ClubPostAdd3).HasMaxLength(50);

                entity.Property(e => e.ClubTelNo).HasMaxLength(50);

                entity.Property(e => e.ClubWebSite).HasMaxLength(50);

                entity.Property(e => e.Executive).HasMaxLength(50);

                entity.Property(e => e.Fardh)
                    .HasColumnName("FARDH")
                    .HasMaxLength(20);

                entity.Property(e => e.Fards)
                    .HasColumnName("FARDS")
                    .HasMaxLength(20);

                entity.Property(e => e.Secretary).HasMaxLength(50);
            });

            modelBuilder.Entity<Commission>(entity =>
            {
                entity.Property(e => e.CommissionId)
                    .HasColumnName("CommissionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Branch).HasMaxLength(50);

                entity.Property(e => e.ClientMemNo).HasMaxLength(10);

                entity.Property(e => e.ComDate).HasColumnType("datetime");

                entity.Property(e => e.ComType).HasMaxLength(20);

                entity.Property(e => e.Commission1)
                    .HasColumnName("Commission")
                    .HasColumnType("money");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.PaymentMethod).HasMaxLength(15);

                entity.Property(e => e.PaymentTransNo).HasMaxLength(15);

                entity.Property(e => e.RepNo).HasMaxLength(10);

                entity.Property(e => e.TransactionNo).HasMaxLength(15);
            });

            modelBuilder.Entity<CommissionStructure>(entity =>
            {
                entity.Property(e => e.CommissionStructureId).HasColumnName("CommissionStructureID");

                entity.Property(e => e.Description).HasMaxLength(25);
            });

            modelBuilder.Entity<CostCode>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Cost Code");

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(10);
            });

            modelBuilder.Entity<DedicatedStatus>(entity =>
            {
                entity.HasKey(e => e.DedecatedId);

                entity.Property(e => e.DedecatedId)
                    .HasColumnName("DedecatedID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationDate).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.Dsno)
                    .HasColumnName("DSNo")
                    .HasMaxLength(15);

                entity.Property(e => e.Dstype)
                    .HasColumnName("DSType")
                    .HasMaxLength(50);

                entity.Property(e => e.MemNo).HasMaxLength(10);

                entity.Property(e => e.TerminationDate).HasColumnType("datetime");

                entity.Property(e => e.TrasfDsno)
                    .HasColumnName("TrasfDSNo")
                    .HasMaxLength(25);

                entity.Property(e => e.TrsfAssociation).HasMaxLength(120);

                entity.Property(e => e.TrsfAssociionFarno)
                    .HasColumnName("TrsfAssociionFARNo")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Dslookup>(entity =>
            {
                entity.ToTable("DSLookup");

                entity.Property(e => e.DslookupId).HasColumnName("DSLookupID");

                entity.Property(e => e.DedicatedStatus).HasMaxLength(255);
            });

            modelBuilder.Entity<EndorsementLookup>(entity =>
            {
                entity.Property(e => e.EndorsementLookupId).HasColumnName("EndorsementLookupID");

                entity.Property(e => e.EndorsementType)
                    .HasColumnName("Endorsement Type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Endorsements>(entity =>
            {
                entity.HasKey(e => e.EndorsId);

                entity.Property(e => e.EndorsId).HasColumnName("EndorsID");

                entity.Property(e => e.Action).HasMaxLength(50);

                entity.Property(e => e.Calibre).HasMaxLength(50);

                entity.Property(e => e.EndorsementDate).HasColumnType("datetime");

                entity.Property(e => e.EndorsementNo).HasMaxLength(255);

                entity.Property(e => e.EndorsementType).HasMaxLength(255);

                entity.Property(e => e.FcaSection)
                    .HasColumnName("FCA Section")
                    .HasMaxLength(255);

                entity.Property(e => e.FireArmMakeModel).HasMaxLength(100);

                entity.Property(e => e.FireArmType).HasMaxLength(50);

                entity.Property(e => e.MemNo).HasMaxLength(10);

                entity.Property(e => e.SerialNumber).HasMaxLength(25);
            });

            modelBuilder.Entity<FirearmType>(entity =>
            {
                entity.HasKey(e => e.FirearmType1);

                entity.Property(e => e.FirearmType1)
                    .HasColumnName("FirearmType")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<MemberTypeLookUp>(entity =>
            {
                entity.HasKey(e => e.MemberTypeId);

                entity.Property(e => e.MemberTypeId).HasColumnName("MemberTypeID");

                entity.Property(e => e.MemberType).HasMaxLength(50);
            });

            modelBuilder.Entity<Members>(entity =>
            {
                entity.HasKey(e => e.MemNo);

                entity.Property(e => e.MemNo)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Branch).HasMaxLength(50);

                entity.Property(e => e.CellNo).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CurrnetAssName).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Ethicity).HasMaxLength(25);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.Firstname).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idno)
                    .HasColumnName("IDNo")
                    .HasMaxLength(30);

                entity.Property(e => e.InceptionDate).HasColumnType("datetime");

                entity.Property(e => e.MemType).HasMaxLength(25);

                entity.Property(e => e.MyBonusNo).HasMaxLength(25);

                entity.Property(e => e.NoOfFa).HasColumnName("NoOfFA");

                entity.Property(e => e.PhysicalAddress)
                    .HasColumnName("Physical Address")
                    .HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("Postal Code")
                    .HasMaxLength(6);

                entity.Property(e => e.Province).HasMaxLength(50);

                entity.Property(e => e.SalesMan).HasMaxLength(20);

                entity.Property(e => e.Sex).HasMaxLength(255);

                entity.Property(e => e.Suburb).HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .HasColumnName("SURNAME")
                    .HasMaxLength(60);

                entity.Property(e => e.Title).HasMaxLength(6);

                entity.Property(e => e.TypeFahg).HasColumnName("TypeFAHG");

                entity.Property(e => e.TypeFarifle).HasColumnName("TypeFARifle");

                entity.Property(e => e.TypeFasa).HasColumnName("TypeFASA");

                entity.Property(e => e.TypeFasg).HasColumnName("TypeFASG");

                entity.Property(e => e.TypeHuntingOutfitter).HasColumnName("TypeHUntingOutfitter");

                entity.Property(e => e.TypeHuntingPh).HasColumnName("TypeHuntingPH");

                entity.Property(e => e.TypeSshg).HasColumnName("TypeSSHG");

                entity.Property(e => e.TypeSsmg).HasColumnName("TypeSSMG");

                entity.Property(e => e.TypeSsrlr).HasColumnName("TypeSSRLR");

                entity.Property(e => e.TypeSsrsr).HasColumnName("TypeSSRSR");

                entity.Property(e => e.TypeSssa).HasColumnName("TypeSSSA");

                entity.Property(e => e.TypeSssg).HasColumnName("TypeSSSG");

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<NextNoValue>(entity =>
            {
                entity.HasKey(e => e.NumberId);

                entity.Property(e => e.NumberId).HasColumnName("NumberID");

                entity.Property(e => e.NumberType).HasMaxLength(50);

                entity.Property(e => e.Parameter).HasMaxLength(10);
            });

            modelBuilder.Entity<Outlets>(entity =>
            {
                entity.HasKey(e => e.OutletId);

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Outlet).HasMaxLength(120);

                entity.Property(e => e.PostalCode).HasMaxLength(10);

                entity.Property(e => e.TelNumber).HasMaxLength(12);
            });

            modelBuilder.Entity<PendingRenewal>(entity =>
            {
                entity.HasKey(e => e.RenewalId);

                entity.Property(e => e.RenewalId).HasColumnName("RenewalID");

                entity.Property(e => e.FinYear).HasMaxLength(4);

                entity.Property(e => e.MemNo)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Outlet).HasMaxLength(50);

                entity.Property(e => e.RenewalDate).HasColumnType("datetime");

                entity.Property(e => e.RenewalFee).HasColumnType("money");

                entity.Property(e => e.SalesRep).HasMaxLength(15);
            });

            modelBuilder.Entity<Prefixes>(entity =>
            {
                entity.HasKey(e => e.Prefix);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(100);
            });

            modelBuilder.Entity<Qualification>(entity =>
            {
                entity.Property(e => e.QualificationId).HasColumnName("QualificationID");

                entity.Property(e => e.Assessment).HasMaxLength(40);

                entity.Property(e => e.AssessmentDate)
                    .HasColumnName("Assessment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AssessmentNo).HasMaxLength(20);

                entity.Property(e => e.MemNo).HasMaxLength(25);
            });

            modelBuilder.Entity<QualificationLookUp>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Qualification).HasMaxLength(40);
            });

            modelBuilder.Entity<SalesReps>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo).HasMaxLength(20);

                entity.Property(e => e.AccountType).HasMaxLength(20);

                entity.Property(e => e.BankName).HasMaxLength(20);

                entity.Property(e => e.Branch).HasMaxLength(50);

                entity.Property(e => e.BranchCode).HasMaxLength(10);

                entity.Property(e => e.CellNo).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Firstname).HasMaxLength(50);

                entity.Property(e => e.Frequency).HasMaxLength(1);

                entity.Property(e => e.Idno)
                    .HasColumnName("IDNo")
                    .HasMaxLength(30);

                entity.Property(e => e.MemNo)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.MemType).HasMaxLength(25);

                entity.Property(e => e.PhysicalAddress)
                    .HasColumnName("Physical Address")
                    .HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("Postal Code")
                    .HasMaxLength(6);

                entity.Property(e => e.Province).HasMaxLength(50);

                entity.Property(e => e.Suburb).HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .HasColumnName("SURNAME")
                    .HasMaxLength(60);

                entity.Property(e => e.Title).HasMaxLength(6);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<SectionLookup>(entity =>
            {
                entity.HasKey(e => e.Section);

                entity.Property(e => e.Section)
                    .HasMaxLength(255)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Beneficiary).HasMaxLength(255);

                entity.Property(e => e.CostCode).HasColumnName("Cost Code");

                entity.Property(e => e.DatePaid).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.InceptionDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("Invoice Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.LoanSponsor).HasMaxLength(255);

                entity.Property(e => e.MemNo).HasMaxLength(10);

                entity.Property(e => e.PaymentMethod).HasMaxLength(50);

                entity.Property(e => e.ReceiptNo).HasMaxLength(50);

                entity.Property(e => e.RepTransNo).HasMaxLength(50);

                entity.Property(e => e.StoreTransNo).HasMaxLength(10);

                entity.Property(e => e.TransactionNo).HasMaxLength(25);

                entity.Property(e => e.Vat).HasColumnType("money");

                entity.Property(e => e.Year).HasMaxLength(4);
            });
        }
    }
}
