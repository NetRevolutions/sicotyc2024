using sicotyc.entities.Models;

namespace sicotyc.contracts
{
    public interface IDriverLicenseRepository
    {
        Task<IEnumerable<DriverLicense>> GetDriverLicensesByDriverAsync(Guid driverId, bool trackChanges);
        void CreateDriverLicense(DriverLicense driverLicense);
        void DeleteDriverLicense(DriverLicense driverLicense);
    }
}
