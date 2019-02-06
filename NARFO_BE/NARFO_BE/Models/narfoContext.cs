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

        public virtual DbSet<Employees> Employees { get; set; }
      
        public virtual DbSet<_Member> Members { get; set; }
        public virtual DbSet<_SalesReps> SalesReps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=dev.retrotest.co.za;Initial Catalog=narfo;Persist Security Info=False;User ID=group2;Password=jtn8TVNQMW_28esy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.Property(e => e.Dob).HasColumnName("DOB");
            });
        }
    }
}
