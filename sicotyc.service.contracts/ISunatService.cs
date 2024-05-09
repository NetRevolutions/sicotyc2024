using sicotyc.entities.Models;

namespace sicotyc.service.contracts
{
    public interface ISunatService
    {
        Task<SunatResponse> GetSunatCompanyDataAsync(string ruc);
    }
}
