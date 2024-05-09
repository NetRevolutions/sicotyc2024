namespace sicotyc.entities.Exceptions
{
    public sealed class LookupCodeNotFoundException : Exception
    {
        public LookupCodeNotFoundException(Guid lookupCodeId)
            : base($"El LookupCode con el id: {lookupCodeId} no existe en la base de datos.")
        {
        }
    }
}
