namespace sicotyc.entities.DataTransferObjects
{
    /**
     * Nota: No recomiendo usar record porque dificulta devolverlo en otro formato diferente de JSON 
     * tal como XML
     */
    //public record LookupCodeDto(Guid Id, string LookupCodeValue, string LookupCodeName, int LookupCodeOrder/*, Guid LookupCodeGroupId*/);
    public class LookupCodeDto
    {
        public Guid Id { get; set; }
        public string? LookupCodeValue { get; set; }
        public string? LookupCodeName { get; set; }
        public int LookupCodeOrder { get; set; }
        public Guid LookupCodeGroupId { get; set; }
    }
}
