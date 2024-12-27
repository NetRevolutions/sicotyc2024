using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using sicotyc.entities.Models;

namespace sicotyc.repository.Configuration
{
    public class LookupCodeConfiguration : IEntityTypeConfiguration<LookupCode>
    {
        public void Configure(EntityTypeBuilder<LookupCode> builder)
        {
            builder.HasData
            (                
            /**** Template *****
            new LookupCode
            {
                Id = new Guid(""),
                LookupCodeValue = "",
                LookupCodeName = "",
                LookupCodeOrder = 1,
                LookupCodeGroupId = new Guid(""),
                CreatedBy = "SYSTEM"
            },
            ******************************/  
            
            #region CATEGORIA VEHICULOS
                new LookupCode
                {
                    Id = new Guid("5C2D783A-8D86-40DB-A682-ABFF1EBE1325"),
                    LookupCodeValue = "L1",
                    LookupCodeName = "L1 - Dos Ruedas - Hasta 50 cm3 - Vel. Max. 50 km/h",
                    LookupCodeOrder = 1,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("43D3B835-0099-4C90-97E8-A90E46263981"),
                    LookupCodeValue = "L2",
                    LookupCodeName = "L2 - Tres Ruedas - Hasta 50 cm3 - Vel. Max. 50 km/h",
                    LookupCodeOrder = 2,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("6B440BD4-1FC3-4FF0-A657-D2DA4CD7667C"),
                    LookupCodeValue = "L3",
                    LookupCodeName = "L3 - Dos Ruedas - Mas de 50 cm3 - Vel. Mayor 50 km/h",
                    LookupCodeOrder = 3,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("15FB0388-449A-493E-8B25-B5C9D48724DE"),
                    LookupCodeValue = "L4",
                    LookupCodeName = "L4 - Tres Ruedas Asimetricas al Eje Longitudinal",
                    LookupCodeOrder = 4,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("E3023E84-144E-4C66-B508-1D6C03C8E452"),
                    LookupCodeValue = "L5",
                    LookupCodeName = "L5 - Tres Ruedas Simetricas al Eje Longitudinal, Peso menor a 1 TN",
                    LookupCodeOrder = 5,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("69B2E6E4-3652-43F5-BBE7-46319D143F1E"),
                    LookupCodeValue = "M1",
                    LookupCodeName = "M1 - Hasta 9 Asientos (Inc. conductor)",
                    LookupCodeOrder = 6,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("FC61F0AE-1FAC-4F04-A87A-7FE542E4398E"),
                    LookupCodeValue = "M2",
                    LookupCodeName = "M2 - Mas de 9 asientos - PBV Maximo 5 TN",
                    LookupCodeOrder = 7,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("B997A2D6-AA12-46E8-B074-2222C388FCC1"),
                    LookupCodeValue = "M3",
                    LookupCodeName = "M3 - Mas de 9 asientos - PBV Mayor 5 TN",
                    LookupCodeOrder = 8,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("E50C94EE-A2FC-4817-BE47-FC24A2E762FD"),
                    LookupCodeValue = "N1",
                    LookupCodeName = "N1 - De PBV de 3.5 TN o menos",
                    LookupCodeOrder = 9,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("ACAD96FE-FCC8-428B-B597-33E75DD3A5EA"),
                    LookupCodeValue = "N2",
                    LookupCodeName = "N2 - De PBV mayor a 3.5 TN hasta 12 TN",
                    LookupCodeOrder = 10,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("7568F431-F970-42F2-860B-52B3D56E89F7"),
                    LookupCodeValue = "N3",
                    LookupCodeName = "N3 - De PBV mayor a 12 TN",
                    LookupCodeOrder = 11,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("B95C8DBF-B7BC-4A4C-82CF-2EC93D976934"),
                    LookupCodeValue = "O1",
                    LookupCodeName = "O1 - Remolques de PBV de 0.75 TN o menos",
                    LookupCodeOrder = 12,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("C4A84B0A-BD4A-44B5-854E-6895EE11C347"),
                    LookupCodeValue = "O2",
                    LookupCodeName = "O2 - Remolques de PBV mayor a 0.75 TN hasta 3.5 TN",
                    LookupCodeOrder = 13,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("69522111-2411-4920-AD1C-7A60B8D15A2F"),
                    LookupCodeValue = "O3",
                    LookupCodeName = "O3 - Remolques de PBV mayor a 3.5 TN hasta 10 TN",
                    LookupCodeOrder = 14,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("14B7D51D-1584-4224-8C9B-FD3DA3DE7B23"),
                    LookupCodeValue = "O4",
                    LookupCodeName = "O4 - Remolques de PBV mayor a 10 TN",
                    LookupCodeOrder = 15,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("4CFE7678-6E98-4CE9-A031-9A9E6D205996"),
                    LookupCodeValue = "SA",
                    LookupCodeName = "SA - Casas Rodantes",
                    LookupCodeOrder = 16,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("7A989CD1-BE51-44C7-9E5B-A506942A0836"),
                    LookupCodeValue = "SB",
                    LookupCodeName = "SB - Vehiculos Blindados para el transporte de Valores",
                    LookupCodeOrder = 17,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("DA120915-15F5-46FC-AF15-FEE8D5939F86"),
                    LookupCodeValue = "SC",
                    LookupCodeName = "SC - Ambulancias",
                    LookupCodeOrder = 18,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("8185BF65-4CB0-45AD-85E2-5782302EC1FE"),
                    LookupCodeValue = "SD",
                    LookupCodeName = "SD - Vehiculos Funerarios",
                    LookupCodeOrder = 19,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("852E1CDC-8BA1-4615-ACEE-FC1692DC2D44"),
                    LookupCodeValue = "SE",
                    LookupCodeName = "SE - Bomberos",
                    LookupCodeOrder = 20,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("EF6BFAF8-6B4B-40FD-A13A-6BDC27D8BEC0"),
                    LookupCodeValue = "SF",
                    LookupCodeName = "SF - Vehiculos Celulares",
                    LookupCodeOrder = 21,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("603ECB5E-9E89-462C-89B6-EEDD06337574"),
                    LookupCodeValue = "SG",
                    LookupCodeName = "SG - Porta Tropas",
                    LookupCodeOrder = 22,
                    LookupCodeGroupId = new Guid("A0860957-DC94-4006-86FC-B9CCF4F78A33"),
                    CreatedBy = "SYSTEM"
                },
            #endregion

            #region CLAIMS PERMITIDOS
                new LookupCode
                {
                    Id = new Guid("752CE625-DA67-4842-B19D-18C5572DBBCE"),
                    LookupCodeValue = "UserName",
                    LookupCodeName = "USERNAME",
                    LookupCodeOrder = 1,
                    LookupCodeGroupId = new Guid("CDA56E87-1B44-4625-9F19-AC7EB282A9B7"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("37A294BB-D8E2-4655-80A8-A2FE719766D4"),
                    LookupCodeValue = "FirstName",
                    LookupCodeName = "FIRSTNAME",
                    LookupCodeOrder = 2,
                    LookupCodeGroupId = new Guid("CDA56E87-1B44-4625-9F19-AC7EB282A9B7"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("E129C250-DE59-45D3-8794-58E073FF8064"),
                    LookupCodeValue = "LastName",
                    LookupCodeName = "LASTNAME",
                    LookupCodeOrder = 3,
                    LookupCodeGroupId = new Guid("CDA56E87-1B44-4625-9F19-AC7EB282A9B7"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("6B1B516F-9073-4657-8A4C-9CB7EBE8EA25"),
                    LookupCodeValue = "Email",
                    LookupCodeName = "EMAIL",
                    LookupCodeOrder = 4,
                    LookupCodeGroupId = new Guid("CDA56E87-1B44-4625-9F19-AC7EB282A9B7"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("1AEC098A-859A-4586-80B6-B6F4BEB848FB"),
                    LookupCodeValue = "Id",
                    LookupCodeName = "ID",
                    LookupCodeOrder = 5,
                    LookupCodeGroupId = new Guid("CDA56E87-1B44-4625-9F19-AC7EB282A9B7"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("50BD3490-2377-4945-9229-F018F6B07BF8"),
                    LookupCodeValue = "PhoneNumber",
                    LookupCodeName = "PHONENUMBER",
                    LookupCodeOrder = 6,
                    LookupCodeGroupId = new Guid("CDA56E87-1B44-4625-9F19-AC7EB282A9B7"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("F7AB3CF1-AFE9-4B2B-977F-953D9F3B9275"),
                    LookupCodeValue = "Role",
                    LookupCodeName = "ROLE",
                    LookupCodeOrder = 7,
                    LookupCodeGroupId = new Guid("CDA56E87-1B44-4625-9F19-AC7EB282A9B7"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("8E009C6D-5920-4135-8A26-49EC04C6E7D5"),
                    LookupCodeValue = "Img",
                    LookupCodeName = "IMG",
                    LookupCodeOrder = 8,
                    LookupCodeGroupId = new Guid("CDA56E87-1B44-4625-9F19-AC7EB282A9B7"),
                    CreatedBy = "SYSTEM"
                },
            #endregion

            #region CONDICION EMPRESA
                new LookupCode
                {
                    Id = new Guid("78D4D89C-EFC4-4672-9B41-BFB5BF6CE748"),
                    LookupCodeValue = "HABIDO",
                    LookupCodeName = "Habido",
                    LookupCodeOrder = 1,
                    LookupCodeGroupId = new Guid("D86C0AD0-1F0F-4D1D-B2C1-232874477770"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("E109EC6D-3B84-4978-B725-E00CBE152819"),
                    LookupCodeValue = "NO_HABIDO",
                    LookupCodeName = "No Habido",
                    LookupCodeOrder = 2,
                    LookupCodeGroupId = new Guid("D86C0AD0-1F0F-4D1D-B2C1-232874477770"),
                    CreatedBy = "SYSTEM"
                },
            #endregion

            #region ESTADO EMPRESA
                new LookupCode
                {
                    Id = new Guid("E0A65440-DA87-454D-AAFC-CD59A53A92D1"),
                    LookupCodeValue = "ACTIVO",
                    LookupCodeName = "Activo",
                    LookupCodeOrder = 1,
                    LookupCodeGroupId = new Guid("B0DD9A3B-A5ED-4960-B94B-155AE7809E86"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("A2305318-91CE-4DA7-AA32-DC00DC3A129B"),
                    LookupCodeValue = "OBLIGADO_LLEVAR_CONTABILIDAD",
                    LookupCodeName = "Obligado a llevar Contabilidad",
                    LookupCodeOrder = 2,
                    LookupCodeGroupId = new Guid("B0DD9A3B-A5ED-4960-B94B-155AE7809E86"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("15DB719F-1D18-406D-BC4B-144DF7DCE134"),
                    LookupCodeValue = "BAJA_TEMPORAL",
                    LookupCodeName = "Baja Temporal",
                    LookupCodeOrder = 3,
                    LookupCodeGroupId = new Guid("B0DD9A3B-A5ED-4960-B94B-155AE7809E86"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("1D6BFBAF-130A-48D3-B87A-16BC27544B17"),
                    LookupCodeValue = "BAJA_DEFINITIVA",
                    LookupCodeName = "Baja Definitiva",
                    LookupCodeOrder = 4,
                    LookupCodeGroupId = new Guid("B0DD9A3B-A5ED-4960-B94B-155AE7809E86"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("1F0C7BCB-2F90-4EC4-89FA-87C7EC50A96A"),
                    LookupCodeValue = "OMISO",
                    LookupCodeName = "Omiso",
                    LookupCodeOrder = 5,
                    LookupCodeGroupId = new Guid("B0DD9A3B-A5ED-4960-B94B-155AE7809E86"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("0304A87A-E49F-4811-A2A7-E68FAF0F6930"),
                    LookupCodeValue = "OBLIGADO_EMITIR_COMPROBANTE_ELECTRONICO",
                    LookupCodeName = "Obligado a emitir comprobantes electronicos",
                    LookupCodeOrder = 6,
                    LookupCodeGroupId = new Guid("B0DD9A3B-A5ED-4960-B94B-155AE7809E86"),
                    CreatedBy = "SYSTEM"
                },
            #endregion

            #region TIPO DE COMBUSTIBLE
                new LookupCode
                {
                    Id = new Guid("798912F4-7813-4126-9C99-C9921F85DA6B"),
                    LookupCodeValue = "DSL",
                    LookupCodeName = "DIESEL",
                    LookupCodeOrder = 1,
                    LookupCodeGroupId = new Guid("F6112698-650A-4567-8A85-B73755AE39C0"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("53B2D295-6628-4F70-BACD-887A7FE4C34F"),
                    LookupCodeValue = "GAS",
                    LookupCodeName = "Gasolina",
                    LookupCodeOrder = 2,
                    LookupCodeGroupId = new Guid("F6112698-650A-4567-8A85-B73755AE39C0"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("2807ADD9-17F6-4D7D-AFB4-5A66DE3FEAB0"),
                    LookupCodeValue = "GLP",
                    LookupCodeName = "GLP (Gas Licuado de Petroleo)",
                    LookupCodeOrder = 3,
                    LookupCodeGroupId = new Guid("F6112698-650A-4567-8A85-B73755AE39C0"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("1E083EA3-4B61-4576-94FB-2CB0691F56BB"),
                    LookupCodeValue = "GNV",
                    LookupCodeName = "GNV (Gas Natural Vehicular)",
                    LookupCodeOrder = 4,
                    LookupCodeGroupId = new Guid("F6112698-650A-4567-8A85-B73755AE39C0"),
                    CreatedBy = "SYSTEM"
                },
            #endregion

            #region TIPO DE DOC. IDENTIDAD
                new LookupCode
                {
                    Id = new Guid("2D253E01-AFA1-4A59-BC6A-26526F0D8498"),
                    LookupCodeValue = "DNI",
                    LookupCodeName = "Documento Nacional de Identidad",
                    LookupCodeOrder = 1,
                    LookupCodeGroupId = new Guid("86D227DC-E0CA-4A78-85F4-83A6EB30CBC7"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("8DC0180A-2FFC-4807-803A-37AAB6ECAAB2"),
                    LookupCodeValue = "CEX",
                    LookupCodeName = "Carnet de Extranjería",
                    LookupCodeOrder = 2,
                    LookupCodeGroupId = new Guid("86D227DC-E0CA-4A78-85F4-83A6EB30CBC7"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("DE0CC597-AD66-4497-ACAB-33617EB077BD"),
                    LookupCodeValue = "PASS",
                    LookupCodeName = "Pasaporte",
                    LookupCodeOrder = 3,
                    LookupCodeGroupId = new Guid("86D227DC-E0CA-4A78-85F4-83A6EB30CBC7"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("792F255C-2B8B-42E6-9968-2855373E5C86"),
                    LookupCodeValue = "PNAC",
                    LookupCodeName = "Partida de Nacimiento",
                    LookupCodeOrder = 4,
                    LookupCodeGroupId = new Guid("86D227DC-E0CA-4A78-85F4-83A6EB30CBC7"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("B2A7D680-B5DC-41D1-9792-695602FC2954"),
                    LookupCodeValue = "CFFAA",
                    LookupCodeName = "Carnet de FFAA",
                    LookupCodeOrder = 5,
                    LookupCodeGroupId = new Guid("86D227DC-E0CA-4A78-85F4-83A6EB30CBC7"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("FE8B2536-5A20-4680-8DFE-526000DF87E1"),
                    LookupCodeValue = "PASSD",
                    LookupCodeName = "Pasaporte Diplomatico",
                    LookupCodeOrder = 6,
                    LookupCodeGroupId = new Guid("86D227DC-E0CA-4A78-85F4-83A6EB30CBC7"),
                    CreatedBy = "SYSTEM"
                },
            #endregion

            #region TIPO DE EMPRESA
                new LookupCode
                {
                    Id = new Guid("EAF628EE-9413-472E-A5B7-3C9D45F10CF0"),
                    LookupCodeValue = "ET",
                    LookupCodeName = "Empresa de Transporte",
                    LookupCodeOrder = 1,
                    LookupCodeGroupId = new Guid("E4D10BC8-A160-4A9D-BC87-C94CF849E14C"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("58250D62-975A-4883-81F7-946C91CF2DEC"),
                    LookupCodeValue = "OT",
                    LookupCodeName = "Otros",
                    LookupCodeOrder = 2,
                    LookupCodeGroupId = new Guid("E4D10BC8-A160-4A9D-BC87-C94CF849E14C"),
                    CreatedBy = "SYSTEM"
                },
            #endregion

            #region TIPO DE LICENCIA DE CONDUCIR
                new LookupCode
                {
                    Id = new Guid("11E436C6-929E-41D2-BB40-EF58B0A6C54A"),
                    LookupCodeValue = "A1",
                    LookupCodeName = "A-I",
                    LookupCodeOrder = 1,
                    LookupCodeGroupId = new Guid("AB544E6E-6107-45BB-BF5B-B89401DC8AFC"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("D8D6121D-F8DD-4042-A45F-D3F4D9304D1D"),
                    LookupCodeValue = "A2A",
                    LookupCodeName = "A-IIa",
                    LookupCodeOrder = 2,
                    LookupCodeGroupId = new Guid("AB544E6E-6107-45BB-BF5B-B89401DC8AFC"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("BDAAC09A-FB61-4C12-8756-08CF07BB8CDD"),
                    LookupCodeValue = "A2B",
                    LookupCodeName = "A-IIb",
                    LookupCodeOrder = 3,
                    LookupCodeGroupId = new Guid("AB544E6E-6107-45BB-BF5B-B89401DC8AFC"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("335AF8DA-4070-4382-9948-78F5D7C608AD"),
                    LookupCodeValue = "A3A",
                    LookupCodeName = "A-IIIa",
                    LookupCodeOrder = 4,
                    LookupCodeGroupId = new Guid("AB544E6E-6107-45BB-BF5B-B89401DC8AFC"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("16FF9B37-0C2B-425A-B13B-D7E4113A56F1"),
                    LookupCodeValue = "A3B",
                    LookupCodeName = "A-IIIb",
                    LookupCodeOrder = 5,
                    LookupCodeGroupId = new Guid("AB544E6E-6107-45BB-BF5B-B89401DC8AFC"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("B65D8F64-A4A7-4A67-9554-8BBE686F1918"),
                    LookupCodeValue = "A3C",
                    LookupCodeName = "A-IIIc",
                    LookupCodeOrder = 6,
                    LookupCodeGroupId = new Guid("AB544E6E-6107-45BB-BF5B-B89401DC8AFC"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("8FFF4F82-3314-4F5B-A255-661D5B5B2A6E"),
                    LookupCodeValue = "B1",
                    LookupCodeName = "B-I",
                    LookupCodeOrder = 7,
                    LookupCodeGroupId = new Guid("AB544E6E-6107-45BB-BF5B-B89401DC8AFC"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("4A12B60A-033E-495E-98A8-7899A952A4D2"),
                    LookupCodeValue = "B2A",
                    LookupCodeName = "B-IIa",
                    LookupCodeOrder = 8,
                    LookupCodeGroupId = new Guid("AB544E6E-6107-45BB-BF5B-B89401DC8AFC"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("D49052CC-B76C-41ED-97A2-0586745A44BC"),
                    LookupCodeValue = "B2B",
                    LookupCodeName = "B-IIb",
                    LookupCodeOrder = 9,
                    LookupCodeGroupId = new Guid("AB544E6E-6107-45BB-BF5B-B89401DC8AFC"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("FDC88DE9-5C83-43F7-A689-6AED7FE375C2"),
                    LookupCodeValue = "B2C",
                    LookupCodeName = "B-IIc",
                    LookupCodeOrder = 10,
                    LookupCodeGroupId = new Guid("AB544E6E-6107-45BB-BF5B-B89401DC8AFC"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("14E4DFED-E5AE-4A07-886A-F8A685E1BB03"),
                    LookupCodeValue = "A4",
                    LookupCodeName = "A-IV o Especial",
                    LookupCodeOrder = 11,
                    LookupCodeGroupId = new Guid("AB544E6E-6107-45BB-BF5B-B89401DC8AFC"),
                    CreatedBy = "SYSTEM"
                },
            #endregion

            #region TIPO DE PAGO PEAJE
                new LookupCode
                {
                    Id = new Guid("867C1549-7132-4E8E-174A-08DA70AE983A"),
                    LookupCodeValue = "ByAxis",
                    LookupCodeName = "Por Eje",
                    LookupCodeOrder = 1,
                    LookupCodeGroupId = new Guid("71B0316A-9831-499A-B9BB-08DA70AE70ED"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("7E603067-A1ED-4B52-174B-08DA70AE983A"),
                    LookupCodeValue = "ByAxis2",
                    LookupCodeName = "Por Eje2",
                    LookupCodeOrder = 2,
                    LookupCodeGroupId = new Guid("71B0316A-9831-499A-B9BB-08DA70AE70ED"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("1A011E51-2471-4CCD-174C-08DA70AE983A"),
                    LookupCodeValue = "ByAxis3",
                    LookupCodeName = "Por Eje3",
                    LookupCodeOrder = 3,
                    LookupCodeGroupId = new Guid("71B0316A-9831-499A-B9BB-08DA70AE70ED"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("23078793-CD0A-4718-2AA4-08DA71DA4714"),
                    LookupCodeValue = "ByAxis4",
                    LookupCodeName = "Por Eje4",
                    LookupCodeOrder = 4,
                    LookupCodeGroupId = new Guid("71B0316A-9831-499A-B9BB-08DA70AE70ED"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("47B84A27-C75A-44D3-174D-08DA70AE983A"),
                    LookupCodeValue = "ByAxis5",
                    LookupCodeName = "Por Eje5",
                    LookupCodeOrder = 5,
                    LookupCodeGroupId = new Guid("71B0316A-9831-499A-B9BB-08DA70AE70ED"),
                    CreatedBy = "SYSTEM"
                },
            #endregion                        

            #region TIPO DE SERVICIO
                new LookupCode
                {
                    Id = new Guid("6963984F-C5E0-4ED9-9647-46AC7054E344"),
                    LookupCodeValue = "IMPO",
                    LookupCodeName = "IMPORTACION",
                    LookupCodeOrder = 1,
                    LookupCodeGroupId = new Guid("C6ED82D5-4A24-464B-BEBD-F33C0B7F7D80"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("E83581FC-E05C-4C80-B5C2-E381FD7765D7"),
                    LookupCodeValue = "EXPO",
                    LookupCodeName = "EXPORTACION",
                    LookupCodeOrder = 2,
                    LookupCodeGroupId = new Guid("C6ED82D5-4A24-464B-BEBD-F33C0B7F7D80"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("5F38D3FD-F34E-45EB-AEBF-512F5EBD94EE"),
                    LookupCodeValue = "CS",
                    LookupCodeName = "CARGA SUELTA",
                    LookupCodeOrder = 3,
                    LookupCodeGroupId = new Guid("C6ED82D5-4A24-464B-BEBD-F33C0B7F7D80"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("FDC11A23-1DC7-4160-BB9D-019579C56E46"),
                    LookupCodeValue = "DV",
                    LookupCodeName = "DEVOLUCIÓN DE VACÍO",
                    LookupCodeOrder = 4,
                    LookupCodeGroupId = new Guid("C6ED82D5-4A24-464B-BEBD-F33C0B7F7D80"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("E5C70DF3-CF54-477F-881D-7D142F0B51AA"),
                    LookupCodeValue = "TX",
                    LookupCodeName = "TRACCIÓN",
                    LookupCodeOrder = 5,
                    LookupCodeGroupId = new Guid("C6ED82D5-4A24-464B-BEBD-F33C0B7F7D80"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("8BD83659-B611-488D-AAAC-E5D418BAC06C"),
                    LookupCodeValue = "CB",
                    LookupCodeName = "CAMA BAJA",
                    LookupCodeOrder = 6,
                    LookupCodeGroupId = new Guid("C6ED82D5-4A24-464B-BEBD-F33C0B7F7D80"),
                    CreatedBy = "SYSTEM"
                },
            #endregion

            #region TIPO DE UNIDAD DE TRANSPORTE
                new LookupCode
                {
                    Id = new Guid("8B22CE5A-1D4C-436A-92DC-BFF4C9AF8565"),
                    LookupCodeValue = "REM",
                    LookupCodeName = "REMOLCADOR",
                    LookupCodeOrder = 1,
                    LookupCodeGroupId = new Guid("74FA91F9-2019-4E0B-97C5-63B790594515"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("99DA2463-52A3-4E35-978B-99C3C7A8C7FC"),
                    LookupCodeValue = "PLAT40S2",
                    LookupCodeName = "PLATAFORMA DE  40 PIES (2 EJES)",
                    LookupCodeOrder = 2,
                    LookupCodeGroupId = new Guid("74FA91F9-2019-4E0B-97C5-63B790594515"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("2EA5C93E-B7E5-41D9-8DB1-DCE45C0975DA"),
                    LookupCodeValue = "PLAT40S3",
                    LookupCodeName = "PLATAFORMA DE  40 PIES (3 EJES)",
                    LookupCodeOrder = 3,
                    LookupCodeGroupId = new Guid("74FA91F9-2019-4E0B-97C5-63B790594515"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("B18CC534-6C71-43E7-B3A7-C0FF2D8F7CD6"),
                    LookupCodeValue = "PLAT20S2",
                    LookupCodeName = "PLATAFORMA DE  20 PIES (2 EJES)",
                    LookupCodeOrder = 4,
                    LookupCodeGroupId = new Guid("74FA91F9-2019-4E0B-97C5-63B790594515"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("F9775A11-583D-435B-A9C9-1B30D6B08E65"),
                    LookupCodeValue = "CONT40S2",
                    LookupCodeName = "CONTAINERA DE 40 PIES (2 EJES)",
                    LookupCodeOrder = 5,
                    LookupCodeGroupId = new Guid("74FA91F9-2019-4E0B-97C5-63B790594515"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("80779654-C53E-4502-B230-39476D0B5A31"),
                    LookupCodeValue = "CONT40S3",
                    LookupCodeName = "CONTAINERA DE 40 PIES (3 EJES)",
                    LookupCodeOrder = 6,
                    LookupCodeGroupId = new Guid("74FA91F9-2019-4E0B-97C5-63B790594515"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("1C8B7BAF-7A76-4469-94B1-B6B79B87D3BC"),
                    LookupCodeValue = "CONT20S2",
                    LookupCodeName = "CONTAINERA DE 20 PIES (2 EJES)",
                    LookupCodeOrder = 7,
                    LookupCodeGroupId = new Guid("74FA91F9-2019-4E0B-97C5-63B790594515"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("AAC495F0-CF83-40C2-90BC-B6EDAB8D02D5"),
                    LookupCodeValue = "FURGCER",
                    LookupCodeName = "FURGON CERRADO",
                    LookupCodeOrder = 8,
                    LookupCodeGroupId = new Guid("74FA91F9-2019-4E0B-97C5-63B790594515"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("A15FB960-6ED5-4562-8A91-76F069380BDC"),
                    LookupCodeValue = "FURGALGAV",
                    LookupCodeName = "FURGON ALAS DE GAVIOTA",
                    LookupCodeOrder = 9,
                    LookupCodeGroupId = new Guid("74FA91F9-2019-4E0B-97C5-63B790594515"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("0A66A417-0AAA-4AEC-9CC6-E93A29598191"),
                    LookupCodeValue = "CB40",
                    LookupCodeName = "CAMA BAJA 40 PIES",
                    LookupCodeOrder = 10,
                    LookupCodeGroupId = new Guid("74FA91F9-2019-4E0B-97C5-63B790594515"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("CE065324-C0F1-401D-A3B4-B4284204AB8B"),
                    LookupCodeValue = "CB20",
                    LookupCodeName = "CAMA BAJA 20 PIES",
                    LookupCodeOrder = 11,
                    LookupCodeGroupId = new Guid("74FA91F9-2019-4E0B-97C5-63B790594515"),
                    CreatedBy = "SYSTEM"
                },
                new LookupCode
                {
                    Id = new Guid("47AA2631-2500-49B9-BB9A-B52DCE33C3D4"),
                    LookupCodeValue = "CC40",
                    LookupCodeName = "CAMA CUNA 40 PIES",
                    LookupCodeOrder = 12,
                    LookupCodeGroupId = new Guid("74FA91F9-2019-4E0B-97C5-63B790594515"),
                    CreatedBy = "SYSTEM"
                }
            #endregion

            );
        }
    }
}
