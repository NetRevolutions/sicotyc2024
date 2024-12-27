using System.ComponentModel.DataAnnotations.Schema;

namespace sicotyc.entities.Models
{
    [Table("COMPANY_COMPANY_TYPE", Schema = "SCT")]
    public class CompanyCompanyType
    {
        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }
        [ForeignKey("CompanyType")]
        public Guid CompanyTypeId { get; set; }

        public Company? Company { get; set; }
        public CompanyType? CompanyType { get; set; }
    }
}
