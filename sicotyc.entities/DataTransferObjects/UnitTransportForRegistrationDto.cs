using System.ComponentModel.DataAnnotations;

namespace sicotyc.entities.DataTransferObjects
{
    public class UnitTransportForRegistrationDto
    {
        public Guid UnitTransportId { get; set; } = Guid.NewGuid();
        [Required(ErrorMessage = "Ruc es requerido")]
        public string? Ruc { get; set; }
        public string? Plate { get; set; }
        public string? Brand { get; set; }
        public string? FabricationYear { get; set; }
        public string? ModelYear { get; set; }
        public DateTime? SoatExpiredDate { get; set; }
        public DateTime? TechnicalReviewExpiredDate { get; set; }
        public string? Fuel { get; set; }
        public string? AdditionalNotes { get; set; }
        public string? VehicleQualificationNumber { get; set; }
        public DateTime? VehicleQualificationExpirationDate { get; set; }
        public string? VehicleConfiguration { get; set; }
        public string? Img { get; set; }
        public UnitTransportDetailDto? UnitTransportDetail { get; set; }
        [Required(ErrorMessage = "Usuario de Creacion es requerido")]
        public string? CreatedBy { get; set; }
    }
}
