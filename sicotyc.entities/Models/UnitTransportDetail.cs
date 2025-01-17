using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace sicotyc.entities.Models
{
    [Table("UNIT_TRANSPORT_DETAIL", Schema = "SCT")]
    public class UnitTransportDetail
    {
        [Key]
        public Guid UnitTransportDetailId { get; set; }
        [Display(Name = "Categoria")]
        public string? Category { get; set; }
        [Display(Name = "Modelo")]
        public string? Model { get; set; }
        [Display(Name = "Color")]
        public string? Color { get; set; }
        [Display(Name = "Numero de Serie")]
        public string? SerialNumber { get; set; }
        [Display(Name = "Numero de Motor")]
        public string? EngineNumber { get; set; }
        [Display(Name = "Fuerza de torque")]
        public string? BodyWork { get; set; }
        [Display(Name = "Largo")]
        public string? Large { get; set; }
        [Display(Name = "Ancho")]
        public string? Width { get; set; }
        [Display(Name = "Peso")]
        public string? Height { get; set; }
        [Display(Name = "Numero de Ejes")]
        public string? Axles { get; set; }
        
        // Relation 1:1
        public UnitTransport? UnitTransport { get; set; }

        // Relation 1:*


        // Relation *:*


    }
}
