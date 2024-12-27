using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sicotyc.entities.Models
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage ="Nombre es requerido")]
        [MaxLength(20)]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Apellido es requerido")]
        [MaxLength(20)]
        public string? LastName { get; set; }
        public string? Img { get; set; }

        // Relation 1:1
        [ForeignKey("UserDetail")]
        public Guid? UserDetailId { get; set; }
        public UserDetail? UserDetail { get; set; }

        [ForeignKey("Company")]
        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }

        // Relation 1:*



        // Relation *:*

    }
}
