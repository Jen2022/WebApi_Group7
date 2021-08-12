using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApi1.Models
{
    public partial class FarmerSchemeContext : DbContext
    {
        public FarmerSchemeContext()
        {
        }

        public FarmerSchemeContext(DbContextOptions<FarmerSchemeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BankDetail> BankDetails { get; set; }
        public virtual DbSet<BidderMarketplace> BidderMarketplaces { get; set; }
        public virtual DbSet<CropForSale> CropForSales { get; set; }
        public virtual DbSet<Insurance> Insurances { get; set; }
        public virtual DbSet<InsuranceClaim> InsuranceClaims { get; set; }
        public virtual DbSet<LandDetail> LandDetails { get; set; }
        public virtual DbSet<RoleType> RoleTypes { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-V6I6O4B\\MSSQLSERVERD;Database=FarmerScheme;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BankDetail>(entity =>
            {
                entity.HasKey(e => e.BankId)
                    .HasName("pk_BankDetails");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.AccountNo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IfscCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IFSC_Code");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BankDetails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_bankdetails");
            });

            modelBuilder.Entity<BidderMarketplace>(entity =>
            {
                entity.HasKey(e => e.BidId)
                    .HasName("pk_BidderMarketplace");

                entity.ToTable("BidderMarketplace");

                entity.Property(e => e.BidId).HasColumnName("BidID");

                entity.Property(e => e.ApprovalStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('pending')");

                entity.Property(e => e.CropId).HasColumnName("CropID");

                entity.Property(e => e.CurrentBid).HasColumnType("money");

                entity.Property(e => e.DateOfBid).HasColumnType("date");

                entity.Property(e => e.FinalBid).HasColumnType("money");

                entity.Property(e => e.Msp)
                    .HasColumnType("money")
                    .HasColumnName("MSP");

                entity.Property(e => e.PreviousBids).HasColumnType("money");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Crop)
                    .WithMany(p => p.BidderMarketplaces)
                    .HasForeignKey(d => d.CropId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_BidderMarketplace");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BidderMarketplaces)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_marketplace");
            });

            modelBuilder.Entity<CropForSale>(entity =>
            {
                entity.HasKey(e => e.CropId)
                    .HasName("pk_CropDetails");

                entity.ToTable("CropForSale");

                entity.Property(e => e.CropId).HasColumnName("CropID");

                entity.Property(e => e.CropName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CropType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfSoldCrop).HasColumnType("date");

                entity.Property(e => e.FertilizerType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Msp)
                    .HasColumnType("money")
                    .HasColumnName("MSP");

                entity.Property(e => e.SoilCert)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SoilPh).HasColumnName("SoilPH");

                entity.Property(e => e.SoldPrice).HasColumnType("money");

                entity.Property(e => e.StatusOfCropSell)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('pending')");

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CropForSales)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_userid");
            });

            modelBuilder.Entity<Insurance>(entity =>
            {
                entity.HasKey(e => e.IapplicationId)
                    .HasName("pk_insurance");

                entity.ToTable("Insurance");

                entity.Property(e => e.IapplicationId).HasColumnName("IApplicationID");

                entity.Property(e => e.Area)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CropId).HasColumnName("CropID");

                entity.Property(e => e.Season)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SumInsuredPerHectare).HasColumnType("money");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Crop)
                    .WithMany(p => p.Insurances)
                    .HasForeignKey(d => d.CropId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_insurance");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Insurances)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_insu");
            });

            modelBuilder.Entity<InsuranceClaim>(entity =>
            {
                entity.HasKey(e => e.ClaimId)
                    .HasName("pk_insuranceclaim");

                entity.ToTable("InsuranceClaim");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CauseOfLoss)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('pending')");

                entity.Property(e => e.DateOfLoss).HasColumnType("date");

                entity.Property(e => e.Icompany)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ICompany")
                    .HasDefaultValueSql("('AGRICULTURE INSURANCE COMPANY')");

                entity.Property(e => e.InsuranceName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SumInsured).HasColumnType("money");

                entity.HasOne(d => d.PolicyNoNavigation)
                    .WithMany(p => p.InsuranceClaims)
                    .HasForeignKey(d => d.PolicyNo)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_insuranceclaim");
            });

            modelBuilder.Entity<LandDetail>(entity =>
            {
                entity.HasKey(e => e.LandId)
                    .HasName("pk_LandDetails");

                entity.Property(e => e.LandId).HasColumnName("LandID");

                entity.Property(e => e.LandAddress)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LandArea)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LandDetails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_landdetails");
            });

            modelBuilder.Entity<RoleType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RoleType");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserRole)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_roletype");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("pk_User");

                entity.ToTable("tblUser");

                entity.HasIndex(e => e.AadharCard, "UQ__tblUser__15CE99CCC8097A2E")
                    .IsUnique();

                entity.HasIndex(e => e.PanCard, "UQ__tblUser__886311706B06940F")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "UQ__tblUser__A9D105344E694D67")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.AadharCard)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate).HasColumnType("date");

                entity.Property(e => e.Certificate)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PanCard)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pincode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TraderLicense)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VerificationStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('pending')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
