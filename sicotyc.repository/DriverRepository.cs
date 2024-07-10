using Microsoft.EntityFrameworkCore;
using sicotyc.contracts;
using sicotyc.entities.Models;
using sicotyc.entities.RequestFeatures;
using sicotyc.repository.Extensions;

namespace sicotyc.repository
{
    public class DriverRepository : RepositoryBase<Driver>, IDriverRepository 
    {
        public DriverRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {            
        }        

        public async Task<PagedList<Driver>> GetAllDriversAsync(DriverParameters driverParameters, string ruc, bool trackChanges)
        {
            var drivers = new List<Driver>();
            if (!String.IsNullOrEmpty(driverParameters.SearchTerm))
            {     
                drivers = await FindByCondition(d => d.Ruc.Trim().ToLower() == ruc.Trim().ToLower(), trackChanges)
                    .Where(d => d.DocumentNumber.Contains(driverParameters.SearchTerm) ||
                            d.Address.Contains(driverParameters.SearchTerm) ||
                            d.DocumentNumber.Contains(driverParameters.SearchTerm) ||
                            d.DocumentType.Contains(driverParameters.SearchTerm) ||
                            d.FirstName.Contains(driverParameters.SearchTerm) ||
                            d.LastName.Contains(driverParameters.SearchTerm))
                    .OrderBy(o => o.LastName)
                    .ToListAsync();                
            }
            else
            {
                drivers = await FindByCondition(d => d.DriverId != null && d.Ruc.Trim().ToLower() == ruc.Trim().ToLower(), trackChanges)
                .Search(driverParameters.SearchTerm)
                .Sort(driverParameters.OrderBy)
                .ToListAsync();                
            }

            return PagedList<Driver>
                .ToPagedList(drivers, driverParameters.PageNumber, driverParameters.PageSize);
        }

        public async Task<PagedList<Driver>> GetAllDriversAsAdminAsync(DriverParameters driverParameters, bool trackChanges)
        {
            var drivers = new List<Driver>();
            if (!String.IsNullOrEmpty(driverParameters.SearchTerm))
            {
                drivers = await FindAll(trackChanges)
                    .Where(d => d.DocumentNumber.Contains(driverParameters.SearchTerm) ||
                            d.Address.Contains(driverParameters.SearchTerm) ||
                            d.DocumentNumber.Contains(driverParameters.SearchTerm) ||
                            d.DocumentType.Contains(driverParameters.SearchTerm) ||
                            d.FirstName.Contains(driverParameters.SearchTerm) ||
                            d.LastName.Contains(driverParameters.SearchTerm) ||
                            d.Ruc.Contains(driverParameters.SearchTerm))
                    .OrderBy(o => o.LastName)
                    .ToListAsync();
            }
            else
            {
                drivers = await FindByCondition(d => d.DriverId != null, trackChanges)
                .Search(driverParameters.SearchTerm)
                .Sort(driverParameters.OrderBy)
                .ToListAsync();
            }

            return PagedList<Driver>
                .ToPagedList(drivers, driverParameters.PageNumber, driverParameters.PageSize);
        }


        public async Task<IEnumerable<Driver>> GetAllDriversAsync(string ruc, bool trackChanges) =>
            await FindByCondition(d => d.DriverId != null && d.Ruc.Trim().ToLower() == ruc.Trim().ToLower(), trackChanges)
            .OrderBy(o => o.LastName)
            .ToListAsync();

        public async Task<IEnumerable<Driver>> GetAllDriversAsAdminAsync(bool trackChanges) =>
            await FindByCondition(d => d.DriverId != null, trackChanges)
            .OrderBy(o => o.LastName)
            .ToListAsync();

        public async Task<IEnumerable<Driver>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
            await FindByCondition(d => ids.Contains(d.DriverId), trackChanges)
            .ToListAsync();        

        public async Task<Driver> GetDriverByIdAsync(Guid id, bool trackChanges) =>
            await FindByCondition(d => d.DriverId.Equals(id), trackChanges)
            .SingleOrDefaultAsync();

        public async Task<Driver> GetDriverByDocumentNumberAsync(string documentNumber, bool trackChanges) =>
            await FindByCondition(d => d.DocumentNumber.Trim().ToLower() == documentNumber.Trim().ToLower(), trackChanges)
            .SingleOrDefaultAsync();        

        public void CreateDriver(Driver driver) => Create(driver);

        public void DeleteDriver(Driver driver) => Delete(driver);
        
    }
}
