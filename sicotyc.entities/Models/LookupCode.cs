using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace sicotyc.entities.Models
{
    [Table("LOOKUP_CODE", Schema = "SCT")]
    public class LookupCode : TrackingBase
    {
        [Column("LookupCodeId")]
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "El valor del LookupCode es requerido")]
        [MaxLength(50)]
        public string? LookupCodeValue { get; set; }

        [Required(ErrorMessage = "El nombre del LookupCode es requerido")]
        [StringLength(100, ErrorMessage = "El LookupCodeName no debe de superar los 100 caracteres")]
        public string? LookupCodeName { get; set; }

        [Required(ErrorMessage = "El orden del LookupCode es requerido y es unico")]
        public int LookupCodeOrder { get; set; }

        // Relation 1:1


        // Relation 1:*
        [ForeignKey("LookupCodeGroup")]
        public Guid LookupCodeGroupId { get; set; }
        public LookupCodeGroup? LookupCodeGroup { get; set; }

        // Relation *:*        

    }
}
