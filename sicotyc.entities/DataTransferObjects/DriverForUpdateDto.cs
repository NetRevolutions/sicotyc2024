using sicotyc.entities.Models;
using System.ComponentModel.DataAnnotations;

namespace sicotyc.entities.DataTransferObjects
{
    public class DriverForUpdateDto
    {
        [Required(ErrorMessage = "Ruc es requerido")]
        public string? Ruc { get; set; }
        [Required(ErrorMessage = "Nombre es requerido")]
        public string? FirsName { get; set; }
        [Required(ErrorMessage = "Apellido es requerido")]
        public string? LastName { get; set; }
        public string? Img { get; set; }
        [Required(ErrorMessage = "Tipo de documento es requerido")]
        public string? DocumentType { get; set; }
        [Required(ErrorMessage = "Numero de documento es requerido")]
        public string? DocumentNumber { get; set; }
        [Required(ErrorMessage = "Fecha de expiracion del documento es requerido")]
        public DateTime? DocumentExpiration { get; set; }
        public ICollection<DriverLicenseDto>? DriverLicenses { get; set; }
        public bool EnableIMO { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public DateTime? AntecedentePolicialesExpiration { get; set; }
        public DateTime? AntecedentesPenalesExpiration { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime LastUpdatedOn { get; set; } = DateTime.UtcNow;
    }
}
