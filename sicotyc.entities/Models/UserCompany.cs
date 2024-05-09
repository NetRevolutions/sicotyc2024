using System.ComponentModel.DataAnnotations.Schema;

namespace sicotyc.entities.Models
{
    [Table("USER_COMPANY", Schema = "SCT")]
    public class UserCompany
    {
        [ForeignKey(nameof(User))]
        public string? Id { get; set; }
        public User? User { get; set; }
        [ForeignKey(nameof(Company))]
        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
