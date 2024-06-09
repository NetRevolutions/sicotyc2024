using AutoMapper;
using sicotyc.contracts;
using sicotyc.entities.Models;
using sicotyc.entities.RequestFeatures;
using sicotyc.service.contracts;
using System.Reflection.Metadata.Ecma335;

namespace sicotyc.service
{
    public class DriverService : IDriverService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        public DriverService(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }        

        public async Task<PagedList<Driver>> GetAllDriversAsync(DriverParameters driverParameters, string ruc, bool isAdmin, bool trackChanges)
        {
            if (isAdmin)
            {
                return await _repository.Driver.GetAllDriversAsAdminAsync(driverParameters, trackChanges); 
            }
            else 
            { 
                return await _repository.Driver.GetAllDriversAsync(driverParameters, ruc, trackChanges);
            }
        }

        public async Task<IEnumerable<Driver>> GetAllDriversAsync(string ruc, bool isAdmin, bool trackChanges)
        {
            if (isAdmin)
            {
                return await _repository.Driver.GetAllDriversAsAdminAsync(trackChanges);
            }
            else
            { 
                return await _repository.Driver.GetAllDriversAsync(ruc, trackChanges);
            }
        }

        public async Task<IEnumerable<Driver>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) 
        { 
            return await _repository.Driver.GetByIdsAsync(ids, trackChanges);
        }            

        public async Task<Driver> GetDriverByDocumentNumberAsync(string documentNumber, bool trackChanges)
        {
            return await _repository.Driver.GetDriverByDocumentNumberAsync(documentNumber, trackChanges);
        }

        public async Task<Driver> GetDriverByIdAsync(Guid id, bool trackChanges)
        {
            return await _repository.Driver.GetDriverByIdAsync(id, trackChanges);
        }

        public void CreateDriver(Driver driver)
        {
            _repository.Driver.CreateDriver(driver);
        }

        public void DeleteDriver(Driver driver)
        {
            _repository.Driver.DeleteDriver(driver);
        }
    }
}
