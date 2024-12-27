using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using sicotyc.entities.Models;

namespace sicotyc.repository.Configuration
{
    public class LookupCodeGroupConfiguration : IEntityTypeConfiguration<LookupCodeGroup>
    {
        public void Configure(EntityTypeBuilder<LookupCodeGroup> builder)
        {
            builder.HasData
            (
                new LookupCodeGroup
                {
                    Id = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    Name = "CATEGORIA VEHICULOS",
                    CreatedBy = "SYSTEM"
                },
                new LookupCodeGroup
                {
                    Id = new Guid("CDA56E87-1B44-4625-9F19-AC7EB282A9B7"),
                    Name = "CLAIMS PERMITIDOS",
                    CreatedBy = "SYSTEM"
                },
                new LookupCodeGroup
                {
                    Id = new Guid("D86C0AD0-1F0F-4D1D-B2C1-232874477770"),
                    Name = "CONDICION EMPRESA",
                    CreatedBy = "SYSTEM"
                },
                new LookupCodeGroup
                {
                    Id = new Guid("B0DD9A3B-A5ED-4960-B94B-155AE7809E86"),
                    Name = "ESTADO EMPRESA",
                    CreatedBy = "SYSTEM"
                },
                new LookupCodeGroup
                {
                    Id = new Guid("F6112698-650A-4567-8A85-B73755AE39C0"),
                    Name = "TIPO DE COMBUSTIBLE",
                    CreatedBy = "SYSTEM"
                },
                new LookupCodeGroup
                {
                    Id = new Guid("86D227DC-E0CA-4A78-85F4-83A6EB30CBC7"),
                    Name = "TIPO DE DOC. IDENTIDAD",
                    CreatedBy = "SYSTEM"
                },
                new LookupCodeGroup
                {
                    Id = new Guid("E4D10BC8-A160-4A9D-BC87-C94CF849E14C"),
                    Name = "TIPO DE EMPRESA",
                    CreatedBy = "SYSTEM"
                },
                new LookupCodeGroup
                {
                    Id = new Guid("AB544E6E-6107-45BB-BF5B-B89401DC8AFC"),
                    Name = "TIPO DE LICENCIA DE CONDUCIR",
                    CreatedBy = "SYSTEM"
                },
                new LookupCodeGroup
                {
                    Id = new Guid("71B0316A-9831-499A-B9BB-08DA70AE70ED"),
                    Name = "TIPO DE PAGO PEAJE",
                    CreatedBy = "SYSTEM"
                },
                new LookupCodeGroup
                {
                    Id = new Guid("C6ED82D5-4A24-464B-BEBD-F33C0B7F7D80"),
                    Name = "TIPO DE SERVICIO",
                    CreatedBy = "SYSTEM"
                },
                new LookupCodeGroup
                {
                    Id = new Guid("74FA91F9-2019-4E0B-97C5-63B790594515"),
                    Name = "TIPO DE UNIDAD DE TRANSPORTE",
                    CreatedBy = "SYSTEM"
                }
            );
        }
    }
}
