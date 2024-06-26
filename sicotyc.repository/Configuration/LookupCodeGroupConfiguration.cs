﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
                    Id = new Guid("71B0316A-9831-499A-B9BB-08DA70AE70ED"),
                    Name = "TIPO DE PAGO PEAJE",
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
                    Id = new Guid("C6ED82D5-4A24-464B-BEBD-F33C0B7F7D80"),
                    Name = "TIPO DE SERVICIO",
                    CreatedBy = "SYSTEM"
                },
                new LookupCodeGroup
                {
                    Id = new Guid("CDA56E87-1B44-4625-9F19-AC7EB282A9B7"),
                    Name = "CLAIMS PERMITIDOS",
                    CreatedBy = "SYSTEM"
                }
            );
        }
    }
}
