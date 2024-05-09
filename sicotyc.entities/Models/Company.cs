using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using sicotyc.entities.Validations;
using sicotyc.entities.Enum;

namespace sicotyc.entities.Models
{
    [Table("COMPANY", Schema = "SCT")]
    public class Company : TrackingBase
    {
        [Key]
        public Guid CompanyId { get; set; }
        [Required(ErrorMessage = "El valor del Ruc es requerido")]
        [RucValidation(ErrorMessage = "El Ruc debe tener 11 digitos numericos")]
        public string? Ruc { get; set; }
        public string? CompanyName { get; set; }
        public CompanyStateEnum? CompanyState { get; set; }
        public CompanyConditionEnum? CompanyCondition { get; set; }
        public string? CompanyFiscalAddress { get; set; }
        public string? CompanyEmail { get; set; }
        public string? CompanyPhone { get; set; }

    }
}
