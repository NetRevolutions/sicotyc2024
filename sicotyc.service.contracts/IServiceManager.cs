namespace sicotyc.service.contracts
{
    public interface IServiceManager
    {        
        ISunatService Sunat { get; }
        IDriverService Driver { get; }
    }
}
