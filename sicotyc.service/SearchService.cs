﻿using AutoMapper;
using FluentEmail.Core;
using sicotyc.contracts;
using sicotyc.entities.DataTransferObjects;
using sicotyc.entities.RequestFeatures;
using sicotyc.service.contracts;

namespace sicotyc.service
{
    public class SearchService : ISearchService
    {
        private readonly IRepositoryManager _repository;        
        private readonly IMapper _mapper;

        public SearchService(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<SearchResultDto>> SearchAllAsync(string searchTerm)
        {
            return await SearchUsersAsync(searchTerm);

            // TODO: Cuando se requiera buscar en otros modelos se hace join de los resultados.
        }

        public async Task<IEnumerable<SearchResultDto>> SearchByCollectionAsync(string collection, string searchTerm)
        {
            switch (collection.Trim().ToUpper())
            {
                case "USERS":
                    return await SearchUsersAsync(searchTerm);
                case "TRANSPORTS":
                    throw new NotImplementedException($"La coleccion {collection} aun no se encuentra implementada");
                case "LOOKUPCODEGROUPS":
                    return await SearchLookupCodeGroupsAsync(searchTerm);
                case "LOOKUPCODES":
                    return await SearchLookupCodesAsync(searchTerm);
                case "COMPANIES":
                    return await SearchCompaniesAsync(searchTerm);
                case "DRIVERS":
                    return await SearchDriversAsync(searchTerm);
                case "UNIT_TRANSPORTS":

                default:
                    throw new ArgumentException("Coleccion no valida", nameof(collection));

            }
        }

        public async Task<IEnumerable<SearchResultDto>> SearchUsersAsync(string searchTerm)
        {
            UserParameters userParameters = new UserParameters();
            userParameters.SearchTerm = searchTerm;
            userParameters._pageSize = 1000;

            var usersFromDB = await _repository.AuthenticationManager.GetUsersAsync(userParameters, trackChanges: false);

            var searchesDto = _mapper.Map<IEnumerable<SearchResultDto>>(usersFromDB);
            searchesDto.ForEach(x => { x.Entity = "Users"; });

            return searchesDto;

        }

        public async Task<IEnumerable<SearchResultDto>> SearchLookupCodeGroupsAsync(string searchTerm)
        {
            LookupCodeGroupParameters lookupCodeGroupParameters = new LookupCodeGroupParameters();
            lookupCodeGroupParameters.SearchTerm = searchTerm;
            lookupCodeGroupParameters._pageSize = 1000;

            var lookupCodeGroupsFromDB = await _repository.LookupCodeGroup.GetAllLookupCodeGroupsAsync(lookupCodeGroupParameters, trackChanges: false);

            var searchesDto = _mapper.Map<IEnumerable<SearchResultDto>>(lookupCodeGroupsFromDB);
            searchesDto.ForEach(x => { x.Entity = "LookupCodeGroups"; });

            return searchesDto;

        }

        public async Task<IEnumerable<SearchResultDto>> SearchLookupCodesAsync(string searchTerm)
        {
            string[] search = searchTerm.Split("|");
            Guid lookupCodeGroupId = new Guid(search[0].ToString());
            string term = search[1].ToString();

            LookupCodeParameters lookupCodeParameters = new LookupCodeParameters();
            lookupCodeParameters.SearchTerm = term;
            lookupCodeParameters._pageSize = 1000;

            var lookupCodesFromDB = await _repository.LookupCode.GetLookupCodesAsync(lookupCodeGroupId, lookupCodeParameters, trackChanges: false);

            var searchesDto = _mapper.Map<IEnumerable<SearchResultDto>>(lookupCodesFromDB);
            searchesDto.ForEach(x => { x.Entity = "LookupCodes"; });

            return searchesDto;

        }

        public async Task<IEnumerable<SearchResultDto>> SearchCompaniesAsync(string searchTerm)
        {   
            CompanyParameters companyParameters = new CompanyParameters();
            companyParameters.SearchTerm = searchTerm;
            companyParameters._pageSize = 1000;

            var companiesFromDB = await _repository.Company.GetAllCompaniesAsync(companyParameters, trackChanges: false);
            
            var searchesDto = _mapper.Map<IEnumerable<SearchResultDto>>(companiesFromDB);
            searchesDto.ForEach(x => { x.Entity = "Companies"; });

            return searchesDto;
        }

        public async Task<IEnumerable<SearchResultDto>> SearchDriversAsync(string searchTerm)
        {
            string[] search = searchTerm.Split('|');
            bool isAdmin = bool.Parse(search[0].ToString());
            string ruc = search[1].ToString().Trim();
            string term = search[2].ToString();

            DriverParameters driverParameters = new DriverParameters();
            driverParameters.SearchTerm = term;
            driverParameters._pageSize = 1000;

            var driversFromDB = isAdmin ? await _repository.Driver.GetAllDriversAsAdminAsync(driverParameters, trackChanges: false) :
                                                        await _repository.Driver.GetAllDriversAsync(driverParameters, ruc, trackChanges: false);  
            
            var searchesDto = _mapper.Map<IEnumerable<SearchResultDto>>(driversFromDB);
            searchesDto.ForEach(x => { x.Entity = "Drivers"; });

            return searchesDto;
        }

        public async Task<IEnumerable<SearchResultDto>> SearchUnitTransportsAsync(string searchTerm) 
        { 
            UnitTransportParameters unitTransportParameters = new UnitTransportParameters();
            unitTransportParameters.SearchTerm = searchTerm;
            unitTransportParameters._pageSize = 1000;

            var unitTransportsFromDB = await _repository.UnitTransport.GetAllUnitTransportsAsync(unitTransportParameters, trackChanges: false);

            var searchesDto = _mapper.Map<IEnumerable<SearchResultDto>>(unitTransportsFromDB);
            searchesDto.ForEach(x => { x.Entity = "UnitTransports"; });

            return searchesDto;            

        }
    }
}
