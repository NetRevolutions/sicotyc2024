using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace sicotyc.entities.Models
{
    [Table("OPTIONS_ROLE", Schema = "SCT")]
    public class MenuOptionRole
    {
        [Required]
        public string? RoleId { get; set; }
        [Required]
        public Guid OptionId { get; set; }
    }
}
