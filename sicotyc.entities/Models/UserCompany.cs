using System.ComponentModel.DataAnnotations.Schema;

namespace sicotyc.entities.Models
{
    [Table("USER_COMPANY", Schema = "SCT")]
    public class UserCompany
    {
        //[ForeignKey("User")]
        public Guid Id { get; set; }
        public User? User { get; set; }
        
        //[ForeignKey("Company")]
        //public Guid CompanyId { get; set; }
        public string Ruc { get; set; }
        public Company? Company { get; set; }
    }
}
