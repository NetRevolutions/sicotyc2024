using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using sicotyc.entities.Validations;
using sicotyc.entities.Enum;

namespace sicotyc.entities.Models
{
    [Table("COMPANY", Schema = "SCT")]
    public class Company : TrackingBase
    {
        // [Key]
        public Guid CompanyId { get; set; } = Guid.NewGuid();
        [Key]
        [Required(ErrorMessage = "El valor del Ruc es requerido")]
        [RucValidation(ErrorMessage = "El Ruc debe tener 11 digitos numericos")]        
        public required string Ruc { get; set; }
        [Required(ErrorMessage ="Nombre de la empresa es requerido")]        
        public string? CompanyName { get; set; }
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[NULL]")]        
        public string? CompanyComercialName { get; set; }
        public CompanyStateEnum? CompanyState { get; set; }
        public CompanyConditionEnum? CompanyCondition { get; set; }
        public string? CompanyFiscalAddress { get; set; }
        public string? CompanyEmail { get; set; }
        public string? CompanyPhone { get; set; }

        // Relation 1:1


        // Relation 1:*        

        public List<CompanyType>? CompanyTypes { get; set; }

        // Relation *:*        
        public ICollection<UserCompany>? UserCompanies { get; set; }

    }
}
