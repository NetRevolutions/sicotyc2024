using sicotyc.entities.Models;

namespace sicotyc.contracts
{
    public interface ICompanyRepository
    {
        Task<Company> GetCompanyByIdAsync(Guid id, bool trackChanges);
        Task<Company> GetCompanyByRucAsync(string ruc, bool trackChanges);
        void CreateCompany(Company company);
        void DeleteCompany(Company company);
        void DeleteCompanyByRuc(string ruc);
    }
}
