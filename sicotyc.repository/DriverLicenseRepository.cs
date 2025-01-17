using Microsoft.EntityFrameworkCore;
using sicotyc.contracts;
using sicotyc.entities.Models;

namespace sicotyc.repository
{
    public class DriverLicenseRepository : RepositoryBase<DriverLicense>, IDriverLicenseRepository
    {
        public DriverLicenseRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {            
        }

        public async Task<IEnumerable<DriverLicense>> GetDriverLicensesByDriverAsync(Guid driverId, bool trackChanges) => 
            await FindByCondition(d => d.DriverId == driverId, trackChanges)
            .OrderBy(o => o.LicenseType)
            .ToListAsync();        

        public void CreateDriverLicense(DriverLicense driverLicense) => Create(driverLicense);        

        public void DeleteDriverLicense(DriverLicense driverLicense) => Delete(driverLicense);
                
    }
}
