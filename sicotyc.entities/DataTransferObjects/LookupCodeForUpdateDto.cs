namespace sicotyc.entities.DataTransferObjects
{
    public class LookupCodeForUpdateDto
    {
        public string? LookupCodeValue { get; set; }
        public string? LookupCodeName { get; set; }
        public int? LookupCodeOrder { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime LastUpdatedOn { get; set; } = DateTime.UtcNow;
    }
}
