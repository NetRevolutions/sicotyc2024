namespace sicotyc.entities.DataTransferObjects
{
    public class CompanyForUpdateDto
    {
        public string? CompanyName { get; set; }
        public string? CompanyComercialName { get; set; }
        public string? CompanyFiscalAddress { get; set; }
        public string? CompanyEmail { get; set; }
        public string? CompanyPhone { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime LastUpdatedOn { get; set; } = DateTime.UtcNow;
    }
}
