using sicotyc.entities.Models;
using sicotyc.entities.RequestFeatures;

namespace sicotyc.service.contracts
{
    public interface IDriverService
    {
        Task<PagedList<Driver>> GetAllDriversAsync(DriverParameters driverParameters, string ruc, bool isAdmin, bool trackChanges);
        Task<IEnumerable<Driver>> GetAllDriversAsync(string ruc, bool isAdmin, bool trackChanges);

        Task<Driver> GetDriverByDocumentNumberAsync(string documentNumber, bool trackChanges);
        Task<Driver> GetDriverByIdAsync(Guid id, bool trackChanges);
        Task<IEnumerable<Driver>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        void CreateDriver(Driver driver);
        void DeleteDriver(Driver driver);
    }
}
