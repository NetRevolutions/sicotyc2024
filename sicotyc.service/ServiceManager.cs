using AutoMapper;
using Microsoft.AspNetCore.Identity;
using sicotyc.contracts;
using sicotyc.entities.Models;
using sicotyc.service.contracts;

namespace sicotyc.service
{
    public sealed class ServiceManager : IServiceManager
    {        
        private readonly Lazy<ISearchService> _searchService;
        private readonly Lazy<ISunatService> _sunatService;
        private readonly Lazy<IDriverService> _driverService;

        public ServiceManager(IRepositoryManager repositoryManager,
                                ILoggerManager logger,
                                IMapper mapper,
                                //UserManager<User> userManager,
                                IAuthenticationManager authManager)
        {            
            _searchService = new Lazy<ISearchService>(() => new SearchService(repositoryManager, mapper));
            _sunatService = new Lazy<ISunatService>(() => new SunatService(repositoryManager, mapper));
            _driverService = new Lazy<IDriverService>(() => new DriverService(repositoryManager, mapper));
        }        

        public ISearchService SearchService => _searchService.Value;

        public ISunatService Sunat => _sunatService.Value;
        public IDriverService Driver => _driverService.Value;        
    }
}
