using sicotyc.entities.Models;
using System.ComponentModel.DataAnnotations;

namespace sicotyc.entities.DataTransferObjects
{
    public class DriverLicenseDto
    {
        [Required(ErrorMessage = "Driver ID es requerido")]
        public Guid DriverId { get; set; }        
        [Required(ErrorMessage = "Numero de Licencia es requerido")]
        public string? LicenseNumber { get; set; }
        [Required(ErrorMessage = "Tipo de Licencia es requerido")]
        public string? LicenseType { get; set; }
        [Required(ErrorMessage = "Fecha de Expiracion de la licencia es requerido")]
        public DateTime? LicenseExpiration { get; set; }
    }
}
