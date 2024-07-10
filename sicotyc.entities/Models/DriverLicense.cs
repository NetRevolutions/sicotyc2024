using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sicotyc.entities.Models
{
    [Table("DRIVER_LICENSE", Schema = "SCT")]
    public class DriverLicense : TrackingBase
    {
        [Key]
        public Guid DriverLicenseId { get; set; }

        [Required (ErrorMessage ="El Nro de Licencia es requerido")]
        public string? LicenseNumber { get; set; }
        [Required (ErrorMessage = "El tipo de licencia es requerido")]
        public string? LicenseType { get; set; }
        [Required (ErrorMessage = "La fecha de expiracion de la licencia es requerido")]
        public DateTime? LicenseExpiration { get; set; }
        
        [ForeignKey(nameof(Driver))]    // Navigational Properties
        public Guid DriverId { get; set; }
        public Driver? Driver { get; set; }        
    }
}
