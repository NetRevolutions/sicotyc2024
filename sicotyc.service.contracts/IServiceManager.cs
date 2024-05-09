namespace sicotyc.service.contracts
{
    public interface IServiceManager
    {
        ILookupCodeGroupService LookupCodeGroupService { get; }
        ILookupCodeService LookupCodeService { get; }
        ISunatService SunatService { get; }
    }
}
