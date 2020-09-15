using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LegatusAdmin.Models
{
    public partial class dbContext : DbContext
    {
        public dbContext()
        {
        }

        public dbContext(DbContextOptions<dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<DeviceCodes> DeviceCodes { get; set; }
        public virtual DbSet<EBusinessPartnersCategories> EBusinessPartnersCategories { get; set; }
        public virtual DbSet<ECompanyBranchesContactDetailTypes> ECompanyBranchesContactDetailTypes { get; set; }
        public virtual DbSet<MBank> MBank { get; set; }
        public virtual DbSet<MBankBranches> MBankBranches { get; set; }
        public virtual DbSet<MBusinessPartners> MBusinessPartners { get; set; }
        public virtual DbSet<MCompany> MCompany { get; set; }
        public virtual DbSet<MCompanyBranches> MCompanyBranches { get; set; }
        public virtual DbSet<MCompanyBranchesContactDetails> MCompanyBranchesContactDetails { get; set; }
        public virtual DbSet<MLocalization> MLocalization { get; set; }
        public virtual DbSet<PayrollEPaymentCycleTypes> PayrollEPaymentCycleTypes { get; set; }
        public virtual DbSet<PayrollMBusinessPartners> PayrollMBusinessPartners { get; set; }
        public virtual DbSet<PayrollPaymentCycles> PayrollPaymentCycles { get; set; }
        public virtual DbSet<PersistedGrants> PersistedGrants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=localhost;database=LegatusHCM;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("company_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AspNetUsers_m_company");
            });

            modelBuilder.Entity<DeviceCodes>(entity =>
            {
                entity.HasKey(e => e.UserCode);

                entity.HasIndex(e => e.DeviceCode)
                    .IsUnique();

                entity.HasIndex(e => e.Expiration);

                entity.Property(e => e.UserCode).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.DeviceCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SubjectId).HasMaxLength(200);
            });

            modelBuilder.Entity<EBusinessPartnersCategories>(entity =>
            {
                entity.ToTable("e_business_partners_categories");

                entity.HasComment("group the business partners data by these categories");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BusinessPartnerCategoryName)
                    .IsRequired()
                    .HasColumnName("business_partner_category_name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment(@"driver,
cook,
cleaner,
employee,

descriptions of the categories");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("company_id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("links to the company table");
            });

            modelBuilder.Entity<ECompanyBranchesContactDetailTypes>(entity =>
            {
                entity.ToTable("e_company_branches_contact_detail_types");

                entity.HasComment(@"enum
types of the contact items");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ContactItemType)
                    .HasColumnName("contact_item_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MBank>(entity =>
            {
                entity.ToTable("m_bank");

                entity.HasComment("master data for the bank");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BankName)
                    .HasColumnName("bank_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MBankBranches>(entity =>
            {
                entity.ToTable("m_bank_branches");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AddressLine1)
                    .HasColumnName("address_line_1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasColumnName("address_line_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine3)
                    .HasColumnName("address_line_3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankId)
                    .HasColumnName("bank_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.MBankBranches)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_m_bank_branches_m_bank");
            });

            modelBuilder.Entity<MBusinessPartners>(entity =>
            {
                entity.ToTable("m_business_partners");

                entity.HasComment(@"master data 
all people and stacke holders
equvalent ot sap business partner");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("identity guid");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.AddressLine1)
                    .HasColumnName("address_line_1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasColumnName("address_line_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine3)
                    .HasColumnName("address_line_3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("branch_id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("links to the company branch table");

                entity.Property(e => e.BusinessPartnersCategory)
                    .HasColumnName("business_partners_category")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("links to the category of the business partner");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("company_id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("links to the company table");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("date_of_birth")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalizationId)
                    .HasColumnName("localization_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("full name in the case of a person");

                entity.Property(e => e.NationalId)
                    .HasColumnName("national_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasColumnName("nationality")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MCompany>(entity =>
            {
                entity.ToTable("m_company");

                entity.HasComment(@"master data for the company
");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("identity guid");

                entity.Property(e => e.CompanyLogo)
                    .HasColumnName("company_logo")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("url to company logo");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("company_name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("company name");
            });

            modelBuilder.Entity<MCompanyBranches>(entity =>
            {
                entity.ToTable("m_company_branches");

                entity.HasComment(@"matsers data for the company branch
");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("identity guid");

                entity.Property(e => e.AddressLine1)
                    .HasColumnName("address_line_1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasColumnName("address_line_2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine3)
                    .HasColumnName("address_line_3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyBranchName)
                    .IsRequired()
                    .HasColumnName("company_branch_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("company_id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("links to the m_company table");

                entity.Property(e => e.IsHeadQuarters)
                    .HasColumnName("is_head_quarters")
                    .HasComment("is this the headquaters of the company?");

                entity.Property(e => e.LocalizationId)
                    .HasColumnName("localization_id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("links to the localization table");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MCompanyBranches)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_m_company_branches_m_company");

                entity.HasOne(d => d.Localization)
                    .WithMany(p => p.MCompanyBranches)
                    .HasForeignKey(d => d.LocalizationId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_m_company_branches_m_localization");
            });

            modelBuilder.Entity<MCompanyBranchesContactDetails>(entity =>
            {
                entity.ToTable("m_company_branches_contact_details");

                entity.HasComment("contact numbers, mobile or tel or fax");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("identity guid");

                entity.Property(e => e.CompanyBranchId)
                    .IsRequired()
                    .HasColumnName("company_branch_id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("links to the branch id of the company");

                entity.Property(e => e.ContactItem)
                    .HasColumnName("contact_item")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("the contact number/fax/");

                entity.Property(e => e.ContactItemDescription)
                    .HasColumnName("contact_item_description")
                    .IsUnicode(false);

                entity.Property(e => e.ContactItemType)
                    .HasColumnName("contact_item_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ContactItemTypeNavigation)
                    .WithMany(p => p.MCompanyBranchesContactDetails)
                    .HasForeignKey(d => d.ContactItemType)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_m_company_branches_contact_details_e_company_branches_contact_detail_types");
            });

            modelBuilder.Entity<MLocalization>(entity =>
            {
                entity.ToTable("m_localization");

                entity.HasComment("master data for all the localization settings");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CurrencyIsoCode)
                    .HasColumnName("currency_iso_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyLongName)
                    .HasColumnName("currency_long_name")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.CurrencySymbol)
                    .HasColumnName("currency_symbol")
                    .HasMaxLength(50);

                entity.Property(e => e.LocalizationName)
                    .HasColumnName("localization_name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("name of the localization, zimbabwe, zambia, botswana etc");
            });

            modelBuilder.Entity<PayrollEPaymentCycleTypes>(entity =>
            {
                entity.ToTable("payroll_e_payment_cycle_types");

                entity.HasComment("the types of the payemnt cycles");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("identity guid");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("company_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentCycleName)
                    .IsRequired()
                    .HasColumnName("payment_cycle_name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("name of the cycle");
            });

            modelBuilder.Entity<PayrollMBusinessPartners>(entity =>
            {
                entity.ToTable("payroll_m_business_partners");

                entity.HasComment(@"master data for the payrol
links to the business partner master data
");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BankAccountNumber)
                    .HasColumnName("bank_account_number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankBranchId)
                    .HasColumnName("bank_branch_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankId)
                    .HasColumnName("bank_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessPartnerId)
                    .IsRequired()
                    .HasColumnName("business_partner_id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("links to the business partner");

                entity.Property(e => e.GrossSalary)
                    .HasColumnName("gross_salary")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastPayrun)
                    .HasColumnName("last_payrun")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentCycleId)
                    .HasColumnName("payment_cycle_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.BusinessPartner)
                    .WithMany(p => p.PayrollMBusinessPartners)
                    .HasForeignKey(d => d.BusinessPartnerId)
                    .HasConstraintName("FK_payroll_m_business_partners_payroll_m_business_partners");
            });

            modelBuilder.Entity<PayrollPaymentCycles>(entity =>
            {
                entity.ToTable("payroll_payment_cycles");

                entity.HasComment("payment cycles for a company payrol");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<PersistedGrants>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.HasIndex(e => e.Expiration);

                entity.HasIndex(e => new { e.SubjectId, e.ClientId, e.Type });

                entity.Property(e => e.Key).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.SubjectId).HasMaxLength(200);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
