namespace sicotyc.entities.Exceptions
{
    public sealed class LookupCodeGroupNotFoundException : NotFoundException
    {
        public LookupCodeGroupNotFoundException(Guid lookupCodeGroupId)
            : base($"El lookupCodeGroup con el id: {lookupCodeGroupId} no existe en la base de datos.")
        {
        }
    }
}
