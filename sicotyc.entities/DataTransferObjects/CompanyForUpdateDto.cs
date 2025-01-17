using System.ComponentModel.DataAnnotations;

namespace sicotyc.entities.DataTransferObjects
{
    public class CompanyForUpdateDto
    {
        [Required(ErrorMessage = "El Ruc es requerido")]
        public string? Ruc { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyComercialName { get; set; }
        public string? CompanyFiscalAddress { get; set; }
        public string? CompanyEmail { get; set; }
        public string? CompanyPhone { get; set; }
        public IEnumerable<string>? CompanyTypes { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime LastUpdatedOn { get; set; } = DateTime.UtcNow;
    }
}
