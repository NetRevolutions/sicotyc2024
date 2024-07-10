using System.ComponentModel.DataAnnotations;

namespace sicotyc.entities.DataTransferObjects
{
    public class DriverLicenseForCreationDto
    {
        public Guid? DriverLicenseId { get; set; } = Guid.NewGuid();

        //[Required(ErrorMessage ="DriverId es requerido")]
        public Guid? DriverId { get; set; }
        [Required(ErrorMessage = "Numero de Licencia es requerido")]
        public string? LicenseNumber { get; set; }
        [Required(ErrorMessage = "Tipo de Licencia es requerido")]
        public string? LicenseType { get; set; }
        [Required(ErrorMessage = "Fecha de Expiracion de la licencia es requerido")]
        public DateTime? LicenseExpiration { get; set; }
        [Required(ErrorMessage = "Usuario de Creacion es requerido")]        
        public string? CreatedBy { get; set; }
    }
}
