using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sicotyc.entities.Configuration;
using sicotyc.entities.Models;
using sicotyc.repository.Configuration;

namespace sicotyc.repository
{
    public class RepositoryContext : IdentityDbContext<User>
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new LookupCodeGroupConfiguration());
            modelBuilder.ApplyConfiguration(new LookupCodeConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());

            modelBuilder.Entity<CompanyCompanyType>().HasKey(cct => new { cct.CompanyId, cct.CompanyTypeId });
            
            modelBuilder.Entity<DriverLicense>().HasKey(dl => new { dl.DriverId, dl.LicenseNumber, dl.LicenseType });

            // TODO:
            modelBuilder.Entity<MenuOptionRole>().HasKey(mor => new { mor.RoleId, mor.OptionId });

            // TODO:
            modelBuilder.Entity<CompanyCompanyType>().HasKey(cct =>new { cct.CompanyId, cct.CompanyTypeId});

        }

        #region DBSet
        public DbSet<LookupCodeGroup>? LookupCodeGroups { get; set; }
        public DbSet<LookupCode>? LookupCodes { get; set; }
        public DbSet<Company>? Companies { get; set; }
        public DbSet<CompanyType>? CompanyTypes { get; set; }
        public DbSet<UserDetail>? UserDetails { get; set; }
        public DbSet<ComplementTransport>? ComplementTransports { get; set; }
        public DbSet<Driver>? Drivers { get; set; }
        public DbSet<DriverLicense>? DriverLicenses { get; set; }        
        public DbSet<UnitTransport>? UnitTransports { get; set; }
        public DbSet<UnitTransportDetail>? TransportDetails { get; set; }
        public DbSet<WhareHouse>? WhareHouses { get; set; }
        //public DbSet<DriverWhareHouse>? DriverWhareHouses { get; set; }
        public DbSet<MenuOption>? MenuOptions { get; set; }
        public DbSet<MenuOptionRole>? MenuOptionRoles { get; set; }
        public DbSet<OptionByRole>? OptionByRoles { get; set; }

        #endregion


    }
}
