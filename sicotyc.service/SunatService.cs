using AutoMapper;
using sicotyc.contracts;
using sicotyc.entities.Models;
using sicotyc.service.contracts;

namespace sicotyc.service
{
    public class SunatService : ISunatService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public SunatService(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<SunatResponse> GetSunatCompanyDataAsync(string ruc)
        {
            throw new NotImplementedException();
        }
    }
}
