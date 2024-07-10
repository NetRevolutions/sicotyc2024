using sicotyc.entities.Models;
using System.ComponentModel.DataAnnotations;

namespace sicotyc.entities.DataTransferObjects
{
    public class DriverForCreationDto
    {
        [Required(ErrorMessage = "DriverId es requerido")]
        public Guid DriverId { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Ruc es requerido")]
        public string? Ruc { get; set; }
        [Required(ErrorMessage = "Nombre es requerido")]
        public string? FirstName { get; set; }          
        [Required(ErrorMessage = "Apellido es requerido")]
        public string? LastName { get; set; }
        public string? Img { get; set; }
        [Required(ErrorMessage = "Tipo de documento es requerido")]
        public string? DocumentType { get; set; }
        [Required(ErrorMessage = "Numero de documento es requerido")]
        public string? DocumentNumber { get; set; }
        [Required(ErrorMessage ="Fecha de expiracion del documento es requerido")]
        public DateTime? DocumentExpiration { get; set; }
        public ICollection<DriverLicenseForCreationDto>? DriverLicenses { get; set; }
        public bool EnableIMO { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public DateTime? AntecedentesPolicialesExpiration { get; set; } = DateTime.MinValue;
        public DateTime? AntecedentesPenalesExpiration { get; set; } = DateTime.MinValue;
        [Required(ErrorMessage = "Usuario de creacion es requerido")]
        public string? CreatedBy { get; set; }
    }
}
