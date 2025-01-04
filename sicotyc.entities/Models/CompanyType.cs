using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sicotyc.entities.Models
{
    [Table("COMPANY_TYPE", Schema = "SCT")]
    public class CompanyType : TrackingBase
    {
        [Key]
        public Guid CompanyTypeId { get; set; }
        [Required(ErrorMessage = "El tipo de empresa es requerido")]
        public string? CompanyTypeName { get; set; }

        // Relation 1:1


        // Relation 1:*
        [ForeignKey("Company")]
        public string Ruc { get; set; }
        public Company? Company { get; set; }

        // Relation *:*

    }
}
