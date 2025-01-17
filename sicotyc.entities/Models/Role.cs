using Microsoft.AspNetCore.Identity;

namespace sicotyc.entities.Models
{
    public class Role : IdentityRole<Guid>
    {

        // Relation 1:1


        // Relation 1:*


        // Relation *:*
        public ICollection<MenuOptionRole>? OptionRole { get; set; }

    }
}
