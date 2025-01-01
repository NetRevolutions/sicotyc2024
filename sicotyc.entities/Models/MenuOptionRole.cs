using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace sicotyc.entities.Models
{
    [Table("OPTIONS_ROLE", Schema = "SCT")]
    public class MenuOptionRole
    {
        [ForeignKey("Options")]
        public Guid OptionId { get; set; }
        
        [ForeignKey("Role")]
        public Guid Id { get; set; }
        
        public MenuOption? Option { get; set; }
        public Role? Role { get; set; }
    }
}
