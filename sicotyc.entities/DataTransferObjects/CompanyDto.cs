using sicotyc.entities.Enum;

namespace sicotyc.entities.DataTransferObjects
{
    public class CompanyDto
    {
        public Guid CompanyId { get; set; }
        public string? Ruc { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyComercialName { get; set; }
        public string? CompanyState { get; set; }
        public string? CompanyCondition { get; set; }
        public string? CompanyFiscalAddress { get; set; }
        public string? CompanyEmail { get; set; }
        public string? CompanyPhone { get; set; }
        public IEnumerable<string>? CompanyTypes { get; set; }
    }
}
