using Microsoft.EntityFrameworkCore;
using sicotyc.contracts;
using sicotyc.entities.Models;
using sicotyc.entities.RequestFeatures;
using sicotyc.repository.Extensions;

namespace sicotyc.repository
{
    public class UnitTransportRepository : RepositoryBase<UnitTransport>, IUnitTransportRepository
    {
        public UnitTransportRepository(RepositoryContext repositoryContext) 
            : base(repositoryContext)
        {
        }

        public async Task<PagedList<UnitTransport>> GetAllUnitTransportsAsync(UnitTransportParameters parameters, bool trackChanges)
        {
            var unitTransports = new List<UnitTransport>();
            if (!String.IsNullOrEmpty(parameters.SearchTerm))
            {
                unitTransports = await FindAll(trackChanges)
                    .Where(u => u.Plate.Contains(parameters.SearchTerm) ||
                            u.Brand.Contains(parameters.SearchTerm))
                    .OrderBy(o => o.Plate)
                    .ToListAsync();
            }
            else
            {
                unitTransports = await FindByCondition(c => c.Plate != string.Empty, trackChanges)
                    .Search(parameters.SearchTerm)
                    .Sort(parameters.OrderBy)
                    .ToListAsync();
            }

            return PagedList<UnitTransport>
                .ToPagedList(unitTransports, parameters.PageNumber, parameters.PageSize);
        }

        public async Task<IEnumerable<UnitTransport>> GetAllUnitTransportsAsync(bool trackChanges) =>
            await FindByCondition(c => c.Plate != string.Empty, trackChanges)
            .Sort("Plate")
            .ToListAsync();

        public async Task<UnitTransport> GetUnitTransportByIdAsync(Guid id, bool trackChanges) =>
            await FindByCondition(x => x.UnitTransportId.Equals(id), trackChanges)
            .SingleOrDefaultAsync();

        public async Task<UnitTransport> GetUnitTransportByPlateAsync(string plate, bool trackChanges) =>
            await FindByCondition(x => x.Plate.Equals(plate), trackChanges)
            .SingleOrDefaultAsync();

        public async Task<IEnumerable<UnitTransport>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
            await FindByCondition(x => ids.Contains(x.UnitTransportId), trackChanges)
            .ToListAsync();
        
        public void CreateUnitTransport(UnitTransport unitTransport) => Create(unitTransport);

        public void DeleteUnitTransport(UnitTransport unitTransport) => Delete(unitTransport);
    }
}
