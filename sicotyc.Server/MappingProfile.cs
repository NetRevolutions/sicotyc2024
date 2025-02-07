﻿using AutoMapper;
using FluentEmail.Core;
using sicotyc.entities.DataTransferObjects;
using sicotyc.entities.Enum;
using sicotyc.entities.Models;

namespace sicotyc.Server
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LookupCodeGroup, LookupCodeGroupDto>();
            CreateMap<LookupCode, LookupCodeDto>();
            CreateMap<LookupCodeGroupForCreationDto, LookupCodeGroup>()
                .ForMember(d => d.Name, opt => opt.MapFrom(o => o.LookupCodeGroupName));
            CreateMap<LookupCodeForCreationDto, LookupCode>();
            CreateMap<LookupCodeForUpdateDto, LookupCode>()
                .ForMember(d => d.UpdateDtm, opt => opt.MapFrom(o => o.LastUpdatedOn))
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<LookupCodeGroupForUpdateDto, LookupCodeGroup>()
                .ForMember(d => d.Name, opt => opt.MapFrom(o => o.LookupCodeGroupName))
                .ForMember(d => d.UpdateDtm, opt => opt.MapFrom(o => o.LastUpdatedOn));
            CreateMap<LookupCodeCollectionForCreationDto, LookupCode>();
            CreateMap<UserForRegistrationDto, User>();
            CreateMap<UserForUpdateDto, User>();
            CreateMap<User, UserDto>();
            CreateMap<User, SearchResultDto>()
                    .ForMember(d => d.Name, opt => opt.MapFrom(o => o.FirstName + " " + o.LastName));
            CreateMap<LookupCodeGroup, SearchResultDto>()
                    .ForMember(d => d.Name, opt => opt.MapFrom(o => o.Name));
            CreateMap<LookupCode, SearchResultDto>()
                    .ForMember(d => d.Name, opt => opt.MapFrom(o => o.LookupCodeName));
            CreateMap<UserDetailForCreationDto, UserDetail>().ReverseMap();
            CreateMap<UserDetailForUpdateDto, UserDetail>()
                .ForMember(d => d.UpdateDtm, opt => opt.MapFrom(o => o.LastUpdatedOn))
                .ReverseMap();
            CreateMap<CompanyForRegistrationDto, Company>().ReverseMap();
            CreateMap<CompanyDto, Company>().ReverseMap();
            //CreateMap<CompanyForUpdateDto, Company>().ReverseMap();
            CreateMap<CompanyForUpdateDto, Company>()
                .ForMember(d => d.CompanyComercialName, opt => opt.MapFrom(src => src.CompanyComercialName))
                .ForMember(d => d.CompanyEmail, opt => opt.MapFrom(src => src.CompanyEmail))
                .ForMember(d => d.CompanyPhone, opt => opt.MapFrom(src => src.CompanyPhone))
                .ForMember(d => d.UpdateDtm, opt => opt.MapFrom(src => src.LastUpdatedOn))
                .ForMember(d => d.CompanyTypes, opt => opt.MapFrom(src => 
                    src.CompanyTypes != null
                        ? src.CompanyTypes.Select(type => new CompanyType { Ruc = src.Ruc, LookupCodeValue = type}).ToList()
                        : new List<CompanyType>()))                
                .ReverseMap()
                .ForMember(dto => dto.CompanyTypes, opt => opt.MapFrom(src => 
                    src.CompanyTypes != null
                        ? src.CompanyTypes.Select(ct => ct.LookupCodeValue).ToList()
                        : new List<string>()))
                .ForMember(dto => dto.LastUpdatedOn, opt => opt.MapFrom(src => src.UpdateDtm));
            CreateMap<Company, SearchResultDto>()
                .ForMember(d => d.Id, opt => opt.MapFrom(o => o.CompanyId))
                .ForMember(d => d.Name, opt => opt.MapFrom(o => o.CompanyName));
            CreateMap<DriverDto, Driver>().ReverseMap();
            CreateMap<DriverForCreationDto, Driver>().ReverseMap();
            CreateMap<DriverForUpdateDto, Driver>().ReverseMap();
            CreateMap<DriverLicenseDto, DriverLicense>();
            CreateMap<DriverLicenseForCreationDto, DriverLicense>().ReverseMap();
            CreateMap<DriverLicenseForUpdateDto, DriverLicense>().ReverseMap();
            CreateMap<Driver, SearchResultDto>()
                .ForMember(d => d.Id, opt => opt.MapFrom(o => o.DriverId))
                .ForMember(d => d.Name, opt => opt.MapFrom(o => o.FirstName + " " + o.LastName));
            CreateMap<UnitTransportForRegistrationDto, UnitTransport>().ReverseMap();
            CreateMap<UnitTransportDto, UnitTransport>().ReverseMap();
            CreateMap<UnitTransportForUpdateDto, UnitTransport>().ReverseMap();
            CreateMap<UnitTransport, SearchResultDto>()
                .ForMember(d => d.Id, opt => opt.MapFrom(o => o.UnitTransportId))
                .ForMember(d => d.Name, opt => opt.MapFrom(o => o.Plate));
        }
    }
}
