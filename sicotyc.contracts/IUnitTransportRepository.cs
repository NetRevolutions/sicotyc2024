using sicotyc.entities.Models;
using sicotyc.entities.RequestFeatures;

namespace sicotyc.contracts
{
    public interface IUnitTransportRepository
    {
        Task<PagedList<UnitTransport>> GetAllUnitTransportsAsync(UnitTransportParameters parameters, bool trackChanges);
        Task<IEnumerable<UnitTransport>> GetAllUnitTransportsAsync(bool trackChanges);
        Task<UnitTransport> GetUnitTransportByIdAsync(Guid id, bool trackChanges);
        Task<UnitTransport> GetUnitTransportByPlateAsync(string plate, bool trackChanges);
        Task<IEnumerable<UnitTransport>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        void CreateUnitTransport(UnitTransport unitTransport);
        void DeleteUnitTransport(UnitTransport unitTransport);
    }
}
