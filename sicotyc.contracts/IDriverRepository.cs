using sicotyc.entities.Models;
using sicotyc.entities.RequestFeatures;

namespace sicotyc.contracts
{
    public interface IDriverRepository
    {
        Task<PagedList<Driver>> GetAllDriversAsync(DriverParameters driverParameters, string ruc, bool trackChanges);
        Task<PagedList<Driver>> GetAllDriversAsAdminAsync(DriverParameters driverParameters, bool trackChanges);
        Task<IEnumerable<Driver>> GetAllDriversAsync(string ruc, bool trackChanges);
        Task<IEnumerable<Driver>> GetAllDriversAsAdminAsync(bool trackChanges);
        Task<Driver> GetDriverByDocumentNumberAsync(string documentNumber, bool trackChanges);
        Task<Driver> GetDriverByIdAsync(Guid id, bool trackChanges);
        Task<IEnumerable<Driver>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        void CreateDriver(Driver driver);
        void DeleteDriver(Driver driver);
    }
}
