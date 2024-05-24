using System.ComponentModel.DataAnnotations;

namespace sicotyc.entities.DataTransferObjects
{
    public class CompanyForRegistrationDto
    {
        public Guid CompanyId { get; set; } = Guid.NewGuid();
        [Required(ErrorMessage = "El Ruc es requerido")]
        public string? Ruc { get; set; }

        public string? CompanyName { get; set; }
        public string? CompanyComercialName { get; set; }
        public string? CompanyState { get; set; }
        [Required(ErrorMessage = "Usuario de Creacion es requerido")]
        public string? CreatedBy { get; set; }
    }
}
