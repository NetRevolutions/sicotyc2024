using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sicotyc.entities.Models;

namespace sicotyc.entities.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role
                {
                    Id =  new Guid("091249CD-A7B3-467D-8938-2AA534324E21"),
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRATOR" // Todo menos acceso a Mantenimiento de usuarios y lookup
                },
                new Role
                {
                    Id = new Guid("4A784AE9-F240-48E9-A98D-57F8B557D922"),
                    Name = "Transportista",
                    NormalizedName = "FORWARDER"    // Transportista
                },
                new Role
                {
                    Id = new Guid("E9ACCB7A-DFD4-43D8-9038-EA8BF23B270D"),
                    Name = "Coordinador de Transporte",
                    NormalizedName = "FORWARDER-COORDINATOR" // Coordinador de Transporte
                },
                new Role
                {
                    Id = new Guid("45825849-2DC8-4631-BEAC-AAF53F844C6E"),
                    Name = "Facturador de Transporte",
                    NormalizedName = "FORWARDER-BILLER" // Facturador de Transporte
                },
                new Role
                {
                    Id = new Guid("34872081-8AD9-4A28-BD76-29BE97039208"),
                    Name = "Agencia de Aduana",
                    NormalizedName = "AGENCY" // Agencia de Aduana
                }
            );
        }
    }
}
