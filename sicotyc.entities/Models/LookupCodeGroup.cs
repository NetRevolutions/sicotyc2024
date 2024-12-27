using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace sicotyc.entities.Models
{
    [Table("LOOKUP_CODE_GROUP", Schema = "SCT")]
    public class LookupCodeGroup : TrackingBase
    {
        [Column("LookupCodeGroupId")]
        [Key]
        public Guid Id { get; set; }

        [Column("LookupCodeGroupName")]
        [Required(ErrorMessage = "Nombre de LookupCodeGroup es requerido")]
        [MaxLength(60, ErrorMessage = " La longitud maxima del nombre del LookupCodeGroup es de 60 caracteres")]
        public string? Name { get; set; }

        // Relation 1:1


        // Relation 1:*
        public List<LookupCode>? LookupCodes { get; set; }

        // Relation *:*

        
    }
}
