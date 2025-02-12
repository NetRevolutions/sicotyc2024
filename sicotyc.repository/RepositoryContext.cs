﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sicotyc.entities.Configuration;
using sicotyc.entities.Models;
using sicotyc.repository.Configuration;

namespace sicotyc.repository
{
    public class RepositoryContext : IdentityDbContext<User, Role, Guid>
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {
        }

        #region DBSet
        public DbSet<LookupCodeGroup>? LookupCodeGroups { get; set; }
        public DbSet<LookupCode>? LookupCodes { get; set; }
        public DbSet<Company>? Companies { get; set; }
        public DbSet<UserCompany> UserCompanies { get; set; }
        public DbSet<CompanyType>? CompanyTypes { get; set; }
        public DbSet<UserDetail>? UserDetails { get; set; }
        public DbSet<ComplementTransport>? ComplementTransports { get; set; }
        public DbSet<Driver>? Drivers { get; set; }
        public DbSet<DriverLicense>? DriverLicenses { get; set; }
        public DbSet<UnitTransport>? UnitTransports { get; set; }
        public DbSet<UnitTransportDetail>? TransportDetails { get; set; }
        public DbSet<WhareHouse>? WhareHouses { get; set; }
        public DbSet<MenuOption>? MenuOptions { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new LookupCodeGroupConfiguration());
            modelBuilder.ApplyConfiguration(new LookupCodeConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());

            // Customize Fields 
            modelBuilder.Entity<Company>(entity => {
                
                entity.Property(e => e.CompanyState)
                .HasConversion<string>();

                entity.Property(e => e.CompanyCondition)
                .HasConversion<string>();

            });

            modelBuilder.Entity<LookupCode>()
                .HasAlternateKey(l => l.LookupCodeValue);

            // Register Class is not part DataBase model
            modelBuilder.Entity<OptionByRole>().HasNoKey();

            // Customize Relation
            modelBuilder.Entity<DriverLicense>().HasKey(dl => new { dl.DriverId, dl.LicenseNumber, dl.LicenseType });

            // Relation *:*
            modelBuilder.Entity<MenuOptionRole>().HasKey(mor => new { mor.OptionId, mor.Id });

            modelBuilder.Entity<UserCompany>().HasKey(uc => new { uc.Id, uc.Ruc });

            modelBuilder.Entity<UserCompany>()
                .HasOne(uc => uc.User)
                .WithMany(u => u.UserCompanies)
                .HasForeignKey(uc => uc.Id);
                
            modelBuilder.Entity<UserCompany>()
                .HasOne(uc => uc.Company)
                .WithMany(c => c.UserCompanies)
                .HasForeignKey(uc => uc.Ruc);

            modelBuilder.Entity<CompanyType>().HasKey(ct => new { ct.Ruc, ct.LookupCodeValue });

            modelBuilder.Entity<CompanyType>()
                .HasOne(ct => ct.Company)
                .WithMany(c => c.CompanyTypes)
                .HasForeignKey(ct => ct.Ruc);

            modelBuilder.Entity<CompanyType>()
                .HasOne(ct => ct.TypeOfCompany)
                .WithMany(t => t.CompanyTypes)
                .HasForeignKey(ct => ct.LookupCodeValue)
                .HasPrincipalKey(l => l.LookupCodeValue);

        }
    }
}
