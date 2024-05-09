using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace sicotyc.entities.Models
{
    public abstract class TrackingBase
    {
        [Required(ErrorMessage = "El usuario de creacion es requerido")]
        [MaxLength(60, ErrorMessage = "La longitud maxima del usuario de creacion es de 60 caracteres")]
        public string? CreatedBy { get; set; }

        [Column("CreatedOn", TypeName = "datetime2")]
        public DateTime CreateDtm { get; set; } = DateTime.UtcNow;

        [MaxLength(60, ErrorMessage = "La longitud maxima del usuario de creacion es de 60 caracteres")]
        public string? UpdatedBy { get; set; }

        [Column("LastUpdatedOn", TypeName = "datetime2")]
        public DateTime? UpdateDtm { get; set; }

        [Column("DeletedOn", TypeName = "datetime2")]
        public DateTime? DeleteDtm { get; set; }

        public TrackingBase()
        {
            CreateDtm = DateTime.UtcNow;
        }
    }
}
