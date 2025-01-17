using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sicotyc.entities.Models
{
    [Table("COMPANY_TYPE", Schema = "SCT")]
    public class CompanyType
    {
        //[ForeignKey("Company")]
        public string Ruc { get; set; }
        public Company Company { get; set; }

        //[ForeignKey("LookupCode")]
        [Column("TypeOfCompany")]
        public string LookupCodeValue { get; set; }
        public LookupCode TypeOfCompany { get; set; }
    }
}
