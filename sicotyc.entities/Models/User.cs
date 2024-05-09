using Microsoft.AspNetCore.Identity;

namespace sicotyc.entities.Models
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Img { get; set; }
    }
}
