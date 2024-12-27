using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using sicotyc.entities.Validations;

namespace sicotyc.entities.Models
{
    [Table("UNIT_TRANSPORT", Schema = "SCT")]
    public class UnitTransport : TrackingBase
    {
        [Key]
        public Guid UnitTransportId { get; set; }
        [Required(ErrorMessage = "El valor del Ruc es requerido")]
        [RucValidation(ErrorMessage = "El Ruc debe tener 11 digitos numericos")]
        public string? Ruc { get; set; }
        [Required(ErrorMessage ="La Placa es requerido")]
        public string? Plate { get; set; }
        [Required(ErrorMessage = "EL Modelo es requerido")]
        public string? Brand { get; set; }
        [Required(ErrorMessage = "El año de fabricacion es requerido")]
        public string? FabricationYear { get; set; }
        [Required(ErrorMessage = "El año del modelo es requerido")]
        public string? ModelYear { get; set; }
        public DateTime? SoatExpiredDate { get; set; }
        public DateTime? TechnicalReviewExpiredDate { get; set; }
        public string? Fuel { get; set; }
        public string? AdditionalNotes { get; set; }
        public string? VehicleQualificationNumber { get; set; }
        public DateTime? VehicleQualificationExpirationDate { get; set; }
        public string? VehicleConfiguration { get; set; }
        public string? Img { get; set; }

        // Relation 1:1
        [ForeignKey("UnitTransportDetail")]
        public Guid UnitTransportDetailId { get; set; }
        public UnitTransportDetail? UnitTransportDetail { get; set; }

        // Relation 1:*


        // Relation *:*
    }
}
