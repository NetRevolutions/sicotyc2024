using sicotyc.entities.Models;
using System.ComponentModel.DataAnnotations;

namespace sicotyc.entities.DataTransferObjects
{
    public class DriverLicenseDto
    {        
        public Guid? DriverLicenseId { get; set; }
        public string? LicenseNumber { get; set; }
        public string? LicenseType { get; set; }
        public DateTime? LicenseExpiration { get; set; }
        public Guid DriverId { get; set; }
    }
}
