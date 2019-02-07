using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NARFO_BE.Models
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

        public virtual DbSet<Action> Action { get; set; }
        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<ActivityLookup> ActivityLookup { get; set; }
        public virtual DbSet<Administrator> Administrator { get; set; }
        public virtual DbSet<ApplicationLookup> ApplicationLookup { get; set; }
        public virtual DbSet<BankDetails> BankDetails { get; set; }
        public virtual DbSet<Club> Club { get; set; }
        public virtual DbSet<Comission> Comission { get; set; }
        public virtual DbSet<CommissionStructure> CommissionStructure { get; set; }
        public virtual DbSet<CostCode> CostCode { get; set; }
        public virtual DbSet<DedicatedStatus> DedicatedStatus { get; set; }
        public virtual DbSet<Dslookup> Dslookup { get; set; }
        public virtual DbSet<Endorsement> Endorsement { get; set; }
        public virtual DbSet<FireArmType> FireArmType { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<MemberTypeLookUp> MemberTypeLookUp { get; set; }
        public virtual DbSet<Outlets> Outlets { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PendingRenewal> PendingRenewal { get; set; }
        public virtual DbSet<Qualification> Qualification { get; set; }
        public virtual DbSet<SalesReps> SalesReps { get; set; }
        public virtual DbSet<SectionLookup> SectionLookup { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=dev.retrotest.co.za;Initial Catalog=narfo;Persist Security Info=False;User ID=group2;Password=jtn8TVNQMW_28esy;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<Action>(entity =>
            {
                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.Action1)
                    .HasColumnName("Action")
                    .HasMaxLength(50);

                entity.Property(e => e.ShortCode).HasMaxLength(10);
            });

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasKey(e => e.ActiviryId);

                entity.Property(e => e.ActiviryId)
                    .HasColumnName("ActiviryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityDate).HasColumnType("date");

                entity.Property(e => e.ActivityDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Caliber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateSubmitted).HasColumnType("date");

                entity.Property(e => e.FirearmType)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MemNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MemNoNavigation)
                    .WithMany(p => p.Activity)
                    .HasForeignKey(d => d.MemNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Activity_Member");
            });

            modelBuilder.Entity<ActivityLookup>(entity =>
            {
                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Administrator>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK_Administrator_1");

                entity.Property(e => e.AdminId)
                    .HasColumnName("AdminID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MemNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MemNoNavigation)
                    .WithMany(p => p.Administrator)
                    .HasForeignKey(d => d.MemNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Administrator_Member");
            });

            modelBuilder.Entity<ApplicationLookup>(entity =>
            {
                entity.HasKey(e => e.AppLookupId);

                entity.Property(e => e.AppLookupId).HasColumnName("AppLookupID");

                entity.Property(e => e.ApplicationType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UnitStandard).HasColumnType("numeric(10, 0)");
            });

            modelBuilder.Entity<BankDetails>(entity =>
            {
                entity.Property(e => e.BankDetailsId)
                    .HasColumnName("BankDetailsID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountNumber).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber).HasColumnType("numeric(10, 0)");
            });

            modelBuilder.Entity<Club>(entity =>
            {
                entity.Property(e => e.ClubId)
                    .HasColumnName("ClubID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Administartion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClubEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClubName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClubPostAddress1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClubTelNo).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ClubWebSite)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Executive)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fard)
                    .HasColumnName("FARD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fards)
                    .HasColumnName("FARDS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Secretary)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Comission>(entity =>
            {
                entity.Property(e => e.ComissionId)
                    .HasColumnName("ComissionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientMemNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ComDate).HasColumnType("date");

                entity.Property(e => e.ComType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comission1)
                    .HasColumnName("Comission")
                    .HasColumnType("money");

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTransNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RepNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeNavigation)
                    .WithMany(p => p.Comission)
                    .HasForeignKey(d => d.Code)
                    .HasConstraintName("FK_Comission_CostCode");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.Comission)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_Comission_Payment");

                entity.HasOne(d => d.TransactionNoNavigation)
                    .WithMany(p => p.Comission)
                    .HasForeignKey(d => d.TransactionNo)
                    .HasConstraintName("FK_Comission_Transaction");
            });

            modelBuilder.Entity<CommissionStructure>(entity =>
            {
                entity.HasKey(e => e.ComSid);

                entity.Property(e => e.ComSid)
                    .HasColumnName("ComSID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeNavigation)
                    .WithMany(p => p.CommissionStructure)
                    .HasForeignKey(d => d.Code)
                    .HasConstraintName("FK_CommissionStructure_CostCode");
            });

            modelBuilder.Entity<CostCode>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DedicatedStatus>(entity =>
            {
                entity.HasKey(e => e.DedicatedId);

                entity.Property(e => e.DedicatedId)
                    .HasColumnName("DedicatedID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationDate).HasColumnType("date");

                entity.Property(e => e.Approved)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("date");

                entity.Property(e => e.Dsno)
                    .HasColumnName("DSNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dstype)
                    .HasColumnName("DSType")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MemNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Motivation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RefusalReason)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Termination)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TerminationReason)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Transfare)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TrasfDsno)
                    .HasColumnName("TrasfDSNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrsfAssociation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TrsfAssociationFarn)
                    .HasColumnName("TrsfAssociationFARN")
                    .HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.MemNoNavigation)
                    .WithMany(p => p.DedicatedStatus)
                    .HasForeignKey(d => d.MemNo)
                    .HasConstraintName("FK_DedicatedStatus_Member");
            });

            modelBuilder.Entity<Dslookup>(entity =>
            {
                entity.ToTable("DSLookup");

                entity.Property(e => e.DslookupId).HasColumnName("DSLookupID");

                entity.Property(e => e.DedicatedStatus).HasMaxLength(255);
            });

            modelBuilder.Entity<Endorsement>(entity =>
            {
                entity.HasKey(e => e.EndorsId);

                entity.Property(e => e.EndorsId).HasColumnName("EndorsID");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Calibre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndorsementDate).HasColumnType("date");

                entity.Property(e => e.EndorsementNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndorsementType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Hunting; Sports Shooting; Self Protection')");

                entity.Property(e => e.Fcasection)
                    .HasColumnName("FCASection")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FireArmMakeModel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FireArmType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Handgun; Rifle; Self Loading Rifle; Shotgun')");

                entity.Property(e => e.MemNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.FireArmTypeNavigation)
                    .WithMany(p => p.Endorsement)
                    .HasForeignKey(d => d.FireArmType)
                    .HasConstraintName("FK_Endorsement_FireArmType");

                entity.HasOne(d => d.MemNoNavigation)
                    .WithMany(p => p.Endorsement)
                    .HasForeignKey(d => d.MemNo)
                    .HasConstraintName("FK_Endorsement_Member");
            });

            modelBuilder.Entity<FireArmType>(entity =>
            {
                entity.HasKey(e => e.FireArmType1);

                entity.Property(e => e.FireArmType1)
                    .HasColumnName("FireArmType")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.LoginId).HasColumnName("LoginID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasKey(e => e.MemNo);

                entity.Property(e => e.MemNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CellNo).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClubId).HasColumnName("ClubID");

                entity.Property(e => e.CurrentAssName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentAssociation)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ethinicity)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idno)
                    .HasColumnName("IDNo")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.InceptionDate).HasColumnType("date");

                entity.Property(e => e.LoginId).HasColumnName("LoginID");

                entity.Property(e => e.MemType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Representative; Ordinary; Executive; Client; Owner')");

                entity.Property(e => e.MyBonusNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NoOfFa).HasColumnName("NoOfFA");

                entity.Property(e => e.Password)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Suburb)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TypeFahg).HasColumnName("TypeFAHG");

                entity.Property(e => e.TypeFarifle).HasColumnName("TypeFARifle");

                entity.Property(e => e.TypeFasa).HasColumnName("TypeFASA");

                entity.Property(e => e.TypeFasg).HasColumnName("TypeFASG");

                entity.Property(e => e.TypeHuntingPh).HasColumnName("TypeHuntingPH");

                entity.Property(e => e.TypeSshg).HasColumnName("TypeSSHG");

                entity.Property(e => e.TypeSsmg).HasColumnName("TypeSSMG");

                entity.Property(e => e.TypeSsrlr).HasColumnName("TypeSSRLR");

                entity.Property(e => e.TypeSsrsr).HasColumnName("TypeSSRSR");

                entity.Property(e => e.TypeSssa).HasColumnName("TypeSSSA");

                entity.Property(e => e.TypeSssg).HasColumnName("TypeSSSG");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Club)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.ClubId)
                    .HasConstraintName("FK_Member_Club");

                entity.HasOne(d => d.EmailNavigation)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.Email)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Member_Login");

                entity.HasOne(d => d.OwnerNavigation)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.Owner)
                    .HasConstraintName("FK_Member_Outlets");
            });

            modelBuilder.Entity<MemberTypeLookUp>(entity =>
            {
                entity.HasKey(e => e.MemberTypeId);

                entity.Property(e => e.MemberTypeId)
                    .HasColumnName("MemberTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MemberType).HasMaxLength(50);
            });

            modelBuilder.Entity<Outlets>(entity =>
            {
                entity.HasKey(e => e.Owner);

                entity.Property(e => e.Owner).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode).HasColumnType("numeric(6, 0)");

                entity.Property(e => e.TellNumber).HasColumnType("numeric(10, 0)");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.MemNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MemNoNavigation)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.MemNo)
                    .HasConstraintName("FK_Payment_Member");
            });

            modelBuilder.Entity<PendingRenewal>(entity =>
            {
                entity.HasKey(e => e.RenewalD);

                entity.Property(e => e.RenewalD).ValueGeneratedNever();

                entity.Property(e => e.MemNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Outlet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RenewalDate).HasColumnType("smalldatetime");

                entity.Property(e => e.RenewalFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesRep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MemNoNavigation)
                    .WithMany(p => p.PendingRenewalNavigation)
                    .HasForeignKey(d => d.MemNo)
                    .HasConstraintName("FK_PendingRenewal_Member");
            });

            modelBuilder.Entity<Qualification>(entity =>
            {
                entity.Property(e => e.QualificationId)
                    .HasColumnName("QualificationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Assessment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AssessmentDate).HasColumnType("date");

                entity.Property(e => e.AssessmentNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkDoc)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MemNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MemNoNavigation)
                    .WithMany(p => p.Qualification)
                    .HasForeignKey(d => d.MemNo)
                    .HasConstraintName("FK_Qualification_Member");
            });

            modelBuilder.Entity<SalesReps>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountNo).HasColumnType("numeric(15, 0)");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MemNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MemNoNavigation)
                    .WithMany(p => p.SalesReps)
                    .HasForeignKey(d => d.MemNo)
                    .HasConstraintName("FKSalesReps_Member");
            });

            modelBuilder.Entity<SectionLookup>(entity =>
            {
                entity.Property(e => e.SectionLookupId).HasColumnName("SectionLookupID");

                entity.Property(e => e.Section).HasMaxLength(255);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => e.TransactionNo);

                entity.Property(e => e.TransactionNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Beneficiary)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DatePaid).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.InceptionDate).HasColumnType("date");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.LoanSponsor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RepTransNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreTransNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vat).HasColumnType("money");

                entity.Property(e => e.Year).HasColumnType("smalldatetime");

                entity.HasOne(d => d.MemNoNavigation)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.MemNo)
                    .HasConstraintName("FK_Transaction_Member");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_Payment");
            });
        }
    }
}
