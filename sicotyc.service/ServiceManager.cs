using AutoMapper;
using sicotyc.contracts;
using sicotyc.service.contracts;

namespace sicotyc.service
{
    public sealed class ServiceManager : IServiceManager
    {        
        private readonly Lazy<ISearchService> _searchService;
        private readonly Lazy<ISunatService> _sunatService;

        public ServiceManager(IRepositoryManager repository,                                
                                ILoggerManager logger,
                                IMapper mapper,
                                IAuthenticationManager authManager)
        {            
            _searchService = new Lazy<ISearchService>(() => new SearchService(repository, mapper));
            _sunatService = new Lazy<ISunatService>(() => new SunatService(repository, mapper));
        }        

        public ISearchService SearchService => _searchService.Value;

        public ISunatService Sunat => _sunatService.Value;       
    }
}
